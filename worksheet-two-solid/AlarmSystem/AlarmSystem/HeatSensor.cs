using System;

namespace AlarmSystem
{
    public class HeatSensor : ISensorMotion
    {
        private string Location { get; }

        public HeatSensor(string location)
        {
            Location = location; // change and do a gps lookup
            IsTriggered = false;
        }
        
        public HeatSensor() => IsTriggered = false;

        public bool IsTriggered
        {
            get => new Random().Next(0, 100) < 50;
            set { }
        }

        public string GetLocation()=> Location;

        public string GetSensorType() => GetType().Name;
    }
}