using System;

namespace AlarmSystem
{
    public class MotionSensor : ISensorMotion
    {
        private string Location { get; } 
        public bool IsTriggered
        {
            get => DateTime.Now.Hour > 22 && DateTime.Now.Hour < 6; 
            set {  }
            
        }
        public MotionSensor(string location)
        {
            Location = location; 
            IsTriggered = false;
        }

        internal MotionSensor() => IsTriggered = false;


        public string GetLocation()
        {
            return Location ;
        }

        public string GetSensorType() => GetType().Name;
        
    }
}