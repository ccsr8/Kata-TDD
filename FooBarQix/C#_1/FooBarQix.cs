using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Day1
{
    internal class FooBarQix
    {
        public string Compute(int number)
        {
            var result = CheckDivisible(number);
            result += CheckContain(number, !string.IsNullOrEmpty(result));

            return result;
        }

        private static string CheckDivisible(int number)
        {
            var result = string.Empty;
            var isDivisible3 = number % 3 == 0;
            var isDivisible5 = number % 5 == 0;
            var isDivisible7 = number % 7 == 0;

            result += isDivisible3 ? "Foo" : string.Empty;
            result += isDivisible5 ? "Bar" : string.Empty;
            result += isDivisible7 ? "Qix" : string.Empty;

            return result;
        }

        private static string CheckContain(int number, bool isDivisible)
        {
            var result = string.Empty;
            var numberText = number.ToString();

            for (var i = 0; i < numberText.Length; i++)
            {
                switch (numberText[i])
                {
                    case '3':
                        result += "Foo";
                        break;
                    case '5':
                        result += "Bar";
                        break;
                    case '7':
                        result += "Qix";
                        break;
                    case '0':
                        result += "*";
                        break;
                    default:
                        if (!isDivisible)
                        {
                            result += numberText[i];
                        }
                        break;
                }
            }

            return result;
        }
    }
}