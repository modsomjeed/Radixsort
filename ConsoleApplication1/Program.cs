using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree t = new BinaryTree();
            object z = t.toArray(BinaryTree.Traversal.Inorder);
            Console.WriteLine( ( (int [] ) z) [0]);
            Console.Read();
        }
    }
    class BinaryTree
    {
        public class Traversal
        {
            public const int Inorder = 1;
            public const int Preorder = 2;
            public const int Postorder = 3;
        }
        public object toArray(int i)
        {
            int[] x1 = new int[] { 1, 2, 3 };
            int[] x2 = new int[] { 2, 3, 4 };
            int[] x3 = new int[] { 3, 4, 5 };
            switch (i)
            { 
                case 1:
                    return x1;
                    break;
                case 2:
                    return x2;
                    break;
                case 3:
                    return x3;
                    break;
                default:
                    Console.WriteLine("Error");
                    return null;
                    break;
;            }
        }
    }
}
