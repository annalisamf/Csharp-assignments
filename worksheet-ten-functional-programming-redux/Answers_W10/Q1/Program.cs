using System;

namespace Q1
{
    public enum BmiRange
    {
        Underweight,
        Healthy,
        Overweight
    }

    public static class Bmi
    {
        public static void Main()
        {
            Start(Input, Output);
        }

        public static double Input(string field)
        {
            Console.WriteLine($"Please enter your {field}");
            return double.Parse(Console.ReadLine() ?? string.Empty);
        }

        public static void Output(BmiRange range)
        {
            Console.WriteLine($"Based on your BMI, you are {range}");
        }

        public static void Start(Func<string, double> input, Action<BmiRange> output)
        {
            var weight = input("weight");
            var height = input("height");

            var bmiRange = Calculation(height, weight).Range();
            output(bmiRange);
        }

        public static double Calculation(double height, double weight) =>
            Math.Round(weight / Math.Pow(height, 2), 2);

        public static BmiRange Range(this double bmi) =>
            bmi < 18.5 ? BmiRange.Underweight :
            bmi >= 25 ? BmiRange.Overweight : BmiRange.Healthy;
    }
}

