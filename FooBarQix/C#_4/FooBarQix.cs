using System;

namespace Day4
{
    internal class FooBarQix
    {
        public FooBarQix()
        {
        }

        internal string Compute(int number)
        {
            var result = string.Empty;
            result = CheckDivisible(number, result);
            result = CheckContain(number, result);

            if (string.IsNullOrEmpty(result))
            {
                result = number.ToString();
            }

            return result.Replace("0", "*");
        }

        private static string CheckContain(int number, string result)
        {
            var numberText = number.ToString();
            var isCanDivisible = !string.IsNullOrEmpty(result);

            for (var i = 0; i < numberText.Length; i++)
            {
                if (numberText[i].ToString().Contains("3"))
                {
                    result += "Foo";
                }
                else if (numberText[i].ToString().Contains("5"))
                {
                    result += "Bar";
                }
                else if (numberText[i].ToString().Contains("7"))
                {
                    result += "Qix";
                }
                else if (numberText[i].ToString().Contains("0"))
                {
                    result += "0";
                }
                else if (!isCanDivisible)
                {
                    result += numberText[i].ToString();
                }
            }

            return result;
        }

        private static string CheckDivisible(int number, string result)
        {
            if (number % 3 == 0)
            {
                result += "Foo";
            }

            if (number % 5 == 0)
            {
                result += "Bar";
            }

            if (number % 7 == 0)
            {
                result += "Qix";
            }

            return result;
        }
    }
}