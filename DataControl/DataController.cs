using SimpleExample;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MavBoia.Geography;
using System.Diagnostics;
using System.Timers;
using System.Dynamic;
using MavBoia;
using MavlinkDataController;

namespace MavBoia.DataControl
{
    public class DataController
    {
        public event Action<GPSData> OnGPSDataReceived;
        public event Action<BMSData> OnBMSDataReceived;
        public event Action<BMSStatusData> OnBMSStatusDataReceived;
        public event Action<InstrumentationData> OnInstrumentationsDataReceived;
        public event Action<MPPTData> OnMPPTDataReceived;
        public event Action<MPPTStateData> OnMPPTStatusDataReceived; 
        public event Action<RadioStatusData> OnRadioStatusDataReceived; 
        public event Action<TemperatureData> OnTemperatureDataReceived;
        public event Action<MotorData1> OnMotor1DataReceived;
        public event Action<MotorData2> OnMotor2DataReceived;

        private InstrumentationData lastInstrumentationDataProcessed = new InstrumentationData();

        private double lastLatitude;
        private double lastLongitude;

        //private float CalculateVelocity()
        //{
        //    if (this.lastDataProcessed.Latitude == 0 || this.lastDataProcessed.Longitude == 0) return 0f;

        //    float velocity = (float)((GeoUtils.HaversineDistance(this.lastLatitude, this.lastLongitude, this.lastDataProcessed.Latitude, this.lastDataProcessed.Longitude) / 1.852) * 3600);
        //    this.lastLatitude = lastDataProcessed.Latitude;
        //    this.lastLongitude = lastDataProcessed.Longitude;

        //    return velocity;
        //}


        public void ProcessMavlinkMessage(MAVLink.MAVLinkMessage message)
        {
            Console.WriteLine(message.msgtypename);
            switch (message.msgid)
            {
                // Delegates and lambda expressions must be used to update the UI from a different thread.
                case (uint)MAVLink.MAVLINK_MSG_ID.GPS:
                    //MAVLink.mavlink_gps_t payload = (MAVLink.mavlink_gps_t)message.data;
                    //MavlinkUtilities.PrintMessageInfo(message);
                    //AllSensorData allSensorData = new AllSensorData(payload);
                    //allSensorData.Velocity = CalculateVelocity();
                    //lastDataProcessed = AllSensorData.Clone(allSensorData);
                    //SaveData(allSensorData);
                    //OnDataReceived?.Invoke(allSensorData);
                    ProcessGPSData((MAVLink.mavlink_gps_t)message.data);
                    break;

                case (uint)MAVLink.MAVLINK_MSG_ID.BMS:
                    ProcessBMSData((MAVLink.mavlink_bms_t)message.data);
                    break;

                case (uint)MAVLink.MAVLINK_MSG_ID.BMS_STATUS:
                    ProcessBMSStatusData((MAVLink.mavlink_bms_status_t)message.data);
                    break;

                case (uint)MAVLink.MAVLINK_MSG_ID.INSTRUMENTATION:
                    ProcessInstrumentationData((MAVLink.mavlink_instrumentation_t)message.data);
                    break;

                case (uint)MAVLink.MAVLINK_MSG_ID.MPPT:
                    ProcessMPPTData((MAVLink.mavlink_mppt_t)message.data);
                    break;

                case (uint)MAVLink.MAVLINK_MSG_ID.MPPT_STATE:
                    ProcessMPPTStateData((MAVLink.mavlink_mppt_state_t)message.data);
                    break;

                case (uint)MAVLink.MAVLINK_MSG_ID.RADIO_STATUS:
                    ProcessRadioStatusData((MAVLink.mavlink_radio_status_t)message.data);
                    break;

                case (uint)MAVLink.MAVLINK_MSG_ID.TEMPERATURES:
                    ProcessTemperatureData((MAVLink.mavlink_temperatures_t)message.data);
                    break;

                case (uint)MAVLink.MAVLINK_MSG_ID.EZKONTROL_MCU_METER_DATA_I:
                    ProcessMotor1Data((MAVLink.mavlink_ezkontrol_mcu_meter_data_i_t)message.data);
                    break;

                case (uint)MAVLink.MAVLINK_MSG_ID.EZKONTROL_MCU_METER_DATA_II:
                    ProcessMotor2Data((MAVLink.mavlink_ezkontrol_mcu_meter_data_ii_t)message.data);
                    break;
                default:
                    break;
            }
        }

