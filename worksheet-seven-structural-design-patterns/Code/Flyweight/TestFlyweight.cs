using System;

namespace Flyweight
{
    public static class TestFlyweight
    {
        public static void Main(string[] args)
        {
            var code = new Code("C Code...");
            var platform = PlatformFactory.PlatformInstance("C");
            const string line = "--------------------";

            platform.Execute(code);
            Console.WriteLine(line);

            code = new Code("C Code2...");
            platform = PlatformFactory.PlatformInstance("C");
            platform.Execute(code);
            Console.WriteLine(line);

            code = new Code("JAVA Code...");
            platform = PlatformFactory.PlatformInstance("JAVA");
            platform.Execute(code);
            Console.WriteLine(line);

            code = new Code("JAVA Code2...");
            platform = PlatformFactory.PlatformInstance("JAVA");
            platform.Execute(code);
            Console.WriteLine(line);

            code = new Code("RUBY Code...");
            platform = PlatformFactory.PlatformInstance("RUBY");
            platform.Execute(code);
            Console.WriteLine(line);

            code = new Code("RUBY Code2...");
            platform = PlatformFactory.PlatformInstance("RUBY");
            Console.WriteLine(line);
        }
    }
}


// C Platform object created
// Compiling and executing C code.
// -------------------------------------
// Compiling and executing C code.
// -------------------------------------
// Java Platform object created
// Compiling and executing Java code.
// -------------------------------------
// Compiling and executing Java code.
// -------------------------------------
// Ruby Platform object created
// Compiling and executing Ruby code.
// -------------------------------------
// Compiling and executing Ruby code.