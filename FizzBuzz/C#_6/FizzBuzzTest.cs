using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Day6
{
    [TestFixture]
    class FizzBuzzTest
    {
        FizzBuzz _sut;

        [OneTimeSetUp]
        public void Init()
        {
            this._sut = new FizzBuzz();
        }

        [Test]
        public void Say_NumberNotDivisible_ReturnNumber()
        {
            // Arrange
            var number = 1;
            var expected = "1";

            // Act
            var actual = this._sut.Say(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Say_Divisible3_ReturnFizz()
        {
            // Arrange
            var number = 3;
            var expected = "Fizz";

            // Act
            var actual = this._sut.Say(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Say_Divisible5_ReturnBuzz()
        {
            // Arrange
            var number = 5;
            var expected = "Buzz";

            // Act
            var actual = this._sut.Say(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Say_Divisible3And5_ReturnFizzBuzz()
        {
            // Arrange
            var number = 15;
            var expected = "FizzBuzz";

            // Act
            var actual = this._sut.Say(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
