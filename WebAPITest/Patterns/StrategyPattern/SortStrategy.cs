namespace WebAPITest.Patterns.StrategyPattern
{
    public interface SortStrategy
    {
        void sort(ref int[] elements);
    }
}