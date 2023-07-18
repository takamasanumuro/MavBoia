using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public static float currentMotor = 0.0f;
        public static float currentMPPT = 0.0f;
        public static float currentBattery = 0.0f;
        public static float mainBatteryVoltage = 0.0f;
        public static float auxBatteryVoltage = 0.0f;
        public static float generationPower = 0.0f;
        public static float consumptionPower = 0.0f;
        public static float resultantPower = 0.0f;
        public static float latitude = 0.000000f;
        public static float longitude = 0.000000f;
        public static float temperatureMotor = 0.0f;
        public static float temperatureMPPT = 0.0f;
        public FormDados()
        {
            InitializeComponent();
            instance = this;
            MouseDown += Form_MouseDown_Drag;
            MouseMove += Form_MouseMove_Drag;
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
    }
}
