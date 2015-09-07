using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string result = FizzBuzzTransformer.Transform(input);
            Assert.AreEqual(expected, result);
        }

        
    }
}
