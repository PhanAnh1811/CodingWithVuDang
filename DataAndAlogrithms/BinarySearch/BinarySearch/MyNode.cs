using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace BinaryTree
{
    class MyNode
    {
        private int data;
        private MyNode nodeLeft = null;
        private MyNode nodeRight = null;

        public int Data { get => data; set => data = value; }
        public MyNode NodeLeft { get => nodeLeft; set => nodeLeft = value; }
        public MyNode NodeRight { get => nodeRight; set => nodeRight = value; }

        //Default Constructor
        public MyNode() { }
        
        //Parameter Constructor
        public MyNode(int x)
        {
            Data = x;
            NodeLeft = null;
            NodeRight = null;
        }

        public int FindTreeHeight()
        {
            return 1 + Math.Max(
                NodeLeft != null ? NodeLeft.FindTreeHeight() : 0,
                NodeRight != null ? NodeRight.FindTreeHeight() : 0
                );
        }
        public bool AddNodeToTree(int x)
        {
            if (x.CompareTo(Data) == 0)
                return false;
            if (x.CompareTo(Data) < 0)
            {
                if (NodeLeft == null)
                    NodeLeft = new MyNode(x);
                else
                    return NodeLeft.AddNodeToTree(x);
            }
            return true;
        }

        public void NLR()
        {
            Console.Write(Data + " -> ");
            if (NodeLeft != null)
                NodeLeft.NLR();
            if (NodeRight != null)
                NodeRight.NLR();
        }
        public void LNR()
        {
            if (NodeLeft != null)
                NodeLeft.LNR();
            Console.Write(Data + " -> ");
            if (NodeRight != null)
                NodeRight.LNR();
        }
        public void LRN()
        {
            if (NodeLeft != null)
                NodeLeft.LRN();
            if (nodeRight != null)
                NodeRight.LRN();
            Console.Write(Data + " -> ");
        }
        public MyNode SearchX(int x)
        {
            if (x.CompareTo(Data) == 0)
                return this;
            if (x.CompareTo(Data) < 0)
            {
                if (NodeLeft == null)
                    return null;
                return NodeLeft.SearchX(x);
            }
            else
            {
                if (NodeRight == null)
                    return null;
                return NodeRight.SearchX(x);
            }
        }
        public MyNode NodeRightMost()
        {
            if (NodeRight == null)
                return this;
            return NodeRight.NodeRightMost();
        }
        public MyNode NodeLeftMost()
        {
            if (NodeLeft == null)
                return this;
            return NodeLeft.NodeLeftMost();
        }
        public int MinNode()
        {
            if (NodeLeft == null)
                return Data;
            return NodeLeft.MinNode();
        }
        public bool RemoveX(int x,MyNode parent)
        {
            if (x.CompareTo(Data) < 0)
            {
                if (NodeLeft != null)
                    return NodeLeft.RemoveX(x, this);
                else
                    return false;
            }
            else if (x.CompareTo(Data) > 0)
            {
                if (NodeRight != null)
                    return NodeRight.RemoveX(x, this);
                else
                    return false;
            }
            else
            {
                if (NodeLeft != null && NodeRight != null)
                {
                    this.Data = NodeRight.MinNode();
                    NodeRight.RemoveX(this.Data, this);
                }
                else if (parent.NodeLeft == this)
                    parent.NodeLeft = (NodeLeft != null) ? NodeLeft : NodeRight;
                else if (parent.NodeRight == this)
                    parent.NodeRight = (NodeLeft != null) ? NodeLeft : NodeRight; 
            }
            return true;
        }
    }
}
