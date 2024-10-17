using MavlinkDataController;
using SimpleExample;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MavBoia.Forms
{
    public partial class FormRewind : Form
    {
        DataController controller;

        FormMapa formMapa;

        String filePath = "";
        int fileLines = 0;
        bool hasLoadedFile = false;

        public FormRewind(DataController controller)
        {
            InitializeComponent();

            this.controller = controller;
            formMapa = new FormMapa(controller, false);
        }

        private void FormRewind_Load(object sender, EventArgs e)
        {
            formMapa.TopLevel = false;
            formMapa.FormBorderStyle = FormBorderStyle.None;
            formMapa.Dock = DockStyle.Fill;
            panelMap.Controls.Add(formMapa);

            formMapa.Show(); // Calls load event
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.csv"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                String path = dialog.FileName; // get name of file

                fileLines = File.ReadLines(path).Count();
                filePath = path;
                hasLoadedFile = true;

                trackBarRewind.Maximum = fileLines;

                //using (StreamReader reader = new StreamReader(new FileStream (path,FileMode.Open),new UTF8Encoding())) // do anything you want, e.g. read it
                //{

                //}
            }
        }

        private void trackBarRewind_Scroll(object sender, EventArgs e)
        {
            if (!hasLoadedFile) return;
            using (StreamReader sr = new StreamReader(filePath))
            {
                for (int i = 0; i < trackBarRewind.Value-1; i++)
                {
                    sr.ReadLine();
                }

                AllSensorData data = AllSensorData.FromLine(sr.ReadLine());
                string text = $"Tensão da bateria: {data.BatteryVoltage:F2}V\n" +
                                         $"Corrente do motor L: {data.MotorLeftCurrent:F2}A\n" +
                                         $"Corrente do motor R: {data.MotorRightCurrent:F2}A\n" +
                                         $"Corrente do MPPT: {data.MpptCurrent:F2}A\n" +
                                         $"Velocidade: {data.Velocity:F2} nós\n" +
                                         $"Bateria(L): " + FormDados.CheckTemperatureProbe(data.TemperatureBatteryLeft) + "\n" +
                                     $"Bateria(R): " + FormDados.CheckTemperatureProbe(data.TemperatureBatteryRight) + "\n" +
                                     $"MPPT: " + FormDados.CheckTemperatureProbe(data.TemperatureMPPT) + "\n" +
                                     $"Motor L: {data.RpmLeft:F0}\n" +
                             $"Motor R: {data.RpmRight:F0}\n";

                labelData.Text = text;

                formMapa.UpdateData(data);
            }
        }
    }
}
