using System;
using System.Globalization;

namespace FibonacciService
{
    public class FindInFibonacciService : IFindInFibonacciService
    {
        public string FindFibonacciNumbers(string integerForSearch)
        {
            long.TryParse(integerForSearch, out long searchForNumber);
            return FindClosetFibonnacciNumbers(searchForNumber);

        }

        private static string FindClosetFibonnacciNumbers(long searchForNumber)
        {
            if (searchForNumber <= 0)
            {
                return "0";
            }

            long firstFibonacciNumber = 0;
            long secondFibonacciNumber = 1;
            var thirdFibonacciNumber = secondFibonacciNumber;
            while (thirdFibonacciNumber <= searchForNumber)
            {
                firstFibonacciNumber = secondFibonacciNumber;
                secondFibonacciNumber = thirdFibonacciNumber;
                thirdFibonacciNumber = firstFibonacciNumber + secondFibonacciNumber;
            }
            var closestNumber = (Math.Abs(thirdFibonacciNumber - searchForNumber) >=
                                 Math.Abs(secondFibonacciNumber - searchForNumber)) ?
                secondFibonacciNumber : thirdFibonacciNumber;

            return closestNumber == thirdFibonacciNumber ?
                $"{thirdFibonacciNumber} {secondFibonacciNumber} {secondFibonacciNumber + thirdFibonacciNumber}" :
                $"{secondFibonacciNumber} {firstFibonacciNumber} {thirdFibonacciNumber}";
        }
    }
}
