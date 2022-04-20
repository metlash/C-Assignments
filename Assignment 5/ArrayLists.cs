using System;

namespace Assignment
{
    class EmpMan
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeSalaray { get; set; }
    }

    internal class ArrayLists
    {

        public static void Main(String[] args)
        {
            ArrayList employees = new ArrayList()
        {
            new EmpMan { EmployeeId = 11, EmployeeName = "Manoj" , EmployeeSalaray = 50000 },
            new EmpMan { EmployeeId = 12, EmployeeName = "Krishna" , EmployeeSalaray = 2000 },
            new EmpMan { EmployeeId = 13, EmployeeName = "Gokul" , EmployeeSalaray = 10000 },
            new EmpMan { EmployeeId = 14, EmployeeName = "Hari" , EmployeeSalaray = 15000 }
        };

            foreach (EmpMan employee in employees)
            {
                Console.WriteLine(employee.EmployeeId + " " + employee.EmployeeName + " " + employee.EmployeeSalaray);
            }

            Console.ReadKey();
        }

    }
}