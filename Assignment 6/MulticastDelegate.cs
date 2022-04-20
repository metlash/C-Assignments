using System;

namespace Assignment
{

    public delegate void MarketingExecutiveDelegate();
    internal class MulticastDelegate
    {
        public static void Main(String[] args)
        {

            MarketingExecutive marketingExec = new MarketingExecutive();

            MarketingExecutiveDelegate marketingExecutiveDeleg = new MarketingExecutiveDelegate(marketingExec.printManagertDetails);

            marketingExecutiveDeleg += marketingExec.printMarketingExectDetails;

            marketingExecutiveDeleg.Invoke();

            Console.ReadKey();
        }
    }

    public class MarketingExecutive
    {

        private int ID, ExecID;
        private string Name, ExecName;
        private double Salary, ExecSalary;

        public MarketingExecutive()
        {
            Console.WriteLine("\n ---- Enter Manager Details ---- \n");

            Console.Write("Enter the Manager Id: ");
            this.ID = (Convert.ToInt32(Console.ReadLine()));

            Console.Write("Enter the Manager Name : ");
            this.Name = Console.ReadLine();

            Console.Write("Enter the Manager Salary : ");
            this.Salary = Convert.ToDouble(Console.ReadLine());

         

            Console.WriteLine("\n --- Enter Marketing Eecutive Details ----\n");

            Console.Write("Enter the Marketing Executive Id: ");
            this.ExecID = (Convert.ToInt32(Console.ReadLine()));

            Console.Write("Enter the Marketing Executive Name : ");
            this.ExecName = Console.ReadLine();

            Console.Write("Enter the Marketing Executive Salary : ");
            this.ExecSalary = Convert.ToDouble(Console.ReadLine());
        }

        public void printManagertDetails()
        {
            Console.WriteLine("\n----- Manager Details --------\n");

            Console.WriteLine("Manager Id : {0}", ID);
            Console.WriteLine("Manager Name : {0}", Name);
            Console.WriteLine("Manager Salary : {0}", Salary);
        }

        public void printMarketingExectDetails()
        {
            Console.WriteLine("\n----- Marketing Details --------\n");

            Console.WriteLine("Marketing Executive Id : {0}", ExecID);
            Console.WriteLine("Marketing Executive Name : {0}", ExecName);
            Console.WriteLine("Marketing Executive Salary : {0}", ExecSalary);
        }

    }
}