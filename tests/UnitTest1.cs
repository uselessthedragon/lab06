using NUnit.Framework;
using logic;

namespace tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SimplifyFraction()
        {
            RationalNumber number = new RationalNumber(4, 8);

            if (number.Numerator == 1 && number.Denominator == 2)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
        
        [Test]
        public void NegativeDenominator()
        {
            RationalNumber number = new RationalNumber(4, -8);

            if (number.Numerator == 1 && number.Denominator == -2)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void NegativeNumerator()
        {
            RationalNumber number = new RationalNumber(-4, 8);

            if (number.Numerator == -1 && number.Denominator == 2)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void NegativeTopAndBottom()
        {
            RationalNumber number = new RationalNumber(-4, -8);

            if (number.Numerator == 1 && number.Denominator == 2)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void ZeroBottom()
        {
            RationalNumber number = new RationalNumber(4, 0);

            if (number.Numerator == 4 && number.Denominator == 0)
            {
                Assert.Fail();
            }
            else
            {
                Assert.Pass();
            }
        }

        [Test]
        public void DoesntSimplify()
        {
            RationalNumber number = new RationalNumber(17, 23);

            if (number.Numerator == 17 && number.Denominator == 23)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void FractionEquals()
        {
            RationalNumber num1 = new RationalNumber(20, 10);
            RationalNumber num2 = new RationalNumber(4, 2);

            if (num1.Equals(num2))
            {
                Assert.Pass();
            }
            Assert.Fail();
            
        }

        [Test]
        public void SimplfiedImproperFraction()
        {
            SimplifiedFraction  frac = new SimplifiedFraction(18, 7);

            if (frac.WholeUnits == 2 && frac.PartialUnits.Equals(new RationalNumber(4, 7)))
            {   
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        
        [Test]
        public void ImproperFractionEquals()
        {
            SimplifiedFraction num1 = new SimplifiedFraction(125, 50);
            SimplifiedFraction num2 = new SimplifiedFraction(5, 2);

            if (num1.Equals(num2))
            {
                Assert.Pass();
            }
            Assert.Fail();
            
        }
      
        [Test]
        public void NoWhole()
        {
            SimplifiedFraction number = new SimplifiedFraction(4, 7);

            if (number.WholeUnits == 0 && number.PartialUnits.Equals(new RationalNumber(4, 7)))
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void RationalPlus()
        {
            RationalNumber RatNum;
            RationalNumber RatNum2;

            RatNum =  new RationalNumber(1,2) + new RationalNumber (1, 2);
            RatNum2 = new RationalNumber(1, 1);
            
            if (RatNum.Equals(RatNum2))
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
        
        [Test]
        public void RationalMinus()
        {
            RationalNumber RatNum;
            RationalNumber RatNum2;

            RatNum =  new RationalNumber(3,4) - new RationalNumber (1, 4);
            RatNum2 = new RationalNumber(1, 2);
            
            if (RatNum.Equals(RatNum2))
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }

    }
}