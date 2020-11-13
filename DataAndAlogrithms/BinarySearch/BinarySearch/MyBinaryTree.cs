using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class MyBinaryTree
    {
        MyNode root = null;
        private int height = 0;
        private int length = 0;

        public int Count { get => length + 1; }
        public int Height { get => height = HeightTree(); }
        
        public int LeafCount { get => CountLeaf(root); }
        public MyNode Root
        {
            get { return root; }
            set { root = value; }
        }

        public bool Insert(int x)
        {
            if (Root == null)
            {
                Root = new MyNode(x);
                return true;
            }
            else
            {
                if (Root.AddNodeToTree(x))
                {
                    length++;
                    return true;

                }
            }
            return false;
        }

        public void Input()
        {
            Console.Write("Enter number of nodes: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                bool flag = false;
                int x = int.Parse(Console.ReadLine());
                if (root == null)
                {
                    root = new MyNode(x);
                    flag = true;
                    continue;
                }
                else
                {
                    if (root.AddNodeToTree(x))
                    {
                        length++;
                        flag = true;
                    }
                }
            }

        }

        public void PreOrder()
        {
            if (root == null)
                return;
            root.NLR();
        }

        public void InOrder()
        {
            if (root == null)
                return;
            root.LNR();
        }

        public void PostOrder()
        {
            if (root == null)
                return;
            root.LRN();
        }

        public MyNode SearchNode(int x)
        {
            if (root == null)
                return null;
            return root.SearchX(x);
        }

        public MyNode MaxNode()
        {
            if (root == null)
                return null;
            return root.NodeRightMost();
        }

        public MyNode MinNode()
        {
            if (root == null)
                return null;
            return root.NodeLeftMost();
        }

        public bool Remove(int x)
        {
            if (root == null)
                return false;

            if (x.CompareTo(root.Data) == 0)
            {
                MyNode temp = new MyNode();
                temp.NodeLeft = root;
                bool res = root.RemoveX(x, temp);
                root = temp.NodeLeft;
                return res;
            }
            return root.RemoveX(x, null);
        }

        public int HeightTree()
        {
            return root.FindTreeHeight();
        }

        public int CountLeaf(MyNode node)
        {
            if (node == null)
                return 0;
            if (node.NodeLeft == null && node.NodeRight == null)
                return 1;
            else
                return CountLeaf(node.NodeLeft) + CountLeaf(node.NodeRight);
        }


        public int printGivenLevel(MyNode root, int level)
        {
            if (root == null)
                return 0;
            if (level == 1)
                Console.Write(root.Data + " ");
            else if (level > 1)
            {
                printGivenLevel(root.NodeLeft, level - 1);
                printGivenLevel(root.NodeRight, level - 1);
            }
            return 0;
        }

        public void ListByLevel()
        {
            int h = Height;
            int i;
            for (i = 1; i <= h; i++)
            {
                Console.Write("Level {0} -> Data: ", i);
                printGivenLevel(root, i);
                Console.WriteLine();

            }
        }

        public void ListLastLevel()
        {
            Console.Write("List Last Level: ");
            printGivenLevel(root, Height);
        }
    }
}
