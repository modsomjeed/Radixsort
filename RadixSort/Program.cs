using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyQueue;
namespace RadixSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[] { 1, 74, 234, 567, 10, 123, 183, 14, 55, 14, 9, 586, 111, 235, 19, 58, 11 };
            int Max = int.MinValue;
            for (int i = 0; i < number.Length; i++)
                if (number[i] > Max) Max = number[i];
            int d = 1, n = 0; // n คือจำนวนหลัก ที่มากที่สุด
            while (Max / d > 0) { n++; d *= 10; }

            Queue[] q = new ArrayQueue[10];
            for (int i = 0; i < q.Length; i++)
                q[i] = new ArrayQueue(10);

            for (int i = 0; i < number.Length; i++)
            {
                int n1 = number[i] / 1 % 10;
                q[n1].enqueue(number[i]);
            }
            int[] Size = new int[q.Length];
            for (int h = 0, div = 10; h < n - 1; h++, div *= 10)
            {
                for (int k = 0; k < q.Length; k++)
                    Size[k] = q[k].size();
                for (int i = 0; i < q.Length; i++)
                {

                    for (int j = 0; j < Size[i]; j++)
                    {
                        int N = Convert.ToInt32(q[i].peek()) / div % 10;
                        q[N].enqueue(q[i].dequeue());
                    }
                }
            }

            for (int i = 0; i < q.Length; i++)
            {
                int Size2 = q[i].size();
                for (int j = 0; j < Size2; j++)
                    Console.WriteLine(q[i].dequeue());
            }
            Console.ReadLine();

        }
    }
}
