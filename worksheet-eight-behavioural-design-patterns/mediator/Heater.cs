using System;

namespace mediator
{
    public class Heater : IColleague
    {
        public IMachineMediator Mediator { get; set; }

        public void On(int temp)
        {
            Console.WriteLine("Heater is on...");
            if (!Mediator.CheckTemperature(temp)) return;
            Console.WriteLine($"Temperature is set to {temp}");
            Mediator.Off();
        }

        public void Off()
        {
            Console.WriteLine("Heater is off...");
            Mediator.Wash();
        }
    }
}