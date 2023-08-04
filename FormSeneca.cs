using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleExample
{
    public partial class FormSeneca : Form
    {
        public Point previousMousePosition; // Store the previous mouse position for dragging the form around
        public static FormSeneca instance;
        public FormSeneca()
        {
            instance = this;
            InitializeComponent();
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
            previousMousePosition = new Point(e.X, e.Y);
        }

        public void Form_MouseMove_Drag(object sender, MouseEventArgs e)
        {
            // Move the form when dragging
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - previousMousePosition.X;
                this.Top += e.Y - previousMousePosition.Y;
            }
        }
        #endregion

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            rjTextBoxmilliVoltage.Texts = trackBar1.Value.ToString();
            rjTextBoxCurrent.Texts = $"{CalculateBipolarCurrentT201(float.Parse(rjTextBoxmilliVoltage.Texts) * 0.001f, float.Parse(rjTextBoxEscalaMin.Texts), float.Parse(rjTextBoxEscalaMax.Texts), Convert.ToInt32(rjTextBoxBurden.Texts), checkBoxBipolar.Checked):F0}";
        }

        public static float CalculateBipolarCurrentT201(float pin_voltage, float low_scale_range, float full_scale_range, int burden_resistance, bool bipolar_mode = false)
        {

            // Calculates the slope and intercept of the linear equation that relates input current to output voltage.
            float zero_input_voltage = 4.0f * burden_resistance * 0.001f; // 4mA * burden resistor
            float full_input_voltage = 20.0f * burden_resistance * 0.001f; // 20mA * burden resistor

            int signMultiplier = 1;
            if (!bipolar_mode)
            {
                low_scale_range = 0;
                if (pin_voltage < zero_input_voltage)
                {
                    return 0.0f; // If the voltage is outside the valid range, return 0.0f (no current)
                }
            }
            else
            {
                if (pin_voltage < zero_input_voltage || pin_voltage > full_input_voltage)
                {
                    return 0.0f; // If the voltage is outside the valid range, return 0.0f (no current)
                }

                // Determine the direction of the current (positive or negative) based on the bipolar mode

                float middle_input_voltage = (full_input_voltage + zero_input_voltage) / 2.0f;
                if (pin_voltage < middle_input_voltage)
                {
                    // Voltage is in the negative region, so the current is negative (reverse current)
                    //signMultiplier = -1;
                    signMultiplier = 1;
                }
            }

            // Calculate the current using the linear equation
            float low_input_current = low_scale_range;
            float full_input_current = full_scale_range;
            float slope = (full_input_current - low_input_current) / (full_input_voltage - zero_input_voltage);
            float intercept = low_input_current - slope * zero_input_voltage;
            float current = (slope * pin_voltage + intercept) * signMultiplier;
            return current;
        }

        private void FormSeneca_Load(object sender, EventArgs e)
        {
            trackBar1.Minimum = Convert.ToInt32(rjTextBoxBurden.Texts) * 4;
            trackBar1.Maximum = Convert.ToInt32(rjTextBoxBurden.Texts) * 20;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}
