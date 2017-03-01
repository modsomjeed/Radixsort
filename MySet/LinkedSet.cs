using MyCollection;

namespace MySet
{
    public class LinkedSet : LinkedCollectionWithoutHeader,Set
    {
        public new void Add(object e)
        {
            if (!contains(e))
                base.add(e);
        }
    }
}
