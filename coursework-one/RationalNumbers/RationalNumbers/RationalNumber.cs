using System;

namespace RationalNumbers
{
    ///<inheritdoc/>
    public struct RationalNumber : IRationalNumber
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        /// <summary>
        /// Constructor with only the numerator, has implicit denominator=1.
        /// This is essentially a whole number
        /// </summary>
        /// <param name="numerator">An integer</param>
        public RationalNumber(int numerator)
        {
            Numerator = numerator;
            Denominator = 1;
        }

        /// <summary>
        /// Construct a reduced fraction
        /// </summary>
        /// <param name="numerator">An integer, has a default of 0</param>
        /// <param name="denominator">An integer, has a default 1</param>
        /// <exception cref="ArgumentException">Throws ArgumentException if the denominator is 0</exception>
        public RationalNumber(int numerator = 0, int denominator = 1)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.", nameof(denominator));
            }

            if (denominator < 0)
            {
                Numerator = -numerator;
                Denominator = -denominator;
            }
            else
            {
                Numerator = numerator;
                Denominator = denominator;
            }

            Reduce();
        }

        /// <summary>
        /// Construct a reduced fraction from a string containing numbers, spaces and one /, no other characters allowed(except spaces)
        /// </summary>
        /// <param name="fraction">A sting of numbers and at most one "/" </param>
        public RationalNumber(string fraction)
        {
            if (!fraction.Contains("/"))
            {
                Numerator = int.Parse(fraction);
                Denominator = 1;
            }
            else
            {
                //numerator is substring before "/" as int and denominator is substring after "/" as int
                var numerator =
                    int.Parse(fraction.Substring(0, fraction.IndexOf("/", StringComparison.Ordinal)));
                var denominator =
                    int.Parse(fraction.Substring(fraction.IndexOf("/", StringComparison.Ordinal) + 1));
                if (denominator == 0)
                {
                    throw new ArgumentException("Denominator cannot be zero.", nameof(denominator));
                }

                if (denominator < 0)
                {
                    Numerator = -numerator;
                    Denominator = -denominator;
                }
                else
                {
                    Numerator = numerator;
                    Denominator = denominator;
                }

                Reduce();
            }
        }

        public static IRationalNumber operator +(RationalNumber r1, RationalNumber r2) => r1.Add(r2);

        public static IRationalNumber operator -(RationalNumber r1, RationalNumber r2) => r1.Subtract(r2);

        public static IRationalNumber operator *(RationalNumber r1, RationalNumber r2) => r1.Multiply(r2);

        public static IRationalNumber operator /(RationalNumber r1, RationalNumber r2) => r1.Divide(r2);

        public IRationalNumber Abs() => new RationalNumber(Math.Abs(Numerator), Math.Abs(Denominator));

        /// <summary>
        /// Create a reduced fractions by dividing the terms by their greatest common divisor (gcd)
        /// Creates a GDC of the fraction to be reduced and divides the terms by it
        /// </summary>
        /// <returns>The same object with reduced terms</returns>
        private IRationalNumber Reduce()
        {
            var g = Gcd(Numerator, Denominator);
            {
                Numerator /= g;
                Denominator /= g;
                return this;
            }
        }

        public IRationalNumber ExpRational(int power)
        {
            // Exponentiation of a rational number r = a/b to a non-negative integer power n is r^n = (a^n)/(b^n)
            if (power > 0)

            {
                return new RationalNumber((int) Math.Pow(Numerator, power), (int) Math.Pow(Denominator, power));
            }

            // Exponentiation of a rational number r = a/b to a negative integer power n is r^n = (b^m)/(a^m), where m = |n|
            if (power < 0)

            {
                return new RationalNumber((int) Math.Pow(Denominator, Math.Abs(power)), (int) Math.Pow(Numerator,
                    Math.Abs(power)));
            }

            return new RationalNumber(1, 1);
        }

        public IRationalNumber Add(IRationalNumber number)
        {
            //casting the argument as RationalNumber
            //?? returns the value of its left-hand operand if it isn't null
            var r = number as RationalNumber? ?? default;
            return new RationalNumber(Numerator *
                r.Denominator + Denominator * r.Numerator,
                Denominator * r.Denominator);
        }

        public IRationalNumber Subtract(IRationalNumber number)
        {
            var r = number as RationalNumber? ?? default;
            return new RationalNumber(
                Numerator * r.Denominator - Denominator * r.Numerator,
                Denominator * r.Denominator);
        }

        public IRationalNumber Multiply(IRationalNumber number)
        {
            var r = number as RationalNumber? ?? default;
            return new RationalNumber(Numerator * r.Numerator,
                Denominator * r.Denominator);
        }

        public IRationalNumber Divide(IRationalNumber number)
        {
            var r = number as RationalNumber? ?? default;
            //cross multiply the terms of the fractions
            return new RationalNumber(Numerator * r.Denominator,
                Denominator * r.Numerator);
        }

        /// <summary>
        /// Override of the ToString method
        /// </summary>
        /// <returns>String representation of the fraction as numerator/denominator</returns>
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        /// <summary>
        /// Override of the Equals method to implement value equality
        /// </summary>
        /// <param name="obj">The object to compare with the current instance.</param>
        /// <returns>True if obj and this instance are the same type and represent the same value; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is RationalNumber))
            {
                return false;
            }

            return (Numerator == ((RationalNumber) obj).Numerator)
                   && (Denominator == ((RationalNumber) obj).Denominator);
        }


        /// <summary>
        /// Override of the GetHashCode method to implement value equality
        /// </summary>
        /// <returns>Returns the hash code for this instance.</returns>
        public override int GetHashCode()
        {
            return Numerator.GetHashCode() * Denominator.GetHashCode();
        }

        /// <summary>
        /// Helper method to generate the greatest common divisor (gcd) of the terms
        /// </summary>
        /// <param name="n">Numerator</param>
        /// <param name="d">Denominator</param>
        /// <returns>An integer which is the GCD of the terms</returns>
        private static int Gcd(int n, int d)
        {
            //making it static so that it is easier to test, can be called without creating an object of class
            n = Math.Abs(n);
            d = Math.Abs(d);
            //recursion of Euclidean algorithm
            return d == 0 ? n : Gcd(d, n % d);
        }

        public double ExpReal(int baseNumber) => baseNumber.ExpReal(this);
    }

    /// <summary>
    /// Exponentiation of integer to a rational number power
    /// </summary>
    public static class IntNumberExtension
    {
        /// <summary>
        /// Exponentiation of an integer to a rational number
        /// </summary>
        /// <param name="intNumber">An integer</param>
        /// <param name="r">A RationalNumber</param>
        /// <returns>A floating number which is the integer to the power of the RationalNumber</returns>
        public static double ExpReal(this int intNumber, RationalNumber r)
        {
            return Math.Pow(Math.Pow(intNumber, 1.0 / r.Denominator), r.Numerator);
        }
    }

    /// <summary>
    /// Extension class that transforms the fraction in a decimal number
    /// </summary>
    public static class DecimalExtension
    {
        /// <summary>
        /// Transform a RationalNumber into its decimal representation
        /// </summary>
        /// <param name="r">A RationalNumber</param>
        /// <returns>A double which is the representation of the RationalNumber</returns>
        public static double ToDecimal(this IRationalNumber r)
        {
            var n = (RationalNumber) r;
            return Math.Round(((double) n.Numerator / n.Denominator), 2);
        }
    }
}