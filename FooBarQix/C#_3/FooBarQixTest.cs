using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Day3
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
        public void Compute_NumberNotDivisibleOrContain_ReturnNumber(int number)
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
        public void Compute_NumberCanDivisible3_ReturnFoo(int number)
        {
            // Arrage
            var expected = "Foo";

            // Act
            var actual = this._sut.Compute(number);

            // Arrange
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(10)]
        public void Compute_NumberCanDivisible5_ReturnBar(int number)
        {
            // Arrage
            var expected = "Bar*";

            // Act
            var actual = this._sut.Compute(number);

            // Arrange
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(14)]
        public void Compute_NumberCanDivisible5_ReturnQix(int number)
        {
            // Arrage
            var expected = "Qix";

            // Act
            var actual = this._sut.Compute(number);

            // Arrange
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(3)]
        public void Compute_NumberCanDivisible5_ReturnFooFoo(int number)
        {
            // Arrage
            var expected = "FooFoo";

            // Act
            var actual = this._sut.Compute(number);

            // Arrange
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(5)]
        public void Compute_NumberCanDivisible5_ReturnBarBar(int number)
        {
            // Arrage
            var expected = "BarBar";

            // Act
            var actual = this._sut.Compute(number);

            // Arrange
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(7)]
        public void Compute_NumberCanDivisible7_ReturnQixQix(int number)
        {
            // Arrage
            var expected = "QixQix";

            // Act
            var actual = this._sut.Compute(number);

            // Arrange
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(15, "FooBarBar")]
        [TestCase(33, "FooFooFoo")]
        [TestCase(51, "FooBar")]
        [TestCase(53, "BarFoo")]
        [TestCase(101, "1*1")]
        [TestCase(303, "FooFoo*Foo")]
        [TestCase(105, "FooBarQix*Bar")]
        [TestCase(10101, "FooQix**")]
        public void Compute_Data_ReturnExpected(int number, string expected)
        {
            // Arrage
            // Act
            var actual = this._sut.Compute(number);

            // Arrange
            Assert.AreEqual(expected, actual);
        }
    }
}
