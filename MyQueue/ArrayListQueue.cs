using MyList;
using MyCollection;
namespace MyQueue
{
    public class ArrayListQueue : Queue
    {

        private List list;
        public ArrayListQueue(int cap)
        {
            list = new ArrayList(cap);
        }
        public bool isEmpty() { return list.isEmpty(); }
        public int size() { return list.size(); }
        public void enqueue(object e)
        {
            list.add(e);
        }
        public object dequeue()
        {
            object e = peek();
            list.remove(0);
            return e;
        }
        public object peek()
        {
            if (isEmpty()) throw new System.MissingMemberException();
            return list.get(0);

        }
    }
}
