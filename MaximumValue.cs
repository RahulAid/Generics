using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MaximumValue<T> where T : IComparable
    {
        public T[] Values;

        public MaximumValue(T[] Values)
        {
            this.Values = Values;
        }
        public T[] Sort(T[] Values)
        {
            Array.Sort(Values);
            return Values;
        }
        public T MaxValue(params T[] Values)
        {
            var sorted_Values = Sort(Values);
            return sorted_Values[^1];
        }
        public T MaxMethod()
        {
            var max = MaxValue(this.Values);
            return max;
        }
        public void PrintMaxValue()
        {
            var max = MaxValue(this.Values);
            Console.WriteLine("Maximum Value is : " + max);
        }
    }
}
