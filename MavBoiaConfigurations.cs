using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavBoia
{
    internal static class MavBoiaConfigurations
    {
        private static string _serialPort;
        private static int _baudRate;
        private static string rjTextBoxLogDirectory;

        public static string SerialPort { 
            get => _serialPort; 
            set
            {
                _serialPort = value;
                OnSerialConfigurationUpdate?.Invoke();
            }
        }
        public static int BaudRate { 
            get => _baudRate;
            set
            {
                _baudRate = value;
                OnSerialConfigurationUpdate?.Invoke();
            }
        }

        public static string RjTextBoxLogDirectory
        {
            get => rjTextBoxLogDirectory;
            set
            {
                rjTextBoxLogDirectory = value;
            }
        }

        public static Action OnSerialConfigurationUpdate;
    }
}
