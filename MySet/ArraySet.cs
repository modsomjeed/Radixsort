using MyCollection;

namespace MySet
{
    public class ArraySet : ArrayCollection, Set
    {
        public ArraySet(int cap) : base(cap) { }
        public new void Add(object e)
        {
            if (!contains(e))
                base.add(e);
        }
    }
}
