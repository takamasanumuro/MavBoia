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
using CefSharp.MinimalExample.WinForms;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using CefSharp;
using CefSharp.DevTools.Network;
using MavBoia;

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
        BrowserForm formBrowser = new BrowserForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };

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
 
        }
        #endregion

        #region Form Initialization Defaults

        private void GroundStation_Load(object sender, EventArgs e)
        {
           
            //SetSerialPortDefaults("COM5", 4800);
            LoadForms();
            panelTopLeft.Enabled = false;
            panelTopLeft.Visible = false;
            pictureBoxArariboia.Enabled = false;
            pictureBoxArariboia.Visible = false;

        }

        // Ensure all forms are loaded and ready to receive data.
        private void LoadForms()
        {
            List<Form> forms = new List<Form>() { formConfigurações, formDados, formMapa, formBrowser };
            foreach (var form in forms)
            {
                panelFormLoader.Controls.Add(form);
                form.Show();
            }
            panelFormLoader.Controls.Clear();
            panelFormLoader.Controls.Add(formDados);
            panelFormLoader.Show();

            formBrowser.Scale(new SizeF(0.5f, 0.5f));
            panelSecondaryFormLoader.Controls.Clear();
            panelSecondaryFormLoader.Controls.Add(formBrowser);
            panelSecondaryFormLoader.Dock = DockStyle.Fill;
            panelSecondaryFormLoader.Show();
            
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
                    buttonConnect.Text = "Ligar rádio";
                    return;
                }

                // Configure the port based on selected options and opens it.
                serialPort1.PortName = FormConfigurações.instance.comboBoxSerialPort.SelectedItem.ToString();
                serialPort1.BaudRate = int.Parse(FormConfigurações.instance.comboBoxBaudRate.SelectedItem.ToString());
                serialPort1.ReadTimeout = 2000;
                serialPort1.Open();
                buttonConnect.Text = "Desligar rádio";

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
            // Take the hostname from the configurations and start making HTTP requests periodically to the server.
            // The routes are the same as the Mavlink message names.
            // The server will respond with the latest data present in the vehicle.

            if (buttonHTTPConnect.Text == "Ligar rede")
            {
                // Check if hostname exists on the network
                // If it does, start making HTTP requests to the server
                
                buttonHTTPConnect.Text = "Desligar rede";
            } 
            else if (buttonHTTPConnect.Text == "Desligar rede")
            {
                buttonHTTPConnect.Text = "Ligar rede";
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
                    lock (serialLock);
                    {
                        message = mavlinkParser.ReadPacket(serialPort1.BaseStream);
                        if (message == null || message.Payload == null)
                            continue;
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
            while (buttonHTTPConnect.Text == "Desligar rede")
            {
                string hostname = String.Empty;
                string connectionType = String.Empty;
                this.Invoke((MethodInvoker)delegate
                {
                    connectionType = formConfigurações.fancyComboBoxNetConnectionType.SelectedItem.ToString();
                    
                    if (connectionType == "Local")
                    {
                        hostname = formConfigurações.rjTextBoxLocalHostname.Texts;
                    }
                    else if (connectionType == "VPN")
                    {
                        hostname = formConfigurações.rjTextBoxVPNHostname.Texts;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao selecionar nome de host. Verifique as configurações.");
                        return;
                    }

                });

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri($"http://{hostname}:80/");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                
                try
                {

                    // Fetch instrumentation data
                    HttpResponseMessage response = client.GetAsync("instrumentation-system").Result;
                    string jsonContent = response.Content.ReadAsStringAsync().Result;

                    // Parse "current_motor", "current_battery", "current_mppt" and "voltage_battery" from json
                    JObject jsonObject = JObject.Parse(jsonContent);
                    float battery_voltage = (float)jsonObject["battery_voltage"];
                    float motor_current = (float)jsonObject["motor_current"];
                    float battery_current = (float)jsonObject["battery_current"];
                    float mppt_current = (float)jsonObject["mppt_current"];

                    FormDados.motorLeftCurrent = motor_current;
                    FormDados.motorRightCurrent = battery_current;
                    FormDados.mpptCurrent = mppt_current;
                    FormDados.batteryVoltage = battery_voltage;
                    FormDados.generationPower = mppt_current * battery_voltage;
                    FormDados.batteryPower = battery_current * battery_voltage;
                    FormDados.motorLeftPower = battery_current * motor_current;
                    FormDados.resultantPower = FormDados.generationPower + FormDados.batteryPower;

                    Console.WriteLine("VPN-instrumentation-system");

                    formDados.labelInstrumentationData.BeginInvoke(new Action(() => formDados.labelInstrumentationData.Text =
                            $"Tensão da bateria: {battery_voltage:F2}V\n" +
                            $"Corrente do motor: {motor_current:F2}A\n" +
                            $"Corrente da bateria: {battery_current:F2}A\n" +
                            $"Corrente do MPPT: {mppt_current:F2}A\n" +
                            $"Potência de geração: {FormDados.generationPower:F0}W\n" +
                            $"Potência do motor: {FormDados.motorLeftPower:F0}W\n" +
                            $"Potência da bateria: {FormDados.batteryPower:F0}W\n"));

                    string directory = String.Empty;
                    this.Invoke((MethodInvoker)delegate
                    {
                        directory = formConfigurações.rjTextBoxLogDirectory.Texts;
                        if (directory == String.Empty)
                        {
                            MessageBox.Show("Invalid directory!");
                        }
                    });

                    string fileName = "instrumentation-system.csv";
                    string path = Path.Combine(directory, fileName);
                    using (StreamWriter dataLogger = new StreamWriter(path, true))
                    {
                        string timestamp = DateTime.Now.ToString("HH:mm:ss");
                        string csvData = $"{timestamp}; {battery_voltage}; {motor_current}; {battery_current}; {mppt_current}";
                        dataLogger.WriteLine(csvData);
                        dataLogger.Flush();
                    }

                    // Fetch temperatures
                    response = client.GetAsync("temperature-system").Result;
                    jsonContent = response.Content.ReadAsStringAsync().Result;

                    // Parse "temperature_motor" and "temperature_mppt" from json
                    jsonObject = JObject.Parse(jsonContent);
                    float temperature_motor = (float)jsonObject["temperature_motor"];
                    float temperature_battery = (float)jsonObject["temperature_battery"];
                    float temperature_mppt = (float)jsonObject["temperature_mppt"];

                    FormDados.temperatureBatteryLeft = temperature_motor;
                    FormDados.temperatureBatteryRight = temperature_battery;
                    FormDados.temperatureMPPT = temperature_mppt;

                    String temperature_motor_string = $"{temperature_motor:F2}°C";
                    String temperature_battery_string = $"{temperature_battery:F2}°C";
                    String temperature_mppt_string = $"{temperature_mppt:F2}°C";
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
                    formDados.labelTemperatureData.BeginInvoke(new Action(() => formDados.labelTemperatureData.Text =
                        $"Temperatura do motor: {temperature_motor_string}\n" +
                        $"Temperatura da bateria: {temperature_battery_string}\n" +
                        $"Temperatura do MPPT: {temperature_mppt_string}\n"));

                    Console.WriteLine("VPN-temperature-system");

                    this.Invoke((MethodInvoker)delegate
                    {
                        directory = formConfigurações.rjTextBoxLogDirectory.Texts;
                        if (directory == String.Empty)
                        {
                            MessageBox.Show("Invalid directory!");
                        }
                    });

                    fileName = "temperature-system.csv";
                    path = Path.Combine(directory, fileName);

                    using (StreamWriter dataLogger = new StreamWriter(path, true))
                    {
                        string timestamp = DateTime.Now.ToString("HH:mm:ss");
                        string csvData = $"{timestamp}; {temperature_motor}; {temperature_battery}; {temperature_mppt}";
                        dataLogger.WriteLine(csvData);
                        dataLogger.Flush();
                    }

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

                    if ((latitude != -1.0f) && (longitude != -1.0f))
                    {
                        formMapa.UpdateLocation(latitude, longitude);
                    }

                    Console.WriteLine($"vpn-gps-system\n" +
                                      $"Latitude:{latitude}/Longitude:{longitude}/Course:{course}/Speed:{speed}/Satellites:{satellites}");

                    this.Invoke((MethodInvoker)delegate
                    {
                        directory = formConfigurações.rjTextBoxLogDirectory.Texts;
                        if (directory == String.Empty)
                        {
                            MessageBox.Show("Invalid directory!");
                        }
                    });

                    fileName = "gps-system.csv";
                    path = Path.Combine(directory, fileName);

                    using (StreamWriter dataLogger = new StreamWriter(path, true))
                    {
                        string timestamp = DateTime.Now.ToString("HH:mm:ss");
                        string csvData = $"{timestamp}; {latitude}; {longitude}; {course}; {speed}; {satellites}";
                        dataLogger.WriteLine(csvData);
                        dataLogger.Flush();
                    }

                    //formDados.labelGPSData.BeginInvoke(new Action(() => formDados.labelGPSData.Text =
                    //             $"Latitude: {latitude}\n" +
                    //             $"Longitude: {longitude}\n" +
                    //             $"Curso: {course}\n" +
                    //             $"Velocidade: {speed}\n" +
                    //             $"Satélites: {satellites}\n"));
                    //             

                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
                System.Threading.Thread.Sleep(2000);
            }
        }

        String GetLoggingDirectory()
        {
            string directory = String.Empty;
            this.Invoke((MethodInvoker)delegate
            {
                directory = formConfigurações.rjTextBoxLogDirectory.Texts;
                if (directory == String.Empty)
                {
                    MessageBox.Show("Invalid directory!");
                }
            });
            return directory;
        }
        
        void WriteDataCSV(string directory, string fileName, string data)
        {

            if (directory == String.Empty)
            {
                MessageBox.Show("Invalid directory!");
                return;
            }

            if (fileName == String.Empty)
            {
                MessageBox.Show("Invalid file name!");
                return;
            }

            string path = Path.Combine(directory, fileName);
            using (StreamWriter dataLogger = new StreamWriter(path, true))
            {
                string timestamp = DateTime.Now.ToString("HH:mm:ss");
                string csvData = $"{timestamp}; {data}";
                dataLogger.WriteLine(csvData);
                dataLogger.Flush();
            }
        }

        void SaveData(Mavlink.MavlinkMessage message)
        {
            string directory = GetLoggingDirectory();
            string fileName = message.MsgTypename + ".csv";
            string data = MavlinkUtilities.GetMessageDataCSV(message);
            WriteDataCSV(directory, fileName, data);
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
                case (byte)Mavlink.MAVLINK_MSG_ID.ALL_INFO:
                    {
                        var payload = (Mavlink.mavlink_all_info_t)message.Payload;
                        MavlinkUtilities.PrintMessageInfo(message);
                        FormDados.UpdateData(payload);
                        formMapa.UpdateData(payload);
                        UpdateDataForm();          
                        break;
                    }
                default:
                    break;
            }
            SaveData(message);
        }

        private void UpdateDataForm()
        {
            UpdateInstrumentationText();
            UpdateTemperatureText();
            UpdateRPMText();
        }

        private void UpdateInstrumentationText()
        {
            string instrumentationText = $"Tensão da bateria: {FormDados.batteryVoltage:F2}V\n" +
                                         $"Corrente do motor L: {FormDados.motorLeftCurrent:F2}A\n" +
                                         $"Corrente do motor R: {FormDados.motorRightCurrent:F2}A\n" +
                                         $"Corrente do MPPT: {FormDados.mpptCurrent:F2}A\n";

            formDados.labelInstrumentationData.BeginInvoke(new Action(() => formDados.labelInstrumentationData.Text = instrumentationText));
        }

        private String CheckProbe(float temperature)
        {
            //DS18B20 Technical specifications:
            //Usable temperature range: -55 to 125 °C(-67 °F to + 257 °F)
            
            const float probe_disconnected_celsius = -55.0f;
            if (temperature < probe_disconnected_celsius)
            {
                return "NC";
            }
            return $"{temperature:F2}°C";
        }

        private void UpdateTemperatureText()
        {

            string temperatureText = $"Bateria(L): " + CheckProbe(FormDados.temperatureBatteryLeft) + "\n" +
                                     $"Bateria(R): " + CheckProbe(FormDados.temperatureBatteryRight) + "\n" +
                                     $"MPPT: " + CheckProbe(FormDados.temperatureMPPT) + "\n";

            formDados.labelTemperatureData.BeginInvoke(new Action(() => formDados.labelTemperatureData.Text = temperatureText));

        }

        private void UpdateRPMText()
        {
            string rpmText = $"Motor L: {FormDados.rpmLeft}\n" +
                             $"Motor R: {FormDados.rpmRight}\n";

            formDados.labelRPM.BeginInvoke(new Action(() => formDados.labelRPM.Text = rpmText));
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
        }

        private void buttonDados_Click(object sender, EventArgs e)
        {
            ButtonGenericClickCallback(sender, e);
            panelFormLoader.Controls.Clear();
            SetFormLoaderSmall();
            panelFormLoader.Controls.Add(formDados);
            formDados.Show();         
        }

        private void buttonMapa_Click(object sender, EventArgs e)
        {
            ButtonGenericClickCallback(sender, e);
            panelFormLoader.Controls.Clear();
            panelFormLoader.Dock = DockStyle.Fill;
            panelFormLoader.Controls.Add(formMapa);
            formMapa.Show();
        }

        private void buttonConfigurações_Click(object sender, EventArgs e)
        {
            ButtonGenericClickCallback(sender, e);
            panelFormLoader.Controls.Clear();
            panelFormLoader.Dock = DockStyle.Fill;
            panelFormLoader.Controls.Add(formConfigurações);
            formConfigurações.Show();
        }

        private void buttonRastreio_Click(object sender, EventArgs e)
        {
            ButtonGenericClickCallback(sender, e);
            panelFormLoader.Controls.Clear();
            panelFormLoader.Dock = DockStyle.Fill;
            panelFormLoader.Controls.Add(formBrowser);
            panelFormLoader.Show();

            panelTopLeft.Enabled = true;
            panelTopLeft.Visible = true;
            pictureBoxArariboia.Enabled = true;
            pictureBoxArariboia.Visible = true;

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
            panelSecondaryFormLoader.Controls.Clear();
            panelSecondaryFormLoader.Controls.Add(formBrowser);
            panelSecondaryFormLoader.Show();

            panelTopLeft.Enabled = false;
            panelTopLeft.Visible = false;
            pictureBoxArariboia.Enabled = false;
            pictureBoxArariboia.Visible = false;
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

        }

        private void labelTitleSelection_Click(object sender, EventArgs e)
        {

        }

        private void panelSecondaryFormLoader_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBoxArariboia_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            panelTopLeft.Enabled = false;
            panelTopLeft.Visible = false;
            pictureBoxArariboia.Enabled = false;
            pictureBoxArariboia.Visible = false;
        }

        private void pictureBoxArariboia_DoubleClick(object sender, EventArgs e)
        {

        }

        private void buttonRastreio_DragDrop(object sender, DragEventArgs e)
        {

        }
    }
}
