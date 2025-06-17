using Opc.Cpx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavBoia.DataControl
{
    public class TemperatureData
    {
        int temperature_battery_left; /*< [cdegC] Left side of battery pack*/
        int temperature_battery_right; /*< [cdegC] Right side of battery pack*/
        int temperature_mppt_left; /*< [cdegC] MPPT temperature on its left side.*/
        int temperature_mppt_right; /*< [cdegC] MPPT temperature on its left side.*/

        public int TemperatureBatteryLeft { get => temperature_battery_left; set => temperature_battery_left = value; }
        public int TemperatureBatteryRight { get => temperature_battery_right; set => temperature_battery_right = value; }
        public int TemperatureMpptLeft { get => temperature_mppt_left; set => temperature_mppt_left = value; }
        public int TemperatureMpptRight { get => temperature_mppt_right; set => temperature_mppt_right = value; }

        public TemperatureData() { }

        public TemperatureData(MAVLink.mavlink_temperatures_t mavTemp)
        {
            this.temperature_battery_left = mavTemp.temperature_battery_left;
            this.temperature_battery_right = mavTemp.temperature_battery_right;
            this.temperature_mppt_left = mavTemp.temperature_mppt_left;
            this.temperature_mppt_right = mavTemp.temperature_mppt_right;
        }

        public override string ToString()
        {
            return "TEMPERATURES";
        }
    }
}
