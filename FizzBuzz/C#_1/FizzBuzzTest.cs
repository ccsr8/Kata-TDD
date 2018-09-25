namespace Kata
{
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    public class FizzBuzzTest
    {
        [Test]
        [TestCase(1)]
        [TestCase(2)]
        public void Print_NumberIsNotDivisibleBy3_ReturnNumber(int number)
        {
            // Arrange
            // Act
            var sut = FizzBuzz.Print(number);

            // Assert
            sut.Should().Be(number.ToString());
        }

        [Test]
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void Print_NumberDivisibleBy3_ReturnFizz(int number)
        {
            // Arrange
            // Act
            var sut = FizzBuzz.Print(number);

            // Assert
            Assert.AreEqual("Fizz", sut);
        }

        [Test]
        [TestCase(5)]
        [TestCase(10)]
        public void Print_NumberDivisibleBy5_ReturnBuzz(int number)
        {
            // Arrange
            // Act
            var sut = FizzBuzz.Print(number);

            // Assert
            Assert.AreEqual("Buzz", sut);
        }

        [Test]
        [TestCase(15)]
        public void Print_NumberDivisibleBy3And5_ReturnFizzBuzz(int number)
        {
            // Arrange
            // Act
            var sut = FizzBuzz.Print(number);

            // Assert
            Assert.AreEqual("FizzBuzz", sut);
        }
    }
}
