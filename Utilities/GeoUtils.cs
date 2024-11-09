using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MavBoia.Geography
{
    internal static class GeoUtils
    {
        private const long EarthRadius = 6371;

        private static double Deg2Rad(double angle)
        {
            return angle * (Math.PI / 180);
        }

        public static double HaversineDistance(double latitude1, double longitude1, double latitude2, double longitude2)
        {
            double deltaLat = Deg2Rad(latitude2 - latitude1);
            double deltaLon = Deg2Rad(longitude2 - longitude1);

            double a = Math.Pow(Math.Sin(deltaLat) / 2, 2) + Math.Cos(Deg2Rad(latitude1)) * Math.Cos(Deg2Rad(latitude2)) * Math.Pow(Math.Sin(deltaLon) / 2, 2);

            double distance = 2 * EarthRadius * Math.Asin(Math.Sqrt(a));

            return distance;
        }
    }
}
