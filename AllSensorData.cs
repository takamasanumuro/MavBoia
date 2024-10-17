using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavlinkDataController
{
    public class AllSensorData
    {
        private float motorLeftCurrent = 0.0f;
        private float motorRightCurrent = 0.0f;
        private float mpptCurrent = 0.0f;
        private float batteryVoltage = 0.0f;
        private double latitude = 0.000000f;
        private double longitude = 0.000000f;
        private float velocity = 0.0f;
        private float temperatureBatteryLeft = 0.0f;
        private float temperatureBatteryRight = 0.0f;
        private float temperatureMPPT = 0.0f;
        private float rpmLeft = 0.0f;
        private float rpmRight = 0.0f;
        private float irradiance = 0.0f;   


        public float BatteryCurrent => motorLeftCurrent + motorRightCurrent - mpptCurrent;

        public float GenerationPower => mpptCurrent * batteryVoltage;

        public float BatteryPower => BatteryCurrent * batteryVoltage;

        public float MotorLeftPower => motorLeftCurrent * batteryVoltage;

        public float MotorRightPower => motorRightCurrent * batteryVoltage;

        public float ResultantPower => BatteryPower * batteryVoltage;

        public float MotorLeftCurrent { get => motorLeftCurrent; set => motorLeftCurrent = value; }
        public float MotorRightCurrent { get => motorRightCurrent; set => motorRightCurrent = value; }
        public float MpptCurrent { get => mpptCurrent; set => mpptCurrent = value; }
        public float BatteryVoltage { get => batteryVoltage; set => batteryVoltage = value; }
        public double Latitude { get => latitude; set => latitude = value; }
        public double Longitude { get => longitude; set => longitude = value; }
        public float Velocity { get => velocity; set => velocity = value; }
        public float TemperatureBatteryLeft { get => temperatureBatteryLeft; set => temperatureBatteryLeft = value; }
        public float TemperatureBatteryRight { get => temperatureBatteryRight; set => temperatureBatteryRight = value; }
        public float TemperatureMPPT { get => temperatureMPPT; set => temperatureMPPT = value; }
        public float RpmLeft { get => rpmLeft; set => rpmLeft = value; }
        public float RpmRight { get => rpmRight; set => rpmRight = value; }
        public float Irradiance { get => irradiance; set => irradiance = value; }



        //private void UpdateCalculatedValues()
        //{
        //    this.batteryCurrent = this.motorLeftCurrent + this.motorRightCurrent - this.mpptCurrent;
        //    this.generationPower = this.mpptCurrent * this.batteryVoltage;
        //    this.batteryPower = this.batteryCurrent * this.batteryVoltage;
        //    this.motorLeftPower = this.motorLeftCurrent * this.batteryVoltage;
        //    this.motorRightPower = this.motorRightCurrent * this.batteryVoltage;
        //    this.resultantPower = this.batteryPower * this.batteryVoltage;
        //}

        public string ToCSV()
        {
            return String.Format(CultureInfo.InvariantCulture, $"ALL_INFO," +
                "{0:F2}," +
                "{1:F2}," +
                "{2:F2}," +
                "{3:F2}," +
                "{4:F2}," +
                "{5:F2}," +
                "{6:F2}," +
                "{7:F14}," +
                "{8:F14}," +
                "{9:F2}," +
                "{10:F0}," +
                "{11:F0}",
                batteryVoltage,
                motorLeftCurrent,
                motorRightCurrent,
                mpptCurrent,
                temperatureBatteryLeft,
                temperatureBatteryRight,
                temperatureMPPT,
                latitude,
                longitude,
                velocity,
                rpmLeft,
                rpmRight);
        }

        public static AllSensorData FromLine(string line)
        {
            String[] items = line.Split(',');
            return new AllSensorData()
            {
                BatteryVoltage = float.Parse(items[1], CultureInfo.InvariantCulture),
                MotorLeftCurrent = float.Parse(items[2], CultureInfo.InvariantCulture),
                MotorRightCurrent = float.Parse(items[3], CultureInfo.InvariantCulture),
                MpptCurrent = float.Parse(items[4], CultureInfo.InvariantCulture),
                TemperatureBatteryLeft = float.Parse(items[5], CultureInfo.InvariantCulture),
                TemperatureBatteryRight = float.Parse(items[6], CultureInfo.InvariantCulture),
                TemperatureMPPT = float.Parse(items[7], CultureInfo.InvariantCulture),
                Latitude = double.Parse(items[8], CultureInfo.InvariantCulture),
                Longitude = double.Parse(items[9], CultureInfo.InvariantCulture),
                Velocity = float.Parse(items[10], CultureInfo.InvariantCulture),
                RpmLeft = float.Parse(items[11], CultureInfo.InvariantCulture),
                RpmRight = float.Parse(items[12], CultureInfo.InvariantCulture),
            };
        }

        public static AllSensorData Clone(AllSensorData data)
        {
            return new AllSensorData()
            {
                BatteryVoltage = data.BatteryVoltage,
                MotorLeftCurrent = data.MotorLeftCurrent,
                MotorRightCurrent = data.MotorRightCurrent,
                MpptCurrent = data.mpptCurrent,
                TemperatureBatteryLeft = data.TemperatureBatteryLeft,
                TemperatureBatteryRight = data.TemperatureBatteryRight,
                TemperatureMPPT = data.temperatureMPPT,
                Latitude = data.Latitude,
                Longitude = data.Longitude,
                Velocity = data.Velocity,
                RpmLeft = data.RpmLeft,
                RpmRight = data.RpmRight,
                Irradiance = data.irradiance,
            };
        }

        public AllSensorData() { }
        
        public AllSensorData(Mavlink.mavlink_all_info_t message)
        {
            motorLeftCurrent = message.motor_current_left;
            motorRightCurrent = message.motor_current_right;
            mpptCurrent = message.mppt_current;
            batteryVoltage = message.battery_voltage;
            latitude = message.latitude;
            longitude = message.longitude;
            temperatureBatteryLeft = message.temperature_battery_left;
            temperatureBatteryRight = message.temperature_battery_right;
            temperatureMPPT = message.temperature_mppt;
            rpmLeft = message.rpm_left;
            rpmRight = message.rpm_right;
        }
    }
}
