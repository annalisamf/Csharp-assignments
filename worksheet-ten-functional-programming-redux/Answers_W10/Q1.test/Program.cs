using System;
using NUnit.Framework;

namespace Q1.test
{
    public class BmiTests
    {
        [TestCase(1.70, 68, ExpectedResult = 23.53)]
        [TestCase(1.58, 70, ExpectedResult = 28.04)]
        [TestCase(1.90, 65, ExpectedResult = 18.01)]
        public double Calculation(double height, double weight)
            => Bmi.Calculation(height, weight);

        [TestCase(23.53, ExpectedResult = BmiRange.Healthy)]
        [TestCase(28.04, ExpectedResult = BmiRange.Overweight)]
        [TestCase(18.01, ExpectedResult = BmiRange.Underweight)]
        public BmiRange Range(double bmi) => bmi.Range();

        [TestCase(1.70, 68, ExpectedResult = BmiRange.Healthy)]
        [TestCase(1.58, 70, ExpectedResult = BmiRange.Overweight)]
        [TestCase(1.90, 65, ExpectedResult = BmiRange.Underweight)]
        public BmiRange ReadBmi(double height, double weight)
        {
            var result = default(BmiRange);
            Func<string, double> input = s => s == "height" ? height : weight;
            Action<BmiRange> output = r => result = r;

            Bmi.Start(input, output);
            return result;
        }
    }
}