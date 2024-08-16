using SimpleExample;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MavBoia;
using System.Diagnostics;

namespace MavlinkDataController
{
    public class DataController
    {
        public event Action<AllSensorData> OnDataReceived;

        #region Variables
        // To avoid messing with generated code, this variables were created to manage GLG Chart.
        private float motorLeftCurrent = 0.0f;
        private float motorRightCurrent = 0.0f;
        private float mpptCurrent = 0.0f;
        private float batteryCurrent = 0.0f;
        private float batteryVoltage = 0.0f;
        private float generationPower = 0.0f;
        private float batteryPower = 0.0f;
        private float motorLeftPower = 0.0f;
        private float motorRightPower = 0.0f;
        private float resultantPower = 0.0f;
        private float latitude = 0.000000f;
        private float longitude = 0.000000f;
        private float temperatureBatteryLeft = 0.0f;
        private float temperatureBatteryRight = 0.0f;
        private float temperatureMPPT = 0.0f;
        private float rpmLeft = 0.0f;
        private float rpmRight = 0.0f;
        #endregion

        public class AllSensorData
        {
            private float motorLeftCurrent = 0.0f;
            private float motorRightCurrent = 0.0f;
            private float mpptCurrent = 0.0f;
            private float batteryCurrent = 0.0f;
            private float batteryVoltage = 0.0f;
            private float generationPower = 0.0f;
            private float batteryPower = 0.0f;
            private float motorLeftPower = 0.0f;
            private float motorRightPower = 0.0f;
            private float resultantPower = 0.0f;
            private float latitude = 0.000000f;
            private float longitude = 0.000000f;
            private float temperatureBatteryLeft = 0.0f;
            private float temperatureBatteryRight = 0.0f;
            private float temperatureMPPT = 0.0f;
            private float rpmLeft = 0.0f;
            private float rpmRight = 0.0f;

            public float MotorLeftCurrent { get => motorLeftCurrent; set { this.motorLeftCurrent = value; UpdateCalculatedValues(); } }
            public float MotorRightCurrent { get => motorRightCurrent; set { motorRightCurrent = value; UpdateCalculatedValues(); } }
            public float MpptCurrent { get => mpptCurrent; set { mpptCurrent = value; UpdateCalculatedValues(); } }
            public float BatteryCurrent { get => batteryCurrent; private set => batteryCurrent = value; }
            public float BatteryVoltage { get => batteryVoltage; set { batteryVoltage = value; UpdateCalculatedValues(); } }
            public float GenerationPower { get => generationPower; private set => generationPower = value; }
            public float BatteryPower { get => batteryPower; private set => batteryPower = value; }
            public float MotorLeftPower { get => motorLeftPower; private set => motorLeftPower = value; }
            public float MotorRightPower { get => motorRightPower; private set => motorRightPower = value; }
            public float ResultantPower { get => resultantPower; private set => resultantPower = value; }
            public float Latitude { get => latitude; set => latitude = value; }
            public float Longitude { get => longitude; set => longitude = value; }
            public float TemperatureBatteryLeft { get => temperatureBatteryLeft; set => temperatureBatteryLeft = value; }
            public float TemperatureBatteryRight { get => temperatureBatteryRight; set => temperatureBatteryRight = value; }
            public float TemperatureMPPT { get => temperatureMPPT; set => temperatureMPPT = value; }
            public float RpmLeft { get => rpmLeft; set => rpmLeft = value; }
            public float RpmRight { get => rpmRight; set => rpmRight = value; }


            private void UpdateCalculatedValues()
            {
                this.batteryCurrent = this.motorLeftCurrent + this.motorRightCurrent - this.mpptCurrent;
                this.generationPower = this.mpptCurrent * this.batteryVoltage;
                this.batteryPower = this.batteryCurrent * this.batteryVoltage;
                this.motorLeftPower = this.motorLeftCurrent * this.batteryVoltage;
                this.motorRightPower = this.motorRightCurrent * this.batteryVoltage;
                this.resultantPower = this.batteryPower * this.batteryVoltage;
            }

            public AllSensorData(float motorLeftCurrent, float motorRightCurrent, float mpptCurrent, float batteryVoltage, float latitude, float longitude, float temperatureBatteryLeft, float temperatureBatteryRight, float temperatureMPPT, float rpmLeft, float rpmRight)
            {
                this.motorLeftCurrent = motorLeftCurrent;
                this.motorRightCurrent = motorRightCurrent;
                this.mpptCurrent = mpptCurrent;
                this.batteryVoltage = batteryVoltage;
                UpdateCalculatedValues();
                this.latitude = latitude;
                this.longitude = longitude;
                this.temperatureBatteryLeft = temperatureBatteryLeft;
                this.temperatureBatteryRight = temperatureBatteryRight;
                this.temperatureMPPT = temperatureMPPT;
                this.rpmLeft = rpmLeft;
                this.rpmRight = rpmRight;
            }
            public AllSensorData() 
            {
                this.motorLeftCurrent = 0;
                this.motorRightCurrent = 0;
                this.mpptCurrent = 0;
                this.batteryCurrent = 0;
                this.batteryVoltage = 0;
                this.generationPower = 0;
                this.batteryPower = 0;
                this.motorLeftPower = 0;
                this.motorRightPower = 0;
                this.resultantPower = 0;
                this.latitude = 0;
                this.longitude = 0;
                this.temperatureBatteryLeft = 0;
                this.temperatureBatteryRight = 0;
                this.temperatureMPPT = 0;
                this.rpmLeft = 0;
                this.rpmRight = 0;
            }
        }
        
