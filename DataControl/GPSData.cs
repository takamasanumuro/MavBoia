using Opc.Cpx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavBoia.DataControl
{
    public class GPSData : IBoatData
    {
        private double latitude; /*< [degE7] */
        private double longitude; /*< [degE7] */
        private float speed; /*< [cm/s] */
        private int course; /*< [deg] Direction of movement(not heading)*/
        private int heading; /*< [deg] Direction of the bow (source not from GPS, but from IMU)*/
        private int satellites_visible; /*<  */
        private float hdop; /*<  Horizontal dilution of precision. Represents quality of GPS constellation. Values close to 1 are best. Above 5 is poor*/

        public double Latitude { get => latitude; set => latitude = value; }
        public double Longitude { get => longitude; set => longitude = value; }
        public float Speed { get => speed; set => speed = value; }
        public int Course { get => course; set => course = value; }
        public int Heading { get => heading; set => heading = value; }
        public int Satellites_visible { get => satellites_visible; set => satellites_visible = value; }
        public float Hdop { get => hdop; set => hdop = value; }

        public GPSData() { }
        public GPSData(MAVLink.mavlink_gps_t mavGps)
        {
            this.Latitude = mavGps.latitude / 1e7;
            this.Longitude = mavGps.longitude / 1e7;
            this.Course = mavGps.course;
            this.Hdop = mavGps.hdop;
            this.Satellites_visible = mavGps.satellites_visible;
            this.Speed = mavGps.speed * (3600.0f / 100000.0f);
        }

        public override string ToString()
        {
            return $"Latitude: {latitude}\n" +
                $"Longitude: {longitude}\n" +
                $"Speed: {speed}\n" +
                $"Course: {course}\n" +
                $"Hdop: {hdop}\n" +
                $"Satellites: {satellites_visible}";
        }
    }
}
