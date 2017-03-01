﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBinaryHeap;


namespace MyBinaryTree
{
    public class HuffmanTree : BinaryTree, IComparable
    {
        public HuffmanTree(int f, Node left, Node right)
        { root = new Node(f, left, right); }
        public int CompareTo(object x)
        { return Frequency() - ((HuffmanTree)x).Frequency(); }
        public int Frequency()
        { return (int)root.e; }
        public static HuffmanTree encode(int[] f)
        {
            BinaryMinHeapInterBinary h = new BinaryMinHeapInterBinary(0);
            for (int i = 0; i < f.Length; i++)
                h.enqueue(new HuffmanTree(f[i], null, null));
            for (int i = 0; i < f.Length - 1; i++)
            {
                HuffmanTree t1 = (HuffmanTree)h.dequeue();
                HuffmanTree t2 = (HuffmanTree)h.dequeue();
                int sumf = t1.Frequency() + t2.Frequency();
                h.enqueue(new HuffmanTree(sumf, t1.root, t2.root));
            }
            return (HuffmanTree)h.dequeue();
        }
    }

}
