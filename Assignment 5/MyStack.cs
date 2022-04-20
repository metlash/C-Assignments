using System;
using System.Collections;

namespace Assignment
{
    internal class MyStack
    {
        public static void Main(String[] args)
        {
            Stack myStack = new Stack();
           
            myStack.Push("11");
            myStack.Push("Manoj");
            myStack.Push("50000");

           
            Console.WriteLine("Employee Details: ");
            foreach (Object obj in myStack)
            {
                Console.WriteLine(obj);
            }
            myStack.Pop();
            Console.WriteLine("\n Employee Details after Pop Operations:");
            foreach (Object obj in myStack)
            {
                Console.WriteLine(obj);
            }
            Console.ReadLine();
        }
    }
}