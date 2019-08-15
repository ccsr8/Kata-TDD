namespace C6
{
    internal class FooBarQix : IFooBarQix
    {
        public string Compute(int number)
        {
            bool isDivisibleBy3 = number % 3 == 0;
            if (isDivisibleBy3)
            {
                return "Foo";
            }

            return number.ToString();
        }
    }
}