using System;
using System.Collections.Generic;

namespace Day6
{
    internal class FizzBuzz
    {
        public FizzBuzz()
        {
        }

        internal string Say(int number)
        {
            var matrix = new Dictionary<int, string>()
            {
                { 15, "FizzBuzz"},
                { 5, "Buzz"},
                { 3, "Fizz"}
            };

            var result = number.ToString();
            foreach (var item in matrix)
            {
                if (number % item.Key == 0)
                {
                    result = item.Value;
                    break;
                }
            }

            return result;
        }
    }
}