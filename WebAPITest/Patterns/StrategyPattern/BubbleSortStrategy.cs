namespace WebAPITest.Patterns.StrategyPattern
{
    public class BubbleSortStrategy : SortStrategy
    {
        public void sort(ref int[] elements) {
            var size = elements.Length;
            bool swapped;
            do {
                swapped = false;
                for (int i = 0; i < size - 1; i++) {
                    if (elements[i] > elements[i + 1]) {
                        this.swap(ref elements[i], ref elements[i + 1]);
                        swapped = true;
                    }
                }
                size--;
            } while (swapped);
        }

        protected void swap(ref int a, ref int b) {
            var tmp = a;
            a = b;
            b = tmp;
        }
    }
}