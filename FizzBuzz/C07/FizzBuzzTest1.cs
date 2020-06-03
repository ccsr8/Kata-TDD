using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using FluentAssertions;
using Shouldly;

namespace C07
{
    [TestFixture]
    internal class FizzBuzzTest1
    {
        private FizzBuzz _fizzBuzz;

        [OneTimeSetUp]
        public void Init()
        {
            this._fizzBuzz = new FizzBuzz();
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        public void Say_NumberNotDivisibleBy3Or5_ReturnNumber(int number)
        {
            // Arrange
            var expected = number.ToString();

            // Act
            var actual = this._fizzBuzz.Say(number);

            // Assert
            actual.ShouldBe(expected);
        }

        [TestCase(6)]
        public void Say_NumberIsDivisibleBy3_ReturnFoo(int number)
        {
            // Arrange
            var expected = "Foo";

            // Act
            var actual = this._fizzBuzz.Say(number);

            // Assert
            actual.ShouldBe(expected);
        }

        [TestCase(10)]
        public void Say_NumberIsDivisibleBy5_ReturnBar(int number)
        {
            // Arrange
            var expected = "Bar";

            // Act
            var actual = this._fizzBuzz.Say(number);

            // Assert
            actual.ShouldBe(expected);
        }
    }
}