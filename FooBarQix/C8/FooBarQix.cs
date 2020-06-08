namespace C8
{
    internal class FooBarQix : IFooBarQix
    {
        public string Say(int number)
        {
            var result = string.Empty;
            result = CheckDivisible(number, result);
            result = CheckContain(number, result);

            if (string.IsNullOrEmpty(result))
                result = number.ToString();

            return result;
        }

        private static string CheckContain(int number, string result)
        {
            foreach (var item in number.ToString())
            {
                if (item == '3')
                    result += "Foo";

                if (item == '5')
                    result += "Bar";

                if (item == '7')
                    result += "Qix";
            }

            return result;
        }

        private static string CheckDivisible(int number, string result)
        {
            if (number % 3 == 0)
                result += "Foo";

            if (number % 5 == 0)
                result += "Bar";

            if (number % 7 == 0)
                result += "Qix";

            return result;
        }
    }
}