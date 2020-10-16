using System;

namespace state
{
    public class RobotOff : IRoboticState
    {
        private readonly Robot _robot;

        public RobotOff(Robot robot) => _robot = robot;


        public void Walk()
        {
            Console.WriteLine("Walking...");
            _robot.RoboticState = _robot.RobotOn;

        }

        public void Cook()
        {
            Console.WriteLine("Cooking...");
        }

        public void Off()
        {
            Console.WriteLine("Already switched off...");
            _robot.RoboticState = _robot.RobotOff;
        }

        public void On() => Console.WriteLine("Switching on...");
    }
}