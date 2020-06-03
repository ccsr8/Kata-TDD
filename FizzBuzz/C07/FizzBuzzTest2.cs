using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;

namespace C07
{
    public class FizzBuzzTest2
    {
        private FizzBuzz _fizzBuzz;

        public FizzBuzzTest2()
        {
            this._fizzBuzz = new FizzBuzz();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        public void Say_NumberNotDivisibleBy3Or5_ReturnNumber(int number)
        {
            // Arrange
            var expected = number.ToString();

            // Act
            var actual = this._fizzBuzz.Say(number);

            // Assert
            actual.ShouldBe(expected);
        }

        [Theory]
        [InlineData(6)]
        public void Say_NumberIsDivisibleBy3_ReturnFoo(int number)
        {
            // Arrange
            var expected = "Foo";

            // Act
            var actual = this._fizzBuzz.Say(number);

            // Assert
            actual.ShouldBe(expected);
        }

        [Theory]
        [InlineData(10)]
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