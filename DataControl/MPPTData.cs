using Opc.Cpx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavBoia.DataControl
{
    public class MPPTData
    {
        float pv_voltage; /*< [cV] Solar array voltage,ID=3100*/
        float pv_current; /*< [cA] Solar array current,ID=3101*/
        float battery_voltage; /*< [cV] Battery voltage,ID=3104*/
        float battery_current; /*< [cA] Net battery current(positive=charging),ID=331B*/

        public float Pv_voltage { get => pv_voltage; set => pv_voltage = value; }
        public float Pv_current { get => pv_current; set => pv_current = value; }
        public float Battery_voltage { get => battery_voltage; set => battery_voltage = value; }
        public float Battery_current { get => battery_current; set => battery_current = value; }

        public MPPTData() { }

        public MPPTData(MAVLink.mavlink_mppt_t mavMppt)
        {
            this.pv_current = mavMppt.pv_current / 100.0f;
            this.pv_voltage = mavMppt.pv_voltage / 100.0f;
            this.battery_current= mavMppt.battery_current / 100.0f ;
            this.battery_voltage = mavMppt.battery_voltage / 100.0f;    
        }

        public override string ToString()
        {
            return "MPPT";
        }
    }
}
