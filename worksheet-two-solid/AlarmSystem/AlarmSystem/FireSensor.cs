using System;
using System.Runtime.CompilerServices;

namespace AlarmSystem
{
    public class FireSensor : ISensorHazard
    {
        public bool IsTriggered
        {
            get => BatteryPercentage > 0 && new Random().Next(0, 100) < 5;
            set {  }
        }

        private string Location { get; }
        
        public double BatteryPercentage { get; private set; }
        
        public FireSensor()
        {
            IsTriggered = false;
            BatteryPercentage = 100;
        }

        public FireSensor(string location)
        {
            Location = location; 
            IsTriggered = false;
            BatteryPercentage = 100;

        }

        public string GetLocation()
        {
            return Location;

        }

        public string GetSensorType() => "Fire sensor";
       

        public double GetBatteryPercentage()
        {
            BatteryPercentage *= .90;
            return Math.Round(BatteryPercentage,2);
            
        }

        public override string ToString()
        {
            return "Fire Sensor";
        }
    }
}