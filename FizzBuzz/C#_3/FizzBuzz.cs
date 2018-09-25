using System;

namespace Kata
{
    internal class FizzBuzz
    {
        public FizzBuzz()
        {
        }

        internal string Say(int number)
        {
            var result = number.ToString();
            var isCanDivisible3 = number % 3 == 0;
            var isCanDivisible5 = number % 5 == 0;

            if (isCanDivisible3 && isCanDivisible5)
            {
                result = "FizzBuzz";
            }
            else if (isCanDivisible3)
            {
                result = "Fizz";
            } else if (isCanDivisible5)
            {
                result = "Buzz";
            }

            return result;
        }
    }
}