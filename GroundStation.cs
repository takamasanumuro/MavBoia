using Opc.Cpx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SimpleExample
{
    public partial class GroundStation : Form
    {
        public static GroundStation instance;
        //Mavlink parser responsible for parsing and deparsing mavlink packets
        private Mavlink.MavlinkParser mavlinkParser = new Mavlink.MavlinkParser();
        
        private object serialLock = new object(); // lock to prevent thread collisions on serial port
        private byte SysIDLocal { get;  set; } = 0xFF; // Default System ID for ground stations.
        private byte CompIDLocal { get; set; } = (byte)Mavlink.MAV_COMPONENT.MAV_COMP_ID_MISSIONPLANNER;
        private byte VehicleSysID { get; set; } = 0x01; // Default System ID for vehicles.
        private byte VehicleCompID { get; set; } = (byte)Mavlink.MAV_COMPONENT.MAV_COMP_ID_ONBOARD_COMPUTER;
 
        FormChart formGraficos = new FormChart() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
        FormDados formDados = new FormDados() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
        FormMapa formMapa = new FormMapa() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
        FormConfigurações formConfigurações = new FormConfigurações() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };

        public Point previousMousePosition; // Store the previous mouse position for dragging the form around

        public GroundStation()
        {
            InitializeComponent();
            instance = this;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            MouseDown += Form_MouseDown_Drag;
            MouseMove += Form_MouseMove_Drag;
            
               
        }
        #region Form Rounding and Dragging
        // This is the function that will allow the form to be rounded
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

        // Allows form to be dragged.
        protected override void WndProc(ref Message m)
        {
            // Constants for form rounding and dragging
            const int WM_NCHITTEST = 0x84;
            const int HT_CAPTION = 0x2;
            // Override WndProc to enable dragging
            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);
                if (m.Result.ToInt32() == HT_CAPTION)
                    m.Result = (IntPtr)1;
                return;
            }
            base.WndProc(ref m);
        }

        public void Form_MouseDown_Drag(object sender, MouseEventArgs e)
        {
            // Store the current mouse position
            GroundStation.instance.previousMousePosition = new Point(e.X, e.Y);
        }

        public void Form_MouseMove_Drag(object sender, MouseEventArgs e)
        {
            // Move the form when dragging
            if (e.Button == MouseButtons.Left)
            {
                GroundStation.instance.Left += e.X - GroundStation.instance.previousMousePosition.X;
                GroundStation.instance.Top += e.Y - GroundStation.instance.previousMousePosition.Y;
            }
        }
        #endregion

        #region Form Initialization Defaults

        private void GroundStation_Load(object sender, EventArgs e)
        {
           
                SetSerialPortDefaults("COM3", 115200);
                LoadForms();

        }

        // Ensure all forms are loaded and ready to receive data.
        private void LoadForms()
        {
            List<Form> forms = new List<Form>() { formConfigurações, formDados, formMapa };
            foreach (var form in forms)
            {
                panelFormLoader.Controls.Add(form);
                form.Show();
            }
            panelFormLoader.Controls.Clear();
            panelFormLoader.Controls.Add(formMapa);
            panelFormLoader.Dock = DockStyle.Fill;
            panelFormLoader.Show();
        }

        private void SetSerialPortDefaults(string portName, int baudRate)
        {
           
            comboBoxBaudRate.SelectedItem = baudRate.ToString();
            String[] portNames = SerialPort.GetPortNames();   
            comboBoxSerialPort.DataSource = portNames;
            if (portNames.Length == 0) return;
            foreach (var item in SerialPort.GetPortNames())
            {
                // Sets default value
                if (item == portName)
                {
                    comboBoxSerialPort.SelectedItem = item;
                    buttonConnect.PerformClick();
                }             
            }        
        }

        #endregion


        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // if the port is open close it
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    buttonConnect.Text = "Abrir";
                    return;
                }

                // Configure the port based on selected options and opens it.
                serialPort1.PortName = comboBoxSerialPort.SelectedItem.ToString();
                serialPort1.BaudRate = int.Parse(comboBoxBaudRate.SelectedItem.ToString());
                serialPort1.ReadTimeout = 2000;
                serialPort1.Open();
                buttonConnect.Text = "Fechar";

                // Read data from serial port on a background thread in order to not block the UI thread.        
                BackgroundWorker workerSerialPort = new BackgroundWorker();
                workerSerialPort.DoWork += workerSerialPort_ReadData;
                workerSerialPort.RunWorkerAsync();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}\n" + $"Verifique se a porta existe ou já está sendo usada por outro programa.");
            }    
        }

        private void buttonHTTPConnect_Click(object sender, EventArgs e)
        {
            // Take the hostname from the textbox and start making HTTP requests periodically to the server.
            // The routes are the same as the Mavlink message names.
            // The server will respond with the latest data present in the vehicle.

            if (textBoxHostname.Texts == String.Empty)
            {
                MessageBox.Show("Insira um endereço válido.");
                return;
            }
            else if (textBoxHostname.Texts == "localhost")
            {
                MessageBox.Show("Não é possível conectar ao localhost.");
                return;
            }

            if (buttonHTTPConnect.Text == "Conectar")
            {
                // Check if hostname exists on the network
                // If it does, start making HTTP requests to the server
                


                buttonHTTPConnect.Text = "Desconectar";
                textBoxHostname.Enabled = false;
                // Gray out text box
                textBoxHostname.BackColor = Color.FromArgb(46, 51, 73);
            } 
            else if (buttonHTTPConnect.Text == "Desconectar")
            {
                buttonHTTPConnect.Text = "Conectar";
                textBoxHostname.Enabled = true;
                // Restore text box color
                textBoxHostname.BackColor = Color.FromArgb(255, 255, 255);
                return;
            }

            BackgroundWorker workerHTTPConnection = new BackgroundWorker();
            workerHTTPConnection.DoWork += workerHTTPConnection_FetchData;
            workerHTTPConnection.RunWorkerAsync();
        }

        /// <summary>
        /// Reads data from the serial port and processes it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void workerSerialPort_ReadData(object sender, DoWorkEventArgs e)
        {
            while (serialPort1.IsOpen)
            {
                try
                {
                    Mavlink.MavlinkMessage message;
                    lock (serialLock)
                    {
                        message = mavlinkParser.ReadPacket(serialPort1.BaseStream);
                        if (message == null || message.Payload == null)
                            continue;
                    }
             
                    // Check the the message is addressed to us
                    if (VehicleSysID != message.SysID || VehicleCompID != message.CompID)
                    {
                        // Not implemented for now;
                    }
                    ProcessMessage(message);
                }
                catch (Exception serialException)
                {
                    Console.WriteLine($"{serialException.Message} at {System.DateTime.Now}");
                }

                System.Threading.Thread.Sleep(1);
            }
        }

        private void workerHTTPConnection_FetchData(object sender, DoWorkEventArgs e)
        {
            while (buttonHTTPConnect.Text == "Desconectar")
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri($"http://{textBoxHostname.Texts}:80/");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                
                try
                {

                    // Fetch control system data

                    HttpResponseMessage response = client.GetAsync("control-system").Result;
                    string jsonContent = response.Content.ReadAsStringAsync().Result;

                    JObject jsonObject = JObject.Parse(jsonContent);
                    float dac_voltage = (float)jsonObject["dac_output"];
                    float pot_voltage = (float)jsonObject["potentiometer_signal"];

                    FormDados.dacVoltage = dac_voltage;
                    FormDados.potVoltage = pot_voltage;

                    formDados.labelControlData.BeginInvoke(new Action(() => formDados.labelControlData.Text =
                                $"Tensão do DAC: {dac_voltage:F2}V\n" +
                                $"Tensão do potenciômetro: {pot_voltage:F2}V\n"));

                    // Fetch instrumentation data
                    response = client.GetAsync("instrumentation-system").Result;
                    jsonContent = response.Content.ReadAsStringAsync().Result;

                    // Parse "current_motor", "current_battery", "current_mppt" and "voltage_battery" from json
                    jsonObject = JObject.Parse(jsonContent);
                    float battery_voltage = (float)jsonObject["battery_voltage"];
                    float motor_current = (float)jsonObject["motor_current"];
                    float battery_current = (float)jsonObject["battery_current"];
                    float mppt_current = (float)jsonObject["mppt_current"];
                    
                    FormDados.motorCurrent = motor_current;
                    FormDados.batteryCurrent = battery_current;
                    FormDados.mpptCurrent = mppt_current;
                    FormDados.mainBatteryVoltage = battery_voltage;
                    FormDados.generationPower = mppt_current * battery_voltage;
                    FormDados.consumptionPower = battery_current * battery_voltage;
                    
                    FormDados.resultantPower = FormDados.generationPower + FormDados.consumptionPower;

                    // Do something with the parsed values
                    Console.WriteLine($"Current Motor: {motor_current}");
                    Console.WriteLine($"Current Battery: {battery_current}");
                    Console.WriteLine($"Current MPPT: {mppt_current}");
                    Console.WriteLine($"Voltage Battery: {battery_voltage}");

                    formDados.labelInstrumentationData.BeginInvoke(new Action(() => formDados.labelInstrumentationData.Text =
                        $"Tensão da bateria: {battery_voltage:F2}V\n" +
                        $"Corrente do motor: {motor_current:F2}A\n" +
                        $"Corrente da bateria: {battery_current:F2}A\n" +
                        $"Corrente do MPPT: {mppt_current:F2}A\n" +
                        $"Potência de geração: {FormDados.generationPower:F0}W\n" +
                        $"Potência de consumo: {FormDados.consumptionPower:F0}W\n" +
                        $"Potência resultante: {FormDados.resultantPower:F0}W\n"));

                    // Fetch temperatures
                    response = client.GetAsync("temperature-system").Result;
                    jsonContent = response.Content.ReadAsStringAsync().Result;

                    // Parse "temperature_motor" and "temperature_mppt" from json
                    jsonObject = JObject.Parse(jsonContent);
                    float temperature_motor = (float)jsonObject["temperature_motor"];
                    float temperature_battery = (float)jsonObject["temperature_battery"];
                    float temperature_mppt = (float)jsonObject["temperature_mppt"];

                    FormDados.temperatureMotor = temperature_motor;
                    FormDados.temperatureBattery = temperature_battery;
                    FormDados.temperatureMPPT = temperature_mppt;

                    String temperature_motor_string = $"{temperature_motor.ToString()}°C";
                    String temperature_battery_string = $"{temperature_battery.ToString()}°C";
                    String temperature_mppt_string = $"{temperature_mppt.ToString()}°C";
                    const float probe_disconnected = -127.0f;
                    if (temperature_motor == probe_disconnected)
                    {
                        temperature_motor_string = "Sonda não conectada";
                    }
                    if (temperature_battery == probe_disconnected)
                    {
                        temperature_battery_string = "Sonda não conectada";
                    }
                    if (temperature_mppt == probe_disconnected)
                    {
                        temperature_mppt_string = "Sonda não conectada";
                    }
                    formDados.labelTemperaturaDados.BeginInvoke(new Action(() => formDados.labelTemperaturaDados.Text =
                        $"Temperatura do motor: {temperature_motor_string}\n" +
                        $"Temperatura da bateria: {temperature_battery_string}\n" +
                        $"Temperatura do MPPT: {temperature_mppt_string}\n"));

                    // Fetch GPS data
                    response = client.GetAsync("gps-system").Result;
                    jsonContent = response.Content.ReadAsStringAsync().Result;

                    // Parse "latitude", "longitude", "course", "speed" and "satellites" from JSON
                    jsonObject = JObject.Parse(jsonContent);
                    float latitude = (float)jsonObject["latitude"];
                    float longitude = (float)jsonObject["longitude"];
                    float course = (float)jsonObject["course"];
                    float speed = (float)jsonObject["speed"];
                    int satellites = (int)jsonObject["satellites"];

                    FormDados.latitude = latitude;
                    FormDados.longitude = longitude;
                    FormDados.course = course;
                    FormDados.speed = speed;
                    FormDados.satellites = satellites;

                    //formDados.labelGPSData.BeginInvoke(new Action(() => formDados.labelGPSData.Text =
                    //             $"Latitude: {latitude}\n" +
                    //             $"Longitude: {longitude}\n" +
                    //             $"Curso: {course}\n" +
                    //             $"Velocidade: {speed}\n" +
                    //             $"Satélites: {satellites}\n"));
                    //             

                    // Get auxiliary data

                    // Fetch "auxiliary" from JSON
                    response = client.GetAsync("auxiliary-system").Result;
                    jsonContent = response.Content.ReadAsStringAsync().Result;

                    // Parse "auxiliary" from JSON
                    jsonObject = JObject.Parse(jsonContent);
                    float aux_current = (float)jsonObject["aux_current"];
                    float aux_voltage = (float)jsonObject["aux_voltage"];
                    byte pumps = (byte)jsonObject["pumps"];
                    String leftPumpState = DecodePumpMask(pumps, 1);
                    String rightPumpState = DecodePumpMask(pumps, 0);

                    FormDados.auxBatteryCurrent = aux_current;
                    FormDados.auxBatteryVoltage = aux_voltage;
                    FormDados.pumpMask = pumps;

                    formDados.labelAuxiliaryData.BeginInvoke(new Action(() => formDados.labelAuxiliaryData.Text =
                        $"Tensão da bateria auxiliar: {aux_voltage:F2}V\n" +
                        $"Corrente da bateria auxiliar: {aux_current:F2}A\n" +
                        $"Bomba de bombordo: {leftPumpState}\n" +
                        $"Bomba de boreste: {rightPumpState}\n"));


                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
                System.Threading.Thread.Sleep(5000);
            }
        }

        /// <summary>
        /// Process received Mavlink message based on its message ID.
        /// </summary>
        /// <param name="message"></param>
        void ProcessMessage(Mavlink.MavlinkMessage message)
        {
            Console.WriteLine(message.MsgTypename);
            switch (message.MsgID)
            {
                // Delegates and lambda expressions must be used to update the UI from a different thread.
               
                case (byte)Mavlink.MAVLINK_MSG_ID.CONTROL_SYSTEM:
                    {
                        var payload = (Mavlink.mavlink_control_system_t)message.Payload;
                        //String leftPumpState = DecodePumpMask((byte)payload.pumps, 1);
                        //String rightPumpState = DecodePumpMask((byte)(int)payload.pumps, 0);
                        formDados.labelControlData.BeginInvoke( new Action(() => formDados.labelControlData.Text = 
                            $"Sinal Pot:{payload.potentiometer_signal:F2}V\n" +
                            $"Sinal Encoder:{payload.dac_output:F2}V\n"));
                        break;
                    }
                case (byte)Mavlink.MAVLINK_MSG_ID.INSTRUMENTATION:
                    {
                        var payload = (Mavlink.mavlink_instrumentation_t)message.Payload;
                        float motor_current = payload.motor_current;
                        float battery_current = payload.battery_current;
                        float mppt_current = payload.mppt_current;
                        float battery_voltage = payload.battery_voltage;
                        float generation_power = battery_voltage * mppt_current;
                        float consumption_power = battery_voltage * motor_current;
                        float resultant_power = generation_power - consumption_power;

                        FormDados.motorCurrent = motor_current;
                        FormDados.batteryCurrent = battery_current;
                        FormDados.mpptCurrent = mppt_current;
                        FormDados.mainBatteryVoltage = battery_voltage;
                        FormDados.generationPower = generation_power;
                        FormDados.consumptionPower = consumption_power;
                        FormDados.resultantPower = resultant_power;

                        formDados.labelInstrumentationData.BeginInvoke(new Action(() => formDados.labelInstrumentationData.Text =
                            $"Tensão da bateria: {battery_voltage:F2}V\n" +
                            $"Corrente do motor: {motor_current:F2}A\n" +
                            $"Corrente da bateria: {battery_current:F2}A\n" +
                            $"Corrente do MPPT: {mppt_current:F2}A\n" +
                            $"Potência de geração: {generation_power}W\n" +
                            $"Potência de consumo: {consumption_power}W\n" +
                            $"Potência resultante: {resultant_power}W\n"));                 
                        break;
                    }
                case (byte)Mavlink.MAVLINK_MSG_ID.TEMPERATURES:
                    {
                        var payload = (Mavlink.mavlink_temperatures_t)message.Payload;

                        FormDados.temperatureMotor = payload.temperature_motor;
                        FormDados.temperatureBattery = payload.temperature_battery;
                        FormDados.temperatureMPPT = payload.temperature_mppt;

                        String temperature_motor = $"{payload.temperature_motor.ToString()}°C";
                        String temperature_battery = $"{payload.temperature_battery.ToString()}°C";
                        String temperature_mppt = $"{payload.temperature_mppt.ToString()}°C";
                        const float probe_disconnected = -127.0f;
                        if (payload.temperature_motor == probe_disconnected)
                        {
                            temperature_motor = "Sonda não conectada";
                        }
                        if (payload.temperature_battery == probe_disconnected)
                        {
                            temperature_battery = "Sonda não conectada";
                        }
                        if (payload.temperature_mppt == probe_disconnected)
                        {
                            temperature_mppt = "Sonda não conectada";
                        }
                        formDados.labelTemperaturaDados.BeginInvoke(new Action(() => formDados.labelTemperaturaDados.Text = 
                            $"Temperatura do motor: {temperature_motor}\n" +
                            $"Temperatura da bateria: {temperature_battery}\n" +
                            $"Temperatura do MPPT: {temperature_mppt}\n"));
                        break;
                    }

                case (byte)Mavlink.MAVLINK_MSG_ID.GPS_INFO:
                    {
                        var payload = (Mavlink.mavlink_gps_info_t)message.Payload;
                      
                        float latitude = payload.latitude;
                        float longitude = payload.longitude;
                        float course = payload.course;
                        float speed = payload.speed;
                        byte satellites = payload.satellites_visible;

                        if ((latitude != -1.0f) && (longitude != -1.0f))
                        {
                            formMapa.UpdateLocation(latitude, longitude);
                        }

                        Console.WriteLine($"GPS received: Lat:{latitude}/Long:{longitude}/Course:{course}/Speed:{speed}/Satellites:{satellites}");                    
                        break;
                    }
                case (byte)Mavlink.MAVLINK_MSG_ID.AUX_SYSTEM:
                    {
                        var payload = (Mavlink.mavlink_aux_system_t)message.Payload;
                        float aux_current = payload.current;
                        float aux_voltage = payload.voltage;
                        byte pumps = (byte)payload.pumps;
                        String leftPumpState = DecodePumpMask((byte)payload.pumps, 1);
                        String rightPumpState = DecodePumpMask((byte)(int)payload.pumps, 0);

                        FormDados.auxBatteryCurrent = aux_current;
                        FormDados.auxBatteryVoltage = aux_voltage;
                        FormDados.pumpMask = pumps;

                        formDados.labelAuxiliaryTitle.BeginInvoke(new Action(() => formDados.labelAuxiliaryTitle.Text =
                            $"Tensão da bateria: {aux_voltage:F2}V\n" +
                            $"Corrente da bateria: {aux_current:F2}A\n" +
                            $"Bomba esquerda: {leftPumpState}\n" +
                            $"Bomba direita: {rightPumpState}\n"));
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
   
        /// <summary>
        /// Updates the serial port list when the user clicks on the combo box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxSerialPort_Click(object sender, EventArgs e)
        {
            comboBoxSerialPort.DataSource = SerialPort.GetPortNames();      
        }

        /// <summary>
        /// Sets the form loader panel back to small size.
        /// </summary>
        private void SetFormLoaderSmall()
        {
            panelFormLoader.Size = new System.Drawing.Size(910, 480);
            panelFormLoader.Dock = DockStyle.Bottom;
        }

        private void buttonGraficos_Click(object sender, EventArgs e)
        {
            ButtonGenericClickCallback(sender, e);
            panelFormLoader.Controls.Clear();
            panelFormLoader.Dock = DockStyle.Fill;
            panelFormLoader.Controls.Add(formGraficos);
            formGraficos.Show();
            labelTitleSelection.Text = "Gráficos";

        }

        private void buttonDados_Click(object sender, EventArgs e)
        {
            ButtonGenericClickCallback(sender, e);
            panelFormLoader.Controls.Clear();
            SetFormLoaderSmall();
            panelFormLoader.Controls.Add(formDados);
            formDados.Show();
            labelTitleSelection.Text = "Dados";
                    
        }

        private void buttonMapa_Click(object sender, EventArgs e)
        {
            ButtonGenericClickCallback(sender, e);
            panelFormLoader.Controls.Clear();
            panelFormLoader.Dock = DockStyle.Fill;
            panelFormLoader.Controls.Add(formMapa);
            formMapa.Show();
            labelTitleSelection.Text = "Mapa";

        }

        private void buttonConfigurações_Click(object sender, EventArgs e)
        {
            ButtonGenericClickCallback(sender, e);
            panelFormLoader.Controls.Clear();
            SetFormLoaderSmall();
            panelFormLoader.Controls.Add(formConfigurações);
            labelTitleSelection.Text = "Configurações";
            formConfigurações.Show();

        }

        /// <summary>
        /// Callback for all buttons in the sidebar. Sets the panelNav position and color, which is the thin blue bar that tracks the buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGenericClickCallback(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            panelNav.Height = button.Height;
            panelNav.Top = button.Top;
            panelNav.Left = button.Left;
            panelNav.BringToFront();
            button.BackColor = Color.FromArgb(46, 51, 73);
        }
    
        private void button_Leave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.FromArgb(24, 30, 54);       
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Close application
            System.Windows.Forms.Application.Exit();
        }

        private void buttonLogPacket_Click(object sender, EventArgs e)
        {
            // Send and log a mavlink heartbeat message to the console
            byte[] buffer = mavlinkParser.GenerateMAVLinkPacket10(Mavlink.MAVLINK_MSG_ID.HEARTBEAT,
                new Mavlink.mavlink_heartbeat_t()
                {
                    custom_mode = (uint)Mavlink.MAV_MODE.MANUAL_DISARMED,
                    type = (byte)Mavlink.MAV_TYPE.GCS,
                    autopilot = (byte)Mavlink.MAV_AUTOPILOT.INVALID,
                    base_mode = (byte)Mavlink.MAV_MODE_FLAG.SAFETY_ARMED,
                    system_status = (byte)Mavlink.MAV_STATE.STANDBY,
                    mavlink_version = 1
                }, this.SysIDLocal, this.CompIDLocal);
            serialPort1.Write(buffer, 0, buffer.Length);
            WriteBufferConsole(buffer, "", true);

        }

        private void comboBoxSerialPort_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxBaudRate_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelTitleSelection_Click(object sender, EventArgs e)
        {

        }


    }
}
