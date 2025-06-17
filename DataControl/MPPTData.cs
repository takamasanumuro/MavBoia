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
        int pv_voltage; /*< [cV] Solar array voltage,ID=3100*/
        int pv_current; /*< [cV] Solar array current,ID=3101*/
        int battery_voltage; /*< [cV] Battery voltage,ID=3104*/
        int battery_current; /*< [cA] Net battery current(positive=charging),ID=331B*/

        public int Pv_voltage { get => pv_voltage; set => pv_voltage = value; }
        public int Pv_current { get => pv_current; set => pv_current = value; }
        public int Battery_voltage { get => battery_voltage; set => battery_voltage = value; }
        public int Battery_current { get => battery_current; set => battery_current = value; }

        public MPPTData() { }

        public MPPTData(MAVLink.mavlink_mppt_t mavMppt)
        {
            this.pv_current = mavMppt.pv_current;
            this.pv_voltage = mavMppt.pv_voltage;
            this.battery_current= mavMppt.battery_current;
            this.battery_voltage = mavMppt.battery_voltage;    
        }

        public override string ToString()
        {
            return $"Pv Voltage: {pv_voltage}\n" +
                $"Pv_current: {pv_current}\n" +
                $"Battery Current: {battery_current}\n" +
                $"Battery Voltage: {battery_voltage}";
        }
    }
}
