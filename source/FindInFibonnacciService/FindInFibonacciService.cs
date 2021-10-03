namespace FibonacciService
{
    public class FindInFibonacciService : IFindInFibonacciService
    {
        public string FindFibonacciNumbers(int integerForSearch)
        {
            return integerForSearch.ToString();
        }
    }
}
