using MavBoia;
using MavBoia.Utilities;
using MavlinkDataController;
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
using MavBoia.DataControl;

namespace SimpleExample
{
    public partial class FormDados : Form
    {
        FormResizer resizer;

        public FormDados(MavBoia.DataControl.DataController serialDataController)
        {
            resizer = new FormResizer(this);
            InitializeComponent();
            resizer.InitializeResizer();

            serialDataController.OnBMSStatusDataReceived += UpdateDataBMSStatus;
            serialDataController.OnBMSDataReceived += UpdateDataBMS;
            serialDataController.OnMotor1DataReceived += UpdateMotorData1;
            serialDataController.OnMotor2DataReceived += UpdateMotorData2;
            serialDataController.OnTemperatureDataReceived += UpdateTemperatureData;
            serialDataController.OnInstrumentationsDataReceived += UpdateInstrumentationData;

        }

        public void UpdateDataBMSStatus(BMSStatusData data)
        {
            this.BeginInvoke((Action)(() =>
            {
                foreach (var failure in data.FailureFlags)
                {
                    Label label = new Label();
                    label.Text = failure.ToString() + "\n" + data.Timestamp; ;
                    label.AutoSize = false;
                    label.MaximumSize = new Size(flowLayoutBMS.Width - 20, 0);
                    label.AutoEllipsis = false;
                    label.AutoSize = true;
                    String failureString = data.FailureFlags.ToString();
                    if (failureString[failureString.Length-1] == '2')
                    {
                        label.BackColor = Color.Red;
                    }
                    flowLayoutBMS.Controls.Add(label);
                }
            }));
        }

        private void UpdateDataBMS(BMSData data)
        {
            this.BeginInvoke((Action)(() =>
            {
                String voltages = "";
                for(int i = 0; i < data.Voltages.Length; i++)
                {
                    voltages += $"{data.Voltages[i].ToString()}, ";
                }

                lbl_bms_voltage.Text = voltages;

                lbl_bms_curr.Text = $"BMS Corrente: {data.Current_battery}";
                lbl_bms_soc.Text = $"BMS SOC: {data.State_of_charge}";
                lbl_bms_temp_1.Text = $"BMS Temp1: {data.Temperatures[0]}";
                lbl_bms_temp_2.Text = $"BMS Temp2: {data.Temperatures[1]}";
                lbl_bat_volt.Text = $"Bateria Tensão: {data.Total_voltage}";

                lbl_estimative.Text = "Estimativa Bateria: " + ((int)(-1 * (((data.State_of_charge / 100) * 40) / data.Current_battery) * 60)).ToString();
            }));
        }

        private void UpdateInstrumentationData(InstrumentationData data)
        {
            this.BeginInvoke((Action)(() =>
            {
                lbl_bat_curr.Text = $"Bateria Corrente: {data.BatteryCurrent}";
                lbl_aux_bat_curr.Text = $"Bateria Aux. Corrente: {data.AuxiliaryBatteryCurrent}";
                lbl_bat_aux_volt.Text = $"Bateria Aux. Tensão: {data.AuxiliaryBatteryVoltage}";
                lbl_mppt_curr.Text = $"Corrente MPPT: {data.MpptCurrent}";
                lbl_motor_curr_L.Text = $"Corrente Motor L: {data.MotorCurrentLeft}";
                lbl_motor_curr_R.Text = $"Corrente Motor R: {data.MotorCurrentRight}";
            }));
        }

        private void UpdateMotorData1(MotorData1 data)
        {
            this.BeginInvoke((Action)(() =>
            {
                if (data.Instance == MOTOR_INSTANCE.LEFT)
                {
                    //if(lbl_motor_curr_L.Text != "") lbl_motor_curr_L.Text = $"Corrente Motor L (M): {data.Bus_current}";
                    lbl_motor_volt_L.Text = $"Tensão Motor BB: {data.Bus_voltage}";
                    lbl_rpm_L.Text = $"RPM L: {data.Rpm}";
                }
                else if (data.Instance == MOTOR_INSTANCE.RIGHT)
                {
                    //lbl_motor_curr_R.Text = $"Corrente Motor R (M): {data.Bus_current}";
                    lbl_motor_volt_R.Text = $"Tensão Motor BR: {data.Bus_voltage}";
                    lbl_rpm_R.Text = $"RPM R: {data.Rpm}";
                }
            }));
        }

        private void UpdateMotorData2(MotorData2 data)
        {
            this.BeginInvoke((Action)(() =>
            {
                if (data.Instance == MOTOR_INSTANCE.LEFT)
                {
                    lbl_temp_cont_L.Text = $"Temp Controlador BB: {data.Controller_temperature}";
                }
                else if (data.Instance == MOTOR_INSTANCE.RIGHT)
                {
                    lbl_motor_curr_R.Text = $"Temp Controlador BR: {data.Controller_temperature}";
                }
            }));
        }

        private void UpdateTemperatureData(TemperatureData data)
        {
            this.BeginInvoke((Action)(() =>
            {
                lbl_temp_bat_L.Text = $"Temp Bateria L: {data.TemperatureBatteryLeft}";
                lbl_temp_bat_R.Text = $"Temp Bateria R: {data.TemperatureBatteryRight}";
                lbl_temp_mppt_L.Text = $"Temp MPPT L: {data.TemperatureMpptLeft}";
                lbl_temp_mppt_R.Text = $"Temp MPPT R: {data.TemperatureMpptRight}";
            }));
        }



        private void FormDados_Resize(object sender, EventArgs e)
        {
            resizer.ResizeAll();
        }

        private void FormDados_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                Label label = new Label();
                label.Text = "oi";
                label.AutoSize = false;
                label.MaximumSize = new Size(flowLayoutBMS.Width - 20, 0);
                label.AutoEllipsis = false;
                label.AutoSize = true;
                flowLayoutBMS.Controls.Add(label);
            }
            flowLayoutBMS.Visible = true;
        }

        private void ToggleNotificationBar()
        {
            if (tabControlNotifications.Visible)
            {
                tabControlNotifications.Visible = false;
                
                btnNotifications.Text = "<";
            }
            else
            {
                tabControlNotifications.Visible = true;
                btnNotifications.Text = ">"; 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToggleNotificationBar();
        }

        private void lbl_bms_soc_Click(object sender, EventArgs e)
        {

        }

        private void lbl_rpm_R_Click(object sender, EventArgs e)
        {

        }

        private void lbl_temp_cont_R_Click(object sender, EventArgs e)
        {

        }

        private void lbl_temp_cont_L_Click(object sender, EventArgs e)
        {

        }

        private void lbl_bms_temp_1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_bms_temp_2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_bat_curr_Click(object sender, EventArgs e)
        {

        }

        private void lbl_motor_volt_L_Click(object sender, EventArgs e)
        {

        }

        private void lbl_motor_volt_R_Click(object sender, EventArgs e)
        {

        }

        private void lbl_motor_curr_R_Click(object sender, EventArgs e)
        {

        }

        private void lbl_motor_curr_L_Click(object sender, EventArgs e)
        {

        }

        private void lbl_mppt_curr_Click(object sender, EventArgs e)
        {

        }

        private void lbl_aux_bat_curr_Click(object sender, EventArgs e)
        {

        }
    }
}