using System;
using System.Linq;

namespace WebAPITest.Patterns.StrategyPattern
{
    public class Collection
    {
        protected int[] elements;
        protected ISortStrategy sortStrategy;

        public Collection(int[] elements) {
            this.elements = elements;
            this.sortStrategy = null;
        }

        public void SetSortStrategy(ISortStrategy sortStrategy) {
            this.sortStrategy = sortStrategy;
        }

        public void sort()
        {
            if (this.sortStrategy != null) {
                this.sortStrategy.Sort(ref this.elements);
            }
        }

        public override String ToString()
        {
            return "[" + string.Join(
                ", ", 
                this.elements.Select(
                    item => item.ToString()
                ).ToArray()
            ) + "]";
        }

        //...
    }
}