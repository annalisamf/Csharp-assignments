using System;

namespace state
{
    public class RobotWalk : IRoboticState
    {
        private readonly Robot _robot;

        public RobotWalk(Robot robot) => _robot = robot;

        public void Walk()
        {
            Console.WriteLine("Walking...");
            _robot.RoboticState = _robot.RobotOn;
        }

        public void Cook() => Console.WriteLine("Cooking...");

        public void Off() => Console.WriteLine("Robot is switched off...");

        public void On() => Console.WriteLine("Robot is already switched on...");
    }
}