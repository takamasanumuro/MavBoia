using System;
using System.Collections.Generic;

namespace MavBoia.DataControl
{
    public enum BMS_STATUS
    {
        CHARGE, DISCHARGE
    }

    public enum FAILURE_FLAGS
    {
        // Byte 0
        CELL_VOLT_HIGH_LEVEL_1,
        CELL_VOLT_HIGH_LEVEL_2,
        CELL_VOLT_LOW_LEVEL_1,
        CELL_VOLT_LOW_LEVEL_2,
        SUM_VOLT_HIGH_LEVEL_1,
        SUM_VOLT_HIGH_LEVEL_2,
        SUM_VOLT_LOW_LEVEL_1,
        SUM_VOLT_LOW_LEVEL_2,

        // Byte 1
        CHG_TEMP_HIGH_LEVEL_1,
        CHG_TEMP_HIGH_LEVEL_2,
        CHG_TEMP_LOW_LEVEL_1,
        CHG_TEMP_LOW_LEVEL_2,
        DISCHG_TEMP_HIGH_LEVEL_1,
        DISCHG_TEMP_HIGH_LEVEL_2,
        DISCHG_TEMP_LOW_LEVEL_1,
        DISCHG_TEMP_LOW_LEVEL_2,

        // Byte 2
        CHG_OVERCURRENT_LEVEL_1,
        CHG_OVERCURRENT_LEVEL_2,
        DISCHG_OVERCURRENT_LEVEL_1,
        DISCHG_OVERCURRENT_LEVEL_2,
        SOC_HIGH_LEVEL_1,
        SOC_HIGH_LEVEL_2,
        SOC_LOW_LEVEL_1,
        SOC_LOW_LEVEL_2,

        // Byte 3
        DIFF_VOLT_LEVEL_1,
        DIFF_VOLT_LEVEL_2,
        DIFF_TEMP_LEVEL_1,
        DIFF_TEMP_LEVEL_2,
        RESERVED_3_4,
        RESERVED_3_5,
        RESERVED_3_6,
        RESERVED_3_7,

        // Byte 4
        CHG_MOS_TEMP_HIGH_ALARM,
        DISCHG_MOS_TEMP_HIGH_ALARM,
        CHG_MOS_TEMP_SENSOR_ERR,
        DISCHG_MOS_TEMP_SENSOR_ERR,
        CHG_MOS_ADHESION_ERR,
        DISCHG_MOS_ADHESION_ERR,
        CHG_MOS_OPEN_CIRCUIT_ERR,
        DISCHG_MOS_OPEN_CIRCUIT_ERR,

        // Byte 5
        AFE_COLLECT_CHIP_ERR,
        VOLTAGE_COLLECT_DROPPED,
        CELL_TEMP_SENSOR_ERR,
        EEPROM_ERR,
        RTC_ERR,
        PRECHARGE_FAILURE,
        COMMUNICATION_FAILURE,
        INTERNAL_COMMUNICATION_FAILURE,

        // Byte 6
        CURRENT_MODULE_FAULT,
        SUM_VOLTAGE_DETECT_FAULT,
        SHORT_CIRCUIT_PROTECT_FAULT,
        LOW_VOLT_FORBIDDEN_CHG_FAULT
    }

    public class BMSStatusData : IBoatData
    {
        // ADICIONAR LISTA DE ERROS E CADA ERRO É UM ENUM

