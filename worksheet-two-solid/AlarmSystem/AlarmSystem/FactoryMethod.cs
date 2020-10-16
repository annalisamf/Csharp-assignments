using System.Collections.Generic;

namespace AlarmSystem
{
    public static class FactoryMethod
    {
        public static IEnumerable<ISensorHazard> CreateHazardsList(params ISensorHazard[] sensor) =>
            new List<ISensorHazard>(sensor);

        public static IEnumerable<ISensorMotion> CreateSecurityList(params ISensorMotion[] sensor) => new List<ISensorMotion>(sensor);

        public static FireSensor CreateFireSensor() => new FireSensor();

        public static FireSensor CreateFireSensor(string location) => new FireSensor(location);

        public static SmokeSensor CreateSmokeSensor() => new SmokeSensor();

        public static SmokeSensor CreateSmokeSensor(string location) => new SmokeSensor(location);

        public static MotionSensor CreateMotionSensor() => new MotionSensor();

        public static MotionSensor CreateMotionSensor(string location) => new MotionSensor(location);

        public static HeatSensor CreateHeatSensor(string location) => new HeatSensor(location);
        
        public static HeatSensor CreateHeatSensor() => new HeatSensor();

    }
}