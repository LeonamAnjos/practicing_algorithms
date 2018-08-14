using System;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace PracticingAlgorithms.Others
{
    [TestFixture]
    public class ReversePolishNotationCalculatorTest
    {
        [Test]
        public void ShouldReturn14()
        {
            var actual = ReversePolishNotationCalculator.Calculate("512+4*+3-");
            Assert.That(actual, Is.EqualTo(14));
        }

        [Test]
        public void ShouldReturn17()
        {
            var actual = ReversePolishNotationCalculator.Calculate("512+5*+3-");
            Assert.That(actual, Is.EqualTo(17));
        }

        [Test]
        public void ShouldReturn1()
        {
            var actual = ReversePolishNotationCalculator.Calculate("51-2+5*33333++++/1-");
            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void ShouldReturnErrorWhenTheAmountOfOperatorsIsEqualsToTheAmountOfNumbers()
        {
            Assert.Throws<ApplicationException>(() => ReversePolishNotationCalculator.Calculate("111+++"));
        }

        [Test]
        public void ShouldReturnErrorWhenTheAmountOfOperatorsIsBiggerThanTheAmountOfNumbers()
        {
            Assert.Throws<ApplicationException>(() => ReversePolishNotationCalculator.Calculate("22+++"));
        }

        [Test]
        public void ShouldReturnErrorWhenThereAreNumbersWithoutBeenEvaluated()
        {
            Assert.Throws<ApplicationException>(() => ReversePolishNotationCalculator.Calculate("123+"));
        }

        [Test]
        public void ShouldReturnErrorWhenThereIsAnyInvalidChar()
        {
            Assert.Throws<ApplicationException>(() => ReversePolishNotationCalculator.Calculate("51,"));
        }

    }
}
