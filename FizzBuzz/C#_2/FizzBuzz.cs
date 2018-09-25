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
            var isDivisible3 = number % 3 == 0;
            var isDivisible5 = number % 5 == 0;

            if (isDivisible3 && isDivisible5)
            {
                return "FizzBuzz";
            }
            else if (isDivisible3)
            {
                return "Fizz";
            }
            else if (isDivisible5)
            {
                return "Buzz";
            }

            return number.ToString();
        }
    }
}