using System;
using MyCollection;

namespace CPE
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayCollection A = new ArrayCollection(10);
            A.add("A");
            A.add("B");
            A.add("C");
            A.add("D");
            A.add("E");
            A.add("F");
            A.remove("A");
            Console.ReadLine();
        }
    }
}
