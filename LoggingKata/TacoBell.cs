﻿namespace LoggingKata
{
    public class TacoBell : ITrackable
    {
        public string Name { get; set; }
        public Point Location { get; set; }
        public TacoBell(string name, double latitude, double longitude) 
        {
            Name = name;
            Location = new Point(latitude, longitude);
        }
    }
}

