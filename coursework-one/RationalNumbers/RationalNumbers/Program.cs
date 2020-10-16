using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace RationalNumbers
{
    static class Program
    {
        private static void Main()
        {
            RationalNumber rr = new RationalNumber(6);
            Console.WriteLine($"rr is {rr}");
            RationalNumber r = new RationalNumber(10, 5);
            Console.WriteLine($"r is: {r}");
            RationalNumber r1 = new RationalNumber("6 /    8");
            Console.WriteLine($"r1 is {r1}");
            Console.WriteLine($"r1 in decimal is: {r1.ToDecimal()}"); //extension method

            var sum = r1 + r;
            Console.WriteLine($"The sum of r1 and r is: {sum}");
            Console.WriteLine($"The difference between r and r1 is: {r - r1}");
            Console.WriteLine($"The difference between r1 and r is: {r1 - r}");
            Console.WriteLine($"The product between r and r1 is: {r * r1}");
            Console.WriteLine($"The quotient between r and r1 is: {r / r1}");
            Console.WriteLine($"The quotient between r1 and r is: {r1 / r}");

            var r2 = new RationalNumber();
            Console.WriteLine($"The default RationalNumber is: {r2}");

            RationalNumber r3 = new RationalNumber(14, 2);
            RationalNumber r4 = new RationalNumber(7);
            Console.WriteLine($"r3 is equal to r4: {r3.Equals(r4)}");
            Console.WriteLine($"Hashcode for r4 is {r4.GetHashCode()}");
            Console.WriteLine($"Hashcode for r3 is {r3.GetHashCode()}");
            Console.WriteLine(new RationalNumber(3, 5) + new RationalNumber(4));
            IRationalNumber r5 = new RationalNumber(-4, 3);
            Console.WriteLine($"r5 is {r5}");

            Console.WriteLine(4.ExpReal(r1)); // this is from the extension method
            Console.WriteLine(r1.ExpReal(4));
            Console.WriteLine($"7/13 to the power of 3 is: {new RationalNumber("7/13").ExpRational(3)}");
            var r6 = new RationalNumber("7/13").ExpRational(3);
            Console.WriteLine($"7/13 to the power of 3 in decimal form is: {r6.ToDecimal()}");
        }
    }
}