namespace C6
{
    using Xunit;

    public class FooBarQixTest
    {
        private readonly IFooBarQix _sut;

        public FooBarQixTest()
        {
            this._sut = new FooBarQix();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        public void Compute_NotDivisibleBy3Or5Or7_ReturnNumber(int number)
        {
            var expected = number.ToString();
            var actual = this._sut.Compute(number);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, "Foo")]
        [InlineData(10, "Bar")]
        [InlineData(14, "Qix")]
        public void Compute_DivisibleBy3Or5Or7_ReturnExpected(int number, string expected)
        {
            var actual = this._sut.Compute(number);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, "FooFoo")]
        [InlineData(5, "BarBar")]
        [InlineData(7, "QixQix")]
        public void Compute_Contain3Or5Or7_ReplaceDigit(int number, string expected)
        {
            var actual = this._sut.Compute(number);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(15, "FooBarBar")]
        [InlineData(33, "FooFooFoo")]
        [InlineData(21, "FooQix")]
        [InlineData(51, "FooBar")]
        [InlineData(53, "BarFoo")]
        public void Compute_MultipleCondition_ReturnExpected(int number, string expected)
        {
            var actual = this._sut.Compute(number);
            Assert.Equal(expected, actual);
        }
    }
}