using System;

namespace C07
{
    internal class FizzBuzz
    {
        public FizzBuzz()
        {
        }

        internal string Say(int number)
        {
            if (number % 3 == 0)
                return "Foo";
            else if (number % 5 == 0)
                return "Bar";
            else
                return number.ToString();
        }
    }
}