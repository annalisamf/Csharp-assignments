using System;

namespace AlarmSystem
{
    public class SmokeSensor : ISensorHazard
    {
        private string Location { get; }


        public bool IsTriggered
        {
            get => BatteryPercentage > 0 && new Random().Next(0, 100) < 10;
            set { }
        }


        public double BatteryPercentage { get; private set; }


        public SmokeSensor(string location)
        {
            Location = location;
            IsTriggered = false;
            BatteryPercentage = 100;
        }

        internal SmokeSensor()
        {
            IsTriggered = false;
            BatteryPercentage = 100;        }


        public string GetLocation()
        {
            return Location;
        }

        public string GetSensorType() => "Smoke Sensor";

        public double GetBatteryPercentage()
        {
            BatteryPercentage *= .8;
            return Math.Round(BatteryPercentage, 2);
        }
    }
}