namespace Linq
{
    public static class AggregateFunc
    {
        public static void AggregateFuncSum()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            var result = numbers.Aggregate((a, b) => a + b);
            Console.WriteLine(result);
        }
    }
}