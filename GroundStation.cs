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
using System.Threading;
using DataController.SerialData;

namespace SimpleExample
{
    public partial class GroundStation : Form
    {
        public static GroundStation instance;
        //Mavlink parser responsible for parsing and deparsing mavlink packets
        private Mavlink.MavlinkParser mavlinkParser = new Mavlink.MavlinkParser();

        private byte SysIDLocal { get;  set; } = 0xFF; // Default System ID for ground stations.
        private byte CompIDLocal { get; set; } = (byte)Mavlink.MAV_COMPONENT.MAV_COMP_ID_MISSIONPLANNER;
        private byte VehicleSysID { get; set; } = 0x01; // Default System ID for vehicles.
        private byte VehicleCompID { get; set; } = (byte)Mavlink.MAV_COMPONENT.MAV_COMP_ID_ONBOARD_COMPUTER;

        // Forms declaration
        FormChart formGraficos;
        FormMapa formMapa;
        FormConfigurações formConfigurações;
        BrowserForm formBrowser;
        FormDados formDados;

        public Point previousMousePosition; // Store the previous mouse position for dragging the form around
        
        // Serial communication
        public static SerialDataController serialDataController;
        private SerialPort serialPort;
        private BackgroundWorker serialWorker;
        private object serialLock = new object(); // lock to prevent thread collisions on serial port


        public GroundStation()
        {
            InitializeComponent();
            instance = this;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            MouseDown += Form_MouseDown_Drag;
            MouseMove += Form_MouseMove_Drag;

            // Serial port initialization
            serialPort = new SerialPort("COM8", 9600);
            serialPort.ReadTimeout = 2000;
            serialDataController = new SerialDataController();

            serialWorker = new BackgroundWorker();
            serialWorker.WorkerSupportsCancellation = true;
            serialWorker.DoWork += serialWorker_DoWork;
            serialWorker.RunWorkerCompleted += serialWorker_RunWorkerCompleted;

            // Forms instantiation
            formGraficos = new FormChart() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            formDados = new FormDados(serialDataController) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            formMapa = new FormMapa(serialDataController) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            formConfigurações = new FormConfigurações() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            formBrowser = new BrowserForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };

            MavBoiaConfigurations.OnSerialConfigurationUpdate += UpdateSerialConfiguration;
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

        #region SerialCommunication
        private void UpdateSerialConfiguration()
        {
            if (serialPort.IsOpen)
            {
                lock (serialLock)
                {
                    serialPort.Close();
                    serialPort.PortName = MavBoiaConfigurations.SerialPort;
                    serialPort.BaudRate = MavBoiaConfigurations.BaudRate;
                    serialPort.Open();
                }
            }
            else
            {
                serialPort.PortName = MavBoiaConfigurations.SerialPort;
                serialPort.BaudRate = MavBoiaConfigurations.BaudRate;
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                const string buttonOffText = "Ligar rádio";
                const string buttonOnText = "Desligar rádio";

                // if the port is open close it
                if (serialPort.IsOpen)
                {
                    serialWorker.CancelAsync();
                    buttonConnect.Text = buttonOffText;
                    return;
                }

                serialPort.PortName = MavBoiaConfigurations.SerialPort;
                serialPort.BaudRate = MavBoiaConfigurations.BaudRate;
                serialPort.Open();
                serialWorker.RunWorkerAsync();
                buttonConnect.Text = buttonOnText;
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}\n" + $"Verifique se a porta existe ou já está sendo usada por outro programa.");
            }    
        }

        private void serialWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!serialWorker.CancellationPending)
            {
                try
                {
                    if (!serialPort.IsOpen) continue;
                    Mavlink.MavlinkMessage message;
                    lock (serialLock)
                        message = mavlinkParser.ReadPacket(serialPort.BaseStream);

                    if (message != null)
                    {
                        serialDataController.ProcessMavlinkMessage(message);
                    }
                }
                catch(UnauthorizedAccessException unauthorizedException)
                {
                    buttonConnect.BeginInvoke((Action)(() => { buttonConnect.Text = "Ligar rádio"; }));
                    serialWorker.CancelAsync();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }

                Thread.Sleep(1);
            }
            e.Cancel = true;
        }

        private void serialWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lock (serialLock)
                serialPort.Close();
        }

        #endregion

        private void buttonHTTPConnect_Click(object sender, EventArgs e)
        {
            
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
