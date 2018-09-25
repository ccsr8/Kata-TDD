using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Kata
{
    [TestFixture]
    class FizzBuzzTest
    {
        FizzBuzz _sut;

        [OneTimeSetUp]
        public void Inint()
        {
            _sut = new FizzBuzz();
        }

        [Test]
        [TestCase(1)]
        public void Say_NumberIsNotDivisible3Or5_ReturnNumber(int number)
        {
            // Arrange
            // Act
            var result = _sut.Say(number);

            // Assert
            Assert.AreEqual(number.ToString(), result);
        }

        [Test]
        [TestCase(3)]
        public void Say_NumberIsDivisible3_ReturnFizz(int number)
        {
            // Arrange
            // Act
            var result = _sut.Say(number);

            // Assert
            Assert.AreEqual("Fizz", result);
        }

        [Test]
        [TestCase(5)]
        public void Say_NumberIsDivisible5_ReturnBuzz(int number)
        {
            // Arrange
            // Act
            var result = _sut.Say(number);

            // Assert
            Assert.AreEqual("Buzz", result);
        }

        [Test]
        [TestCase(15)]
        [TestCase(30)]
        public void Say_NumberIsDivisible3Or5_ReturnFizzBuzz(int number)
        {
            // Arrange
            // Act
            var result = _sut.Say(number);

            // Assert
            Assert.AreEqual("FizzBuzz", result);
        }
    }
}
