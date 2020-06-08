using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;

namespace C08
{
    public class FizzBuzz2_Say
    {
        private IFizzBuzz _fizzBuzz;

        public FizzBuzz2_Say()
        {
            this._fizzBuzz = new FizzBuzz();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        public void NumberNotDivisibleBy3or5_ReturnNumber(int number)
        {
            // Arrange
            var expected = number.ToString();

            // Act
            var actual = this._fizzBuzz.Say(number);

            // Assert
            actual.ShouldBe(expected);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        public void NumberIsDivisibleBy3_ReturnFizz(int number)
        {
            // Arrange
            var expected = "Fizz";

            // Act
            var actual = this._fizzBuzz.Say(number);

            // Assert
            actual.ShouldBe(expected);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
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