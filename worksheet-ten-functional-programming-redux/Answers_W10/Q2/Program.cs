using System;
using LaYumba.Functional;
using static LaYumba.Functional.F;
using Enum = LaYumba.Functional.Enum;

namespace Q2
{
    internal static class Program
    {
        private static Option<TEnum> Parse<TEnum>(this string s) where TEnum : struct
            => System.Enum.TryParse(s, out TEnum t) ? Some(t) : None;


        public static void Main(string[] args)
        {
            "Friday".Parse<DayOfWeek>(); // => Some(DayOfWeek.Friday)
            "Freeday".Parse<DayOfWeek>(); // => None
            Console.WriteLine("Friday".Parse<DayOfWeek>());
            Console.WriteLine("Freeday".Parse<DayOfWeek>());

            Option<DayOfWeek> a = Enum.Parse<DayOfWeek>("Friday");
            Console.WriteLine(a);
            var t = Enum.Parse<DayOfWeek>("Freeday"); // => None
            Console.WriteLine(t);
        }
    }
}