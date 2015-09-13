using FizzBuzz.Business;
using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
                Console.Write(FizzBuzzEngine.Transform(i) + ", ");
            Console.Write(FizzBuzzEngine.Transform(100));
            Console.ReadKey();
        }
    }
}
