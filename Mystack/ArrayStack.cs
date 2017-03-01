using System;
namespace MyStack
{
   public class ArrayStack : Stack
    {
        private object[] data;
        protected int SIZE;
        private int cap;
        public ArrayStack(int cap)
        {
            this.cap = cap;
            data = new object[cap];
        }
        public bool isEmpty() { return SIZE == 0; }
        public int size() { return SIZE; }
        public void push(object e)
        {
            ensureCapacity();
            data[SIZE++] = e;
        }

        public object peek()
        {
            if (isEmpty())
                throw new System.MissingMemberException();
            return data[SIZE - 1];
        }
        public object pop()
        {
            object e = peek();
            data[--SIZE] = null;
            return e;
        }
        private void ensureCapacity() { }
    }
}
