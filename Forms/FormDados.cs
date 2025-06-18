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

            serialDataController.OnInstrumentationsDataReceived += UpdateDataInstrumentation;
            serialDataController.OnTemperatureDataReceived += UpdateDataTemperature;
            serialDataController.OnMotor1DataReceived += UpdateDataMotor;

        }


        public void UpdateDataInstrumentation(InstrumentationData message)
        {
            this.BeginInvoke((Action)(() =>
            {
                labelBatteryVoltage.Text = $"Tensão da bateria: {message.BatteryVoltage:F2}V";
                labelMotorCurrentLeft.Text = $"Corrente do motor L: {message.MotorCurrentLeft:F2}A";
                labelMotorCurrentRight.Text = $"Corrente do motor R: {message.MotorCurrentRight:F2}A";
                labelMpptCurrent.Text = $"Corrente do MPPT: {message.MpptCurrent:F2}A";
                labelIrradiance.Text = $"Irradiância: {message.Irradiance} W/m^2";
            }));
        }

        public void UpdateDataGPS(GPSData message)
        {
            this.BeginInvoke((Action)(() =>
            {
                labelVelocity.Text = $"Velocidade: {message.Speed:F2} nós";
            }));
        }

        public void UpdateDataTemperature(TemperatureData message)
        {
            this.BeginInvoke((Action)(() =>
            {

                labelBatteryLeftTemp.Text = $"Bateria(L): " + Utils.CheckTemperatureProbe(message.TemperatureBatteryLeft);
                labelBatteryRightTemp.Text = $"Bateria(R): " + Utils.CheckTemperatureProbe(message.TemperatureBatteryRight);
                labelMpptTemp.Text = $"MPPT: " + Utils.CheckTemperatureProbe(message.TemperatureMpptRight);
            }));
        }

        public void UpdateDataMotor(MotorData1 message)
        {
            this.BeginInvoke((Action)(() =>
            {
                if (message.Instance == MOTOR_INSTANCE.LEFT)
                {
                    labelRpmLeft.Text = $"Motor L: {message.Rpm:F0}";
                }
                else
                {
                    labelRpmRight.Text = $"Motor R: {message.Rpm:F0}";
                }
            }));
        }

        private void FormDados_Resize(object sender, EventArgs e)
        {
            resizer.ResizeAll();
        }
    }
}
