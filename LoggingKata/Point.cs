namespace LoggingKata
{
    public struct Point
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Point(double lat, double lon)
        {
            Latitude = lat;
            Longitude = lon;
        }
    }
}
