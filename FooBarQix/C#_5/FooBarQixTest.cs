using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Day5
{
    [TestFixture]
    class FooBarQixTest
    {
        FooBarQix _sut;

        [OneTimeSetUp]
        public void Init()
        {
            this._sut = new FooBarQix();
        }

        [Test]
        [TestCase(1)]
        public void Compute_NumberNotDivisibe3Or5Or7_ReturnNumber(int number)
        {
            // Arrange
            var expected = number.ToString();

            // Act
            var actual = this._sut.Compute(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(6)]
        public void Compute_NumberDivisibe3_ReturFoo(int number)
        {
            // Arrange
            var expected = "Foo";

            // Act
            var actual = this._sut.Compute(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(10)]
        public void Compute_NumberDivisibe5_ReturBar(int number)
        {
            // Arrange
            var expected = "Bar*";

            // Act
            var actual = this._sut.Compute(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(14)]
        public void Compute_NumberDivisibe7_ReturBar(int number)
        {
            // Arrange
            var expected = "Qix";

            // Act
            var actual = this._sut.Compute(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(3)]
        public void Compute_NumberDivisibe3AndContain3_ReturBar(int number)
        {
            // Arrange
            var expected = "FooFoo";

            // Act
            var actual = this._sut.Compute(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(5)]
        public void Compute_NumberDivisibe5AndContain5_ReturBar(int number)
        {
            // Arrange
            var expected = "BarBar";

            // Act
            var actual = this._sut.Compute(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(7)]
        public void Compute_NumberDivisibe7AndContain7_ReturBar(int number)
        {
            // Arrange
            var expected = "QixQix";

            // Act
            var actual = this._sut.Compute(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(15, "FooBarBar")]
        [TestCase(21, "FooQix")]
        [TestCase(33, "FooFooFoo")]
        [TestCase(51, "FooBar")]
        [TestCase(53, "BarFoo")]
        [TestCase(101, "1*1")]
        [TestCase(303, "FooFoo*Foo")]
        [TestCase(105, "FooBarQix*Bar")]
        [TestCase(10101, "FooQix**")]
        public void Compute_MultiCase_ReturExpected(int number, string expected)
        {
            // Act
            var actual = this._sut.Compute(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
