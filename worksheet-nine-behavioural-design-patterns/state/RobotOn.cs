using System;

namespace state
{
    public class RobotOn : IRoboticState
    {
        public RobotOn(Robot robot) => Robot = robot;

        private Robot Robot { get; set; }

        // public IRoboticState RoboticState { get; set; }


        public void Walk()
        {
            Console.WriteLine("Walking...");
            Robot.RoboticState = Robot.RobotWalk;

        }

        public void Cook()
        {
            Console.WriteLine("Cooking...");
            Robot.RoboticState = Robot.RobotCook;
        }

        public void Off() => Console.WriteLine("Robot is switched off...");

        public void On() => Console.WriteLine("Robot is switched on...");
    }
}