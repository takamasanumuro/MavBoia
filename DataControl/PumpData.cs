using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavBoia.DataControl
{
    public enum PUMP_STATE
    {
        ON, OFF
    }
    public class PumpData
    {
        private PUMP_STATE pump_state;

        public PUMP_STATE Pump_state { get => pump_state; set => pump_state = value; }

        public PumpData() { }

        public PumpData(MAVLink.mavlink_pumps_t mavPump)
        {
            if (mavPump.pump_states == 0)
            {
                this.pump_state = PUMP_STATE.OFF;
            }
            else
            {
                this.pump_state = PUMP_STATE.ON;
            }
        }
    }
}
