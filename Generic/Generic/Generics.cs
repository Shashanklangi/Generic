using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class MaxNumber<R> where R : IComparable
    {
        public R[] value;

        public MaxNumber(R[] value)
        {
            this.value = value;
        }
        public R[] Sort(R[] values)
        {
            Array.Sort(values);
            return values;
        }
        public R MaxValue(params R[] values)
        {
            var SortedValues = Sort(values);
            return SortedValues[^1];
        }
        public R MaxMethod()
        {
            var Max = MaxValue(this.value);
            return Max;
        }
        public void PrintMax()
        {
            var Max = MaxValue(this.value);
            Console.WriteLine("Maximum value is " + Max);
        }
    }
}
