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
            SetSerialPortDefaults("COM5", 4800);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelControlData_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
                    return;
                }
            }
            MessageBox.Show("Serial port number not found!");
        }

        private void rjTextBoxLogDirectory__TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSeneca_Click(object sender, EventArgs e)
        {
            FormSeneca formSeneca = new FormSeneca();
            formSeneca.ShowDialog();
        }
    }
}
