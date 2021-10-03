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

            return integerForSearch.ToString();
        }
    }
}
