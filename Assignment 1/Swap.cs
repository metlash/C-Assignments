using System;

namespace Program
{
    class Swap
    {
        public static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("Enter the First Number : ");
            a = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("Enter the Second Number : ");
            b = Convert.ToInt16(Console.ReadLine());

            Swap obj = new Swap();
            obj.swap(a, b);

            Console.Read();
        }

        void swap(int num1, int num2)
        {

            Console.WriteLine("--------- Before Swapping --------");

            Console.WriteLine("Number 1 : " + num1);
            Console.WriteLine("Number 2 : " + num2);

            int temp;

            temp = num1;
            num1 = num2;
            num2 = temp;


            Console.WriteLine("--------- After Swapping --------");

            Console.WriteLine("Number 1 : " + num1);
            Console.WriteLine("Number 2 : " + num2);

            Console.ReadKey();
        }

    }
}