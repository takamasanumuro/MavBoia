using Opc.Cpx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavBoia.DataControl
{
    enum RADIO_INSTANCE
    {
        PRIMARY,
        SECONDARY
    }
    public class RadioStatusData
    {
        int rxerrors; /*<  Count of radio packet receive errors (since boot).*/
        RADIO_INSTANCE instance; /*<  Radio instance, 0 for primary radio, 1 for secondary radio.*/
        int rssi; /*<  Local (message sender) received signal strength indication in device-dependent units/scale. Values: [0-254], UINT8_MAX: invalid/unknown.*/

        public int Rxerrors { get => rxerrors; set => rxerrors = value; }
        public int Rssi { get => rssi; set => rssi = value; }
        internal RADIO_INSTANCE Instance { get => instance; set => instance = value; }

        public RadioStatusData() { }

        public RadioStatusData(MAVLink.mavlink_radio_status_t mavRadio)
        {
            this.rssi= mavRadio.rssi;
            this.rxerrors = mavRadio.rxerrors;
            if(mavRadio.instance == 0) this.instance = RADIO_INSTANCE.PRIMARY;
            else if(mavRadio.instance == 1) this.instance = RADIO_INSTANCE.SECONDARY;
        }

        public override string ToString()
        {
            return "RADIO_STATUS";
        }
    }
}
