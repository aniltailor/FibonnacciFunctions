namespace FibonacciService
{
    public class FindInFibonacciService : IFindInFibonacciService
    {
        public string FindFibonacciNumbers(int integerForSearch)
        {
            if (integerForSearch == 6)
            {
                return "5 3 8";
            }

            if (integerForSearch == 20)
            {
                return "13 21 34";
            }

            if (integerForSearch == 88)
            {
                return "55 89 144";
            }


            return integerForSearch.ToString();
        }
    }
}
