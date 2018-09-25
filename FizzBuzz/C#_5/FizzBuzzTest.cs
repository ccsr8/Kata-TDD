using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Kata5
{
    [TestFixture]
    internal class FizzBuzzTest
    {
        private FizzBuzz _sut;

        [OneTimeSetUp]
        public void Init()
        {
            this._sut = new FizzBuzz();
        }

        [Test]
        [TestCase(1)]
        public void Say_NumberNotDivisible3Or5_ReturnNumber(int number)
        {
            // Arrange
            // Act
            var result = this._sut.Say(number);

            // Assert
            Assert.AreEqual(number.ToString(), result);
        }

        [Test]
        [TestCase(3)]
        public void Say_NumberIsDivisible3_ReturnFizz(int number)
        {
            // Arrange
            // Act
            var result = this._sut.Say(number);

            // Assert
            Assert.AreEqual("Fizz", result);
        }

        [Test]
        [TestCase(5)]
        public void Say_NumberIsDivisible5_ReturnBuzz(int number)
        {
            // Arrange
            // Act
            var result = this._sut.Say(number);

            // Assert
            Assert.AreEqual("Buzz", result);
        }

        [Test]
        [TestCase(15)]
        public void Say_NumberIsDivisible3And5_ReturnFizzBuzz(int number)
        {
            // Arrange
            // Act
            var result = this._sut.Say(number);

            // Assert
            Assert.AreEqual("FizzBuzz", result);
        }

    }
}
