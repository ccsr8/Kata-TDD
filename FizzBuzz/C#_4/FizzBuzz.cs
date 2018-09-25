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
            var result =  number.ToString();

            var isDivisible3 = number % 3 == 0;
            var isDivisible5 = number % 5 == 0;

            if (isDivisible3 && isDivisible5)
            {
                result = "FizzBuzz";
            }
            else if (isDivisible3)
            {
                result = "Fizz";
            }
            else if (isDivisible5)
            {
                result = "Buzz";
            }

            return result;
        }
    }
}