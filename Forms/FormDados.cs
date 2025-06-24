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
            serialDataController.OnMPPTDataReceived += UpdateMPPTData;

        }

        public void UpdateDataBMSStatus(BMSStatusData data)
        {
            this.BeginInvoke((Action)(() =>
            {
                //foreach (var failure in data.FailureFlags)
                //{
                //    Label label = new Label();
                //    label.Text = failure.ToString() + "\n" + data.Timestamp; ;
                //    label.AutoSize = false;
                //    label.MaximumSize = new Size(flowLayoutBMS.Width - 20, 0);
                //    label.AutoEllipsis = false;
                //    label.AutoSize = true;
                //    String failureString = data.FailureFlags.ToString();
                //    if (failureString[failureString.Length-1] == '2')
                //    {
                //        label.BackColor = Color.Red;
                //    }
                //    flowLayoutBMS.Controls.Add(label);
                //}
            }));
        }

        private void UpdateDataBMS(BMSData data)
        {
            this.BeginInvoke((Action)(() =>
            {
                String voltages = "";
                int i;
                for(i = 0; i < data.Voltages.Length-1; i++)
                {
                    voltages += $"{data.Voltages[i].ToString()}, ";
                }
                voltages += $"{data.Voltages[i].ToString()}";

                lbl_bms_voltage.Text = voltages;


                lbl_bms_curr.Text = data.Current_battery.ToString() + " A";
                lbl_bms_soc.Text = data.State_of_charge.ToString() + " %";
                lbl_temp_bat_L.Text = data.Temperatures[0].ToString() + " ºC";
                lbl_temp_bat_R.Text = data.Temperatures[1].ToString() + " ºC";
                lbl_bat_volt.Text = data.Total_voltage.ToString() + " V";
                float estimative = -1 * (((data.State_of_charge / 100.0f) * 40.0f) / data.Current_battery);
                lbl_estimative.Text = $"{Math.Floor(estimative)}h {((estimative - Math.Floor(estimative)) * 60):F0}min";
                //lbl_estimative.Text = estimative.ToString();
            }));
        }

        private void UpdateInstrumentationData(InstrumentationData data)
        {
            this.BeginInvoke((Action)(() =>
            {
                lbl_inst_bat_volt.Text = data.BatteryVoltage.ToString() + " V";
                lbl_bat_curr.Text = data.BatteryCurrent.ToString() + " A";
                lbl_aux_bat_curr.Text = data.AuxiliaryBatteryCurrent.ToString() + " A";
                lbl_bat_aux_volt.Text = data.AuxiliaryBatteryVoltage.ToString() + " V";
                //lbl_mppt_curr.Text = data.MpptCurrent.ToString() + " A";
                //lbl_panel_volt.Text = data.MotorCurrentLeft.ToString() + " A";
                //lbl_panel_curr.Text = data.MotorCurrentRight.ToString() + " A";
            }));
        }

        private void UpdateMotorData1(MotorData1 data)
        {
            this.BeginInvoke((Action)(() =>
            {
                if (data.Instance == MOTOR_INSTANCE.LEFT)
                {
                    lbl_motor_volt_BB.Text = data.Bus_voltage.ToString() + " V";
                    lbl_rpm_BB.Text = data.Rpm.ToString();
                    lbl_motor_curr_BB.Text = data.Bus_current.ToString() + " A";
                    lbl_motor_ao_BB.Text = data.Accelerator_opening.ToString();
                }
                else if (data.Instance == MOTOR_INSTANCE.RIGHT)
                {
                    lbl_motor_volt_BR.Text = data.Bus_voltage.ToString() + " V";
                    lbl_rpm_BR.Text = data.Rpm.ToString();
                    lbl_motor_curr_BR.Text = data.Bus_current.ToString() + " A";  
                    lbl_motor_ao_BR.Text = data.Accelerator_opening.ToString();
                }
            }));
        }

        private void UpdateMotorData2(MotorData2 data)
        {
            this.BeginInvoke((Action)(() =>
            {
                if (data.Instance == MOTOR_INSTANCE.LEFT)
                {
                    lbl_temp_cont_BB.Text = data.Controller_temperature.ToString() + " ºC";
                }
                else if (data.Instance == MOTOR_INSTANCE.RIGHT)
                {
                    lbl_temp_cont_BR.Text = data.Controller_temperature.ToString() + " ºC";
                }
            }));
        }

        private void UpdateMPPTData(MPPTData data)
        {
            this.BeginInvoke((Action)(() =>
            {
                lbl_pv_volt.Text = data.Pv_voltage.ToString();
                lbl_pv_curr.Text = data.Pv_current.ToString();

                lbl_mppt_curr.Text = data.MPPT_current.ToString();
            }));
        }

        private void UpdateTemperatureData(TemperatureData data)
        {
            this.BeginInvoke((Action)(() =>
            {
                lbl_temp_bat_L.Text = data.TemperatureBatteryLeft.ToString() + " ºC";
                lbl_temp_bat_R.Text = data.TemperatureBatteryRight.ToString() + " ºC";
                lbl_temp_mppt_L.Text = data.TemperatureMpptLeft.ToString() + " ºC";
                lbl_temp_mppt_R.Text = data.TemperatureMpptRight.ToString() + " ºC";
            }));
        }



        private void FormDados_Resize(object sender, EventArgs e)
        {
            resizer.ResizeAll();
        }

        private void FormDados_Load(object sender, EventArgs e)
        {
        }

        private void ToggleNotificationBar()
        {
            //if (tabControlNotifications.Visible)
            //{
            //    tabControlNotifications.Visible = false;
                
            //    btnNotifications.Text = "<";
            //}
            //else
            //{
            //    tabControlNotifications.Visible = true;
            //    btnNotifications.Text = ">"; 
            //}
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

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }
    }
}