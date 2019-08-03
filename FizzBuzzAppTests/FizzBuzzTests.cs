using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApp.Tests
{
    [TestClass()]
    public class FizzBuzzTests
    {
        [TestMethod()]
        public void NumberTest()
        {
            Assert.AreEqual("1", FizzBuzz.GetFizzBuzz(1));
            Assert.AreEqual("7", FizzBuzz.GetFizzBuzz(7));
            Assert.AreEqual("11", FizzBuzz.GetFizzBuzz(11));
            Assert.AreEqual("41", FizzBuzz.GetFizzBuzz(41));
        }

        [TestMethod()]
        public void FizzTest()
        {
            Assert.AreEqual("Fizz", FizzBuzz.GetFizzBuzz(3));
            Assert.AreEqual("Fizz", FizzBuzz.GetFizzBuzz(9));
            Assert.AreEqual("Fizz", FizzBuzz.GetFizzBuzz(27));
            Assert.AreEqual("Fizz", FizzBuzz.GetFizzBuzz(99));
        }

        [TestMethod()]
        public void BuzzTest()
        {
            Assert.AreEqual("Buzz", FizzBuzz.GetFizzBuzz(5));
            Assert.AreEqual("Buzz", FizzBuzz.GetFizzBuzz(10));
            Assert.AreEqual("Buzz", FizzBuzz.GetFizzBuzz(50));
            Assert.AreEqual("Buzz", FizzBuzz.GetFizzBuzz(80));
        }

        [TestMethod()]
        public void FizzBuzzTest()
        {
            Assert.AreEqual("FizzBuzz", FizzBuzz.GetFizzBuzz(15));
            Assert.AreEqual("FizzBuzz", FizzBuzz.GetFizzBuzz(30));
            Assert.AreEqual("FizzBuzz", FizzBuzz.GetFizzBuzz(60));
            Assert.AreEqual("FizzBuzz", FizzBuzz.GetFizzBuzz(90));
        }
    }
}