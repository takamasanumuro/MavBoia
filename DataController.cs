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
using System.Timers;
using System.Dynamic;

namespace MavlinkDataController
{
    public class DataController
    {
        public event Action<AllSensorData> OnDataReceived;

        #region Variables
        // To avoid messing with generated code, this variables were created to manage GLG Chart.
        //private float motorLeftCurrent = 0.0f;
        //private float motorRightCurrent = 0.0f;
        //private float mpptCurrent = 0.0f;
        //private float batteryCurrent = 0.0f;
        //private float batteryVoltage = 0.0f;
        //private float generationPower = 0.0f;
        //private float batteryPower = 0.0f;
        //private float motorLeftPower = 0.0f;
        //private float motorRightPower = 0.0f;
        //private float resultantPower = 0.0f;
        //private float latitude = 0.000000f;
        //private float longitude = 0.000000f;
        //private float temperatureBatteryLeft = 0.0f;
        //private float temperatureBatteryRight = 0.0f;
        //private float temperatureMPPT = 0.0f;
        //private float rpmLeft = 0.0f;
        //private float rpmRight = 0.0f;
        #endregion

        private AllSensorData lastDataProcessed = new AllSensorData();

        private double lastLatitude;
        private double lastLongitude;

        private float CalculateVelocity()
        {
            if (this.lastDataProcessed.Latitude == 0 || this.lastDataProcessed.Longitude == 0) return 0f;

            float velocity = (float)((Geographic.Calculations.GeoUtils.HaversineDistance(this.lastLatitude, this.lastLongitude, this.lastDataProcessed.Latitude, this.lastDataProcessed.Longitude) / 1.852) * 3600);
            this.lastLatitude = lastDataProcessed.Latitude;
            this.lastLongitude = lastDataProcessed.Longitude;

            return velocity;
        }

        //private void UpdateData(Mavlink.mavlink_all_info_t message)
        //{
        //    this.motorLeftCurrent = message.motor_current_left;
        //    this.motorRightCurrent = message.motor_current_right;
        //    this.mpptCurrent = message.mppt_current;
        //    this.batteryCurrent = this.motorLeftCurrent + this.motorRightCurrent - this.mpptCurrent;
        //    this.batteryVoltage = message.battery_voltage;
        //    this.generationPower = this.mpptCurrent * this.batteryVoltage;
        //    this.batteryPower = this.batteryCurrent * this.batteryVoltage;
        //    this.motorLeftPower = this.motorLeftCurrent * this.batteryVoltage;
        //    this.motorRightPower = this.motorRightCurrent * this.batteryVoltage;
        //    this.resultantPower = this.batteryPower * this.batteryVoltage;
        //    this.latitude = message.latitude;
        //    this.longitude = message.longitude;
        //    this.temperatureBatteryLeft = message.temperature_battery_left;
        //    this.temperatureBatteryRight = message.temperature_battery_right;
        //    this.temperatureMPPT = message.temperature_mppt;
        //    this.rpmLeft = message.rpm_left;
        //    this.rpmRight = message.rpm_right;
        //}

        //private void UpdateData(AllSensorData data)
        //{
        //    this.motorLeftCurrent = data.MotorLeftCurrent;
        //    this.motorRightCurrent = data.MotorRightCurrent;
        //    this.mpptCurrent = data.MpptCurrent;
        //    this.batteryCurrent = this.motorLeftCurrent + this.motorRightCurrent - this.mpptCurrent;
        //    this.batteryVoltage = data.BatteryVoltage;
        //    this.generationPower = this.mpptCurrent * this.batteryVoltage;
        //    this.batteryPower = this.batteryCurrent * this.batteryVoltage;
        //    this.motorLeftPower = this.motorLeftCurrent * this.batteryVoltage;
        //    this.motorRightPower = this.motorRightCurrent * this.batteryVoltage;
        //    this.resultantPower = this.batteryPower * this.batteryVoltage;
        //    this.latitude = data.Latitude;
        //    this.longitude = data.Longitude;
        //    this.temperatureBatteryLeft = data.TemperatureBatteryLeft;
        //    this.temperatureBatteryRight = data.TemperatureBatteryRight;
        //    this.temperatureMPPT = data.TemperatureMPPT;
        //    this.rpmLeft = data.RpmLeft;
        //    this.rpmRight = data.RpmRight;

        //    data.Velocity = this.velocity;
        //}

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
                        AllSensorData allSensorData = new AllSensorData(payload);
                        allSensorData.Velocity = CalculateVelocity();
                        lastDataProcessed = AllSensorData.Clone(allSensorData);
                        SaveData(allSensorData);
                        OnDataReceived?.Invoke(allSensorData);
                        break;
                    }
                default:
                    break;
            }
        }

        public void ProcessNetworkData(AllSensorData data)
        {
            data.Velocity = CalculateVelocity();
            lastDataProcessed = AllSensorData.Clone(data);
            SaveData(data);
            OnDataReceived?.Invoke(data);
        }

        public AllSensorData GetAllSensorData()
        {
            return lastDataProcessed;
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
                string csvData = $"{data},{timestamp}";
                Console.WriteLine(csvData);
                dataLogger.WriteLine(csvData);
            }
        }

        void SaveData(Mavlink.MavlinkMessage message)
        {
            string directory = GetLoggingDirectory();
            if (directory == null) return;
            string fileName = message.MsgTypename + ".csv";
            string data = MavlinkUtilities.GetMessageDataCSV(message);
            data += $"{GetAllSensorData().Velocity}";
            WriteDataCSV(directory, fileName, data);
        }
        
        void SaveData(AllSensorData data)
        {
            string directory = GetLoggingDirectory();
            if (directory == null) return;
            const string fileName = "InfluxDB.csv";

            WriteDataCSV(directory, fileName, data.ToCSV());
        }

        #endregion
    }
}
