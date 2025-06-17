using Opc.Cpx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavBoia.DataControl
{
    public class MPPTStateData
    {
        int battery_status; /*<  Status of the battery,ID=3200.*/
        int charging_equipment_status; /*<  Status of the MPPT,ID=3201.*/

        public int Battery_status { get => battery_status; set => battery_status = value; }
        public int Charging_equipment_status { get => charging_equipment_status; set => charging_equipment_status = value; }

        public MPPTStateData() { }

        public MPPTStateData(MAVLink.mavlink_mppt_state_t mavMpptS)
        {
            this.battery_status = mavMpptS.battery_status;
            this.charging_equipment_status = mavMpptS.charging_equipment_status; 
        }

        public override string ToString()
        {
            return "MPPT_STATE";
        }
    }
}
