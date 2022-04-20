using System;

namespace Program
{
    class Calculator
    {
        public static void Main(string[] args)
        {
            //Variable Declaration
            int operation;
            int a, b;

            //Variable Initialization
            Console.WriteLine("Enter 1 for Addition");
            Console.WriteLine("Enter 2 for Subtraction");
            Console.WriteLine("Enter 3 for Multiplication");
            Console.WriteLine("Enter 4 for Division");
            operation = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of a : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of b : ");
            b = Convert.ToInt32(Console.ReadLine());
           
            switch(operation)
            {
                case 1:
                    Console.WriteLine("The sum of two numbers are : " + (a + b));
                    break;
                case 2:
                    Console.WriteLine("The difference of two numbers are : " + (a - b));
                    break;
                case 3:
                    Console.WriteLine("The multiplication of two numbers are :" + (a * b));
                    break;
                case 4:
                    Console.WriteLine("The division of two numbers are : " + (a / b));
                    break;
                default:
                    Console.WriteLine("Invalid Operation");
                    break;
            }            
            Console.ReadKey();
        }
    }
}