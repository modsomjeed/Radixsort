namespace MyQueue
{
    public class ArrayQueue : Queue
    {
        private object[] data;
        private int SIZE;
        private int cap;
        private int firstindex;
        public ArrayQueue(int cap)
        {
            this.cap = cap;
            data = new object[cap];
        }
        public bool isEmpty() { return SIZE == 0; }
        public int size() { return SIZE; }
        /* public void enqueue(object e)
         {
             ensureCapacity();
             data[firstindex + SIZE++] = e;

         }*/
        public void enqueue(object e)
        {
            ensureCapacity();
            data[(firstindex + SIZE++) % data.Length] = e;
        }
        /*  public object dequeue() 
          {
              object e = peek();
              data[firstindex++] = null;
              SIZE--;
              return e;
          }*/
        public object dequeue()
        {
            object e = peek();
            data[firstindex] = null;
            firstindex = (firstindex + 1) % data.Length;
            SIZE--;
            return e;
        }
        public object peek()
        {
            if (isEmpty()) throw new System.MissingMemberException();
            return data[firstindex];
        }
        /* private void ensureCapacity() 
         {
             object[] tempdata;
             if (SIZE + 1 > data.Length)
                 tempdata = new object[data.Length * 2];
             else if (data.Length > cap && data.Length > 2 * SIZE)
                 tempdata = new object[data.Length / 2 + 1];
             else return;
             for (int i = 0; i < SIZE; i++)
                 tempdata[i] = data[i];
             firstindex = 0;
             data = tempdata;
         }*/
        private void ensureCapacity()
        {
            object[] tempdata;
            if (SIZE + 1 > data.Length)
                tempdata = new object[data.Length * 2];
            else if (data.Length > cap && data.Length > 2 * SIZE)
                tempdata = new object[data.Length / 2 + 1];
            else return;
            for (int i = 0; i < SIZE; i++)
                tempdata[i] = data[data.Length - SIZE + i];
            firstindex = 0;
            data = tempdata;
        }

    }
}
