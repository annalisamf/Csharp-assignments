using System;

namespace strategy
{
    public class LowerTextFormatter : ITextFormatter
    {
        public void Format(string text) => Console.WriteLine($"LowerTextFormatter: {text.ToLower()}");
    }
}