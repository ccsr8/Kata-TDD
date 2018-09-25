using System;

namespace Kata5
{
    internal class FizzBuzz
    {
        public FizzBuzz()
        {
        }

        internal string Say(int number)
        {
            var result = number.ToString();

            bool IsCanDivisible3 = number % 3 == 0;
            bool IsCanDivisible5 = number % 5 == 0;

            if (IsCanDivisible3 && IsCanDivisible5)
            {
                result = "FizzBuzz";
            }
            else if (IsCanDivisible3)
            {
                result = "Fizz";
            }
            else if (IsCanDivisible5)
            {
                result = "Buzz";
            }

            return result;
        }
    }
}