        public DataController()
        { 
        }
        private void UpdateData(Mavlink.mavlink_all_info_t message)
        {
            this.motorLeftCurrent = message.motor_current_left;
            this.motorRightCurrent = message.motor_current_right;
            this.mpptCurrent = message.mppt_current;
            this.batteryCurrent = this.motorLeftCurrent + this.motorRightCurrent - this.mpptCurrent;
            this.batteryVoltage = message.battery_voltage;
            this.generationPower = this.mpptCurrent * this.batteryVoltage;
            this.batteryPower = this.batteryCurrent * this.batteryVoltage;
            this.motorLeftPower = this.motorLeftCurrent * this.batteryVoltage;
            this.motorRightPower = this.motorRightCurrent * this.batteryVoltage;
            this.resultantPower = this.batteryPower * this.batteryVoltage;
            this.latitude = message.latitude;
            this.longitude = message.longitude;
            this.temperatureBatteryLeft = message.temperature_battery_left;
            this.temperatureBatteryRight = message.temperature_battery_right;
            this.temperatureMPPT = message.temperature_mppt;
            this.rpmLeft = message.rpm_left;
            this.rpmRight = message.rpm_right;
        }

        private void UpdateData(AllSensorData data)
        {
            this.motorLeftCurrent = data.MotorLeftCurrent;
            this.motorRightCurrent = data.MotorRightCurrent;
            this.mpptCurrent = data.MpptCurrent;
            this.batteryCurrent = this.motorLeftCurrent + this.motorRightCurrent - this.mpptCurrent;
            this.batteryVoltage = data.BatteryVoltage;
            this.generationPower = this.mpptCurrent * this.batteryVoltage;
            this.batteryPower = this.batteryCurrent * this.batteryVoltage;
            this.motorLeftPower = this.motorLeftCurrent * this.batteryVoltage;
            this.motorRightPower = this.motorRightCurrent * this.batteryVoltage;
            this.resultantPower = this.batteryPower * this.batteryVoltage;
            this.latitude = data.Latitude;
            this.longitude = data.Longitude;
            this.temperatureBatteryLeft = data.TemperatureBatteryLeft;
            this.temperatureBatteryRight = data.TemperatureBatteryRight;
            this.temperatureMPPT = data.TemperatureMPPT;
            this.rpmLeft = data.RpmLeft;
            this.rpmRight = data.RpmRight;
        }

        public void ProcessMavlinkMessage(Mavlink.MavlinkMessage message)
        {
            Console.WriteLine(message.MsgTypename);
            switch (message.MsgID)
            {
                // Delegates and lambda expressions must be used to update the UI from a different thread.
                case (uint)Mavlink.MAVLINK_MSG_ID.ALL_INFO:
                    {
                        Mavlink.mavlink_all_info_t payload = (Mavlink.mavlink_all_info_t)message.Payload;
                        MavlinkUtilities.PrintMessageInfo(message);
                        this.UpdateData(payload);
                        AllSensorData allSensorData = GetAllSensorData();
                        OnDataReceived?.Invoke(allSensorData);
                        break;
                    }
                default:
                    break;
            }
            SaveData(message);
        }

        public void ProcessNetworkData(AllSensorData data)
        {
            UpdateData(data);
            OnDataReceived?.Invoke(data);
        }

        public AllSensorData GetAllSensorData()
        {
            return new AllSensorData(this.motorLeftCurrent, this.motorRightCurrent,
                this.mpptCurrent, this.batteryVoltage, this.latitude, this.longitude, this.temperatureBatteryLeft, this.temperatureBatteryRight,
                this.temperatureMPPT, this.rpmLeft, this.rpmRight);
        }

        #region Logging
        String GetLoggingDirectory()
        {
            string directory = String.Empty;
            directory = MavBoiaConfigurations.RjTextBoxLogDirectory;
            if (directory == String.Empty)
            {
                MessageBox.Show("Invalid directory!");
            }
            return directory;
        }

        void WriteDataCSV(string directory, string fileName, string data)
        {

            if (directory == String.Empty)
            {
                MessageBox.Show("Invalid directory!");
                return;
            }

            if (fileName == String.Empty)
            {
                MessageBox.Show("Invalid file name!");
                return;
            }

            string path = Path.Combine(directory, fileName);
            using (StreamWriter dataLogger = new StreamWriter(path, true))
            {
                string timestamp = DateTime.Now.ToString("HH:mm:ss");
                string csvData = $"{timestamp}; {data}";
                Console.WriteLine(csvData);
                dataLogger.WriteLine(data);
                dataLogger.Flush();
            }
        }

        void SaveData(Mavlink.MavlinkMessage message)
        {
            string directory = GetLoggingDirectory();
            string fileName = message.MsgTypename + ".csv";
            string data = MavlinkUtilities.GetMessageDataCSV(message);
            WriteDataCSV(directory, fileName, data);
        }
        #endregion
    }
}
