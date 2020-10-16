using System;
using System.Collections.Generic;

namespace Q6
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static ISet<R> Map<T, R>(this ISet<T> ts, Func<T, R> f)
        {
            var rs = new HashSet<R>();
            foreach (var t in ts)
                rs.Add(f(t));
            return rs;
        }
    }
}
