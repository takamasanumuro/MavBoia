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

namespace DataController.SerialData
{
    public class SerialDataController
    {
        public event Action<Mavlink.mavlink_all_info_t> OnMavlink_ALL_INFO_MessageReceived;

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

            public float MotorLeftCurrent { get => motorLeftCurrent; }
            public float MotorRightCurrent { get => motorRightCurrent; }
            public float MpptCurrent { get => mpptCurrent; }
            public float BatteryCurrent { get => batteryCurrent; }
            public float BatteryVoltage { get => batteryVoltage; }
            public float GenerationPower { get => generationPower; }
            public float BatteryPower { get => batteryPower; }
            public float MotorLeftPower { get => motorLeftPower; }
            public float MotorRightPower { get => motorRightPower; }
            public float ResultantPower { get => resultantPower; }
            public float Latitude { get => latitude; }
            public float Longitude { get => longitude; }
            public float TemperatureBatteryLeft { get => temperatureBatteryLeft;     }
            public float TemperatureBatteryRight { get => temperatureBatteryRight; }
            public float TemperatureMPPT { get => temperatureMPPT; }
            public float RpmLeft { get => rpmLeft; }
            public float RpmRight { get => rpmRight; }

            public AllSensorData(float motorLeftCurrent, float motorRightCurrent, float mpptCurrent, float batteryCurrent, float batteryVoltage, float generationPower, float batteryPower, float motorLeftPower, float motorRightPower, float resultantPower, float latitude, float longitude, float temperatureBatteryLeft, float temperatureBatteryRight, float temperatureMPPT, float rpmLeft, float rpmRight)
            {
                this.motorLeftCurrent = motorLeftCurrent;
                this.motorRightCurrent = motorRightCurrent;
                this.mpptCurrent = mpptCurrent;
                this.batteryCurrent = batteryCurrent;
                this.batteryVoltage = batteryVoltage;
                this.generationPower = generationPower;
                this.batteryPower = batteryPower;
                this.motorLeftPower = motorLeftPower;
                this.motorRightPower = motorRightPower;
                this.resultantPower = resultantPower;
                this.latitude = latitude;
                this.longitude = longitude;
                this.temperatureBatteryLeft = temperatureBatteryLeft;
                this.temperatureBatteryRight = temperatureBatteryRight;
                this.temperatureMPPT = temperatureMPPT;
                this.rpmLeft = rpmLeft;
                this.rpmRight = rpmRight;
            }
        }
        
        public SerialDataController()
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
                        OnMavlink_ALL_INFO_MessageReceived?.Invoke(payload);
                        break;
                    }
                default:
                    break;
            }
            SaveData(message);
        }

        public AllSensorData GetAllSensorData()
        {
            return new AllSensorData(this.motorLeftCurrent, this.motorRightCurrent,
                this.mpptCurrent, this.batteryCurrent, this.batteryVoltage, this.generationPower,
                this.batteryPower, this.motorLeftPower, this.motorRightPower, this.resultantPower,
                this.latitude, this.longitude, this.temperatureBatteryLeft, this.temperatureBatteryRight,
                this.temperatureMPPT, this.rpmLeft, this.rpmRight);
        }

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
                dataLogger.WriteLine(csvData);
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
    }
}
