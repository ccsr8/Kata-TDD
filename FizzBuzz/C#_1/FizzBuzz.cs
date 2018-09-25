namespace Kata
{
    public static class FizzBuzz
    {
        public static string Print(int number)
        {
            var isDivisibleBy3 = number.IsCanDivisibleBy(3);
            var isDivisibleBy5 = number.IsCanDivisibleBy(5);

            if (isDivisibleBy3 && isDivisibleBy5)
            {
                return "FizzBuzz";
            }
            else if (isDivisibleBy3)
            {
                return "Fizz";
            }
            else if (isDivisibleBy5)
            {
                return "Buzz";
            }

            return number.ToString();
        }

        private static bool IsCanDivisibleBy(this int number, int targetNumber)
        {
            return number % targetNumber == 0;
        }
    }
}