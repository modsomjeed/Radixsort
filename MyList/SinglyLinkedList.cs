using MyCollection;
namespace MyList
{
    public class SinglyLinkedList : LinkedCollectionWithHeader, List
    {
        public new bool contains(object e) { return indexOf(e) > -1; }
        private LinkedNode nodeAt(int index)
        {
            LinkedNode node = first;
            for (int i = -1; i < index; i++)
                node = node.next;
            return node;
        }
        public void add(int index, object e)
        {
            if (index <= SIZE)
            {
                LinkedNode node = nodeAt(index - 1);
                node.next = new LinkedNode(e, node.next);
                SIZE++;
            }
            else
                throw new System.IndexOutOfRangeException();
        }
        public new void add(object e) { add(SIZE, e); }
        private void removeAfter(LinkedNode node)
        {
            if (node.next != null)
            {
                node.next = node.next.next;
                SIZE--;
            }
        }
        public void remove(int index)
        {
            LinkedNode node = nodeAt(index - 1);
            removeAfter(node);
        }
        public new void remove(object e)
        {
            LinkedNode node = first;
            while (node.next != null && !node.next.e.Equals(e))
            {
                node = node.next;
            }
            removeAfter(node);
        }
        public void set(int index, object e) { nodeAt(index).e = e; }
        public object get(int index) { return nodeAt(index).e; }
        public int indexOf(object e)
        {
            for (int i = 0; i < SIZE; i++)
            {
                if (nodeAt(i).e.Equals(e)) { return i; }
            }
            return -1;
        }
    }
}
