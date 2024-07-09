using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using static Mavlink;

public partial class Mavlink
{
    public const string MAVLINK_BUILD_DATE = "Mon Jul 08 2024";
    public const string MAVLINK_WIRE_PROTOCOL_VERSION = "1.0";
    public const int MAVLINK_MAX_PAYLOAD_LEN = 48;

    public const byte MAVLINK1_CORE_HEADER_LEN = 5; // Length of MAVLink1 core header (of the comm. layer)
    public const byte MAVLINK_CORE_HEADER_LEN = 9;///< Length of core header (of the comm. layer)
    public const byte MAVLINK_CORE_HEADER_MAVLINK1_LEN = 5;///< Length of MAVLink1 core header (of the comm. layer)
    public const byte MAVLINK_NUM_HEADER_BYTES = (MAVLINK_CORE_HEADER_LEN + 1);///< Length of all header bytes, including core and stx
    public const byte MAVLINK_NUM_CHECKSUM_BYTES = 2;
    public const byte MAVLINK_NUM_NON_PAYLOAD_BYTES = (MAVLINK_NUM_HEADER_BYTES + MAVLINK_NUM_CHECKSUM_BYTES);

    public const byte MAVLINK2_CORE_HEADER_LEN = 9; // Length of core header (of the comm. layer)
    public const byte MAVLINK2_NUM_HEADER_BYTES = (MAVLINK2_CORE_HEADER_LEN + 1); // Length of all header bytes, including core and stx
    public const byte MAVLINK2_NUM_NON_PAYLOAD_BYTES = (MAVLINK2_NUM_HEADER_BYTES + MAVLINK_NUM_CHECKSUM_BYTES);

    public const int MAVLINK2_MAX_PACKET_LEN = (MAVLINK_MAX_PAYLOAD_LEN + MAVLINK2_NUM_NON_PAYLOAD_BYTES + MAVLINK2_SIGNATURE_BLOCK_LEN);///< Maximum packet length  
    public const byte MAVLINK2_SIGNATURE_BLOCK_LEN = 13;

    public const int MAVLINK_MAX_PACKET_LEN = (MAVLINK_MAX_PAYLOAD_LEN + MAVLINK_NUM_NON_PAYLOAD_BYTES + MAVLINK_SIGNATURE_BLOCK_LEN);///< Maximum packet length
    public const byte MAVLINK_SIGNATURE_BLOCK_LEN = 13;

    public const int MAVLINK_LITTLE_ENDIAN = 1;
    public const int MAVLINK_BIG_ENDIAN = 0;

    public const byte MAVLINK2_STX = 0xFD;

    public const byte MAVLINK1_STX = 0xFE;

    public const byte MAVLINK_ENDIAN = MAVLINK_LITTLE_ENDIAN;

    public const bool MAVLINK_ALIGNED_FIELDS = (1 == 1);

    public const byte MAVLINK_CRC_EXTRA = 1;

    public const byte MAVLINK_COMMAND_24BIT = 0;

    public const bool MAVLINK_NEED_BYTE_SWAP = (MAVLINK_ENDIAN == MAVLINK_LITTLE_ENDIAN);

    // msgid, name, crc, minlength, length, type
    public static MessageInfo[] MavlinkMessageInfoTable = new MessageInfo[] {
        new MessageInfo(0, "HEARTBEAT", 50, 9, 9, typeof( mavlink_heartbeat_t )), // none 24 bit
        new MessageInfo(171, "INSTRUMENTATION", 132, 20, 20, typeof( mavlink_instrumentation_t )), // none 24 bit
        new MessageInfo(172, "TEMPERATURES", 65, 16, 16, typeof( mavlink_temperatures_t )), // none 24 bit
        new MessageInfo(173, "GPS_INFO", 14, 21, 21, typeof( mavlink_gps_info_t )), // none 24 bit
        new MessageInfo(174, "RPM_INFO", 185, 12, 12, typeof( mavlink_rpm_info_t )), // none 24 bit
        new MessageInfo(175, "ALL_INFO", 192, 48, 48, typeof( mavlink_all_info_t )), // none 24 bit

    };

    public const byte MAVLINK_VERSION = 3;

    public const byte MAVLINK_IFLAG_SIGNED = 0x01;
    public const byte MAVLINK_IFLAG_MASK = 0x01;

    public struct MessageInfo
    {
        public uint MsgID { get; internal set; }
        public string Name { get; internal set; }
        public byte Crc { get; internal set; }
        public uint MinLength { get; internal set; }
        public uint Length { get; internal set; }
        public Type Type { get; internal set; }