        float[] temperatures = new float[2]; /*< [cdegC] Temperature of the battery*/
        uint status; /*<  Charge/Discharge FET status and current charging status*/
        byte failure_flags_byte0; /*<  Failure flags: Voltage related (Byte 0).*/
        byte failure_flags_byte1; /*<  Failure flags: Temperature related (Byte 1).*/
        byte failure_flags_byte2; /*<  Failure flags: Current and SOC related (Byte 2).*/
        byte failure_flags_byte3; /*<  Failure flags: Differential V/T related (Byte 3).*/
        byte failure_flags_byte4; /*<  Failure flags: MOSFET and sensor related (Byte 4).*/
        byte failure_flags_byte5; /*<  Failure flags: System/Component related (Byte 5).*/
        byte failure_flags_byte6; /*<  Failure flags: Other faults (Byte 6).*/
        byte fault_code_byte7; /*<  Raw fault code (Byte 7 from original message).*/
        List<FAILURE_FLAGS> failureFlags = new List<FAILURE_FLAGS>();
        long timestamp;


        public float[] Temperatures { get => temperatures; set => temperatures = value; }
        public uint Status { get => status; set => status = value; }
        public List<FAILURE_FLAGS> FailureFlags { get => failureFlags; }
        public long Timestamp { get => timestamp; }

        public BMSStatusData() { }
        public BMSStatusData(MAVLink.mavlink_bms_status_t mavBmsStatus)
        {
            for(int i = 0; i < mavBmsStatus.temperatures.Length; i++)
            {
                this.temperatures[i] = mavBmsStatus.temperatures[i] / 100.0f;
            }
            this.status = mavBmsStatus.status;
            this.timestamp = mavBmsStatus.timestamp_seconds * 1000 + mavBmsStatus.timestamp_milliseconds;

            this.failure_flags_byte0 = mavBmsStatus.failure_flags_byte0;
            this.failure_flags_byte1 = mavBmsStatus.failure_flags_byte1;
            this.failure_flags_byte2 = mavBmsStatus.failure_flags_byte2;
            this.failure_flags_byte3 = mavBmsStatus.failure_flags_byte3;
            this.failure_flags_byte4 = mavBmsStatus.failure_flags_byte4;
            this.failure_flags_byte5 = mavBmsStatus.failure_flags_byte5;
            this.failure_flags_byte6 = mavBmsStatus.failure_flags_byte6;
            this.fault_code_byte7 = mavBmsStatus.fault_code_byte7;

            // Byte 0
            for (int i = 0; i < 8; i++)
            {
                if((this.failure_flags_byte0 & (128 >> i)) != 0)
                {
                    FailureFlags.Add((FAILURE_FLAGS)(i + 8 * 0));
                }
            }

            // Byte 1
            for (int i = 0; i < 8; i++)
            {
                if ((this.failure_flags_byte1 & (128 >> i)) != 0)
                {
                    FailureFlags.Add((FAILURE_FLAGS)(i + 8 * 1));
                }
            }

            // Byte 2
            for (int i = 0; i < 8; i++)
            {
                if ((this.failure_flags_byte2 & (128 >> i)) != 0)
                {
                    FailureFlags.Add((FAILURE_FLAGS)(i + 8 * 2));
                }
            }

            // Byte 3
            for (int i = 0; i < 8; i++)
            {
                if ((this.failure_flags_byte3 & (128 >> i)) != 0)
                {
                    FailureFlags.Add((FAILURE_FLAGS)(i + 8 * 3));
                }
            }

            // Byte 4
            for (int i = 0; i < 8; i++)
            {
                if ((this.failure_flags_byte4 & (128 >> i)) != 0)
                {
                    FailureFlags.Add((FAILURE_FLAGS)(i + 8 * 4));
                }
            }

            // Byte 5
            for (int i = 0; i < 8; i++)
            {
                if ((this.failure_flags_byte5 & (128 >> i)) != 0)
                {
                    FailureFlags.Add((FAILURE_FLAGS)(i + 8 * 5));
                }
            }

            // Byte 6
            for (int i = 0; i < 4; i++)
            {
                if ((this.failure_flags_byte6 & (128 >> i)) != 0)
                {
                    FailureFlags.Add((FAILURE_FLAGS)(i + 8 * 6));
                }
            }
        }

        public override string ToString()
        {
            return "BMS_STATUS";
        }
    }
}
