using MavBoia;
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
        public FormDados(MavlinkDataController.DataController serialDataController)
        {
            InitializeComponent();

            serialDataController.OnDataReceived += UpdateData;
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

        public void UpdateData(AllSensorData message)
        {
            string instrumentationText = $"Tensão da bateria: {message.BatteryVoltage:F2}V\n" +
                                         $"Corrente do motor L: {message.MotorLeftCurrent:F2}A\n" +
                                         $"Corrente do motor R: {message.MotorRightCurrent:F2}A\n" +
                                         $"Corrente do MPPT: {message.MpptCurrent:F2}A\n" +
                                         $"Velocidade: {message.Velocity:F2} nós";

            

            string temperatureText = $"Bateria(L): " + CheckTemperatureProbe(message.TemperatureBatteryLeft) + "\n" +
                                     $"Bateria(R): " + CheckTemperatureProbe(message.TemperatureBatteryRight) + "\n" +
                                     $"MPPT: " + CheckTemperatureProbe(message.TemperatureMPPT) + "\n";

            

            string rpmText = $"Motor L: {message.RpmLeft:F0}\n" +
                             $"Motor R: {message.RpmRight:F0}\n";

            this.BeginInvoke((Action)(() =>
            {
                labelInstrumentationData.Text = instrumentationText;
                labelTemperatureData.Text = temperatureText;
                labelRPM.Text = rpmText;
            }));
        }
    }
}
