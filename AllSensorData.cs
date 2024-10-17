using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavlinkDataController
{
    public class AllSensorData
    {
        private readonly float motorLeftCurrent = 0.0f;
        private readonly float motorRightCurrent = 0.0f;
        private readonly float mpptCurrent = 0.0f;
        private readonly float batteryVoltage = 0.0f;
        private readonly float latitude = 0.000000f;
        private readonly float longitude = 0.000000f;
        private float velocity = 0.0f;
        private readonly float temperatureBatteryLeft = 0.0f;
        private readonly float temperatureBatteryRight = 0.0f;
        private readonly float temperatureMPPT = 0.0f;
        private readonly float rpmLeft = 0.0f;
        private readonly float rpmRight = 0.0f;

        public float MotorLeftCurrent => motorLeftCurrent;

        public float MotorRightCurrent => motorRightCurrent;

        public float MpptCurrent => mpptCurrent;

        public float BatteryVoltage => batteryVoltage;

        public float Latitude => latitude;

        public float Longitude => longitude;

        public float Velocity { get => velocity; set => velocity = value; }

        public float TemperatureBatteryLeft => temperatureBatteryLeft;

        public float TemperatureBatteryRight => temperatureBatteryRight;

        public float TemperatureMPPT => temperatureMPPT;

        public float RpmLeft => rpmLeft;

        public float RpmRight => rpmRight;

        public float BatteryCurrent => motorLeftCurrent + motorRightCurrent - mpptCurrent;

        public float GenerationPower => mpptCurrent * batteryVoltage;

        public float BatteryPower => BatteryCurrent * batteryVoltage;

        public float MotorLeftPower => motorLeftCurrent * batteryVoltage;

        public float MotorRightPower => motorRightCurrent * batteryVoltage;

        public float ResultantPower => BatteryPower * batteryVoltage;



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
            return $"ALL_INFO," +
                $"{batteryVoltage}," +
                $"{motorLeftCurrent}," +
                $"{motorRightCurrent}," +
                $"{mpptCurrent}," +
                $"{temperatureBatteryLeft}," +
                $"{temperatureBatteryRight}," +
                $"{temperatureMPPT}," +
                $"{latitude}," +
                $"{longitude}," +
                $"{velocity}," +
                $"{rpmLeft}," +
                $"{rpmRight}";
        }

        public AllSensorData() { }

        public AllSensorData(float motorLeftCurrent, float motorRightCurrent, float mpptCurrent, float batteryVoltage, float latitude, float longitude, float temperatureBatteryLeft, float temperatureBatteryRight, float temperatureMPPT, float rpmLeft, float rpmRight)
        {
            this.motorLeftCurrent = motorLeftCurrent;
            this.motorRightCurrent = motorRightCurrent;
            this.mpptCurrent = mpptCurrent;
            this.batteryVoltage = batteryVoltage;
            this.latitude = latitude;
            this.longitude = longitude;
            this.temperatureBatteryLeft = temperatureBatteryLeft;
            this.temperatureBatteryRight = temperatureBatteryRight;
            this.temperatureMPPT = temperatureMPPT;
            this.rpmLeft = rpmLeft;
            this.rpmRight = rpmRight;
        }

        public AllSensorData(float motorLeftCurrent, float motorRightCurrent, float mpptCurrent, float batteryVoltage, float latitude, float longitude, float velocity, float temperatureBatteryLeft, float temperatureBatteryRight, float temperatureMPPT, float rpmLeft, float rpmRight)
        {
            this.motorLeftCurrent = motorLeftCurrent;
            this.motorRightCurrent = motorRightCurrent;
            this.mpptCurrent = mpptCurrent;
            this.batteryVoltage = batteryVoltage;
            this.latitude = latitude;
            this.longitude = longitude;
            this.velocity = velocity;
            this.temperatureBatteryLeft = temperatureBatteryLeft;
            this.temperatureBatteryRight = temperatureBatteryRight;
            this.temperatureMPPT = temperatureMPPT;
            this.rpmLeft = rpmLeft;
            this.rpmRight = rpmRight;
        }
        
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
