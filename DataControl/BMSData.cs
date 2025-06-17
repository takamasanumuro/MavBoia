using Opc.Cpx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavBoia.DataControl
{
    public class BMSData : IBoatData
    {
        ushort[] voltages; /*< [mV] Voltage of each cell.*/
        short[] temperatures; /*< [cdegC] Temperature of the battery*/
        int current_battery; /*< [dA] Battery current*/
        int state_of_charge; /*< [%] Remaining battery energy. Values: [0-100]*/

        public ushort[] Voltages { get => voltages; set => voltages = value; }
        public short[] Temperatures { get => temperatures; set => temperatures = value; }
        public int Current_battery { get => current_battery; set => current_battery = value; }
        public int State_of_charge { get => state_of_charge; set => state_of_charge = value; }

        public BMSData() { }

        public BMSData(MAVLink.mavlink_bms_t mavBms)
        {
            this.Voltages = mavBms.voltages.ToArray();
            this.temperatures = mavBms.temperatures.ToArray();
            this.current_battery = mavBms.current_battery;
            this.state_of_charge = mavBms.state_of_charge;
        }

        public override string ToString()
        {
            string s = "Voltages: ";
            foreach(var v in this.voltages)
            {
                s += v.ToString() + ", ";
            }
            s += "\nTemperatures: ";
            foreach (var v in this.temperatures)
            {
                s += v.ToString() + ", ";
            }
            s += $"\nBattery Current: {this.current_battery}\n" +
                $"SOC: {this.state_of_charge}";

            return s;
        }
    }
}
