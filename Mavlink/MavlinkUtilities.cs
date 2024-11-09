using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mavlink;

namespace MavBoia
{
    public static class MavlinkUtilities
    {
        public static void PrintMessageInfo(Mavlink.MavlinkMessage message)
        {
            switch (message.MsgID)
            {
                case (byte)Mavlink.MAVLINK_MSG_ID.HEARTBEAT:
                    var heartbeat = (Mavlink.mavlink_heartbeat_t)message.Payload;
                    Console.WriteLine($"HEARTBEAT: {heartbeat.type}");
                    break;

                case (byte)Mavlink.MAVLINK_MSG_ID.ALL_INFO:
                    var allInfo = (Mavlink.mavlink_all_info_t)message.Payload;

                    Console.WriteLine($"Battery Voltage: {allInfo.battery_voltage}");
                    Console.WriteLine($"Motor Current Left: {allInfo.motor_current_left}");
                    Console.WriteLine($"Motor Current Right: {allInfo.motor_current_right}");
                    Console.WriteLine($"MPPT current: {allInfo.mppt_current}");
                    Console.WriteLine($"Temperature Battery Left Side: {allInfo.temperature_battery_left}");
                    Console.WriteLine($"Temperature Battery Right Side: {allInfo.temperature_battery_right}");
                    Console.WriteLine($"Temperature MPPT: {allInfo.temperature_mppt}");
                    Console.WriteLine($"Latitude: {allInfo.latitude}");
                    Console.WriteLine($"Longitude: {allInfo.longitude}");
                    Console.WriteLine($"RPM left: {allInfo.rpm_left}");
                    Console.WriteLine($"RPM right: {allInfo.rpm_right}");
                    break;
            }
        }

        public static String GetMessageDataCSV(Mavlink.MavlinkMessage message)
        {
            switch (message.MsgID)
            {
                case (byte)Mavlink.MAVLINK_MSG_ID.HEARTBEAT:
                    var heartbeat = (Mavlink.mavlink_heartbeat_t)message.Payload;
                    return $"HEARTBEAT;{heartbeat.type}";
                case (byte)Mavlink.MAVLINK_MSG_ID.ALL_INFO:
                    var allInfo = (Mavlink.mavlink_all_info_t)message.Payload;
                    return $"ALL_INFO;{allInfo.battery_voltage};{allInfo.motor_current_left};{allInfo.motor_current_right};{allInfo.mppt_current};{allInfo.temperature_battery_left};{allInfo.temperature_battery_right};{allInfo.temperature_mppt};{allInfo.latitude};{allInfo.longitude};{allInfo.rpm_left};{allInfo.rpm_right}";
                default:
                    return "";
            }
        }
    }
}
