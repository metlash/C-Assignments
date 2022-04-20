using System;

namespace Program
{
    class Area
    {
        const double Pi = 3.14;
        public static void Main(String[] args)
        {
            double radius, area, circumference;

            Console.WriteLine("Enter the Radius of a circle: ");
            radius = Convert.ToDouble(Console.ReadLine());

            Area obj = new Area();
            Tuple<double, double> result = obj.Calculate(radius);
            
            Console.WriteLine("The Area of the circle is : " + result.Item1);
            Console.WriteLine("The Circumference of the circle is : " + result.Item2);

            Console.ReadKey();           
        }

        Tuple<double, double> Calculate(double r)
        {
            double a, c;

            a = Pi * r * r;

            c = 2 * Pi * r;

            return Tuple.Create(a,c);
        }
    }
}
