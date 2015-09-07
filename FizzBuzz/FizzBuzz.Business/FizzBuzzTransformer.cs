using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Business
{
    public class FizzBuzzTransformer
    {
        public static string Transform(Int32 inputNumber)
        {
            string result = String.Empty;

            if (IsFizz(inputNumber))
                result = "Fizz";
                
            if(IsBuzz(inputNumber))
                result += "Buzz";
            
            if (string.IsNullOrWhiteSpace(result))
                result =inputNumber.ToString();
            return result;
        }

        private static bool IsFizz(int input)
        {
            return input % 3 == 0;
        }

        private static bool IsBuzz(int input)
        {
            return input % 5 == 0;
        }
    }
}
