using CapyKit.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CapyKit.Helpers
{
    /// <summary> Static class providing helper methods for various calculations. </summary>
    public static class CalculationHelper
    {
        #region Members

        /// <summary> The earth's radius in kilometers. </summary>
        public const int EARTH_RADIUS_KILOMETERS = 6371;

        /// <summary> Ratio of miles per kilometer . </summary>
        public const double MILES_PER_KILOMETER = 0.621371;

        /// <summary> The valid hexidecimal characters. </summary>
        private const string chars = "0123456789ABCDEF";

        #endregion Members

        #region Methods

        /// <summary>
        /// Calculates the hash of a given string using an <see cref="MD5"/> value as the first 32 bits.
        /// </summary>
        /// <param name="str"> The string to be hashed. </param>
        /// <returns> The calculated hash. </returns>
        /// <remarks>
        /// This method is used for a quick and consistent hash function. It should not be considered
        /// cryptographically sound or used in security contexts.
        /// </remarks>
        public static int CalculateHash(string str)
        {
            MD5 md5Hasher = MD5.Create();
            var md5Hash = md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(str));
            var hash = BitConverter.ToInt32(md5Hash, 0);

            return hash;
        }

        /// <summary> Calculates the hexadecimal hash. </summary>
        /// <param name="str"> The string to be hashed. </param>
        /// <returns> The calculated 16 character hexadecimal hash. </returns>
        public static string CalculateHexHash(string str)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(str);

            MD5 md5Hasher = MD5.Create();
            byte[] hash = md5Hasher.ComputeHash(bytes);

            char[] hash2 = new char[16];

            // Note that here we are wasting bits of hash!
            // But it isn't really important, because hash.Length == 32
            for (int i = 0; i < hash2.Length; i++)
            {
                hash2[i] = CalculationHelper.chars[hash[i] % CalculationHelper.chars.Length];
            }

            return new string(hash2);
        }

        /// <summary>
        /// Gets the distance between two points on earth using the <c>haversine</c> formula.
        /// </summary>
        /// <param name="latitudeOrigin">       The latitude origin. </param>
        /// <param name="longitudeOrigin">      The longitude origin. </param>
        /// <param name="latitudeDestination">  The latitude destination. </param>
        /// <param name="longitudeDestination"> The longitude destination. </param>
        /// <param name="measurementSystem">    (Optional) The measurement system. </param>
        /// <returns> The distance. </returns>
        /// <remarks>
        /// Uses the <a href="https://www.movable-type.co.uk/scripts/latlong.html">haversine</a> formula
        /// to calculate the "as-the-crow-flies" distance between two points on earth.
        /// </remarks>
        /// <seealso cref="GetDistance(double, double, double, double, MeasurementSystem)"/>
        public static decimal GetDistance(decimal latitudeOrigin, decimal longitudeOrigin, decimal latitudeDestination, decimal longitudeDestination, MeasurementSystem measurementSystem = MeasurementSystem.Imperial)
        {
            double latitudeOriginalDouble = Convert.ToDouble(latitudeOrigin);
            double longitudeOriginDouble = Convert.ToDouble(longitudeOrigin);
            double latitudeDestinationDouble = Convert.ToDouble(latitudeDestination);
            double longitudeDestinationDouble = Convert.ToDouble(longitudeDestination);

            var result = GetDistance(latitudeOriginalDouble, longitudeOriginDouble, latitudeDestinationDouble, longitudeDestinationDouble, measurementSystem);

            return Convert.ToDecimal(result);
        }

        /// <summary> Gets the distance between two points on earth using the <c>haversine</c> formula. </summary>
        /// <param name="latitudeOrigin">       The latitude of the origin. </param>
        /// <param name="longitudeOrigin">      The longitude of the origin. </param>
        /// <param name="latitudeDestination">  The latitude destination. </param>
        /// <param name="longitudeDestination"> The longitude destination. </param>
        /// <param name="measurementSystem">    (Optional) The measurement system. </param>
        /// <returns> The distance. </returns>
        /// <remarks>
        /// Uses the <a href="https://www.movable-type.co.uk/scripts/latlong.html">haversine</a> formula
        /// to calculate the "as-the-crow-flies" distance between two points on earth.
        /// </remarks>
        public static double GetDistance(double latitudeOrigin, double longitudeOrigin, double latitudeDestination, double longitudeDestination, MeasurementSystem measurementSystem = MeasurementSystem.Imperial)
        {
            var thetaLatitude = DegreesToRadians(latitudeOrigin);
            var thetaLongitude = DegreesToRadians(longitudeOrigin);
            var deltaLatitude = DegreesToRadians(latitudeDestination - latitudeOrigin);
            var deltaLongitude = DegreesToRadians(longitudeDestination - longitudeOrigin);

            var haversineTheta = Math.Sin(deltaLatitude / 2) * Math.Sin(deltaLatitude / 2) + Math.Cos(thetaLatitude) * Math.Cos(thetaLongitude) * Math.Sin(deltaLongitude / 2) * Math.Sin(deltaLongitude / 2);
            var angularDistance = 2 * Math.Atan2(Math.Sqrt(haversineTheta), Math.Sqrt(1 - haversineTheta));

            var distance = EARTH_RADIUS_KILOMETERS * angularDistance;

            if (measurementSystem == MeasurementSystem.Imperial)
            {
                return KilometersToMiles(distance);
            }

            return distance;
        }

        /// <summary> Converts kilometers to miles. </summary>
        /// <param name="kilometers"> The value in kilometers. </param>
        /// <returns> The value in miles. </returns>
        public static double KilometersToMiles(double kilometers)
        {
            return kilometers * MILES_PER_KILOMETER;
        }

        /// <summary> Converts miles to kilometers. </summary>
        /// <param name="miles"> The value in miles. </param>
        /// <returns> The value in kilometers. </returns>
        public static double MilesToKilometers(double miles)
        {
            return miles / MILES_PER_KILOMETER;
        }

        /// <summary> Convers degrees to radians. </summary>
        /// <param name="degrees"> The degree value. </param>
        /// <returns> The value as radians. </returns>
        public static double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }

        /// <summary> Converts radians to degrees. </summary>
        /// <param name="radians"> The radian value. </param>
        /// <returns> The value as degrees. </returns>
        public static double RadiansToDegrees(double radians)
        {
            return radians * 180.0 / Math.PI;
        }

        #endregion Methods
    }
}
