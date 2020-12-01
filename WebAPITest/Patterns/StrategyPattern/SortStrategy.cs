namespace WebAPITest.Patterns.StrategyPattern
{
    public interface ISortStrategy
    {
        void Sort(ref int[] elements);
    }
}