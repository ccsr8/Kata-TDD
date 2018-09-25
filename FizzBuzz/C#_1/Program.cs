using System;

namespace Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(FizzBuzz.Print(i));
            }

            Console.ReadKey();
        }
    }
}
