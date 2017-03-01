using MyCollection;
namespace MyList
{
    public class DoublyLinkedList : LinkedCollectionWithoutHeader, List
    {
        private new LinkedNode first = new LinkedNode(null, null, null);
        private new class LinkedNode
        {
            public LinkedNode back;
            public LinkedNode next;
            public object e;
            public LinkedNode(object e, LinkedNode back, LinkedNode next)
            {
                this.e = e;
                this.back = back;
                this.next = next;
            }
        }
        public DoublyLinkedList()
        {
            first.back = first.next = first;
        }
        private void addBefore(LinkedNode node, object e)
        {
            LinkedNode before = node.back;
            LinkedNode here = new LinkedNode(e, before, node);
            before.next = node.back = here;
            SIZE++;
        }
        private LinkedNode nodeAt(int index)
        {
            LinkedNode node = first;
            for (int i = -1; i < index; i++)
                node = node.next;
            return node;
        }
        public void add(int index, object e) { addBefore(nodeAt(index), e); }
        public new void add(object e) { addBefore(first, e); }
        private void removeNode(LinkedNode node)
        {
            LinkedNode before = node.back;
            LinkedNode after = node.next;
            before.next = after;
            after.back = before;
            SIZE--;
        }
        public void remove(int index) { removeNode(nodeAt(index)); }
        public new void remove(object e)
        {
            LinkedNode node = first.next;
            while (node != first)
            {
                if (node.e.Equals(e))
                {
                    removeNode(node);
                    break;
                }
                node = node.next;
            }
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
        public new bool contains(object e)
        {
            return indexOf(e) > -1;
        }
    }
}
