using MavBoia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations.Model;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataController.SerialData;

namespace SimpleExample
{
    public partial class FormDados : Form
    {
        public FormDados(SerialDataController serialDataController)
        {
            InitializeComponent();
            MouseDown += Form_MouseDown_Drag;
            MouseMove += Form_MouseMove_Drag;

            serialDataController.OnMavlink_ALL_INFO_MessageReceived += UpdateData;
        }

        private String CheckTemperatureProbe(float temperature)
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

        public void UpdateData(Mavlink.mavlink_all_info_t message)
        {
            string instrumentationText = $"Tensão da bateria: {message.battery_voltage:F2}V\n" +
                                         $"Corrente do motor L: {message.motor_current_left:F2}A\n" +
                                         $"Corrente do motor R: {message.motor_current_right:F2}A\n" +
                                         $"Corrente do MPPT: {message.mppt_current:F2}A\n";

            

            string temperatureText = $"Bateria(L): " + CheckTemperatureProbe(message.temperature_battery_left) + "\n" +
                                     $"Bateria(R): " + CheckTemperatureProbe(message.temperature_battery_right) + "\n" +
                                     $"MPPT: " + CheckTemperatureProbe(message.temperature_mppt) + "\n";

            

            string rpmText = $"Motor L: {message.rpm_left:F0}\n" +
                             $"Motor R: {message.rpm_right:F0}\n";

            this.BeginInvoke((Action)(() =>
            {
                labelInstrumentationData.Text = instrumentationText;
                labelTemperatureData.Text = temperatureText;
                labelRPM.Text = rpmText;
            }));
        }

        private void Form_MouseDown_Drag(object sender, MouseEventArgs e)
        {
            // Store the current mouse position
            GroundStation.instance.previousMousePosition = new Point(e.X, e.Y);
        }

        private void Form_MouseMove_Drag(object sender, MouseEventArgs e)
        {
            // Move the form when dragging
            if (e.Button == MouseButtons.Left)
            {
                GroundStation.instance.Left += e.X - GroundStation.instance.previousMousePosition.X;
                GroundStation.instance.Top += e.Y - GroundStation.instance.previousMousePosition.Y;
            }
        }

        private void labelControlTitle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
