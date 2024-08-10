using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        }

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
