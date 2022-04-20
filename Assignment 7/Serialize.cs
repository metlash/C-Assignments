using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace BinarySerializationProject
{

    public class Employee
    {
        public int Id = 11;
        public string Name = "Manoj";
        public string Designation = "Associate";

    }
    public class Manager
    {
        public int Id = 21;
        public String Name = "Krishna";
        public double BasicPayScale = 25000;

    }
    public class MarketingExecutive
    {
        public int ExecId = 31;
        public String ExecName = "Hari";
        public String ExecDesignation = "sales";

    }
    internal class Serialize
    {
        static void Main(String[] args)
        {
            //Serializing Manager Object
            Manager manager = new Manager();
            FileStream fileStream = new FileStream(@"c:\Serialization1.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, manager);
            Console.ReadKey();

            //Serializing Employee Object
            Employee employee = new Employee();
            FileStream fileStream1 = new FileStream(@"c:\Serialization2.txt", FileMode.Create);
            BinaryFormatter formatter1 = new BinaryFormatter();
            formatter1.Serialize(fileStream, employee);
            Console.ReadKey();

            //Serializing MarketingExecutive Object
            MarketingExecutive marketingExecutive = new MarketingExecutive();
            FileStream fileStream2 = new FileStream(@"c:\Serialization3.txt", FileMode.Create);
            BinaryFormatter formatter2 = new BinaryFormatter();
            formatter2.Serialize(fileStream2, marketingExecutive);
            Console.ReadKey();

        }
    }
}