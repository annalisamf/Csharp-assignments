using System;

namespace Flyweight
{
    public class CPlatform : IPlatform
    {
        public CPlatform()
        {
            Console.WriteLine("CPlatform object created");
        }

        public void Execute(Code code)
        {
            Console.WriteLine($"Compiling and executing {code} code.");
        }
    }
}