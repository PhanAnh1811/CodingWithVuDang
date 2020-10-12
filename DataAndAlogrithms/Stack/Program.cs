using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyStack
            //MyStack stack = new MyStack(5);
            //stack.Push("Phan");
            //stack.Push("Phan");
            //stack.Push("Phan");
            //stack.Push("Tuan");
            //stack.Push("Anh");
            //string outItem = stack.Pop();
            //Console.WriteLine(outItem);
            //Console.WriteLine(stack.Peek());
            //if (stack.IsEmpty()) 
            //    Console.WriteLine("Stack is empty");
            //else 
            //    Console.WriteLine("Stack is not empty");
            //stack.Clear();

            //if (stack.IsEmpty()) 
            //    Console.WriteLine("Stack is empty");
            //else 
            //    Console.WriteLine("Stack is not empty");

            //if (stack.IsFull()) Console.WriteLine("Stack is full");
            //else Console.WriteLine("Stack is not full");
            //string x = "Anh";
            //if (stack.Contains(x))
            //    Console.WriteLine("find x");
            //else
            //    Console.WriteLine("not find x");
            #endregion

            #region MyExpression
            MyExpressison myExpressison = new MyExpressison("a+b*(c^d-e)^(f+g*h)-i");
            string res = myExpressison.InfixToPostfix();
            Console.WriteLine(res);
            #endregion
        }
    }
}
