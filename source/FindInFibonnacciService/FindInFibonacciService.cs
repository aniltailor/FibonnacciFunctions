using System;

namespace FibonacciService
{
    public class FindInFibonacciService : IFindInFibonacciService
    {
        public string FindFibonacciNumbers(int integerForSearch)
        {
            return FindClosetFibonnacciNumbers(integerForSearch);
        }

        private static string FindClosetFibonnacciNumbers(int searchForNumber)
        {
            if (searchForNumber == 0)
            {
                return "0";
            }

            var firstFibonacciNumber = 0;
            var secondFibonacciNumber = 1;
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
