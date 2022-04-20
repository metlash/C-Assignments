using System;

namespace Organization
{
    internal class LitwareLib
    {
        static void Main(string[] args)
        {
            // Creating Object of Employee Class
            Employee employee = new Employee();

            Console.WriteLine("Enter Employee Number : ");
            employee.SetEmpNo(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Enter Employee Name : ");
            employee.SetEmpName(Console.ReadLine());


            Console.WriteLine("Enter Employee Salary: ");
            employee.SetSalary(Convert.ToDouble(Console.ReadLine()));

            // Method Calling
            employee.calculateSalary(employee);

            // Display Output
            Console.WriteLine("Emp no:" + employee.GetEmpNo());
            Console.WriteLine("Name:" + employee.GetEmpName());
            Console.WriteLine("Salary :" + employee.GetSalary());
            Console.WriteLine("Gross Salary :" + employee.GetGrossSalary());

            Console.ReadKey();

        }
    }
}