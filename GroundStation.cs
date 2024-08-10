﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CefSharp.MinimalExample.WinForms;
using MavBoia;
using System.Threading;
using DataController.SerialData;
using System.Diagnostics;

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

        // Form state
        private Button activatedButton;
        private Form currentForm;
        
        // Serial communication
        public static SerialDataController serialDataController;
        private SerialPort serialPort;
        private BackgroundWorker serialWorker;
        private object serialLock = new object(); // lock to prevent thread collisions on serial port

        public GroundStation()
        {
            InitializeComponent();
            instance = this;

            // Serial port initialization
            serialPort = new SerialPort("COM8", 9600);
            serialPort.ReadTimeout = 2000;
            serialDataController = new SerialDataController();

            serialWorker = new BackgroundWorker();
            serialWorker.WorkerSupportsCancellation = true;
            serialWorker.DoWork += serialWorker_DoWork;
            serialWorker.RunWorkerCompleted += serialWorker_RunWorkerCompleted;

            // Forms instantiation
            formGraficos = new FormChart();
            formDados = new FormDados(serialDataController);
            formMapa = new FormMapa(serialDataController);
            formConfigurações = new FormConfigurações();
            formBrowser = new BrowserForm();

            MavBoiaConfigurations.OnSerialConfigurationUpdate += UpdateSerialConfiguration;
        }

        #region Form Initialization Defaults

        private void GroundStation_Load(object sender, EventArgs e)
        {

            //SetSerialPortDefaults("COM5", 4800);
            LoadForms();
        }

        // Ensure all forms are loaded and ready to receive data.
        private void LoadForms()
        {
            List<Form> forms = new List<Form>() { formConfigurações, formDados, formMapa, formBrowser, formGraficos };
            foreach (Form form in forms)
            {
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                panelDesktop.Controls.Add(form);
                
                form.Hide();
            }
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

        private void buttonConnectRadio_Click(object sender, EventArgs e)
        {
            try
            {
                const string buttonOffText = "Conectar rádio";
                const string buttonOnText = "Desconectar rádio";

                // if the port is open close it
                if (serialPort.IsOpen)
                {
                    serialWorker.CancelAsync();
                    buttonConnectRadio.Text = buttonOffText;
                    return;
                }

                serialPort.PortName = MavBoiaConfigurations.SerialPort;
                serialPort.BaudRate = MavBoiaConfigurations.BaudRate;
                serialPort.Open();
                serialWorker.RunWorkerAsync();
                buttonConnectRadio.Text = buttonOnText;
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
                    buttonConnectRadio.BeginInvoke((Action)(() => { buttonConnectRadio.Text = "Conectar rádio"; }));
                    serialWorker.CancelAsync();
                    Console.WriteLine(unauthorizedException.Message);
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

        #region Button Functions
        private void ActivateButton(Button btn)
        {
            if (btn == null) return;

            if(btn != activatedButton)
            {
                DeactivateButton(activatedButton);
                activatedButton = btn;
                btn.BackColor = Color.FromArgb(46, 51, 73);
            }
        }

        private void DeactivateButton(Button btn)
        {
            if (btn == null) return;

            btn.BackColor = Color.FromArgb(24, 30, 54);
        }
        #endregion

        private void ShowForm(Form form)
        {
            if(currentForm != null)
            {
                currentForm.Hide();
            }
            currentForm = form;
            panelDesktop.Tag = form;
            form.BringToFront();
            form.Show();
            lblTitle.Text = form.Text;
        }

        private void buttonRastreio_Click(object sender, EventArgs e)
        {
            ActivateButton(sender as Button);
            ShowForm(formBrowser);
        }

        private void buttonGraficos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender as Button);
            ShowForm(formGraficos);
        }

        private void buttonDados_Click(object sender, EventArgs e)
        {
            ActivateButton(sender as Button);
            ShowForm(formDados);
        }

        private void buttonMapa_Click(object sender, EventArgs e)
        {
            ActivateButton(sender as Button);
            ShowForm(formMapa);
        }

        private void buttonConfigurações_Click(object sender, EventArgs e)
        {
            ActivateButton(sender as Button);
            ShowForm(formConfigurações);
        }

        /// <summary>
        /// Callback for all buttons in the sidebar. Sets the panelNav position and color, which is the thin blue bar that tracks the buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGenericClickCallback(object sender, EventArgs e)
        {
            //Button button = (Button)sender;
            //panelNav.Height = button.Height;
            //panelNav.Top = button.Top;
            //panelNav.Left = button.Left;
            //panelNav.BringToFront();
            //button.BackColor = Color.FromArgb(46, 51, 73);
            //panelSecondaryFormLoader.Controls.Clear();
            //panelSecondaryFormLoader.Controls.Add(formBrowser);
            //panelSecondaryFormLoader.Show();

            //panelTopLeft.Enabled = false;
            //panelTopLeft.Visible = false;
            //pictureBoxArariboia.Enabled = false;
            //pictureBoxArariboia.Visible = false;
        }

        protected override void OnClosed(EventArgs e)
        {
            this.serialPort?.Dispose();
            base.OnClosed(e);
        }
    }
}
