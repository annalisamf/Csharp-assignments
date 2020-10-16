using System;
using System.Collections.Generic;
using System.Linq;
using static AlarmSystem.FactoryMethod;

namespace AlarmSystem
{
    public class ControlUnit
    {
        private IEnumerable<ISensorHazard> Sensors { get; set; }

        protected void PollSensors()
        {
            Sensors ??= HazardSensorList();
            Results(Sensors);
        }
        
        private IEnumerable<ISensorHazard> HazardSensorList() => CreateHazardsList(
            CreateSmokeSensor("Basement"),
            CreateFireSensor("First Floor"),
            CreateSmokeSensor("Lobby 1st Floor"),
            CreateFireSensor("Second Floor"),
            CreateSmokeSensor("Second Floor"),
            CreateFireSensor("Basement"));


        private void Results(IEnumerable<ISensorHazard> list)
        {
            Console.WriteLine("********************* Hazard Sensors *******************************");
            foreach (var sensor in list)
            {
                if ((int) sensor.BatteryPercentage > 0)
                {
                    Console.WriteLine(sensor.IsTriggered
                        ? $"A {sensor.GetSensorType()} sensor was triggered at {sensor.GetLocation()}, remaining battery {sensor.GetBatteryPercentage()}%"
                        : $"Polled {sensor.GetSensorType()} at {sensor.GetLocation()} successfully, remaining battery {sensor.GetBatteryPercentage()}%");
                }
                else
                {
                    Console.WriteLine(
                        $"{sensor.GetSensorType()} at {sensor.GetLocation()} battery depleted: cannot be polled");
                }
            }

            Console.WriteLine("********************************************************************");
        }
    }
}