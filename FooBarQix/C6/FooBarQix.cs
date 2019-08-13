namespace C6
{
    using System;

    internal class FooBarQix
    {
        public FooBarQix()
        {
        }

        internal string Compute(int number)
        {
            var isDivisible3 = number % 3 == 0;
            var isDivisible5 = number % 5 == 0;
            var isdivisible7 = number % 7 == 0;

            if (isDivisible3)
            {
                return "Foo";
            }
            else if (isDivisible5)
            {
                return "Bar";
            }
            else if (isdivisible7)
            {
                return "Qix";
            }

            return number.ToString();
        }
    }
}