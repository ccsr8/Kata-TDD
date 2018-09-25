using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Kata
{
    [TestFixture]
    public class FizzBuzzNUnitTest
    {
        private FizzBuzz _fizzBuzz;

        [OneTimeSetUp]
        public void Init()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        public void Say_NumberNotDivisible3Or5_ReturnNumber(int number)
        {
            // Arrange
            // Act
            var result = this._fizzBuzz.Say(number);

            // Assert
            Assert.AreEqual(number.ToString(), result);
        }

        [Test]
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void Say_NumberDivisible3_ReturnFizz(int number)
        {
            // Arrange
            // Act
            var result = this._fizzBuzz.Say(number);

            // Assert
            Assert.AreEqual("Fizz", result);
        }

        [Test]
        [TestCase(5)]
        public void Say_NumberDivisible5_ReturnBuzz(int number)
        {
            // Arrange
            // Act
            var result = this._fizzBuzz.Say(number);

            // Assert
            Assert.AreEqual("Buzz", result);
        }

        [Test]
        [TestCase(15)]
        [TestCase(30)]
        public void Say_NumberDivisible3And5_ReturnFizzBuzz(int number)
        {
            // Arrange
            // Act
            var result = this._fizzBuzz.Say(number);

            // Assert
            Assert.AreEqual("FizzBuzz", result);
        }
    }
}
