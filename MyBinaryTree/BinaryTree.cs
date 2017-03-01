using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBinaryTree
{
    public class BinaryTree
    {
        public class Node
        {
            public object e;
            public Node left, right;
            public Node(object e, Node left, Node right)
            {
                this.e = e;
                this.left = left;
                this.right = right;
            }
            public bool isLeaf()//ถามว่ามีใบไหม
            { return left == null && right == null; }
        }
        protected Node root;
        public int numNodes()//ถามว่ามีกี่ Node ไม่มีสูตรก็นับทีละตัวเลย
        {
            return numNodes(root);
        }
        public int depth()//ถามว่าลึกเท่าไหร่
        {
            return depth(root);
        }
        private int numNodes(Node node)//ฟังก์ชันเรียกตัวเอง //ลูปนี้จะหยุดเมื่อมันนับจนเลยใบไปแล้วนั่นเอง
        {
            if (node == null) return 0;
            return 1 + numNodes(node.left) + numNodes(node.right); 
        }
        private int depth(Node node)//ถามความลึก
        {
            if (node == null) return -1; //return -1 เพราะถ้าให้รีเทิน 0 แสดงว่ามีหนึ่ง node นะคิดดีๆ
            return 1 + Math.Max(depth(node.left), depth(node.right));//ใช้ Max เพื่อเปรียบเทียบว่าอันไหนมากกว่ากัน ให้เอาอันมากกว่ามาบวก 1 จะได้ความลึก
        }
        public object[] toArray()
        {
            int n = numNodes(root);
            object[] a = new object[n];
            toArrayPreorder(root, a, 0);
            return a;
        }
        private int toArrayPreorder(Node x, object[] a, int k) //ไม่ส่งออก อาร์เร เพราะตัวแปรอาร์เรเป็น reference type ส่งออกตัวเองอยู่แล้ว
        {
            if (x == null) return k;
            a[k++] = x.e;
            k = toArrayPreorder(x.left, a, k);
            k = toArrayPreorder(x.right, a, k);
            return k;
        }
    }
}

