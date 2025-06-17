using Opc.Cpx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavBoia.DataControl
{
    public class BMSStatusData
    {
        short[] temperatures; /*< [cdegC] Temperature of the battery*/
        uint status; /*<  Charge/Discharge FET status and current charging status*/
        uint failure_flags_byte0; /*<  Failure flags: Voltage related (Byte 0).*/
        uint failure_flags_byte1; /*<  Failure flags: Temperature related (Byte 1).*/
        uint failure_flags_byte2; /*<  Failure flags: Current and SOC related (Byte 2).*/
        uint failure_flags_byte3; /*<  Failure flags: Differential V/T related (Byte 3).*/
        uint failure_flags_byte4; /*<  Failure flags: MOSFET and sensor related (Byte 4).*/
        uint failure_flags_byte5; /*<  Failure flags: System/Component related (Byte 5).*/
        uint failure_flags_byte6; /*<  Failure flags: Other faults (Byte 6).*/
        uint fault_code_byte7; /*<  Raw fault code (Byte 7 from original message).*/

        public short[] Temperatures { get => temperatures; set => temperatures = value; }
        public uint Status { get => status; set => status = value; }
        public uint Failure_flags_byte0 { get => failure_flags_byte0; set => failure_flags_byte0 = value; }
        public uint Failure_flags_byte1 { get => failure_flags_byte1; set => failure_flags_byte1 = value; }
        public uint Failure_flags_byte2 { get => failure_flags_byte2; set => failure_flags_byte2 = value; }
        public uint Failure_flags_byte3 { get => failure_flags_byte3; set => failure_flags_byte3 = value; }
        public uint Failure_flags_byte4 { get => failure_flags_byte4; set => failure_flags_byte4 = value; }
        public uint Failure_flags_byte5 { get => failure_flags_byte5; set => failure_flags_byte5 = value; }
        public uint Failure_flags_byte6 { get => failure_flags_byte6; set => failure_flags_byte6 = value; }
        public uint Fault_code_byte7 { get => fault_code_byte7; set => fault_code_byte7 = value; }

        public BMSStatusData() { }
        public BMSStatusData(MAVLink.mavlink_bms_status_t mavBmsStatus)
        {
            this.temperatures = mavBmsStatus.temperatures.ToArray();
            this.status = mavBmsStatus.status;
            this.failure_flags_byte0 = mavBmsStatus.failure_flags_byte0;
            this.failure_flags_byte1 = mavBmsStatus.failure_flags_byte1;
            this.failure_flags_byte2 = mavBmsStatus.failure_flags_byte2;
            this.failure_flags_byte3 = mavBmsStatus.failure_flags_byte3;
            this.failure_flags_byte4 = mavBmsStatus.failure_flags_byte4;
            this.failure_flags_byte5 = mavBmsStatus.failure_flags_byte5;
            this.failure_flags_byte6 = mavBmsStatus.failure_flags_byte6;
            this.fault_code_byte7 = mavBmsStatus.fault_code_byte7;
        }

        public override string ToString()
        {
            return "BMS_STATUS";
        }
    }
}
