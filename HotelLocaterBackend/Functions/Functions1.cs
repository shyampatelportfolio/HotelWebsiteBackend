using HotelsBackend.Controllers;
using HotelsBackend.Data;
using System;

namespace HotelsBackend.Functions
{
    public class Functions1
    {
        public static Coordinates CalculateRandomCoordinates(Coordinates coordinates, int distance)
        {
            int randomLeft = CalculateRandom(distance);
            int randomRight = CalculateRandom(distance);
            double newLatitude = CalculateNewCoordinatesNorth(coordinates.lat, coordinates.lon, randomLeft);
            double newLongitude = CalculateNewCoordinatesEast(coordinates.lat, coordinates.lon, randomRight);
            Coordinates result = new Coordinates();
            result.lat = newLatitude;
            result.lon = newLongitude;
            return result;
        }
        public static int CalculateHotelNumber(int Population)
        {
            int temp = 0;
            if (Population > 10000000) { temp = 50; };
            if (Population > 1000000 && Population < 10000000)
            {
                double temp2 = (Population - 1000000) / 300000;
                int temp3 = (int)Math.Floor(temp2);
                temp3 += 15;
                temp = temp3;
            }
            if (Population < 1000000) { temp = 15; };
            int randomNumberFinal = CalculateRandom(5);
            int result = temp + randomNumberFinal;
            return result;
        }
        public static int CalculateRandom(int n)
        {
            Random random = new Random();
            double randomNumber = random.NextDouble();
            randomNumber += -0.5;
            int randomNumberFinal = (int)Math.Floor(randomNumber * 2 * n);
            return randomNumberFinal;
        }
        public static int CalculateRandomPositive(int n)
        {
            Random random = new Random();
            double randomNumber = random.NextDouble();
            int randomNumberFinal = (int)Math.Floor(randomNumber * n);
            return randomNumberFinal;
        }
        public static double CalculateRandomFraction(int n)
        {
            int rand1 = CalculateRandomPositive(10);
            double rand1dec = ((double)rand1) / 10;
            double rand2 = (double) CalculateRandomPositive(n);
            return (rand2 + rand1dec);
        }
        public static double CalculateRandomRating()
        {
            int rand1 = CalculateRandomPositive(10);
            double rand1dec = ((double)rand1) / 10;
            double rand2 = (double)CalculateRandomPositive(2);
            double range = (rand2 + rand1dec);
            double resultTemp = 3.1 + range;
            double result = Math.Round(resultTemp, 1);
            return result;
        }
        public static double CalculateRandomFractionPoint5()
        {
            int rand1 = CalculateRandomPositive(6);
            double rand1dec = ((double)rand1) / 10;
            return rand1dec;
        }
        public static double CalculateRandomFractionPointn(int n)
        {
            int rand1 = CalculateRandomPositive(n + 1);
            double rand1dec = ((double)rand1) / 10;
            return rand1dec;
        }
        public static double[] CalculateRandomRatings(double Rating, int Number)
        {
            double[] results = new double[Number];
            double start = 0;
            int n = 5;
            if( Number > 4.5)
            {
                double dif = 5 - Rating;
                double dif2 = dif * 10;
                int tempn = (int)Math.Ceiling(dif2);
                n = tempn;
            }
            for(int i = 0; i < Number; i++)
            {

                double temp = CalculateRandomFractionPointn(n);
                if( start > 0)
                {
                    temp = -temp;
                }
                if ( i == Number - 1)
                {
                    temp = -start;
                }
                double roundedResult = Math.Round(temp, 1);
                results[i] = roundedResult;
                start += roundedResult;
            }
            for (int i = 0; i < results.Length; i++)
            {
                results[i] += Rating;
                results[i] = Math.Round(results[i], 1);
            }
            return results;
        }
        public static double[] CalculateRandomPrices(double Price, int Number)
        {
            double[] results = new double[Number];
            double start = 0;
            
            for (int i = 0; i < Number; i++)
            {

                double temp = CalculateRandom(40);
                if (start > 0)
                {
                    temp = -temp;
                }
                if (i == Number - 1)
                {
                    temp = -start;
                }
                double roundedResult = Math.Round(temp, 1);
                Console.WriteLine(roundedResult);
                results[i] = roundedResult;
                start += roundedResult;
            }
            for (int i = 0; i < results.Length; i++)
            {
                results[i] += Price;
                results[i] = Math.Round(results[i], 1);
            }
            return results;
        }
        public static List<int> CalculateRandomRooms(int maxRoom, int Number)
        {
            List<int> results = new List<int>();

            for (int i = 0; i < Number; i++)
            {
                int roomTemp = CalculateRandomPositive(maxRoom);
                while (results.Contains(roomTemp))
                {
                    roomTemp = CalculateRandomPositive(maxRoom);
                }
                results.Add(roomTemp);
            }
            return results;
        }



        public static string CalculateRandomDate()
        {
            int day = CalculateRandomPositive(28) + 1;
            int month = CalculateRandomPositive(12) + 1;
            int year = CalculateRandomPositive(4) + 2019;
            string day1 = day.ToString();
            string month1 = month.ToString();
            if( day < 10)
            {
                day1 = "0" + day;

            }
            if( month < 10 )
            {
                month1 = "0" + month;
            }
            string result = day1 + "/" + month1 + "/" + year.ToString();
            return result;

        }
        public static bool CalculateRandomBool()
        {
            int rand1 = CalculateRandomPositive(2);
            if(rand1 == 0) return true; else return false;
        }
        public static double CalculateNewCoordinatesNorth(double latitude, double longitude, double distance)
        {
            double earthRadius = 6371;

            double distanceRadians = distance / earthRadius;

            double latitudeRad = ToRadians(latitude);
            double longitudeRad = ToRadians(longitude);

            double newLatitude = ToDegrees(latitudeRad + (distanceRadians));

            double newLongitude = longitude;

            return newLatitude;
        }
        public static double CalculateNewCoordinatesEast(double latitude, double longitude, double distance)
        {
            double earthRadius = 6371;

            double distanceRadians = distance / earthRadius;

            double latitudeRad = ToRadians(latitude);
            double longitudeRad = ToRadians(longitude);

            double newLatitude = latitude;

            double newLongitude = ToDegrees(longitudeRad + (distanceRadians / Math.Cos(latitudeRad)));

            return newLongitude;
        }

        public static double ToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }

        public static double ToDegrees(double radians)
        {
            return radians * 180 / Math.PI;
        }
        private static double DegreeToRadian(double degree)
        {
            return degree * Math.PI / 180.0;
        }
        public static double CalculateDistance(Coordinates coordinates, Coordinates coordinates2)
        {
            double lat1 = coordinates.lat;
            double lon1 = coordinates.lon;
            double lat2 = coordinates2.lat;
            double lon2 = coordinates2.lon;
            const double EarthRadiusInKm = 6371.0;
            var dLat = DegreeToRadian(lat2 - lat1);
            var dLon = DegreeToRadian(lon2 - lon1);

            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                    Math.Cos(DegreeToRadian(lat1)) * Math.Cos(DegreeToRadian(lat2)) *
                    Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            var distance = EarthRadiusInKm * c;

            return distance;
        }


        public static List<string> CalculateRandomStringImages(int total, int scope)
        {
            List<string> images = new List<string>();
            for( int i = 0; i < scope; i ++ )
            {
                int j = CalculateRandomPositive(total + 1);
                string res = "Image" + j;
                while( images.Contains(res))
                {
                    j = CalculateRandomPositive(total + 1);
                    res = "Image" + j;
                }
                images.Add(res);

            }
            return images;
        }

    }
}
