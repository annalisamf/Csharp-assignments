using System;
using System.Collections.Generic;
using LanguageExt;
using static LanguageExt.Prelude;

namespace Q3
{
    internal static class Program
    {
        private static void Main()
        {
            bool isOdd(int i) => i % 2 == 1;
            Console.WriteLine(new List<int>().Lookup(isOdd)); // => None;
            Console.WriteLine(new List<int> {1}.Lookup(isOdd)); // => Some(1);
            
        }

        private static Option<T> Lookup<T>(this IEnumerable<T> ts, Func<T, bool> pred)
        {
            foreach (T t in ts)
                if (pred(t))
                    return Some(t);
            return None;
        }
    }
}