        public MessageInfo(uint msgid, string name, byte crc, uint minlength, uint length, Type type)
        {
            this.MsgID = msgid;
            this.Name = name;
            this.Crc = crc;
            this.MinLength = minlength;
            this.Length = length;
            this.Type = type;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}", Name, MsgID);
        }
    }

    public enum MAVLINK_MSG_ID
    {

        HEARTBEAT = 0,
        INSTRUMENTATION = 171,
        TEMPERATURES = 172,
        GPS_INFO = 173,
        RPM_INFO = 174,
        ALL_INFO = 175,
    }


    ///<summary> Micro air vehicle / autopilot classes. This identifies the individual model. </summary>
    public enum MAV_AUTOPILOT : byte
    {
        ///<summary> Generic autopilot, full support for everything | </summary>
        [Description("Generic autopilot, full support for everything")]
        GENERIC = 0,
        ///<summary> Reserved for future use. | </summary>
        [Description("Reserved for future use.")]
        RESERVED = 1,
        ///<summary> SLUGS autopilot, http://slugsuav.soe.ucsc.edu | </summary>
        [Description("SLUGS autopilot, http://slugsuav.soe.ucsc.edu")]
        SLUGS = 2,
        ///<summary> ArduPilot - Plane/Copter/Rover/Sub/Tracker, https://ardupilot.org | </summary>
        [Description("ArduPilot - Plane/Copter/Rover/Sub/Tracker, https://ardupilot.org")]
        ARDUPILOTMEGA = 3,
        ///<summary> OpenPilot, http://openpilot.org | </summary>
        [Description("OpenPilot, http://openpilot.org")]
        OPENPILOT = 4,
        ///<summary> Generic autopilot only supporting simple waypoints | </summary>
        [Description("Generic autopilot only supporting simple waypoints")]
        GENERIC_WAYPOINTS_ONLY = 5,
        ///<summary> Generic autopilot supporting waypoints and other simple navigation commands | </summary>
        [Description("Generic autopilot supporting waypoints and other simple navigation commands")]
        GENERIC_WAYPOINTS_AND_SIMPLE_NAVIGATION_ONLY = 6,
        ///<summary> Generic autopilot supporting the full mission command set | </summary>
        [Description("Generic autopilot supporting the full mission command set")]
        GENERIC_MISSION_FULL = 7,
        ///<summary> No valid autopilot, e.g. a GCS or other MAVLink component | </summary>
        [Description("No valid autopilot, e.g. a GCS or other MAVLink component")]
        INVALID = 8,
        ///<summary> PPZ UAV - http://nongnu.org/paparazzi | </summary>
        [Description("PPZ UAV - http://nongnu.org/paparazzi")]
        PPZ = 9,
        ///<summary> UAV Dev Board | </summary>
        [Description("UAV Dev Board")]
        UDB = 10,
        ///<summary> FlexiPilot | </summary>
        [Description("FlexiPilot")]
        FP = 11,
        ///<summary> PX4 Autopilot - http://px4.io/ | </summary>
        [Description("PX4 Autopilot - http://px4.io/")]
        PX4 = 12,
        ///<summary> SMACCMPilot - http://smaccmpilot.org | </summary>
        [Description("SMACCMPilot - http://smaccmpilot.org")]
        SMACCMPILOT = 13,
        ///<summary> AutoQuad -- http://autoquad.org | </summary>
        [Description("AutoQuad -- http://autoquad.org")]
        AUTOQUAD = 14,
        ///<summary> Armazila -- http://armazila.com | </summary>
        [Description("Armazila -- http://armazila.com")]
        ARMAZILA = 15,
        ///<summary> Aerob -- http://aerob.ru | </summary>
        [Description("Aerob -- http://aerob.ru")]
        AEROB = 16,
        ///<summary> ASLUAV autopilot -- http://www.asl.ethz.ch | </summary>
        [Description("ASLUAV autopilot -- http://www.asl.ethz.ch")]
        ASLUAV = 17,
        ///<summary> SmartAP Autopilot - http://sky-drones.com | </summary>
        [Description("SmartAP Autopilot - http://sky-drones.com")]
        SMARTAP = 18,
        ///<summary> AirRails - http://uaventure.com | </summary>
        [Description("AirRails - http://uaventure.com")]
        AIRRAILS = 19,
        ///<summary> Fusion Reflex - https://fusion.engineering | </summary>
        [Description("Fusion Reflex - https://fusion.engineering")]
        REFLEX = 20,

    };

    ///<summary> MAVLINK component type reported in HEARTBEAT message. Flight controllers must report the type of the vehicle on which they are mounted (e.g. MAV_TYPE_OCTOROTOR). All other components must report a value appropriate for their type (e.g. a camera must use MAV_TYPE_CAMERA). </summary>
    public enum MAV_TYPE : byte
    {
        ///<summary> Generic micro air vehicle | </summary>
        [Description("Generic micro air vehicle")]
        GENERIC = 0,
        ///<summary> Fixed wing aircraft. | </summary>
        [Description("Fixed wing aircraft.")]
        FIXED_WING = 1,
        ///<summary> Quadrotor | </summary>
        [Description("Quadrotor")]
        QUADROTOR = 2,
        ///<summary> Coaxial helicopter | </summary>
        [Description("Coaxial helicopter")]
        COAXIAL = 3,
        ///<summary> Normal helicopter with tail rotor. | </summary>
        [Description("Normal helicopter with tail rotor.")]
        HELICOPTER = 4,
        ///<summary> Ground installation | </summary>
        [Description("Ground installation")]
        ANTENNA_TRACKER = 5,
        ///<summary> Operator control unit / ground control station | </summary>
        [Description("Operator control unit / ground control station")]
        GCS = 6,
        ///<summary> Airship, controlled | </summary>
        [Description("Airship, controlled")]
        AIRSHIP = 7,
        ///<summary> Free balloon, uncontrolled | </summary>
        [Description("Free balloon, uncontrolled")]
        FREE_BALLOON = 8,
        ///<summary> Rocket | </summary>
        [Description("Rocket")]
        ROCKET = 9,
        ///<summary> Ground rover | </summary>
        [Description("Ground rover")]
        GROUND_ROVER = 10,
        ///<summary> Surface vessel, boat, ship | </summary>
        [Description("Surface vessel, boat, ship")]
        SURFACE_BOAT = 11,
        ///<summary> Submarine | </summary>
        [Description("Submarine")]
        SUBMARINE = 12,
        ///<summary> Hexarotor | </summary>
        [Description("Hexarotor")]
        HEXAROTOR = 13,
        ///<summary> Octorotor | </summary>
        [Description("Octorotor")]
        OCTOROTOR = 14,
        ///<summary> Tricopter | </summary>
        [Description("Tricopter")]
        TRICOPTER = 15,
        ///<summary> Flapping wing | </summary>
        [Description("Flapping wing")]
        FLAPPING_WING = 16,
        ///<summary> Kite | </summary>
        [Description("Kite")]
        KITE = 17,
        ///<summary> Onboard companion controller | </summary>
        [Description("Onboard companion controller")]
        ONBOARD_CONTROLLER = 18,
        ///<summary> Two-rotor Tailsitter VTOL that additionally uses control surfaces in vertical operation. Note, value previously named MAV_TYPE_VTOL_DUOROTOR. | </summary>
        [Description("Two-rotor Tailsitter VTOL that additionally uses control surfaces in vertical operation. Note, value previously named MAV_TYPE_VTOL_DUOROTOR.")]
        VTOL_TAILSITTER_DUOROTOR = 19,
        ///<summary> Quad-rotor Tailsitter VTOL using a V-shaped quad config in vertical operation. Note: value previously named MAV_TYPE_VTOL_QUADROTOR. | </summary>
        [Description("Quad-rotor Tailsitter VTOL using a V-shaped quad config in vertical operation. Note: value previously named MAV_TYPE_VTOL_QUADROTOR.")]
        VTOL_TAILSITTER_QUADROTOR = 20,
        ///<summary> Tiltrotor VTOL. Fuselage and wings stay (nominally) horizontal in all flight phases. It able to tilt (some) rotors to provide thrust in cruise flight. | </summary>
        [Description("Tiltrotor VTOL. Fuselage and wings stay (nominally) horizontal in all flight phases. It able to tilt (some) rotors to provide thrust in cruise flight.")]
        VTOL_TILTROTOR = 21,
        ///<summary> VTOL with separate fixed rotors for hover and cruise flight. Fuselage and wings stay (nominally) horizontal in all flight phases. | </summary>
        [Description("VTOL with separate fixed rotors for hover and cruise flight. Fuselage and wings stay (nominally) horizontal in all flight phases.")]
        VTOL_FIXEDROTOR = 22,
        ///<summary> Tailsitter VTOL. Fuselage and wings orientation changes depending on flight phase: vertical for hover, horizontal for cruise. Use more specific VTOL MAV_TYPE_VTOL_DUOROTOR or MAV_TYPE_VTOL_QUADROTOR if appropriate. | </summary>
        [Description("Tailsitter VTOL. Fuselage and wings orientation changes depending on flight phase: vertical for hover, horizontal for cruise. Use more specific VTOL MAV_TYPE_VTOL_DUOROTOR or MAV_TYPE_VTOL_QUADROTOR if appropriate.")]
        VTOL_TAILSITTER = 23,
        ///<summary> Tiltwing VTOL. Fuselage stays horizontal in all flight phases. The whole wing, along with any attached engine, can tilt between vertical and horizontal mode. | </summary>
        [Description("Tiltwing VTOL. Fuselage stays horizontal in all flight phases. The whole wing, along with any attached engine, can tilt between vertical and horizontal mode.")]
        VTOL_TILTWING = 24,
        ///<summary> VTOL reserved 5 | </summary>
        [Description("VTOL reserved 5")]
        VTOL_RESERVED5 = 25,
        ///<summary> Gimbal | </summary>
        [Description("Gimbal")]
        GIMBAL = 26,
        ///<summary> ADSB system | </summary>
        [Description("ADSB system")]
        ADSB = 27,
        ///<summary> Steerable, nonrigid airfoil | </summary>
        [Description("Steerable, nonrigid airfoil")]
        PARAFOIL = 28,
        ///<summary> Dodecarotor | </summary>
        [Description("Dodecarotor")]
        DODECAROTOR = 29,
        ///<summary> Camera | </summary>
        [Description("Camera")]
        CAMERA = 30,
        ///<summary> Charging station | </summary>
        [Description("Charging station")]
        CHARGING_STATION = 31,
        ///<summary> FLARM collision avoidance system | </summary>
        [Description("FLARM collision avoidance system")]
        FLARM = 32,
        ///<summary> Servo | </summary>
        [Description("Servo")]
        SERVO = 33,
        ///<summary> Open Drone ID. See https://mavlink.io/en/services/opendroneid.html. | </summary>
        [Description("Open Drone ID. See https://mavlink.io/en/services/opendroneid.html.")]
        ODID = 34,
        ///<summary> Decarotor | </summary>
        [Description("Decarotor")]
        DECAROTOR = 35,
        ///<summary> Battery | </summary>
        [Description("Battery")]
        BATTERY = 36,
        ///<summary> Parachute | </summary>
        [Description("Parachute")]
        PARACHUTE = 37,
        ///<summary> Log | </summary>
        [Description("Log")]
        LOG = 38,
        ///<summary> OSD | </summary>
        [Description("OSD")]
        OSD = 39,
        ///<summary> IMU | </summary>
        [Description("IMU")]
        IMU = 40,
        ///<summary> GPS | </summary>
        [Description("GPS")]
        GPS = 41,
        ///<summary> Winch | </summary>
        [Description("Winch")]
        WINCH = 42,

    };

    ///<summary> These flags encode the MAV mode. </summary>
    public enum MAV_MODE_FLAG : byte
    {
        ///<summary> 0b00000001 Reserved for future use. | </summary>
        [Description("0b00000001 Reserved for future use.")]
        CUSTOM_MODE_ENABLED = 1,
        ///<summary> 0b00000010 system has a test mode enabled. This flag is intended for temporary system tests and should not be used for stable implementations. | </summary>
        [Description("0b00000010 system has a test mode enabled. This flag is intended for temporary system tests and should not be used for stable implementations.")]
        TEST_ENABLED = 2,
        ///<summary> 0b00000100 autonomous mode enabled, system finds its own goal positions. Guided flag can be set or not, depends on the actual implementation. | </summary>
        [Description("0b00000100 autonomous mode enabled, system finds its own goal positions. Guided flag can be set or not, depends on the actual implementation.")]
        AUTO_ENABLED = 4,
        ///<summary> 0b00001000 guided mode enabled, system flies waypoints / mission items. | </summary>
        [Description("0b00001000 guided mode enabled, system flies waypoints / mission items.")]
        GUIDED_ENABLED = 8,
        ///<summary> 0b00010000 system stabilizes electronically its attitude (and optionally position). It needs however further control inputs to move around. | </summary>
        [Description("0b00010000 system stabilizes electronically its attitude (and optionally position). It needs however further control inputs to move around.")]
        STABILIZE_ENABLED = 16,
        ///<summary> 0b00100000 hardware in the loop simulation. All motors / actuators are blocked, but internal software is full operational. | </summary>
        [Description("0b00100000 hardware in the loop simulation. All motors / actuators are blocked, but internal software is full operational.")]
        HIL_ENABLED = 32,
        ///<summary> 0b01000000 remote control input is enabled. | </summary>
        [Description("0b01000000 remote control input is enabled.")]
        MANUAL_INPUT_ENABLED = 64,
        ///<summary> 0b10000000 MAV safety set to armed. Motors are enabled / running / can start. Ready to fly. Additional note: this flag is to be ignore when sent in the command MAV_CMD_DO_SET_MODE and MAV_CMD_COMPONENT_ARM_DISARM shall be used instead. The flag can still be used to report the armed state. | </summary>
        [Description("0b10000000 MAV safety set to armed. Motors are enabled / running / can start. Ready to fly. Additional note: this flag is to be ignore when sent in the command MAV_CMD_DO_SET_MODE and MAV_CMD_COMPONENT_ARM_DISARM shall be used instead. The flag can still be used to report the armed state.")]
        SAFETY_ARMED = 128,

    };

    ///<summary> These values encode the bit positions of the decode position. These values can be used to read the value of a flag bit by combining the base_mode variable with AND with the flag position value. The result will be either 0 or 1, depending on if the flag is set or not. </summary>
    public enum MAV_MODE_FLAG_DECODE_POSITION : int /*default*/
    {
        ///<summary> Eighth bit: 00000001 | </summary>
        [Description("Eighth bit: 00000001")]
        CUSTOM_MODE = 1,
        ///<summary> Seventh bit: 00000010 | </summary>
        [Description("Seventh bit: 00000010")]
        TEST = 2,
        ///<summary> Sixth bit:   00000100 | </summary>
        [Description("Sixth bit:   00000100")]
        AUTO = 4,
        ///<summary> Fifth bit:  00001000 | </summary>
        [Description("Fifth bit:  00001000")]
        GUIDED = 8,
        ///<summary> Fourth bit: 00010000 | </summary>
        [Description("Fourth bit: 00010000")]
        STABILIZE = 16,
        ///<summary> Third bit:  00100000 | </summary>
        [Description("Third bit:  00100000")]
        HIL = 32,
        ///<summary> Second bit: 01000000 | </summary>
        [Description("Second bit: 01000000")]
        MANUAL = 64,
        ///<summary> First bit:  10000000 | </summary>
        [Description("First bit:  10000000")]
        SAFETY = 128,

    };

    ///<summary>  </summary>
    public enum MAV_STATE : byte
    {
        ///<summary> Uninitialized system, state is unknown. | </summary>
        [Description("Uninitialized system, state is unknown.")]
        UNINIT = 0,
        ///<summary> System is booting up. | </summary>
        [Description("System is booting up.")]
        BOOT = 1,
        ///<summary> System is calibrating and not flight-ready. | </summary>
        [Description("System is calibrating and not flight-ready.")]
        CALIBRATING = 2,
        ///<summary> System is grounded and on standby. It can be launched any time. | </summary>
        [Description("System is grounded and on standby. It can be launched any time.")]
        STANDBY = 3,
        ///<summary> System is active and might be already airborne. Motors are engaged. | </summary>
        [Description("System is active and might be already airborne. Motors are engaged.")]
        ACTIVE = 4,
        ///<summary> System is in a non-normal flight mode. It can however still navigate. | </summary>
        [Description("System is in a non-normal flight mode. It can however still navigate.")]
        CRITICAL = 5,
        ///<summary> System is in a non-normal flight mode. It lost control over parts or over the whole airframe. It is in mayday and going down. | </summary>
        [Description("System is in a non-normal flight mode. It lost control over parts or over the whole airframe. It is in mayday and going down.")]
        EMERGENCY = 6,
        ///<summary> System just initialized its power-down sequence, will shut down now. | </summary>
        [Description("System just initialized its power-down sequence, will shut down now.")]
        POWEROFF = 7,
        ///<summary> System is terminating itself. | </summary>
        [Description("System is terminating itself.")]
        FLIGHT_TERMINATION = 8,

    };

    ///<summary> Component ids (values) for the different types and instances of onboard hardware/software that might make up a MAVLink system (autopilot, cameras, servos, GPS systems, avoidance systems etc.).       Components must use the appropriate ID in their source address when sending messages. Components can also use IDs to determine if they are the intended recipient of an incoming message. The MAV_COMP_ID_ALL value is used to indicate messages that must be processed by all components.       When creating new entries, components that can have multiple instances (e.g. cameras, servos etc.) should be allocated sequential values. An appropriate number of values should be left free after these components to allow the number of instances to be expanded. </summary>
    public enum MAV_COMPONENT : int /*default*/
    {
        ///<summary> Target id (target_component) used to broadcast messages to all components of the receiving system. Components should attempt to process messages with this component ID and forward to components on any other interfaces. Note: This is not a valid *source* component id for a message. | </summary>
        [Description("Target id (target_component) used to broadcast messages to all components of the receiving system. Components should attempt to process messages with this component ID and forward to components on any other interfaces. Note: This is not a valid *source* component id for a message.")]
        MAV_COMP_ID_ALL = 0,
        ///<summary> System flight controller component ('autopilot'). Only one autopilot is expected in a particular system. | </summary>
        [Description("System flight controller component ('autopilot'). Only one autopilot is expected in a particular system.")]
        MAV_COMP_ID_AUTOPILOT1 = 1,
        ///<summary> SEMTECH SX1276 LoRa Radio | </summary>
        [Description("SEMTECH SX1276 LoRa Radio")]
        MAV_COMP_ID_LORA_RADIO = 25,
        ///<summary> NEO-6M GPS module. | </summary>
        [Description("NEO-6M GPS module.")]
        MAV_COMP_ID_GPS_MODULE = 26,
        ///<summary> Instrumentation board. | </summary>
        [Description("Instrumentation board.")]
        MAV_COMP_ID_INSTRUMENTATION = 27,
        ///<summary> Digital to analog converter + operational amplifier. | </summary>
        [Description("Digital to analog converter + operational amplifier.")]
        MAV_COMP_ID_DAC = 28,
        ///<summary> Battery management system. | </summary>
        [Description("Battery management system.")]
        MAV_COMP_ID_BMS = 29,
        ///<summary> DS18B20 temperature probes. | </summary>
        [Description("DS18B20 temperature probes.")]
        MAV_COMP_ID_DALLAS = 30,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER7 = 31,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER8 = 32,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER9 = 33,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER10 = 34,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER11 = 35,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER12 = 36,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER13 = 37,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER14 = 38,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER15 = 39,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER16 = 40,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER17 = 41,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER18 = 42,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER19 = 43,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER20 = 44,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER21 = 45,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER22 = 46,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER23 = 47,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER24 = 48,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER25 = 49,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER26 = 50,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER27 = 51,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER28 = 52,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER29 = 53,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER30 = 54,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER31 = 55,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER32 = 56,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER33 = 57,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER34 = 58,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER35 = 59,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER36 = 60,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER37 = 61,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER38 = 62,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER39 = 63,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER40 = 64,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER41 = 65,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER42 = 66,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER43 = 67,
        ///<summary> Telemetry radio (e.g. SiK radio, or other component that emits RADIO_STATUS messages). | </summary>
        [Description("Telemetry radio (e.g. SiK radio, or other component that emits RADIO_STATUS messages).")]
        MAV_COMP_ID_TELEMETRY_RADIO = 68,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER45 = 69,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER46 = 70,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER47 = 71,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER48 = 72,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER49 = 73,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER50 = 74,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER51 = 75,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER52 = 76,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER53 = 77,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER54 = 78,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER55 = 79,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER56 = 80,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER57 = 81,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER58 = 82,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER59 = 83,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER60 = 84,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER61 = 85,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER62 = 86,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER63 = 87,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER64 = 88,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER65 = 89,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER66 = 90,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER67 = 91,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER68 = 92,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER69 = 93,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER70 = 94,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER71 = 95,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER72 = 96,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER73 = 97,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER74 = 98,
        ///<summary> Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network. | </summary>
        [Description("Id for a component on privately managed MAVLink network. Can be used for any purpose but may not be published by components outside of the private network.")]
        MAV_COMP_ID_USER75 = 99,
        ///<summary> Camera #1. | </summary>
        [Description("Camera #1.")]
        MAV_COMP_ID_CAMERA = 100,
        ///<summary> Camera #2. | </summary>
        [Description("Camera #2.")]
        MAV_COMP_ID_CAMERA2 = 101,
        ///<summary> Camera #3. | </summary>
        [Description("Camera #3.")]
        MAV_COMP_ID_CAMERA3 = 102,
        ///<summary> Camera #4. | </summary>
        [Description("Camera #4.")]
        MAV_COMP_ID_CAMERA4 = 103,
        ///<summary> Camera #5. | </summary>
        [Description("Camera #5.")]
        MAV_COMP_ID_CAMERA5 = 104,
        ///<summary> Camera #6. | </summary>
        [Description("Camera #6.")]
        MAV_COMP_ID_CAMERA6 = 105,
        ///<summary> Servo #1. | </summary>
        [Description("Servo #1.")]
        MAV_COMP_ID_SERVO1 = 140,
        ///<summary> Servo #2. | </summary>
        [Description("Servo #2.")]
        MAV_COMP_ID_SERVO2 = 141,
        ///<summary> Servo #3. | </summary>
        [Description("Servo #3.")]
        MAV_COMP_ID_SERVO3 = 142,
        ///<summary> Servo #4. | </summary>
        [Description("Servo #4.")]
        MAV_COMP_ID_SERVO4 = 143,
        ///<summary> Servo #5. | </summary>
        [Description("Servo #5.")]
        MAV_COMP_ID_SERVO5 = 144,
        ///<summary> Servo #6. | </summary>
        [Description("Servo #6.")]
        MAV_COMP_ID_SERVO6 = 145,
        ///<summary> Servo #7. | </summary>
        [Description("Servo #7.")]
        MAV_COMP_ID_SERVO7 = 146,
        ///<summary> Servo #8. | </summary>
        [Description("Servo #8.")]
        MAV_COMP_ID_SERVO8 = 147,
        ///<summary> Servo #9. | </summary>
        [Description("Servo #9.")]
        MAV_COMP_ID_SERVO9 = 148,
        ///<summary> Servo #10. | </summary>
        [Description("Servo #10.")]
        MAV_COMP_ID_SERVO10 = 149,
        ///<summary> Servo #11. | </summary>
        [Description("Servo #11.")]
        MAV_COMP_ID_SERVO11 = 150,
        ///<summary> Servo #12. | </summary>
        [Description("Servo #12.")]
        MAV_COMP_ID_SERVO12 = 151,
        ///<summary> Servo #13. | </summary>
        [Description("Servo #13.")]
        MAV_COMP_ID_SERVO13 = 152,
        ///<summary> Servo #14. | </summary>
        [Description("Servo #14.")]
        MAV_COMP_ID_SERVO14 = 153,
        ///<summary> Gimbal #1. | </summary>
        [Description("Gimbal #1.")]
        MAV_COMP_ID_GIMBAL = 154,
        ///<summary> Logging component. | </summary>
        [Description("Logging component.")]
        MAV_COMP_ID_LOG = 155,
        ///<summary> Automatic Dependent Surveillance-Broadcast (ADS-B) component. | </summary>
        [Description("Automatic Dependent Surveillance-Broadcast (ADS-B) component.")]
        MAV_COMP_ID_ADSB = 156,
        ///<summary> On Screen Display (OSD) devices for video links. | </summary>
        [Description("On Screen Display (OSD) devices for video links.")]
        MAV_COMP_ID_OSD = 157,
        ///<summary> Generic autopilot peripheral component ID. Meant for devices that do not implement the parameter microservice. | </summary>
        [Description("Generic autopilot peripheral component ID. Meant for devices that do not implement the parameter microservice.")]
        MAV_COMP_ID_PERIPHERAL = 158,
        ///<summary> Gimbal ID for QX1. | </summary>
        [Description("Gimbal ID for QX1.")]
        MAV_COMP_ID_QX1_GIMBAL = 159,
        ///<summary> FLARM collision alert component. | </summary>
        [Description("FLARM collision alert component.")]
        MAV_COMP_ID_FLARM = 160,
        ///<summary> Parachute component. | </summary>
        [Description("Parachute component.")]
        MAV_COMP_ID_PARACHUTE = 161,
        ///<summary> Winch component. | </summary>
        [Description("Winch component.")]
        MAV_COMP_ID_WINCH = 169,
        ///<summary> Gimbal #2. | </summary>
        [Description("Gimbal #2.")]
        MAV_COMP_ID_GIMBAL2 = 171,
        ///<summary> Gimbal #3. | </summary>
        [Description("Gimbal #3.")]
        MAV_COMP_ID_GIMBAL3 = 172,
        ///<summary> Gimbal #4 | </summary>
        [Description("Gimbal #4")]
        MAV_COMP_ID_GIMBAL4 = 173,
        ///<summary> Gimbal #5. | </summary>
        [Description("Gimbal #5.")]
        MAV_COMP_ID_GIMBAL5 = 174,
        ///<summary> Gimbal #6. | </summary>
        [Description("Gimbal #6.")]
        MAV_COMP_ID_GIMBAL6 = 175,
        ///<summary> Battery #1. | </summary>
        [Description("Battery #1.")]
        MAV_COMP_ID_BATTERY = 180,
        ///<summary> Battery #2. | </summary>
        [Description("Battery #2.")]
        MAV_COMP_ID_BATTERY2 = 181,
        ///<summary> CAN over MAVLink client. | </summary>
        [Description("CAN over MAVLink client.")]
        MAV_COMP_ID_MAVCAN = 189,
        ///<summary> Component that can generate/supply a mission flight plan (e.g. GCS or developer API). | </summary>
        [Description("Component that can generate/supply a mission flight plan (e.g. GCS or developer API).")]
        MAV_COMP_ID_MISSIONPLANNER = 190,
        ///<summary> Component that lives on the onboard computer (companion computer) and has some generic functionalities, such as settings system parameters and monitoring the status of some processes that don't directly speak mavlink and so on. | </summary>
        [Description("Component that lives on the onboard computer (companion computer) and has some generic functionalities, such as settings system parameters and monitoring the status of some processes that don't directly speak mavlink and so on.")]
        MAV_COMP_ID_ONBOARD_COMPUTER = 191,
        ///<summary> Component that lives on the onboard computer (companion computer) and has some generic functionalities, such as settings system parameters and monitoring the status of some processes that don't directly speak mavlink and so on. | </summary>
        [Description("Component that lives on the onboard computer (companion computer) and has some generic functionalities, such as settings system parameters and monitoring the status of some processes that don't directly speak mavlink and so on.")]
        MAV_COMP_ID_ONBOARD_COMPUTER2 = 192,
        ///<summary> Component that lives on the onboard computer (companion computer) and has some generic functionalities, such as settings system parameters and monitoring the status of some processes that don't directly speak mavlink and so on. | </summary>
        [Description("Component that lives on the onboard computer (companion computer) and has some generic functionalities, such as settings system parameters and monitoring the status of some processes that don't directly speak mavlink and so on.")]
        MAV_COMP_ID_ONBOARD_COMPUTER3 = 193,
        ///<summary> Component that lives on the onboard computer (companion computer) and has some generic functionalities, such as settings system parameters and monitoring the status of some processes that don't directly speak mavlink and so on. | </summary>
        [Description("Component that lives on the onboard computer (companion computer) and has some generic functionalities, such as settings system parameters and monitoring the status of some processes that don't directly speak mavlink and so on.")]
        MAV_COMP_ID_ONBOARD_COMPUTER4 = 194,
        ///<summary> Component that finds an optimal path between points based on a certain constraint (e.g. minimum snap, shortest path, cost, etc.). | </summary>
        [Description("Component that finds an optimal path between points based on a certain constraint (e.g. minimum snap, shortest path, cost, etc.).")]
        MAV_COMP_ID_PATHPLANNER = 195,
        ///<summary> Component that plans a collision free path between two points. | </summary>
        [Description("Component that plans a collision free path between two points.")]
        MAV_COMP_ID_OBSTACLE_AVOIDANCE = 196,
        ///<summary> Component that provides position estimates using VIO techniques. | </summary>
        [Description("Component that provides position estimates using VIO techniques.")]
        MAV_COMP_ID_VISUAL_INERTIAL_ODOMETRY = 197,
        ///<summary> Component that manages pairing of vehicle and GCS. | </summary>
        [Description("Component that manages pairing of vehicle and GCS.")]
        MAV_COMP_ID_PAIRING_MANAGER = 198,
        ///<summary> Inertial Measurement Unit (IMU) #1. | </summary>
        [Description("Inertial Measurement Unit (IMU) #1.")]
        MAV_COMP_ID_IMU = 200,
        ///<summary> Inertial Measurement Unit (IMU) #2. | </summary>
        [Description("Inertial Measurement Unit (IMU) #2.")]
        MAV_COMP_ID_IMU_2 = 201,
        ///<summary> Inertial Measurement Unit (IMU) #3. | </summary>
        [Description("Inertial Measurement Unit (IMU) #3.")]
        MAV_COMP_ID_IMU_3 = 202,
        ///<summary> GPS #1. | </summary>
        [Description("GPS #1.")]
        MAV_COMP_ID_GPS = 220,
        ///<summary> GPS #2. | </summary>
        [Description("GPS #2.")]
        MAV_COMP_ID_GPS2 = 221,
        ///<summary> Open Drone ID transmitter/receiver (Bluetooth/WiFi/Internet). | </summary>
        [Description("Open Drone ID transmitter/receiver (Bluetooth/WiFi/Internet).")]
        MAV_COMP_ID_ODID_TXRX_1 = 236,
        ///<summary> Open Drone ID transmitter/receiver (Bluetooth/WiFi/Internet). | </summary>
        [Description("Open Drone ID transmitter/receiver (Bluetooth/WiFi/Internet).")]
        MAV_COMP_ID_ODID_TXRX_2 = 237,
        ///<summary> Open Drone ID transmitter/receiver (Bluetooth/WiFi/Internet). | </summary>
        [Description("Open Drone ID transmitter/receiver (Bluetooth/WiFi/Internet).")]
        MAV_COMP_ID_ODID_TXRX_3 = 238,
        ///<summary> Component to bridge MAVLink to UDP (i.e. from a UART). | </summary>
        [Description("Component to bridge MAVLink to UDP (i.e. from a UART).")]
        MAV_COMP_ID_UDP_BRIDGE = 240,
        ///<summary> Component to bridge to UART (i.e. from UDP). | </summary>
        [Description("Component to bridge to UART (i.e. from UDP).")]
        MAV_COMP_ID_UART_BRIDGE = 241,
        ///<summary> Component handling TUNNEL messages (e.g. vendor specific GUI of a component). | </summary>
        [Description("Component handling TUNNEL messages (e.g. vendor specific GUI of a component).")]
        MAV_COMP_ID_TUNNEL_NODE = 242,
        ///<summary> Deprecated, don't use. Component for handling system messages (e.g. to ARM, takeoff, etc.). | </summary>
        [Description("Deprecated, don't use. Component for handling system messages (e.g. to ARM, takeoff, etc.).")]
        MAV_COMP_ID_SYSTEM_CONTROL = 250,

    };


    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 9)]
    ///<summary> The heartbeat message shows that a system or component is present and responding. The type and autopilot fields (along with the message component id), allow the receiving system to treat further messages from this system appropriately (e.g. by laying out the user interface based on the autopilot). This microservice is documented at https://mavlink.io/en/services/heartbeat.html </summary>
    public struct mavlink_heartbeat_t
    {
        public mavlink_heartbeat_t(uint custom_mode,/*MAV_TYPE*/byte type,/*MAV_AUTOPILOT*/byte autopilot,/*MAV_MODE_FLAG*/byte base_mode,/*MAV_STATE*/byte system_status, byte mavlink_version)
        {
            this.custom_mode = custom_mode;
            this.type = type;
            this.autopilot = autopilot;
            this.base_mode = base_mode;
            this.system_status = system_status;
            this.mavlink_version = mavlink_version;

        }
        /// <summary>A bitfield for use for autopilot-specific flags   </summary>
        [Units("")]
        [Description("A bitfield for use for autopilot-specific flags")]
        public uint custom_mode;
        /// <summary>Vehicle or component type. For a flight controller component the vehicle type (quadrotor, helicopter, etc.). For other components the component type (e.g. camera, gimbal, etc.). This should be used in preference to component id for identifying the component type. MAV_TYPE  </summary>
        [Units("")]
        [Description("Vehicle or component type. For a flight controller component the vehicle type (quadrotor, helicopter, etc.). For other components the component type (e.g. camera, gimbal, etc.). This should be used in preference to component id for identifying the component type.")]
        public  /*MAV_TYPE*/byte type;
        /// <summary>Autopilot type / class. Use MAV_AUTOPILOT_INVALID for components that are not flight controllers. MAV_AUTOPILOT  </summary>
        [Units("")]
        [Description("Autopilot type / class. Use MAV_AUTOPILOT_INVALID for components that are not flight controllers.")]
        public  /*MAV_AUTOPILOT*/byte autopilot;
        /// <summary>System mode bitmap. MAV_MODE_FLAG  bitmask</summary>
        [Units("")]
        [Description("System mode bitmap.")]
        public  /*MAV_MODE_FLAG*/byte base_mode;
        /// <summary>System status flag. MAV_STATE  </summary>
        [Units("")]
        [Description("System status flag.")]
        public  /*MAV_STATE*/byte system_status;
        /// <summary>MAVLink version, not writable by user, gets added by protocol because of magic data type: uint8_t_mavlink_version   </summary>
        [Units("")]
        [Description("MAVLink version, not writable by user, gets added by protocol because of magic data type: uint8_t_mavlink_version")]
        public byte mavlink_version;

    };


    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 20)]
    ///<summary>  Instrumentation data for 3 current sensors and 1 voltage sensor. </summary>
    public struct mavlink_instrumentation_t
    {
        public mavlink_instrumentation_t(float battery_voltage, float motor_current_left, float motor_current_right, float mppt_current, uint timestamp)
        {
            this.battery_voltage = battery_voltage;
            this.motor_current_left = motor_current_left;
            this.motor_current_right = motor_current_right;
            this.mppt_current = mppt_current;
            this.timestamp = timestamp;

        }
        /// <summary>.  [V] </summary>
        [Units("[V]")]
        [Description(".")]
        public float battery_voltage;
        /// <summary>  [A] </summary>
        [Units("[A]")]
        [Description("")]
        public float motor_current_left;
        /// <summary>  [A] </summary>
        [Units("[A]")]
        [Description("")]
        public float motor_current_right;
        /// <summary>  [A] </summary>
        [Units("[A]")]
        [Description("")]
        public float mppt_current;
        /// <summary>Timestamp.   </summary>
        [Units("")]
        [Description("Timestamp.")]
        public uint timestamp;

    };


    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
    ///<summary>  Temperature data for motor and MPPT. </summary>
    public struct mavlink_temperatures_t
    {
        public mavlink_temperatures_t(float temperature_battery_left, float temperature_battery_right, float temperature_mppt, uint timestamp)
        {
            this.temperature_battery_left = temperature_battery_left;
            this.temperature_battery_right = temperature_battery_right;
            this.temperature_mppt = temperature_mppt;
            this.timestamp = timestamp;

        }
        /// <summary>Left side of battery pack  [degC] </summary>
        [Units("[degC]")]
        [Description("Left side of battery pack")]
        public float temperature_battery_left;
        /// <summary>Right side of battery pack  [degC] </summary>
        [Units("[degC]")]
        [Description("Right side of battery pack")]
        public float temperature_battery_right;
        /// <summary>MPPT temperature.  [degC] </summary>
        [Units("[degC]")]
        [Description("MPPT temperature.")]
        public float temperature_mppt;
        /// <summary>Timestamp.   </summary>
        [Units("")]
        [Description("Timestamp.")]
        public uint timestamp;

    };


    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 21)]
    ///<summary>  GPS data from NEO-6M module.  </summary>
    public struct mavlink_gps_info_t
    {
        public mavlink_gps_info_t(float latitude, float longitude, float speed, float course, uint timestamp, byte satellites_visible)
        {
            this.latitude = latitude;
            this.longitude = longitude;
            this.speed = speed;
            this.course = course;
            this.timestamp = timestamp;
            this.satellites_visible = satellites_visible;

        }
        /// <summary>Latitude info. Sixth decimal digit represents 11cm resolution   </summary>
        [Units("")]
        [Description("Latitude info. Sixth decimal digit represents 11cm resolution")]
        public float latitude;
        /// <summary>Longitude info. Sixth decimal digit represents 11cm resolution   </summary>
        [Units("")]
        [Description("Longitude info. Sixth decimal digit represents 11cm resolution")]
        public float longitude;
        /// <summary>Speed  [km/h] </summary>
        [Units("[km/h]")]
        [Description("Speed")]
        public float speed;
        /// <summary>Course  [deg] </summary>
        [Units("[deg]")]
        [Description("Course")]
        public float course;
        /// <summary>Timestamp.   </summary>
        [Units("")]
        [Description("Timestamp.")]
        public uint timestamp;
        /// <summary>Number of visible satellites   </summary>
        [Units("")]
        [Description("Number of visible satellites")]
        public byte satellites_visible;

    };


    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 12)]
    ///<summary>  RPM data from motors  </summary>
    public struct mavlink_rpm_info_t
    {
        public mavlink_rpm_info_t(float rpm_left, float rpm_right, uint timestamp)
        {
            this.rpm_left = rpm_left;
            this.rpm_right = rpm_right;
            this.timestamp = timestamp;

        }
        /// <summary>RPM value for left motor   </summary>
        [Units("")]
        [Description("RPM value for left motor")]
        public float rpm_left;
        /// <summary>RPM value for right motor   </summary>
        [Units("")]
        [Description("RPM value for right motor")]
        public float rpm_right;
        /// <summary>Timestamp.   </summary>
        [Units("")]
        [Description("Timestamp.")]
        public uint timestamp;

    };


    /// extensions_start 0
    [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 48)]
    ///<summary>  All information from the system  </summary>
    public struct mavlink_all_info_t
    {
        public mavlink_all_info_t(float battery_voltage, float motor_current_left, float motor_current_right, float mppt_current, float temperature_battery_left, float temperature_battery_right, float temperature_mppt, float latitude, float longitude, float rpm_left, float rpm_right, uint timestamp)
        {
            this.battery_voltage = battery_voltage;
            this.motor_current_left = motor_current_left;
            this.motor_current_right = motor_current_right;
            this.mppt_current = mppt_current;
            this.temperature_battery_left = temperature_battery_left;
            this.temperature_battery_right = temperature_battery_right;
            this.temperature_mppt = temperature_mppt;
            this.latitude = latitude;
            this.longitude = longitude;
            this.rpm_left = rpm_left;
            this.rpm_right = rpm_right;
            this.timestamp = timestamp;

        }
        /// <summary>.  [V] </summary>
        [Units("[V]")]
        [Description(".")]
        public float battery_voltage;
        /// <summary>  [A] </summary>
        [Units("[A]")]
        [Description("")]
        public float motor_current_left;
        /// <summary>  [A] </summary>
        [Units("[A]")]
        [Description("")]
        public float motor_current_right;
        /// <summary>  [A] </summary>
        [Units("[A]")]
        [Description("")]
        public float mppt_current;
        /// <summary>Left side of battery pack  [degC] </summary>
        [Units("[degC]")]
        [Description("Left side of battery pack")]
        public float temperature_battery_left;
        /// <summary>Right side of battery pack  [degC] </summary>
        [Units("[degC]")]
        [Description("Right side of battery pack")]
        public float temperature_battery_right;
        /// <summary>MPPT temperature.  [degC] </summary>
        [Units("[degC]")]
        [Description("MPPT temperature.")]
        public float temperature_mppt;
        /// <summary>Latitude info. Sixth decimal digit represents 11cm resolution   </summary>
        [Units("")]
        [Description("Latitude info. Sixth decimal digit represents 11cm resolution")]
        public float latitude;
        /// <summary>Longitude info. Sixth decimal digit represents 11cm resolution   </summary>
        [Units("")]
        [Description("Longitude info. Sixth decimal digit represents 11cm resolution")]
        public float longitude;
        /// <summary>RPM value for left motor   </summary>
        [Units("")]
        [Description("RPM value for left motor")]
        public float rpm_left;
        /// <summary>RPM value for right motor   </summary>
        [Units("")]
        [Description("RPM value for right motor")]
        public float rpm_right;
        /// <summary>Timestamp.   </summary>
        [Units("")]
        [Description("Timestamp.")]
        public uint timestamp;

    };

}
