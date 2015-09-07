using FizzBuzz.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(FizzBuzzTransformer.Transform(i) + ", ");
            }
            Console.ReadKey();
        }
    }
}
