using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MAVLink;

namespace MavBoia
{
    public static class MavlinkUtilities
    {
        public static String GetMessageDataCSV(MAVLink.MAVLinkMessage message)
        {
            return null;
            //switch (message.MsgID)
            //{
            //    case (byte)Mavlink.MAVLINK_MSG_ID.HEARTBEAT:
            //        var heartbeat = (Mavlink.mavlink_heartbeat_t)message.Payload;
            //        return $"HEARTBEAT;{heartbeat.type}";
            //    case (byte)Mavlink.MAVLINK_MSG_ID.ALL_INFO:
            //        var allInfo = (Mavlink.mavlink_all_info_t)message.Payload;
            //        return $"ALL_INFO;{allInfo.battery_voltage};{allInfo.motor_current_left};{allInfo.motor_current_right};{allInfo.mppt_current};{allInfo.temperature_battery_left};{allInfo.temperature_battery_right};{allInfo.temperature_mppt};{allInfo.latitude};{allInfo.longitude};{allInfo.rpm_left};{allInfo.rpm_right}";
            //    default:
            //        return "";
            //}
        }
    }
}
