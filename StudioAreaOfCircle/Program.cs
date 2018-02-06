using System;

namespace StudioAreaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the radius of the circle, then press ENTER ");
            string radius = Console.ReadLine();
            double r = Convert.ToInt32(radius);

            double area = 3.14 * r * r;

            Console.WriteLine("The area of the circle is: " + area);
            Console.ReadLine();
            
        }
    }
}
