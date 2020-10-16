using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static AlarmSystem.FactoryMethod;

namespace AlarmSystem
{
    public class SecurityControlUnit : ControlUnit
    {
        private IEnumerable<ISensorMotion> SecuritySensors { get; set; }

        public void PollAllSensors()
        {
            PollSensors();
            if (DateTime.Now.Hour < 22 && DateTime.Now.Hour > 6) return;
            SecuritySensors ??= SecuritySensorList();
            Results(SecuritySensors);
        }

        private IEnumerable<ISensorMotion> SecuritySensorList() => CreateSecurityList(CreateMotionSensor("Basement"), CreateHeatSensor("Lobby"));

        private void Results(IEnumerable<ISensorMotion> list)
        {
            WriteLine("******************** Security Sensors ******************************");

            foreach (var sensor in list)
                WriteLine(sensor.IsTriggered
                    ? $"A {sensor.GetSensorType()} sensor was triggered at {sensor.GetLocation()}"
                    : $"Polled {sensor.GetSensorType()} at {sensor.GetLocation()} successfully");

            WriteLine("********************************************************************");
        }
    }
}