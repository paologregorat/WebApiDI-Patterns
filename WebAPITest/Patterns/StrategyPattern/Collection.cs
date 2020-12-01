using System;
using System.Linq;

namespace WebAPITest.Patterns.StrategyPattern
{
    public class Collection
    {
        protected int[] elements;
        protected SortStrategy sortStrategy;

        public Collection(int[] elements) {
            this.elements = elements;
            this.sortStrategy = null;
        }

        public void setSortStrategy(SortStrategy sortStrategy) {
            this.sortStrategy = sortStrategy;
        }

        public void sort()
        {
            if (this.sortStrategy != null) {
                this.sortStrategy.sort(ref this.elements);
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