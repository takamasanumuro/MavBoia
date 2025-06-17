using Opc.Cpx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavBoia.DataControl
{
    public enum MOTOR_STATUS
    {
        GEAR = 0,
        BREAK = 1, 
        OPERATION_MODE = 2,
        DC_CONTACTOR = 3
    }
    public class MotorData2 : IBoatData
    {
        int controller_temperature; /*<  Controller temperature. Actual value = MAVLink value - 40. Unit: degC*/
        int motor_temperature; /*<  Motor temperature. Actual value = MAVLink value - 40. Unit: degC*/
        MOTOR_STATUS status; /*<  Gear, brake, operation mode and DC contactor.*/
        int error_flags_byte4; /*<  Error flags from Byte 4.*/
        int error_flags_byte5; /*<  Error flags from Byte 5.*/
        int error_flags_byte6; /*<  Error flags from Byte 6.*/
        int life_signal; /*<  Life signal counter derived from bits 7-4 from byte 7, msg II.*/
        MOTOR_INSTANCE instance; /*<  0 for left motor, 1 for right motor*/

        public int Controller_temperature { get => controller_temperature; set => controller_temperature = value; }
        public int Motor_temperature { get => motor_temperature; set => motor_temperature = value; }
        public MOTOR_STATUS Status { get => status; set => status = value; }
        public int Error_flags_byte4 { get => error_flags_byte4; set => error_flags_byte4 = value; }
        public int Error_flags_byte5 { get => error_flags_byte5; set => error_flags_byte5 = value; }
        public int Error_flags_byte6 { get => error_flags_byte6; set => error_flags_byte6 = value; }
        public int Life_signal { get => life_signal; set => life_signal = value; }
        internal MOTOR_INSTANCE Instance { get => instance; set => instance = value; }

        public MotorData2() { }
        
        public MotorData2(MAVLink.mavlink_ezkontrol_mcu_meter_data_ii_t mavMotor2)
        {
            this.controller_temperature = mavMotor2.controller_temperature;
            this.motor_temperature = mavMotor2.motor_temperature;
            if (mavMotor2.instance == 0) this.instance = MOTOR_INSTANCE.LEFT;
            else if (mavMotor2.instance == 1) this.instance = MOTOR_INSTANCE.RIGHT;
        }

        public override string ToString()
        {
            return "MOTOR_DATA_II";
        }
    }
}
