using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class IntNode
    {
        private int data;
        private IntNode nodeNext = null;
        
        public int Data { get => data; set => data = value; }
        public IntNode NodeNext { get => nodeNext; set => nodeNext = value; }
        public IntNode() { }
        public IntNode(int x = 0)
        {
            Data = x;
            NodeNext = null;
        }
    }
}
