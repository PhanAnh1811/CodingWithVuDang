using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region Create Instance
            IntNode node = new IntNode(50);
            IntNode nodeX = new IntNode(5);
            MyLinkedList list = new MyLinkedList();
            #endregion

            #region Implement LinkedList
            list.AddFirst(node);
            list.AddLast(node);     
            list.Input();
            list.ShowList();
            Console.WriteLine();

            if (list.FindX(nodeX))
                Console.WriteLine("Find X in List");
            else
                Console.WriteLine("Not find X in List");
            IntNode x = list.GetMax();
            IntNode y = list.GetMin();
            Console.WriteLine("Max Node: " + x.Data);
            Console.WriteLine("Min Node: " + y.Data);

            Console.WriteLine("Even node in List");
            list.GetEvenList();
            Console.WriteLine("Odd node in List");
            list.GetOddList();

            list.SortNode();
            Console.WriteLine("List have been sorted");
            list.ShowList();
            Console.WriteLine();

            list.RemoveAtPos(3);
            Console.WriteLine("After remove at positon from list");
            list.ShowList();
            Console.WriteLine();

            list.RemoveX(5);
            Console.WriteLine("After remove X from list");
            list.ShowList();
            Console.WriteLine();

            list.InsertAt(3, 10);
            Console.WriteLine("Insert new node at pos with the value X in list");
            list.ShowList();
            Console.WriteLine();

            list.InsertAfterMin(4);
            Console.WriteLine("Insert new node after min node");
            list.ShowList();
            Console.WriteLine();

            list.InsertBeforeMax(65);
            Console.WriteLine("Insert new node before max node");
            list.ShowList();
            Console.WriteLine();

            list.InsertXAfterY(99, 30);
            Console.WriteLine("Insert new node after Y");
            list.ShowList();
            Console.WriteLine();

            list.InsertXBeforeY(99, 30);
            Console.WriteLine("Insert new node after Y");
            list.ShowList();
            Console.WriteLine();
            #endregion
        }
    }
}
