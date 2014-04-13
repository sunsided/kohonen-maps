using System;
using FluentAssertions;
using NUnit.Framework;
using RandomNumberGenerator;

namespace widemeadows.ml.kohonen.tests
{
    [TestFixture]
    public sealed class RandomNumberTests
    {
        [Test]
        public void XorShiftDoesNotRepeadedlyReturnTheSameNumber()
        {
            var rng = new XorShiftRng();
            const int iterations = 20;
            double lastNumber = Double.NaN;
            int count = 0;

            // generate multiple random numbers
            for (int i = 0; i < iterations; ++i)
            {
                var number = rng.GetDouble(min:-1.0, max:1.0);
                number.Should().BeGreaterOrEqualTo(-1.0, "because that is the lower bound");
                number.Should().BeLessOrEqualTo(1.0, "because that is the upper bound");

                // increase count if numbers are the same, otherwise reset counter
                if (number.Equals(lastNumber)) ++count;
                else count = 0;

                // store number
                lastNumber = number;
            }

            count.Should().BeLessOrEqualTo(5, "because more than five times the same number is highly unlikely");
        }
    }
}
