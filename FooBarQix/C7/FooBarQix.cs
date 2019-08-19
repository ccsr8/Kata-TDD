namespace C7
{
    using System;

    internal class FooBarQix
    {
        public FooBarQix()
        {
        }

        internal object Compute(int number)
        {
            string result = CheckDivisible(number);
            result = CheckContain(number, result);

            if (string.IsNullOrEmpty(result))
            {
                result = number.ToString();
            }

            return result;
        }

        private static string CheckContain(int number, string result)
        {
            foreach (var item in number.ToString())
            {
                if (item == '3')
                {
                    result += "Foo";
                }
                else if (item == '5')
                {
                    result += "Bar";
                }
                else if (item == '7')
                {
                    result += "Qix";
                }
            }

            return result;
        }

        private static string CheckDivisible(int number)
        {
            var result = string.Empty;

            var isDivisibleBy3 = number % 3 == 0;
            var isDivisibleBy5 = number % 5 == 0;
            var isDivisibleBy7 = number % 7 == 0;

            if (isDivisibleBy3)
            {
                result += "Foo";
            }

            if (isDivisibleBy5)
            {
                result += "Bar";
            }

            if (isDivisibleBy7)
            {
                result += "Qix";
            }

            return result;
        }
    }
}