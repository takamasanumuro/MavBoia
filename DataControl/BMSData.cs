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
        float[] temperatures = new float[2]; /*< [cdegC] Temperature of the battery*/
        float current_battery; /*< [dA] Battery current*/
        float state_of_charge; /*< [%] Remaining battery energy. Values: [0-100]*/
        float total_voltage;

        public ushort[] Voltages { get => voltages; set => voltages = value; }
        public float[] Temperatures { get => temperatures; set => temperatures = value; }
        public float Current_battery { get => current_battery; set => current_battery = value; }
        public float State_of_charge { get => state_of_charge; set => state_of_charge = value; }
        public float Total_voltage { get => total_voltage; set => total_voltage = value; }

        public BMSData() { }

        public BMSData(MAVLink.mavlink_bms_t mavBms)
        {
            this.Voltages = mavBms.voltages.ToArray();
            for(int i = 0; i < mavBms.temperatures.Length; i++)
            {
                this.temperatures[i] = mavBms.temperatures[i];
            }

            foreach(var v in this.voltages)
            {
                this.Total_voltage += v;
            }
            this.total_voltage /= 1000.0f;

            this.current_battery = mavBms.current_battery / 10.0f;
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
