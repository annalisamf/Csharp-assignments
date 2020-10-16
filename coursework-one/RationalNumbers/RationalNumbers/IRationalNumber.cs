using System;

namespace RationalNumbers
{
    public interface IRationalNumber
    {
        /// <summary>
        /// Sum of two fractions
        /// </summary>
        /// <param name="number"> A rational number</param>
        /// <returns>Sum of two fractions</returns>
        IRationalNumber Add(IRationalNumber number);

        /// <summary>
        /// Subtraction of two fractions
        /// </summary>
        /// <param name="number">A rational number</param>
        /// <returns>The difference between two rational numbers</returns>
        IRationalNumber Subtract(IRationalNumber number);

        /// <summary>
        /// Multiplication of two rational numbers
        /// </summary>
        /// <param name="number">A rational number</param>
        /// <returns>The rational number multiplied by another rational number</returns>
        IRationalNumber Multiply(IRationalNumber number);

        /// <summary>
        /// Division of two rational numbers
        /// </summary>
        /// <param name="number">A rational number</param>
        /// <returns>The rational number divided by another rational number</returns>
        IRationalNumber Divide(IRationalNumber number);

        /// <summary>
        /// Absolute version of a fraction
        /// </summary>
        /// <returns>The fraction with terms in absolute form</returns>
        IRationalNumber Abs();

        /// <summary>
        /// Exponentiation of a rational number to an integer
        /// </summary>
        /// <param name="power">An integer which is the exponent of the power</param>
        /// <returns>The exponentiation of the rational number</returns>
        IRationalNumber ExpRational(int power);

        /// <summary>
        /// Exponentiation of an integer to a rational number
        /// </summary>
        /// <param name="baseNumber">An integer</param>
        /// <returns>A floating number which is the integer to the power of the RationalNumber object it is applied to</returns>
        double ExpReal(int baseNumber);
    }
}