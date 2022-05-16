using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximumNumber
{
    internal class MaxMethodUsingGenerics<T> where T:IComparable
    {
        public T[] values;
        public MaxMethodUsingGenerics(T[]values)
        {
            this.values = values;
        }
        public T[] Sort(T[]values)
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValue(params T[] values)
        {
            var sortValue = Sort(values);
            var maxIndex = sortValue.Length - 1;
            var maxSortValue = sortValue[maxIndex];
            return maxSortValue;
        }
        public T MaxMethod()
        {
            var max = MaxValue(this.values);
            return max;
        }
        public void MaxPrint()
        {
            var max = MaxValue(this.values);
            Console.WriteLine(" The Maximum isn : " + max);
        }
    }
}
