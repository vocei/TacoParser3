using System;
using System.Linq;
using System.IO;
using GeoCoordinatePortable;

namespace LoggingKata
{
    class Program
    {
        static readonly ILog logger = new TacoLogger();
        const string csvPath = "TacoBell-US-AL.csv";
        const double MetersToMiles = 0.00062137;

        static void Main(string[] args)
        {
            // Objective: Find the two Taco Bells that are the farthest apart from one another.
            // Some of the TODO's are done for you to get you started. 

            logger.LogInfo("Log initialized");

            // Use File.ReadAllLines(path) to grab all the lines from your csv file. 
            // Optional: Log an error if you get 0 lines and a warning if you get 1 line
            var lines = File.ReadAllLines(csvPath);

            // This will display the first item in your lines array
            logger.LogInfo($"Lines: {lines[0]}");

            // Create a new instance of your TacoParser class
            var parser = new TacoParser();
            ITrackable tacoBell1 = null;
            ITrackable tacoBell2 = null;
            double finalDistance = 0;
            double testDistance = 0;
            var geo1 = new GeoCoordinate();
            var geo2 = new GeoCoordinate();


            // Use the Select LINQ method to parse every line in lines collection
            var locations = lines.Select(parser.Parse).ToArray();

            for (int i = 0; i < locations.Length; i++)
            {
                geo1.Latitude = locations[i].Location.Latitude;
                geo1.Longitude = locations[i].Location.Longitude;

                for (int j = 1; j < locations.Length; j++)
                {
                    geo2.Latitude = locations[j].Location.Latitude;
                    geo2.Longitude = locations[j].Location.Longitude;

                    testDistance = geo1.GetDistanceTo(geo2);

                    if (finalDistance < testDistance)
                    {
                        finalDistance = testDistance;
                        tacoBell1 = locations[i];
                        tacoBell2 = locations[j];

                    }
                }
            }
            Console.WriteLine($"The two furthest {tacoBell1.GetType().Name}'s are {tacoBell1.Name} and {tacoBell2.Name}");
                Console.WriteLine($"The total distance is {Math.Round((finalDistance * MetersToMiles), 2)} miles.");
        }
    }
}

