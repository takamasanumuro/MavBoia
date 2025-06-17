using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavBoia.DataControl
{
    public class InstrumentationData : IBoatData
    {
        float battery_current; /*< [cA] */
        float motor_current_left; /*< [cA] */
        float motor_current_right; /*< [cA] */
        float mppt_current; /*< [cA] */
        float auxiliary_battery_current; /*< [cA] */
        float battery_voltage; /*< [cV] */
        float auxiliary_battery_voltage; /*< [cV] */
        float irradiance; /*< [W/m^2] */

        public float GenerationPower => mppt_current * battery_voltage;
        public float BatteryPower => BatteryCurrent * battery_voltage;
        public float MotorLeftPower => motor_current_left * battery_voltage;
        public float MotorRightPower => motor_current_right * battery_voltage;
        public float ResultantPower => BatteryPower * battery_voltage;
        public float BatteryCurrent { get => battery_current; set => battery_current = value; }
        public float MotorCurrentLeft { get => motor_current_left; set => motor_current_left = value; }
        public float MotorCurrentRight { get => motor_current_right; set => motor_current_right = value; }
        public float MpptCurrent { get => mppt_current; set => mppt_current = value; }
        public float AuxiliaryBatteryCurrent { get => auxiliary_battery_current; set => auxiliary_battery_current = value; }
        public float BatteryVoltage { get => battery_voltage; set => battery_voltage = value; }
        public float AuxiliaryBatteryVoltage { get => auxiliary_battery_voltage; set => auxiliary_battery_voltage = value; }
        public float Irradiance { get => irradiance; set => irradiance = value; }

        public InstrumentationData() { }

        public InstrumentationData(MAVLink.mavlink_instrumentation_t mavInst)
        {
            this.mppt_current = mavInst.mppt_current;
            this.motor_current_left = mavInst.motor_current_left;
            this.motor_current_right = mavInst.motor_current_right;
            this.auxiliary_battery_current = mavInst.auxiliary_battery_current;
            this.irradiance = mavInst.irradiance;
            this.auxiliary_battery_voltage = mavInst.auxiliary_battery_voltage;
            this.battery_current = mavInst.battery_current;
            this.battery_voltage = mavInst.battery_voltage;
        }

        public override string ToString()
        {
            string s = "BatteryVALUES";
            return s;
        }
    }
}
