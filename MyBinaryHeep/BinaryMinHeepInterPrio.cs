﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyQueue;
using MyPriorityQueue;

namespace MyBinaryHeap
{
    class BinaryMinHeapInterPriority : Queue
    {
        protected object[] data;
        private int SIZE;
        private int cap;
        public BinaryMinHeapInterPriority(int cap)
        {
            data = new object[cap];
            this.cap = cap;
        }
        public bool isEmpty()
        {
            return SIZE == 0;
        }
        public int size()
        {
            return SIZE;
        }
        public object peek()
        {
            if (isEmpty())
                throw new System.MissingMemberException();
            return data[0];
        }
        public void enqueue(object e)
        {
            ensureCapacity();
            data[SIZE] = e;
            reorderUp(SIZE++);
        }
        public object dequeue()
        {
            object max = peek();
            data[0] = data[--SIZE];//ลบค่า sIZE ก่อนแล้วนำข้อมูลตัวที่ SIZE-1 มาใช้
            data[SIZE] = null; //ให้ข้อมูลตำแหน่งที่ SIZE เท่ากับ null
            if (SIZE > 1) reorderDown(0);
            return max;
        }
        private void reorderDown(int k)
        {
            int c;
            while ((c = 2 * k + 1) < SIZE)//มีลูกทางซ้าย
            {
                if (c + 1 < SIZE /*มีลูกทางขวาไหม*/ && isLesserThan(c + 1, c))
                    c++;
                if (!isLesserThan(c, k))
                    break;
                swap(k, c);
                k = c;
            }
        }
        private void reorderUp(int k)
        {
            while (k > 0)
            {
                int p = (k - 1) / 2;
                if (!isLesserThan(k, p))
                    break;
                swap(k, p);
                k = p;
            }
        }
        private void swap(int i, int j)
        {
            object temp = data[i];
            data[i] = data[j];
            data[j] = temp;
        }
        protected virtual bool isLesserThan(int i, int j)
        {
            return ((IComparable)data[i]).CompareTo(data[j]) < 0;
        }
        private void ensureCapacity()
        {
            object[] tempdata;
            if (SIZE + 1 > data.Length)
                tempdata = new object[2 * data.Length + 1];
            else if (data.Length > cap && data.Length > 2 * SIZE)
                tempdata = new object[data.Length / 2 + 1];
            else return;
            for (int i = 0; i < SIZE; i++)
                tempdata[i] = data[data.Length - SIZE + i];
            data = tempdata;
        }
    }
}
