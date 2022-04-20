using System;

namespace Custom
{
    internal class Stack
    {
        static readonly int MAX = 1000;
        int top;
        int[] stack = new int[MAX];

        public Stack()
        {
            top = -1;
        }

        bool IsEmpty()
        {
            return (top < 0);
        }

        public void Push(int values)
        {
            try
            {
                if (top >= MAX)
                {
                    throw new StackException();
                }

                stack[++top] = values;
            }
            catch (StackException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        internal int Pop()
        {
            try
            {
                if (top < 0)
                {
                    throw new StackException();
                    return -1;
                }

                int data = stack[top--];
                return data;
            }
            catch (StackException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
    
        }

        internal void DisplayStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are : ");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }


    internal class StackMain
    {
        static void Main(string[] args)
        {
            try
            {
                Stack stack = new Stack();

                stack.Push(100);
                stack.Push(50);
                stack.Push(120);
                stack.Push(10);

                stack.DisplayStack();
                Console.WriteLine("-------------------------");

                Console.WriteLine("Item popped from Stack : {0}", stack.Pop());

                Console.WriteLine("-------------------------");
                stack.DisplayStack();

                Console.ReadKey();
            }
            catch (IndexOutOfRangeException index)
            {
                Console.WriteLine("Handled IndexOutOfRangeException in the Main method");
            }
        }
    }
}