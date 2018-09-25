using System;

namespace Day2
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
            var isCanDivisible = !string.IsNullOrEmpty(result);
            var numberText = number.ToString();

            for (var i = 0; i < numberText.Length; i++)
            {
                var isContain3 = numberText[i].ToString().Contains("3");
                var isContain5 = numberText[i].ToString().Contains("5");
                var isContain7 = numberText[i].ToString().Contains("7");
                var isContain0 = numberText[i].ToString().Contains("0");

                if (isContain3)
                {
                    result += "Foo";
                }
                else if (isContain5)
                {
                    result += "Bar";
                }
                else if (isContain7)
                {
                    result += "Qix";
                }
                else if (isContain0)
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
            var isDivisible3 = number % 3 == 0;
            var isDivisible5 = number % 5 == 0;
            var isDivisible7 = number % 7 == 0;

            if (isDivisible3)
            {
                result += "Foo";
            }

            if (isDivisible5)
            {
                result += "Bar";
            }

            if (isDivisible7)
            {
                result += "Qix";
            }

            return result;
        }
    }
}