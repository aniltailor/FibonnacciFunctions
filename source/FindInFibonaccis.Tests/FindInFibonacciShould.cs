using FibonacciService;
using NUnit.Framework;
using FluentAssertions;
namespace FindInFibonacci.Tests
{
    public class FindInFibonacciShould
    {
        private IFindInFibonacciService _findInFibonacciService;
       
        [SetUp]
        public void Setup()
        {
            _findInFibonacciService = new FindInFibonacciService();
        }

        [TestCase(0,"0")]
        [TestCase(6, "5 3 8")]
        [TestCase(20, "21 13 34")]
        [TestCase(88, "89 55 144")]
        [TestCase(-1, "0")]
        public void ReturnExpectedFibonacciNumberGivenAnInteger(int integerForSearch, string expectedResult)
        {
            var result = _findInFibonacciService.FindFibonacciNumbers(integerForSearch);
            result.Should().Be(expectedResult, "Should find nearest Fibonacci number and its closest neighbours");
        }
    }
}