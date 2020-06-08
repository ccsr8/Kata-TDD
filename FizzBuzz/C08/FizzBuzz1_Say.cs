using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Shouldly;

namespace C08
{
    [TestFixture]
    internal class FizzBuzz1_Say
    {
        private IFizzBuzz _fizzBuzz;

        [OneTimeSetUp]
        public void Init()
        {
            this._fizzBuzz = new FizzBuzz();
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        public void NumberNotDivisibleBy3Or5_ReturnNumber(int number)
        {
            // Arrange
            var expected = number.ToString();

            // Act
            var actual = this._fizzBuzz.Say(number);

            // Assert
            actual.ShouldBe(expected);
        }

        [TestCase(3)]
        [TestCase(6)]
        public void NumberIsDivisibleBy3_ReturnFizz(int number)
        {
            // Arrange
            var expected = "Fizz";

            // Act
            var actual = this._fizzBuzz.Say(number);

            // Assert
            actual.ShouldBe(expected);
        }

        [TestCase(5)]
        [TestCase(10)]
        public void NumberIsDivisibleBy5_ReturnBuzz(int number)
        {
            // Arrange
            var expected = "Buzz";

            // Act
            var actual = this._fizzBuzz.Say(number);

            // Assert
            actual.ShouldBe(expected);
        }
    }
}