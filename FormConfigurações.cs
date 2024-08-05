using MavBoia;
using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace SimpleExample
{
    public partial class FormConfigurações : Form
    {
        public static FormConfigurações instance;
        public FormConfigurações()
        {
            instance = this;
            InitializeComponent();
            MouseDown += Form_MouseDown_Drag;
            MouseMove += Form_MouseMove_Drag;
            SetSerialPortDefaults("COM8", 9600);
            fancyComboBoxNetConnectionType.SelectedItem = "Local";
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

        /// <summary>
        /// Updates the serial port list when the user clicks on the combo box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxSerialPort_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBoxSerialPort.DataSource = ports;
        }

        private void SetSerialPortDefaults(string portName, int baudRate)
        {
            comboBoxBaudRate.SelectedItem = baudRate.ToString();
            string[] portNames = SerialPort.GetPortNames();
            comboBoxSerialPort.Items.AddRange(portNames);
            if (portNames.Length == 0) return;
            foreach (string item in portNames)
            {
                // Sets default value
                if (item == portName)
                {
                    comboBoxSerialPort.SelectedItem = item;
                    return;
                }
            }
            MessageBox.Show("Serial port number not found!");
        }

        private void buttonSeneca_Click(object sender, EventArgs e)
        {
            FormSeneca formSeneca = new FormSeneca();
            formSeneca.ShowDialog();
        }

        private void comboBoxSerialPort_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            MavBoiaConfigurations.SerialPort = this.comboBoxSerialPort.SelectedItem.ToString();
        }

        private void comboBoxBaudRate_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            MavBoiaConfigurations.BaudRate = this.comboBoxBaudRate.SelectedItem.ToString();
        }
    }
}
