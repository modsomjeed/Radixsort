namespace MyCollection
{
    public class LinkedCollectionWithoutHeader : Collection
    {
        public int SIZE;
        protected LinkedNode first = new LinkedNode(null, null);
        protected class LinkedNode
        {
            public object e;
            public LinkedNode next;
            public LinkedNode(object e, LinkedNode next)
            {
                this.e = e;
                this.next = next;
            }
        }

        public bool isEmpty() { return size() == 0; }
        public int size() { return SIZE; }
        public void add(object e)
        {
            first = new LinkedNode(e, first);
            SIZE++;
        }

        public void remove(object e)
        {
            if (first == null) return;
            if (first.e.Equals(e))
            {
                first = first.next;
                SIZE--;
                return;
            }
            LinkedNode node = first;
            while (node != null)
            {
                if (node.next.e.Equals(e))
                {
                    node.next = node.next.next;
                    SIZE--;
                    return;
                }
                node = node.next;
            }
        }
        public bool contains(object e)
        {
            LinkedNode node = first;
            while (node != null)
            {
                if (node.e.Equals(e)) return true;
                node = node.next;
            }
            return false;
        }
    }
}
