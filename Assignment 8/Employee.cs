using System;
using System.Collections.Generic;
using System.Reflection;

namespace Assignment
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int EmpId, string EmpName, double EmpSalary)
        {
            this.Id = EmpId;
            this.Name = EmpName;
            this.Salary = EmpSalary;
        }
        public void empDetails()
        {
            Console.WriteLine("Employee Id :" + Id);
            Console.WriteLine("Employee name :" + Name);
            Console.WriteLine("Employee Salary :" + Salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(2, "Manoj", 25000);

            Assembly executing = Assembly.GetExecutingAssembly();
            Type[] types = executing.GetTypes();
            emp.empDetails();
            foreach (var item in types)
            {
                Console.WriteLine(item.Name);
                MethodInfo[] mi = item.GetMethods();

                foreach (var method in mi)
                {
                    Console.WriteLine(method.Name);
                }
            }
            Console.ReadLine();
        }
    }
}