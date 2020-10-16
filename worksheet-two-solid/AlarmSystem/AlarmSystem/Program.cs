using System;
using static System.Console;

namespace AlarmSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // ControlUnit controlUnit = new ControlUnit();
            SecurityControlUnit controlUnit = new SecurityControlUnit();

            string input = string.Empty;
            while (!input.Equals("exit"))
            {
                WriteLine("Type \"poll\" to poll all sensors once or \"exit\" to exit");
                input = ReadLine();
                if (input.Equals("poll"))
                {
                    controlUnit.PollAllSensors();
                }
            }
        }
    }
}