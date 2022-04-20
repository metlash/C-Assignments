using System;

namespace Program
{
    class Param
    {

        // method for sum of elements in an array 
        static int sum(int[] arr)
        {
            // initialize sum
            int sum = 0;

            int n = arr.Length;

            // Iterate through all elements and add them to sum
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }              
            return sum;
        }

        // Driver method
        public static void Main()
        {

            int[] arr = { 10, 78, 45, 20, 58 };

            Console.Write("Sum of given array is "  + sum(arr));
            Console.ReadKey();
        }

    }
}
