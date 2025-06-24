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
        private static string rjTextBoxInfluxAdress;
        private static string rjTextBoxInfluxToken;
        private static string rjTextBoxApolloTracker;

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

        public static string RjTextBoxInfluxAdress
        {
            get => rjTextBoxInfluxAdress;
            set
            {
                rjTextBoxInfluxAdress = value;
                OnInfluxConfigurationUpdate?.Invoke();
            }
        }

        public static string RjTextBoxInfluxToken
        {
            get => rjTextBoxInfluxToken;
            set
            {
                rjTextBoxInfluxToken = value;
                OnInfluxConfigurationUpdate?.Invoke();
            }
        }

        public static string RjTextBoxApolloTracker
        {
            get => rjTextBoxApolloTracker;
            set
            {
                rjTextBoxApolloTracker = value;
            }
        }

        public static Action OnSerialConfigurationUpdate;
        public static Action OnInfluxConfigurationUpdate;
    }
}
