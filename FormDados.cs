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

namespace SimpleExample
{
    public partial class FormDados : Form
    {
        public static Form instance;
        public static float motorLeftCurrent = 0.0f;
        public static float motorRightCurrent = 0.0f;
        public static float mpptCurrent = 0.0f;
        public static float batteryCurrent = 0.0f;
        public static float batteryVoltage = 0.0f;
        public static float generationPower = 0.0f;
        public static float batteryPower = 0.0f;
        public static float motorLeftPower = 0.0f;
        public static float motorRightPower = 0.0f;
        public static float resultantPower = 0.0f;
        public static float latitude = 0.000000f;
        public static float longitude = 0.000000f;
        public static float temperatureBatteryLeft = 0.0f;
        public static float temperatureBatteryRight = 0.0f;
        public static float temperatureMPPT = 0.0f;
        public static float rpmLeft = 0.0f;
        public static float rpmRight = 0.0f;


        public FormDados()
        {
            InitializeComponent();
            instance = this;
            MouseDown += Form_MouseDown_Drag;
            MouseMove += Form_MouseMove_Drag;
        }

        public static void UpdateData(Mavlink.mavlink_all_info_t packet)
        {
            batteryVoltage = packet.battery_voltage;
            motorLeftCurrent = packet.motor_current_left;
            motorRightCurrent = packet.motor_current_right;
            mpptCurrent = packet.mppt_current;

            batteryCurrent = motorLeftCurrent + motorRightCurrent - mpptCurrent;
            generationPower = mpptCurrent * batteryVoltage;
            batteryPower = batteryCurrent * batteryVoltage;
            motorLeftPower = motorLeftCurrent * batteryVoltage;
            motorRightPower = motorRightCurrent * batteryVoltage;
            resultantPower = batteryPower * batteryVoltage;

            temperatureBatteryLeft = packet.temperature_battery_left;
            temperatureBatteryRight = packet.temperature_battery_right;
            temperatureMPPT = packet.temperature_mppt;

            latitude = packet.latitude;
            longitude = packet.longitude;

            rpmLeft = packet.rpm_left;
            rpmRight = packet.rpm_right;
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
