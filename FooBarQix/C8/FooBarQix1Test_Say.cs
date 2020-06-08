using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Shouldly;

namespace C8
{
    [TestFixture]
    internal class FooBarQix1Test_Say
    {
        private IFooBarQix _fooBarQix;

        [OneTimeSetUp]
        public void Init()
        {
            this._fooBarQix = new FooBarQix();
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        public void NumberNotDivisible_ReturnNumber(int number)
        {
            // Arrange
            var expected = number.ToString();

            // Act
            var actual = this._fooBarQix.Say(number);

            // Assert
            actual.ShouldBe(expected);
        }

        [TestCase(6)]
        public void NumberDivisibleBy3_ReturnNumber(int number)
        {
            // Arrange
            var expected = "Foo";

            // Act
            var actual = this._fooBarQix.Say(number);

            // Assert
            actual.ShouldBe(expected);
        }

        [TestCase(10)]
        public void NumberDivisibleBy5_ReturnNumber(int number)
        {
            // Arrange
            var expected = "Bar";

            // Act
            var actual = this._fooBarQix.Say(number);

            // Assert
            actual.ShouldBe(expected);
        }

        [TestCase(14)]
        public void NumberDivisibleBy7_ReturnNumber(int number)
        {
            // Arrange
            var expected = "Qix";

            // Act
            var actual = this._fooBarQix.Say(number);

            // Assert
            actual.ShouldBe(expected);
        }

        [TestCase(3)]
        public void NumberContain3_ReplaceFoo(int number)
        {
            // Arrange
            var expected = "FooFoo";

            // Act
            var actual = this._fooBarQix.Say(number);

            // Assert
            actual.ShouldBe(expected);
        }

        [TestCase(5)]
        public void NumberContain5_ReplaceBar(int number)
        {
            // Arrange
            var expected = "BarBar";

            // Act
            var actual = this._fooBarQix.Say(number);

            // Assert
            actual.ShouldBe(expected);
        }

        [TestCase(7)]
        public void NumberContain7_ReplaceQix(int number)
        {
            // Arrange
            var expected = "QixQix";

            // Act
            var actual = this._fooBarQix.Say(number);

            // Assert
            actual.ShouldBe(expected);
        }

        [TestCase(15, "FooBarBar")]
        [TestCase(33, "FooFooFoo")]
        [TestCase(21, "FooQix")]
        [TestCase(51, "FooBar")]
        [TestCase(53, "BarFoo")]
        public void MultipleCondition_ReplaceExpected(int number, string expected)
        {
            // Arrange
            // Act
            var actual = this._fooBarQix.Say(number);

            // Assert
            actual.ShouldBe(expected);
        }
    }
}