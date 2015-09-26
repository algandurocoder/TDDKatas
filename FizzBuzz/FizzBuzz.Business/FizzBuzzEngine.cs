using System;

namespace FizzBuzz.Business
{
    public class FizzBuzzEngine
    {
        public static string Transform(Int32 inputNumber)
        {
            string result = string.Empty;

            if (inputNumber % 3 == 0)
                result = "Fizz";
            
            if (inputNumber % 5 == 0)
                result += "Buzz";
            
            if( string.IsNullOrWhiteSpace(result))
                result = inputNumber.ToString();

            return result;
        }        
    }
}
