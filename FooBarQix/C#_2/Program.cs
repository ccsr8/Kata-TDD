using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            string message;
            var foobar = new FooBarQix();

            for (int i = 1; i <= 100; i++)
            {
                message = string.Format("{0} = {1}", i, foobar.Compute(i));
                Console.WriteLine(message);
            }

            Console.ReadKey();
        }
    }
}
