using MavBoia;
using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace SimpleExample
{
    public partial class FormConfigurações : Form
    {
        public FormConfigurações()
        {
            InitializeComponent();
            SetSerialPortDefaults("COM8", 9600);
            fancyComboBoxNetConnectionType.SelectedItem = "Local";
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
            formSeneca.Show();
        }

        private void comboBoxSerialPort_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            MavBoiaConfigurations.SerialPort = this.comboBoxSerialPort.SelectedItem.ToString();
        }

        private void comboBoxBaudRate_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            MavBoiaConfigurations.BaudRate = int.Parse(this.comboBoxBaudRate.SelectedItem.ToString());
        }

        private void rjTextBoxLogDirectory__TextChanged(object sender, EventArgs e)
        {
            MavBoiaConfigurations.RjTextBoxLogDirectory = this.rjTextBoxLogDirectory.Texts;
        }
    }
}
