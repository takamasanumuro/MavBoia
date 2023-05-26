using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleExample
{
    public partial class GroundStation : Form
    {
        private Mavlink.MavlinkParser mavParser = new Mavlink.MavlinkParser();
        private bool armed = false;
        // locking to prevent thread collisions on serial port
        private object serialLock = new object();
        private byte SysIDLocal { get;  set; } = 0xFF;
        private byte CompIDLocal { get; set; } = (byte)Mavlink.MAV_COMPONENT.MAV_COMP_ID_MISSIONPLANNER;

        private byte VehicleSysID { get; set; } = 0x01;
        private byte VehicleCompID { get; set; } = (byte)Mavlink.MAV_COMPONENT.MAV_COMP_ID_ONBOARD_COMPUTER;

        public GroundStation()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
             int nHeightEllipse

          );

        #region Form Initialization Defaults

        private void GroundStation_Load(object sender, EventArgs e)
        {
            SetSerialPortDefaults("COM4", 9600);            
        }

        private void SetSerialPortDefaults(string portName, int baudRate)
        {
            comboBoxSerialPort.DataSource = SerialPort.GetPortNames();
            foreach (var item in SerialPort.GetPortNames())
            {
                // Sets default value
                if (item == portName) comboBoxSerialPort.SelectedItem = item;
            }
            comboBoxBaudRate.SelectedItem = baudRate.ToString();
            buttonConnect.PerformClick();
        }

        #endregion

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            // if the port is open close it
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                buttonConnect.Text = "Open";
                return;
            }

            // set the comport options
            serialPort1.PortName = comboBoxSerialPort.Text;
            serialPort1.BaudRate = int.Parse(comboBoxBaudRate.Text);

            // open the comport
            serialPort1.Open();
            buttonConnect.Text = "Close";
            

            // set timeout to 2 seconds
            serialPort1.ReadTimeout = 2000;

            BackgroundWorker serialWorker = new BackgroundWorker();

            serialWorker.DoWork += serialWorker_ReadData;

            serialWorker.RunWorkerAsync();
        }

        private void serialWorker_ReadData(object sender, DoWorkEventArgs e)
        {
            while (serialPort1.IsOpen)
            {
                try
                {
                    Mavlink.MavlinkMessage message;
                    lock (serialLock)
                    {
                        // read any valid packet from the port
                        message = mavParser.ReadPacket(serialPort1.BaseStream);
                        
                      
                        // check its valid
                        if (message == null || message.Payload == null)
                            continue;
                    }

                    // check to see if its a hb packet from the comport
                    if (message.Payload.GetType() == typeof(Mavlink.mavlink_heartbeat_t))
                    {
                        var receivedHeartbeat = (Mavlink.mavlink_heartbeat_t)message.Payload;

                        // save the sysid and compid of the seen MAV
                        var targetSysID = message.SysID;
                        var targetCompID = message.CompID;

                        // request streams at 2 hz
                        var buffer = mavParser.GenerateMAVLinkPacket10(Mavlink.MAVLINK_MSG_ID.REQUEST_DATA_STREAM,
                            new Mavlink.mavlink_request_data_stream_t()
                            {
                                req_message_rate = (UInt16)2,
                                target_system = targetSysID,
                                target_component = targetCompID,
                                req_stream_id = (byte)Mavlink.MAV_DATA_STREAM.ALL,
                                start_stop = 1
                            },SysIDLocal, CompIDLocal);

                        WriteBufferConsole(buffer, "Requesting data", true);
                        serialPort1.Write(buffer, 0, buffer.Length);

                        buffer = mavParser.GenerateMAVLinkPacket10(Mavlink.MAVLINK_MSG_ID.HEARTBEAT, receivedHeartbeat);
                        WriteBufferConsole(buffer, "Sending heartbeat back", true);
                        serialPort1.Write(buffer, 0, buffer.Length);
                    }

                    // from here we should check the the message is addressed to us
                    if (VehicleSysID != message.SysID || VehicleCompID != message.CompID)
                        continue;
                    
                    ProcessMessage(message);
                }
                catch
                {
                }

                System.Threading.Thread.Sleep(1);
            }
        }

        void ProcessMessage(Mavlink.MavlinkMessage message)
        {
            Console.WriteLine(message.MsgTypename);
            switch (message.MsgID)
            {
                case (byte)Mavlink.MAVLINK_MSG_ID.NAMED_VALUE_INT:
                    {
                        var payload = (Mavlink.mavlink_named_value_int_t)message.Payload;
                        labelInstruTitle.BeginInvoke((Action)(() => labelInstruTitle.Text = $"Param: {Encoding.UTF8.GetString(payload.name)}" + "]"));
                        labelInstruData.BeginInvoke((Action)(() => labelInstruData.Text = $"Value: {payload.value}"));
                        break;
                    }
                case (byte)Mavlink.MAVLINK_MSG_ID.CONTROL_SYSTEM:
                    {
                        var payload = (Mavlink.mavlink_control_system_t)message.Payload;
                        String leftPumpState = DecodePumpMask(payload.pump_mask, 1);
                        String rightPumpState = DecodePumpMask(payload.pump_mask, 0);
                        labelControlData.BeginInvoke(
                            (Action)(() => labelControlData.Text = $"Sinal PoT:{payload.potentiometer_signal:F2}V\n" +
                            $"Sinal Encoder:{payload.dac_output:F2}V\n" +
                            $"Bomba Esquerda:{leftPumpState}\n" +
                            $"Bomba direita: {rightPumpState}")
                            );                       
                        break;
                    }
                case (byte)Mavlink.MAVLINK_MSG_ID.INSTRUMENTATION:
                    {
                        Random random = new Random();
                        var payload = (Mavlink.mavlink_instrumentation_t)message.Payload;
                        labelInstruTitle.BeginInvoke((Action)(() => labelInstruTitle.Text = $"Instrumentação"));
                        labelInstruData.BeginInvoke((Action)(() => labelInstruData.Text = $"Corrente do motor: {payload.current_zero:F2}A\n" +
                        $"Corrente do MPPT: {payload.current_one:F2}A\n" +
                        $"Corrente auxiliar: {payload.current_two:F2}A\n" +
                        $"Tensão do sistema: {payload.battery_voltage:F2}V\n" +
                        $"Temperatura do MPPT: {random.Next(30,50)}°C\n" +
                        $"Temperatura do Motor: {random.Next(40, 60)}°C"));
                        break;
                    }
                case (byte)Mavlink.MAVLINK_MSG_ID.TEMPERATURES:
                    {

                        break;
                    }
               
                default:
                    break;
            }
        }

        private String DecodePumpMask(byte mask, byte index)
        {
            if (Convert.ToBoolean((1 << index) & mask))
            {
                return "Ativa";
            }
            else
            {
                return "Desligada";
            }
        }

        private void WriteBufferConsole(byte[] buffer, string logMessage, bool UseHexMode = false)
        {
            if (logMessage != String.Empty)
                Console.WriteLine(logMessage);

            if (UseHexMode)
            {
                foreach (var item in buffer)
                {
                    Console.WriteLine($"0x{item.ToString("X2")}");
                }
            }
            else
            {
                foreach (var item in buffer)
                {
                    Console.WriteLine($"{item}");
                }
            }
            Console.WriteLine();
        }

        T ReadSomeData<T>(byte sysid, byte compid, int timeout = 2000)
        {
            DateTime deadLine = DateTime.Now.AddMilliseconds(timeout);

            lock (serialLock)
            {
                // read the current buffered bytes
                while (DateTime.Now < deadLine)
                {
                    var message = mavParser.ReadPacket(serialPort1.BaseStream);

                    // check its not null, and its addressed to us
                    if (message == null || sysid != message.SysID || compid != message.CompID)
                        continue;

                    Console.WriteLine(message);
                    Console.WriteLine(message);

                    if (message.Payload.GetType() == typeof(T))
                    {
                        return (T) message.Payload;
                    }
                }
            }

            throw new Exception("No packet match found");
        }

        private void but_armdisarm_Click(object sender, EventArgs e)
        {
            Mavlink.mavlink_command_long_t req = new Mavlink.mavlink_command_long_t();

            req.target_system = 1;
            req.target_component = 1;

            req.command = (ushort)Mavlink.MAV_CMD.COMPONENT_ARM_DISARM;

            req.param1 = armed ? 0 : 1;
            armed = !armed;
            /*
            req.param2 = p2;
            req.param3 = p3;
            req.param4 = p4;
            req.param5 = p5;
            req.param6 = p6;
            req.param7 = p7;
            */

            byte[] packet = mavParser.GenerateMAVLinkPacket10(Mavlink.MAVLINK_MSG_ID.COMMAND_LONG, req);

            serialPort1.Write(packet, 0, packet.Length);

            try
            {
                var ack = ReadSomeData<Mavlink.mavlink_command_ack_t>(SysIDLocal, CompIDLocal);
                if (ack.result == (byte)Mavlink.MAV_RESULT.ACCEPTED) 
                {

                }
            }
            catch 
            { 
            }
        }

        private void comboBoxSerialPort_Click(object sender, EventArgs e)
        {
            comboBoxSerialPort.DataSource = SerialPort.GetPortNames();      
        }
       
        private void but_mission_Click(object sender, EventArgs e)
        {
            Mavlink.mavlink_mission_count_t req = new Mavlink.mavlink_mission_count_t();

            req.target_system = 1;
            req.target_component = 1;

            // set wp count
            req.count = 1;

            byte[] packet = mavParser.GenerateMAVLinkPacket10(Mavlink.MAVLINK_MSG_ID.MISSION_COUNT, req);
            Console.WriteLine("MISSION_COUNT send");
            serialPort1.Write(packet, 0, packet.Length);

            var ack = ReadSomeData<Mavlink.mavlink_mission_request_t>(SysIDLocal, CompIDLocal);
            if (ack.seq == 0)
            {
                Mavlink.mavlink_mission_item_int_t req2 = new Mavlink.mavlink_mission_item_int_t();

                req2.target_system = SysIDLocal;
                req2.target_component = CompIDLocal;

                req2.command = (byte)Mavlink.MAV_CMD.WAYPOINT;

                req2.current = 1;
                req2.autocontinue = 0;

                req2.frame = (byte)Mavlink.MAV_FRAME.GLOBAL_RELATIVE_ALT;

                req2.y = (int) (115 * 1.0e7);
                req2.x = (int) (-35 * 1.0e7);

                req2.z = (float) (2.34);

                req2.param1 = 0;
                req2.param2 = 0;
                req2.param3 = 0;
                req2.param4 = 0;

                req2.seq = 0;

                packet = mavParser.GenerateMAVLinkPacket10(Mavlink.MAVLINK_MSG_ID.MISSION_ITEM_INT, req2);
                Console.WriteLine("MISSION_ITEM_INT send");
                lock (serialLock)
                {
                    serialPort1.Write(packet, 0, packet.Length);

                    var ack2 = ReadSomeData<Mavlink.mavlink_mission_ack_t>(SysIDLocal, CompIDLocal);
                    if ((Mavlink.MAV_MISSION_RESULT) ack2.type != Mavlink.MAV_MISSION_RESULT.MAV_MISSION_ACCEPTED)
                    {

                    }
                }


                Mavlink.mavlink_mission_ack_t req3 = new Mavlink.mavlink_mission_ack_t();
                req3.target_system = 1;
                req3.target_component = 1;
                req3.type = 0;

                packet = mavParser.GenerateMAVLinkPacket10(Mavlink.MAVLINK_MSG_ID.MISSION_ACK, req3);
                Console.WriteLine("MISSION_ACK send");
                serialPort1.Write(packet, 0, packet.Length);
            }
        }

        private void buttonLogPacket_Click(object sender, EventArgs e)
        {
            // Send and log a mavlink heartbeat message to the console
            byte[] buffer = mavParser.GenerateMAVLinkPacket10(Mavlink.MAVLINK_MSG_ID.HEARTBEAT,
                new Mavlink.mavlink_heartbeat_t()
                {
                    custom_mode = (uint)Mavlink.MAV_MODE.MANUAL_DISARMED,
                    type = (byte)Mavlink.MAV_TYPE.GCS,
                    autopilot = (byte)Mavlink.MAV_AUTOPILOT.INVALID,
                    base_mode = (byte)Mavlink.MAV_MODE_FLAG.SAFETY_ARMED,
                    system_status = (byte)Mavlink.MAV_STATE.STANDBY,
                    mavlink_version= 1
                }, this.SysIDLocal, this.CompIDLocal);
            serialPort1.Write(buffer, 0, buffer.Length);
            WriteBufferConsole(buffer, "", true);

        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            panelNav.Height = buttonSettings.Height;
            panelNav.Top = buttonSettings.Top;
            panelNav.Left = buttonSettings.Left;
            buttonSettings.BackColor = Color.FromArgb(46, 51, 73);            
        }

        private void buttonSettings_Leave(object sender, EventArgs e)
        {
            buttonSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void labelInt_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Close application
            System.Windows.Forms.Application.Exit();
        }
    }
}
