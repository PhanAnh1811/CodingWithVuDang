using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class MyStack
    {
        private int stkMax;
        private int stkTop;
        private string[] stkArray;

        public MyStack(int maxItems = 0)
        {
            StkArray = new  string [maxItems];
            stkMax = maxItems;
            stkTop = -1;
        }

        public int StkMax { get => stkMax; set => stkMax = value; }
        public int StkTop { get => stkTop; set => stkTop = value; }
        public string[] StkArray { get => stkArray; set => stkArray = value; }
        public int Count { get => stkArray.Length; }
        public bool IsEmpty()
        {
            if (stkTop == -1) return true;
            return false;
        }
        public bool IsFull()
        {
            if (stkTop == stkMax - 1) return true;
            return false;
        }
        
        public bool Push(string newItems)
        {
            if (IsFull()) return false;
            stkTop++;
            stkArray[stkTop] = newItems;
            return true;
        }
        public string Pop()
        {
            if (IsEmpty()) return "Stack empty";
            string outItems = stkArray[stkTop];
            stkTop--;
            return outItems;
        }
        public string Peek()
        {
            return stkArray[stkTop-1];
        }
        public void Clear()
        {
            for (int i = 0; i < stkArray.Length; i++)
                Pop();
        }
        public bool Contains(string x)
        {
            if (IsEmpty()) return false;
            for (int i = 0; i < stkArray.Length; i++)
            {
                if (Peek() == x) return true;
            }
            return false;
        }
    }
}
