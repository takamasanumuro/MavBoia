using MavlinkDataController;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MavBoia.InfluxDB
{
    /// <summary>
    /// This class is used to communicate with InfluxDB. Note that you have to dispose this class after use.
    /// </summary>
    internal class InfluxDBCommunication : IDisposable
    {
        private Uri _uri;
        private string _accessToken;
        private HttpClient _httpClient;

        public Uri Uri { 
            get { return _uri; } 
            set 
            {
                this._uri = value;
                this._httpClient.BaseAddress = value;
             } 
        }

        public string AccessToken
        {
            get { return _accessToken; }
            set
            {
                this._accessToken = value;
                this._httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Token", value);
            }
        }

        public InfluxDBCommunication() 
        {
            // The InfluxDB adress
            const string address = "http://localhost:8086";

            // Query data. Using InfluxQL with command:
            // SELECT * FROM Yonah WHERE time > now() - 10s ORDER BY time DESC LIMIT 1
            // This command selects all fields from Yonha measurement from the last 10 seconds, ordering by the newest and getting only the first.
            const string endpoint = "/query?db=Arariboia&q=SELECT%20*%20FROM%20Yonah%20WHERE%20time%20>%20now()%20-%2010s%20ORDER%20BY%20time%20DESC%20LIMIT%201&epoch=s";

            this._uri = new Uri(address + endpoint);

            this._accessToken = "heZy9PrUThd3dxrsKkCh7nSOhVBzxjioa8YlFuSX721xaztA8ZQxgwqyx5D49mHq2Thrj5MJRt2lxsemYSMMCA==";

            this._httpClient = new HttpClient();
            this._httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Token", this._accessToken);
            this._httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/csv"));
        }

        /// <summary>
        /// Get the data from CSV.
        /// </summary>
        /// <param name="csvData"></param>
        /// <returns>A <see cref="DataController.AllSensorData"/> containing all the data from database.</returns>
        private AllSensorData GetAllSensorData(string csvData)
        {
            /* Reference:
             * name,tags,time,battery_voltage,irradiance,latitude,longitude,motor_current_left,motor_current_right,mppt_current,rpm_left,rpm_right,temp_bat_left,temp_bat_right,temp_mppt
Yonah,,1723345517,72.71,79.51,78.399011,50.456619,8.9,9.21,88.39,93.38,76.76,3.06,94.23,91.45
            */

            try
            {
                string[] fields = csvData.Split(',');
                if (fields.Length != 29) return new AllSensorData();

                return new AllSensorData()
                {
                    BatteryVoltage = float.Parse(fields[17], CultureInfo.InvariantCulture),
                    Irradiance = float.Parse(fields[18], CultureInfo.InvariantCulture),
                    Latitude = double.Parse(fields[19], CultureInfo.InvariantCulture),
                    Longitude = double.Parse(fields[20], CultureInfo.InvariantCulture),
                    MotorLeftCurrent = float.Parse(fields[21], CultureInfo.InvariantCulture),
                    MotorRightCurrent = float.Parse(fields[22], CultureInfo.InvariantCulture),
                    MpptCurrent = float.Parse(fields[23], CultureInfo.InvariantCulture),
                    RpmLeft = float.Parse(fields[24], CultureInfo.InvariantCulture),
                    RpmRight = float.Parse(fields[25], CultureInfo.InvariantCulture),
                    TemperatureBatteryLeft = float.Parse(fields[26], CultureInfo.InvariantCulture),
                    TemperatureBatteryRight = float.Parse(fields[27], CultureInfo.InvariantCulture),
                    TemperatureMPPT = float.Parse(fields[28], CultureInfo.InvariantCulture)
                };
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return new AllSensorData();
        }

        /// <summary>
        /// Get the sensor data from the last second.
        /// </summary>
        /// <returns>A <see cref="DataController.AllSensorData"/> containing the data from database.</returns>
        public async Task<AllSensorData> GetAllDataAsync()
        {
            HttpResponseMessage message = await this._httpClient.GetAsync(this._uri);
            string csvString = await message.Content.ReadAsStringAsync();
            return GetAllSensorData(csvString);
        }

        public void Dispose()
        {
            this._httpClient.Dispose();
        }
    }
}
