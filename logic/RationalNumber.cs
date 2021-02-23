using System;

namespace logic
{
    public class RationalNumber
    {
        public RationalNumber()
        {

        }
        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentOutOfRangeException("denominator", "The denominator cannot be zero, as we cannot divide by zero.");
            }

            int small = 1;
            int gcd = 1;

            if (Math.Abs(numerator) < Math.Abs(denominator))
            {
                small = Math.Abs(numerator);
            }
            else
            {
                small = Math.Abs(denominator);
            }

            for (var i = 2; i <= small; i++)
            {
                if (numerator % i == 0 && denominator % i == 0)
                {
                    gcd = i;
                }
            }

            if (numerator < 0 && denominator < 0)
            {
                numerator = Math.Abs(numerator);
                denominator = Math.Abs(denominator);
            }

            Numerator = numerator / gcd;
            Denominator = denominator / gcd;
        }
        
        public int Numerator { get; }
        public int Denominator { get; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return Equals((RationalNumber)obj);
        }

        public bool Equals(RationalNumber number)
        {
            return (Numerator.Equals(number.Numerator) && Denominator.Equals(number.Denominator));
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Numerator.GetHashCode(), Denominator.GetHashCode());
        }

        public static RationalNumber operator + (RationalNumber num1, RationalNumber num2)
        {
            int num1Numerator = num1.Numerator * num2.Denominator;
            int num2Numerator = num2.Numerator * num1.Denominator;

            return new RationalNumber(num1Numerator + num2Numerator, num1.Denominator * num2.Denominator);
        }

        public static RationalNumber operator - (RationalNumber num1, RationalNumber num2)
        {
            int num1Numerator = num1.Numerator * num2.Denominator;
            int num2Numerator = num2.Numerator * num1.Denominator;

            return new RationalNumber(num1Numerator - num2Numerator, num1.Denominator * num2.Denominator);
        }

        public static RationalNumber operator * (RationalNumber num1, RationalNumber num2)
        {

            return new RationalNumber(num1.Numerator * num2.Numerator, num1.Denominator * num2.Denominator);
        }

        public static RationalNumber operator / (RationalNumber num1, RationalNumber num2)
        {
            return new RationalNumber(num1.Numerator * num2.Denominator, num1.Denominator * num2.Numerator);
        }

        public static bool operator < (RationalNumber num1 , RationalNumber num2)
        {
            double num1Floating = (double)num1.Numerator / num1.Denominator;
            double num2Floating = (double)num2.Numerator / num2.Denominator;

            return (num1Floating < num2Floating);
        }

        public static bool operator > (RationalNumber num1 , RationalNumber num2)
        {
            double num1Floating = (double)num1.Numerator / num1.Denominator;
            double num2Floating = (double)num2.Numerator / num2.Denominator;

            //return (num1Floating < num2Floating);
            return false;
        }
    }
}
