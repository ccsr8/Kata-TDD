﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Day1
{
    [TestFixture]
    internal class FooBarQixTest
    {
        FooBarQix _sut;

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
            var result = this._sut.Compute(number);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(6)]
        public void Compute_NumberDivisible3_ReturnFoo(int number)
        {
            // Arrange
            var expected = "Foo";

            // Act
            var result = this._sut.Compute(number);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(10)]
        public void Compute_NumberDivisible5_ReturnBar(int number)
        {
            // Arrange
            var expected = "Bar*";

            // Act
            var result = this._sut.Compute(number);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(14)]
        public void Compute_NumberDivisible7_ReturnQix(int number)
        {
            // Arrange
            var expected = "Qix";

            // Act
            var result = this._sut.Compute(number);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(3)]
        public void Compute_NumberDivisible3AndContain3_ReturnFoo(int number)
        {
            // Arrange
            var expected = "FooFoo";

            // Act
            var result = this._sut.Compute(number);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(5)]
        public void Compute_NumberDivisible5AndContain5_ReturnBarBar(int number)
        {
            // Arrange
            var expected = "BarBar";

            // Act
            var result = this._sut.Compute(number);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(7)]
        public void Compute_NumberDivisible7AndContain7_ReturnQixQix(int number)
        {
            // Arrange
            var expected = "QixQix";

            // Act
            var result = this._sut.Compute(number);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(3, "FooFoo")]
        [TestCase(7, "QixQix")]
        [TestCase(15, "FooBarBar")]
        [TestCase(21, "FooQix")]
        [TestCase(33, "FooFooFoo")]
        [TestCase(51, "FooBar")]
        [TestCase(53, "BarFoo")]
        [TestCase(101, "1*1")]
        [TestCase(303, "FooFoo*Foo")]
        [TestCase(105, "FooBarQix*Bar")]
        [TestCase(10101, "FooQix**")]
        public void Compute_Data_ReturnExpected(int number, string expected)
        {
            // Arrange
            // Act
            var result = this._sut.Compute(number);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
