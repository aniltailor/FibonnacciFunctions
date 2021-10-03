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

        [Test]
        public void ReturnExpectedFibonacciNumberGivenAnIntegerOf6()
        {
            const int integerForSearch = 6;
            const string expectedResult = "5 3 8";
            var result = _findInFibonacciService.FindFibonacciNumbers(integerForSearch);

            result.Should().Be(expectedResult,"Should find nearest Fibonacci number and its closest neighbours");
        }

        [Test]
        public void ReturnZeroGivenAnIntegerOf0()
        {
            const int integerForSearch = 0;
            const string expectedResult = "0";
            var result = _findInFibonacciService.FindFibonacciNumbers(integerForSearch);

            result.Should().Be(expectedResult, "Should find nearest Fibonacci number and its closest neighbours");
        }

    }
}