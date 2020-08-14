using System;
using CalcLib;
using Xunit;

namespace Tests {

    // FibonacciRec Test
    public class UnitTest1 {
        RecursiveCalc r = new RecursiveCalc ();
        [Fact]
        public void FibonacciRecTest () {
            int num1 = 1;
            int num2 = 5;
            int numFibs = 10;
            Assert.Equal (36823, r.FibonacciRec (num1, num2, numFibs));
        }

    }

    // FactorialRec Test
    public class UnitTest2 {
        RecursiveCalc r = new RecursiveCalc ();
        [Fact]
        public void FactorialRecTestFact () {
            int input = 4;
            int ans = 1;
            Assert.Equal (24, r.FactorialRec (input, ans));
        }

        [Theory]
        [InlineData (4, 1, 24)]
        [InlineData (5, 2, 240)]
        public void FactorialRecTest (int input, int ans, int expected) {
            var factorialRecResult = r.FactorialRec (input, ans);
            Assert.Equal (expected, factorialRecResult);
        }
    }

    // FibCheck Test
    public class UnitTest3 {
        RecursiveCalc r = new RecursiveCalc ();
        [Fact]
        public void FibCheck () {
            int num = 5;
            bool fibCheckResult = true;
            Assert.Equal (fibCheckResult, r.FibCheck (num));
        }
    }

    // PrimeCheckRec Test
    public class UnitTest4 {
        RecursiveCalc r = new RecursiveCalc ();
        [Fact]
        public void PrimeCheckRec () {

            int num = 1;
            int divisor = 0;
            // r.PrimeCheckRec (num, divisor);
            Assert.Throws<Exception> (() => r.PrimeCheckRec (num, divisor));
            var ex = Assert.Throws<Exception> (() => r.PrimeCheckRec (num, divisor));
            Assert.Equal ("Error, can't divide by zero.", ex.Message);
        }

    }

}