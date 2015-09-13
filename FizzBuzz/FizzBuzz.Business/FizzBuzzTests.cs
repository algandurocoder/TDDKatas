using NUnit.Framework;
using System;

namespace FizzBuzz.Business
{
    [TestFixture]
    class FizzBuzzTests
    {
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        public void TestTransform(Int32 input, string expected)
        {
            string result = FizzBuzzEngine.Transform(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        
    }
}
