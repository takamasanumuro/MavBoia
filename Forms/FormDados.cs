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

namespace SimpleExample
{
    public partial class FormDados : Form
    {

        FormResizer resizer;

        public FormDados(MavlinkDataController.DataController serialDataController)
        {
            resizer = new FormResizer(this);
            InitializeComponent();
            resizer.InitializeResizer();

            serialDataController.OnDataReceived += UpdateData;
        }


        public void UpdateData(AllSensorData message)
        {
            this.BeginInvoke((Action)(() =>
            {
                labelBatteryVoltage.Text = $"Tensão da bateria: {message.BatteryVoltage:F2}V";
                labelMotorCurrentLeft.Text = $"Corrente do motor L: {message.MotorLeftCurrent:F2}A";
                labelMotorCurrentRight.Text = $"Corrente do motor R: {message.MotorRightCurrent:F2}A";
                labelMpptCurrent.Text = $"Corrente do MPPT: {message.MpptCurrent:F2}A";
                labelVelocity.Text = $"Velocidade: {message.Velocity:F2} nós";
                labelIrradiance.Text = $"Irradiância: {message.Irradiance} W/m^2";

                labelBatteryLeftTemp.Text = $"Bateria(L): " + Utils.CheckTemperatureProbe(message.TemperatureBatteryLeft);
                labelBatteryRightTemp.Text = $"Bateria(R): " + Utils.CheckTemperatureProbe(message.TemperatureBatteryRight);
                labelMpptTemp.Text = $"MPPT: " + Utils.CheckTemperatureProbe(message.TemperatureMPPT);

                labelRpmLeft.Text = $"Motor L: {message.RpmLeft:F0}";
                labelRpmRight.Text = $"Motor R: {message.RpmRight:F0}";
            }));
        }

        private void FormDados_Resize(object sender, EventArgs e)
        {
            resizer.ResizeAll();
        }
    }
}
