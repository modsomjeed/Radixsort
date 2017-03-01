
namespace MyCollection
{
    public interface Collection
    {
         bool isEmpty();
         bool contains(object e);
         void add(object e);
        void remove(object e);
         int size();
    }
}
