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
        [InlineData(3)]
        public void Compute_DivisibleBy3_ReturnFoo(int number)
        {
            var expected = "Foo";
            var actual = this._sut.Compute(number);
            Assert.Equal(expected, actual);
        }
    }
}