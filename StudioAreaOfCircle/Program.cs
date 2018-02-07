using System;

namespace StudioAreaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please enter the radius: ");
            try
            {
                double r = Double.Parse(Console.ReadLine());
                if (r > 0)
                {
                    double area = 3.14 * r * r;

                    Console.WriteLine("The area of the circle is: " + area);
                    Console.ReadLine();
                }
                else if (r <= 0)
                {
                    Console.WriteLine("The radius must be a positive number");
                    Console.ReadLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid character");
                Console.ReadLine();
            }


        }
    }
}
