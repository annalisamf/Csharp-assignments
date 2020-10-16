using System;

namespace state
{
    public class RobotCook : IRoboticState
    {
        private readonly Robot _robot;

        public RobotCook(Robot robot) => _robot = robot;

        public void Walk()
        {
            Console.WriteLine("Walking...");
            _robot.RoboticState = _robot.RobotOn;
        }

        public void Cook() => Console.WriteLine("Cooking...");

        public void Off() => Console.WriteLine("Cannot switch off while cooking...");

        public void On() => Console.WriteLine("Robot is already switched on...");
    }
}