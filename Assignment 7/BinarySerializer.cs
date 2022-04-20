using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Assignment
{
    public class Manager
    {
        public int Id = 11;
        public string Name = "Manoj";
        public double BasicSalary = 25000;
    }


    internal class BinarySerializer
    {
        static void Main(string[] args)
        {
            //Binary Serialization
            Manager manager = new Manager();
            FileStream fileStream = new FileStream(@"c:\BinarySerialization.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, manager);
            Console.ReadKey();

            Manager m = (Manager)formatter.Deserialize(fileStream);
            Console.WriteLine(m.Id);
            Console.WriteLine(m.Name);
            Console.WriteLine(m.BasicSalary);
            Console.ReadKey();

        }
    }
}