using System;

namespace Flyweight
{
    public class ScalaPlatform : IPlatform
    {
        public ScalaPlatform()
        {
            Console.WriteLine("ScalaPlatform object created");
        }

        public void Execute(Code code)
        {
            Console.WriteLine($"Compiling and executing {code} code.");
        }
    }
}