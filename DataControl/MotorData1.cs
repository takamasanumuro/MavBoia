using Opc.Cpx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavBoia.DataControl
{
    enum MOTOR_INSTANCE
    {
        LEFT = 0, RIGHT = 1,
    }

    public class MotorData1
    {
        float bus_voltage; /*< [dV] 0.1V/bit, offset= 0*/
        float bus_current; /*< [dA] 0.1A/bit, offset= -32000*/
        int rpm; /*< [drpm/bit] 0.1rpm/bit, offset= -32000*/
        int accelerator_opening; /*<  1%/bit, throttle signal*/
        MOTOR_INSTANCE instance; /*<  0 for left motor, 1 for right motor*/

        public float Bus_voltage { get => bus_voltage; set => bus_voltage = value; }
        public float Bus_current { get => bus_current; set => bus_current = value; }
        public int Rpm { get => rpm; set => rpm = value; }
        public int Accelerator_opening { get => accelerator_opening; set => accelerator_opening = value; }
        internal MOTOR_INSTANCE Instance { get => instance; set => instance = value; }

        public MotorData1() { }

        public MotorData1(MAVLink.mavlink_ezkontrol_mcu_meter_data_i_t mavMotor1)
        {
            this.rpm = mavMotor1.rpm;
            this.accelerator_opening = mavMotor1.accelerator_opening;
            this.bus_current= mavMotor1.bus_current;
            this.bus_voltage = mavMotor1.bus_voltage;
            if (mavMotor1.instance == 0) this.instance = MOTOR_INSTANCE.LEFT;
            else if (mavMotor1.instance == 1) this.instance = MOTOR_INSTANCE.RIGHT;
        }

        public override string ToString()
        {
            return "MOTOR_DATA_I";
        }
    }
}
