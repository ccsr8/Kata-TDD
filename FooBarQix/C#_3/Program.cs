using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            var foobar = new FooBarQix();

            for (var i = 1; i <= 100; i++)
            {
                Console.WriteLine(foobar.Compute(i));
            }

            Console.ReadKey();
        }
    }
}