        #region Mavlink messages processing
        private void ProcessGPSData(MAVLink.mavlink_gps_t mavGps)
        {
            GPSData gps = new GPSData(mavGps);
            Console.WriteLine(gps.ToString());
            OnGPSDataReceived?.Invoke(gps);
        }

        private void ProcessBMSData(MAVLink.mavlink_bms_t mavBms)
        {
            BMSData bms = new BMSData(mavBms);
            Console.WriteLine(bms.ToString());
            OnBMSDataReceived?.Invoke(bms);
        }

        private void ProcessBMSStatusData(MAVLink.mavlink_bms_status_t mavBmsStatus)
        {
            BMSStatusData bmsStatus = new BMSStatusData(mavBmsStatus);
            Console.WriteLine(bmsStatus.ToString());
            OnBMSStatusDataReceived?.Invoke(bmsStatus);
        }

        private void ProcessInstrumentationData(MAVLink.mavlink_instrumentation_t mavInst)
        {
            InstrumentationData inst = new InstrumentationData(mavInst);
            Console.WriteLine(inst.ToString());
            lastInstrumentationDataProcessed = inst;
            OnInstrumentationsDataReceived?.Invoke(inst);
        }

        private void ProcessMPPTData(MAVLink.mavlink_mppt_t mavMppt)
        {
            MPPTData mppt = new MPPTData(mavMppt);
            Console.WriteLine(mppt.ToString());
            OnMPPTDataReceived?.Invoke(mppt);
        }

        private void ProcessMPPTStateData(MAVLink.mavlink_mppt_state_t mavMpptS)
        {
            MPPTStateData mpptS = new MPPTStateData(mavMpptS);
            Console.WriteLine(mpptS.ToString());
            OnMPPTStatusDataReceived?.Invoke(mpptS);
        }

        private void ProcessRadioStatusData(MAVLink.mavlink_radio_status_t mavRadio)
        {
            RadioStatusData radio = new RadioStatusData(mavRadio);
            Console.WriteLine(radio.ToString());
            OnRadioStatusDataReceived?.Invoke(radio);
        }

        private void ProcessTemperatureData(MAVLink.mavlink_temperatures_t mavTemp)
        {
            TemperatureData temp = new TemperatureData(mavTemp);
            Console.WriteLine(temp.ToString());
            OnTemperatureDataReceived?.Invoke(temp);
        }

        private void ProcessMotor1Data(MAVLink.mavlink_ezkontrol_mcu_meter_data_i_t mavMotor1)
        {
            MotorData1 motor1 = new MotorData1(mavMotor1);
            Console.WriteLine(motor1.ToString());
            OnMotor1DataReceived?.Invoke(motor1);
        }

        private void ProcessMotor2Data(MAVLink.mavlink_ezkontrol_mcu_meter_data_ii_t mavMotor2)
        {
            MotorData2 motor2 = new MotorData2(mavMotor2);
            Console.WriteLine(motor2.ToString());
            OnMotor2DataReceived?.Invoke(motor2);
        }
        #endregion

        public void ProcessNetworkData(AllSensorData data)
        {
            //data.Velocity = CalculateVelocity();
            //lastDataProcessed = AllSensorData.Clone(data);
            //SaveData(data);
            //OnDataReceived?.Invoke(data);
        }

        public InstrumentationData GetInstrumentationData()
        {
            return lastInstrumentationDataProcessed;
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

        void SaveData(MAVLink.MAVLinkMessage message)
        {
            string directory = GetLoggingDirectory();
            if (directory == null) return;
            string fileName = message.msgtypename + ".csv";
            string data = MavlinkUtilities.GetMessageDataCSV(message);
            //data += $"{GetInstrumentationData().Velocity}";
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
