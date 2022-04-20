using System;

namespace Organization
{
    internal class Employee
    {

        private int EmpNo;
        private string EmpName;
        private double Salary;
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        private double NetSalary;
        private double GrossSalary;

        public Employee()
        {
        }

        public int GetEmpNo()
        {
            return EmpNo;
        }
        public void SetEmpNo(int EmpNo)
        {
            this.EmpNo = EmpNo;
        }
        public string GetEmpName()
        {
            return EmpName;
        }
        public void SetEmpName(string EmpName)
        {
            this.EmpName = EmpName;
        }
        public double GetSalary()
        {
            return Salary;
        }
        public void SetSalary(double Salary)
        {
            this.Salary = Salary;
        }

        public double GetHra()
        {
            return HRA;
        }
        void SetHra(double HRA)
        {
            this.HRA = HRA;
        }
        public double GetTa()
        {
            return TA;
        }
        void SetTa(double TA)
        {
            this.TA = TA;
        }
        public double GetDa()
        {
            return DA;
        }
        void SetDa(double DA)
        {
            this.DA = DA;
        }
        public double GetGrossSalary()
        {
            return GrossSalary;
        }
        void SetGrossSalary(double GrossSalary)
        {
            this.GrossSalary = GrossSalary;
        }
        public double GetPf()
        {
            return PF;
        }
        void SetPf(double PF)
        {
            this.PF = PF;
        }
        public double GetTds()
        {
            return TDS;
        }
        void SetTds(double TDS)
        {
            this.TDS = TDS;
        }
        public double GetNetSalary()
        {
            return NetSalary;
        }
        void SetNetSalary(double NetSalary)
        {
            this.NetSalary = NetSalary;
        }

        public void calculateSalary(Employee employeedetails)
        {
            double hra = calculateHra(employeedetails.GetSalary());
            double ta = calculateTa(employeedetails.GetSalary());
            double da = calculateDa(employeedetails.GetSalary());
            double grossSalary = employeedetails.GetSalary() + hra + ta + da;
            double pf = .1 * grossSalary;
            double tds = 0.18 * grossSalary;
            double netSalary = grossSalary - (pf + tds);

            employeedetails.SetHra(hra);
            employeedetails.SetTa(ta);
            employeedetails.SetDa(da);
            employeedetails.SetGrossSalary(grossSalary);
            employeedetails.SetPf(pf);
            employeedetails.SetTds(tds);
            employeedetails.SetNetSalary(netSalary);
        }

        double calculateHra(double Salary)
        {
            if (Salary < 5000)
            {
                return .1 * Salary;
            }
            else if (Salary < 10000)
            {
                return .15 * Salary;
            }
            else if (Salary < 15000)
            {
                return .20 * Salary;
            }
            else if (Salary < 20000)
            {
                return .25 * Salary;
            }
            else
            {
                return .30 * Salary;
            }
        }
        double calculateTa(double Salary)
        {
            if (Salary < 5000)
            {
                return .05 * Salary;
            }
            else if (Salary < 10000)
            {
                return .1 * Salary;
            }
            else if (Salary < 15000)
            {
                return .15 * Salary;
            }
            else if (Salary < 20000)
            {
                return .20 * Salary;
            }
            else
            {
                return .25 * Salary;
            }
        }
        double calculateDa(double Salary)
        {
            if (Salary < 5000)
            {
                return .15 * Salary;
            }
            else if (Salary < 10000)
            {
                return .20 * Salary;
            }
            else if (Salary < 15000)
            {
                return .25 * Salary;
            }
            else if (Salary < 20000)
            {
                return .30 * Salary;
            }
            else
            {
                return .35 * Salary;
            }
            
        }

    }
}