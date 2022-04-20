using System;

namespace Program
{
    class Average
    {
        public static void Main(String[] args)
        {
            //Variable Declaration
            int l = 5;
            double[] marks = new double[l];
            int i;
            double sum = 0, avg;


            Console.WriteLine("Enter the Marks");
           
            //Variable Initialization and Calculating Sum
            for (i = 0; i < l; i++)
            {            
                double mark = Convert.ToDouble(Console.ReadLine());
                marks[i] = mark;
                sum += mark;
            }

            // Calculating Average
            avg = sum / 5;

            //Calculating the highest mark

            double max = 0;
            for (i = 0; i < l; i++)
            {
                if(marks[i] >= max)
                {
                    max = marks[i];
                }

            }
            Console.WriteLine("The Average Mark of all Subjects are : " + avg);
            Console.WriteLine("The Highest Mark of all Subjects are : " + max);
            Console.ReadKey();
        }
    }
}