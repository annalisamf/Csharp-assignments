using System;

namespace mediator
{
    public class Sensor
    {
        public bool CheckTemperature(int temp)
        {
            Console.WriteLine($"Temperature reached {temp} C");
            return true;
        }
    }
}