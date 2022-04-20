using System;

namespace Assignment
{
    internal class GeneriClass
    {
        public static void Main(String[] args)
        {
            List<string> emp = new List<string>();

            emp.Add("Manoj");
            emp.Add("Krishna");
            emp.Add("Hari");
            emp.Add("Gokul");

            Console.WriteLine("Employee Details are : ");
            foreach (var value in emp)
            {
                Console.WriteLine(value);
            }
                

            Console.WriteLine("\nTotal number of Employes are: " + empl.Count);
            Console.ReadLine();
        }
    }
}