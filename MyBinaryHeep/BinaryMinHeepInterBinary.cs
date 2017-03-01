using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBinaryHeap
{
    public class BinaryMinHeapInterBinary : BinaryHeap
    {
        public BinaryMinHeapInterBinary(int cap)
            : base(cap)
        {

        }
        protected override bool isGreaterThan(int i, int j)
        {
            return ((IComparable)data[i]).CompareTo(data[j]) < 0;
        }
    }
}
