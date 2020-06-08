namespace C08
{
    internal class FizzBuzz : IFizzBuzz
    {
        public string Say(int number)
        {
            if (this.IsDivisible(number, 3))
                return "Fizz";
            else if (this.IsDivisible(number, 5))
                return "Buzz";
            else
                return number.ToString();
        }

        private bool IsDivisible(int number, int divisible)
        {
            return number % divisible == 0;
        }
    }
}