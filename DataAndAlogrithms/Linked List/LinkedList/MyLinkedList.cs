using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class MyLinkedList
    {
        private IntNode first = null;
        private IntNode last = null;
        private int length;


        public IntNode First { get => first; set => first = value; }
        public IntNode Last { get => last; set => last = value; }
        public int Length { get => length; set => length = value; }

        public int Count
        {
            get => Length;
        }

        public bool IsEmty()
        {
            return First == null;
        }

        public void AddFirst(IntNode newNode)
        {
            if (IsEmty())
                First = Last = newNode;
            else
            {
                newNode.NodeNext = First;
                First = newNode; 
            }
        }

        public void AddLast(IntNode newNode)
        {
            if (IsEmty())
                Last = First = newNode;
            else
            {
                Last.NodeNext=newNode;
                Last = newNode;
            }
        }

        public void Input()
        {
            int x;
            do
            {
                Console.Write("Enter new node (-1 exit): ");
                x = int.Parse(Console.ReadLine());
                if (x < 0)
                    break;
                else
                {
                    IntNode newNode = new IntNode(x);
                    Length++;
                    //AddFirst(newNode);//if you want to reverse list
                    AddLast(newNode);
                }
            } while (true);
        }

        public void ShowList()
        {
            IntNode p = First;
            while (p != null)
            {
                Console.Write(p.Data + " -> ");
                p = p.NodeNext;
            }
            Console.Write("NULL");
        }

        public bool FindX(IntNode x)
        {
            for(IntNode temp = First; temp != null; temp = temp.NodeNext)
            {
                if (temp.Data == x.Data)
                    return true;
            }
            return false;
        }

        public IntNode GetMax()
        {
            IntNode maxNode = new IntNode();
            maxNode = First;
            for(IntNode pointer = First; pointer != null; pointer = pointer.NodeNext)
            {
                if (pointer.Data >= maxNode.Data)
                    maxNode = pointer;
            }
            return maxNode;
        }

        public IntNode GetMin()
        {
            IntNode minNode = new IntNode();
            minNode = First;
            for (IntNode pointer = First; pointer != null; pointer = pointer.NodeNext)
            {
                if (pointer.Data <= minNode.Data)
                    minNode = pointer;
            }
            return minNode;
        }

        public void GetEvenList()
        {
            for(IntNode pointer = First; pointer != null; pointer = pointer.NodeNext)
            {
                if (pointer.Data % 2 == 0)
                    Console.Write(pointer.Data + " -> ");
            }
            Console.WriteLine("NULL");
        }

        public void GetOddList()
        {
            for(IntNode pointer = First; pointer != null; pointer = pointer.NodeNext)
            {
                if (pointer.Data % 2 != 0)
                    Console.Write(pointer.Data + " -> ");
            }
            Console.WriteLine("NULL");
        }

        public void SortNode()
        {
            for(IntNode i = first; i != null; i = i.NodeNext)
            {
                for(IntNode j = i.NodeNext; j != null; j = j.NodeNext)
                {
                    if (i.Data > j.Data)
                    {
                        int temp = i.Data;
                        i.Data = j.Data;
                        j.Data = temp;
                    }
                }
            }    
            
        }

        public void RemoveAtPos(int pos)
        {
            IntNode head = First;
            if (head == null)
                return;
            IntNode temp = head;
            if (pos == 0)
            {
                head = temp.NodeNext;
                return;
            }
            for(int i=0;temp!=null&&i<pos-1; i++)
            {
                temp = temp.NodeNext;
            }
            if (temp == null || temp.NodeNext == null)
                return;
            IntNode next = temp.NodeNext.NodeNext;
            temp.NodeNext = next;
        }

        public void RemoveX(int x)
        {
            IntNode temp = First, prev = null;
            if (temp != null && temp.Data == x)
            {
                First = temp.NodeNext;
                return;
            }
            while (temp != null && temp.Data != x)
            {
                prev = temp;
                temp = temp.NodeNext;
            }
            if (temp == null)
                return;
            prev.NodeNext = temp.NodeNext;
        }

        public void InsertAt(int pos,int x)
        {
            IntNode node = new IntNode();
            node.Data = x;
            node.NodeNext = null;
            if (First == null)
            {
                if (pos != 0)
                    return;
                else
                    First = node;
            }
            if (first != null && pos == 0)
            {
                node.NodeNext = First;
                First = node;
                return;
            }
            IntNode previous = null;
            IntNode current = First;
            int i = 0;
            while (i < pos)
            {
                previous = current;
                current = current.NodeNext;
                if (current == null)
                    break;
                i++;
            }
            node.NodeNext = current;
            previous.NodeNext = node;
        }

        public void InsertAfterMin(int min)
        {
            IntNode temp = GetMin();
            IntNode x = temp.NodeNext;
            IntNode nodeNeedInsert = new IntNode(min);
            temp.NodeNext = nodeNeedInsert;
            temp.NodeNext.NodeNext = x;
        }
        
        public void InsertBeforeMax(int max)
        {
            IntNode maxNode = GetMax();
            IntNode prev = null;
            IntNode head = First;
            IntNode newNode = new IntNode(max);

            bool flag = false;
            while (head.Data != maxNode.Data)
            {
                flag = true;
                prev = head;
                head = head.NodeNext;
            }
            if (flag)
            {
                prev.NodeNext = newNode;
                prev.NodeNext.NodeNext = head;
            }
            else
                AddFirst(newNode);
        }
        
        public void InsertXAfterY(int x,int y)
        {
            // 9 2 5 3 10
            // insert x sau y
            int pos = 0;
            for(IntNode temp = First; temp != null; temp = temp.NodeNext)
            {
                pos++;
                if (temp.Data == y)
                    break;                
            }
            InsertAt(pos , x);
        }
        public void InsertXBeforeY(int x,int y)
        {
            int pos = 0;
            for (IntNode temp = First; temp != null; temp = temp.NodeNext)
            {
                pos++;
                if (temp.Data == y)
                    break;
            }
            InsertAt(pos-1, x);
        }
    }
}
