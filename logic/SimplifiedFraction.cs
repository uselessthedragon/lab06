using System;

namespace logic
{
    public class SimplifiedFraction
    {
        public int WholeUnits { get; }
        public RationalNumber PartialUnits { get; }

        public SimplifiedFraction(int numerator, int denominator)
        {
            WholeUnits = numerator / denominator;
            PartialUnits = new RationalNumber(numerator % denominator, denominator);
        }
        
        public SimplifiedFraction(RationalNumber ratNum) : this(ratNum.Numerator, ratNum.Denominator)
        {
            
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            
            return Equals((SimplifiedFraction)obj);
        }
        
        public bool Equals (SimplifiedFraction number)
        {
            return (WholeUnits.Equals(number.WholeUnits) && PartialUnits.Equals(number.PartialUnits));
        }
        
        public override int GetHashCode()
        {
            return HashCode.Combine(WholeUnits.GetHashCode(), PartialUnits.GetHashCode());
        }
    }
}
