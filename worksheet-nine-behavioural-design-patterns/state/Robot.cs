using System;

namespace state
{
    public class Robot : IRoboticState
    {
        private enum State
        {
            On,
            Cook,
            Walk,
            Off
        };

        public IRoboticState RobotOn { get; }
        public IRoboticState RobotCook { get; }

        public IRoboticState RobotOff { get; }
        public IRoboticState RobotWalk { get; }

        public IRoboticState RoboticState { get; set; }

        public Robot()
        {
            RobotOn = new RobotOn(this);
            RobotCook = new RobotCook(this);
            RobotOff = new RobotOff(this);
            RobotWalk = new RobotWalk(this);
            RoboticState = RobotOn;
        }

        public void Walk()
        {
            if (!OkayToProceed("walk")) return;
            RoboticState.Walk();
        }

        public void Cook()
        {
            if (!OkayToProceed("cook")) return;
            RoboticState.Cook();
        }

        public void Off()
        {
            if (!OkayToProceed("off")) return;
            RoboticState.Off();
        }

        public void On()
        {
            Console.WriteLine("Robot is switched on");
            RoboticState.On();
        }

        private bool OkayToProceed(string state)
        {
            if (RoboticState != RobotOff) return true;
            Console.WriteLine($"Cannot {state} at Off state.");

            return false;
        }
    }
}