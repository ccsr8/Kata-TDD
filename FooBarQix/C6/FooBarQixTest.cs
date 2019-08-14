namespace C6
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Text;

    [TestFixture]
    internal class FooBarQixTest
    {
        private FooBarQix _sut;

        [OneTimeSetUp]
        public void Init()
        {
            this._sut = new FooBarQix();
        }

        [Test]
        [TestCase(1)]
        public void Compute_NumberNotDivisible3Or5Or7_ReturnNumber(int number)
        {
            // Arrange
            var expected = number.ToString();

            // Act
            var actual = this._sut.Compute(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(3)]
        public void Compute_NumberDivisibleBy3_ReturnFoo(int number)
        {
            // Arrange
            var expected = "Foo";

            // Act
            var actual = this._sut.Compute(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        public void Compute_NumberDivisibleBy5_ReturnBar(int number)
        {
            // Arrange
            var expedted = "Bar";

            // Act
            var actual = this._sut.Compute(number);

            // Assert
            Assert.AreEqual(expedted, actual);
        }

        public void Compute_NumberDivisibleBy7_ReturnQix(int number)
        {
            // Arrange
            var expected = "Qix";

            // Act
            var actual = this._sut.Compute(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}