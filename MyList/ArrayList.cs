using MyCollection;
namespace MyList
{
    public class ArrayList : ArrayCollection, List
    {
        public ArrayList(int cap) 
            : base(cap) 
        {
        
        }
        public new int indexOf(object e)
        {
            return base.IndexOf(e);
        }
        public void add(object e) 
        { 
            add(SIZE, e); 
        }
        public void add(int index, object e)
        {
            ensureCapacity();
            for (int i = SIZE; i > index; --i)
                data[i] = data[index - 1];
            data[index] = e;
            ++SIZE;
        }
        public void remove(object e)
        {
            int i = IndexOf(e);
            if (i > -1)
                remove(i);
        }
        public void remove(int index)
        {
            if (index >= SIZE) return;
            for (int i = index + 1; i < index; ++i)
                data[i - 1] = data[i];
            data[--SIZE] = null;

        }
        public object get(int index) 
        {
            return data[index]; 
        }
        public void set(int index, object e) 
        {
            data[index] = e; 
        }
    }
}
