using System;

namespace StudioAreaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            
          
            Console.WriteLine("Please enter the radius of the circle, then press ENTER " ) ;
            
                double r = Double.Parse(Console.ReadLine());
                        
                if (r > 0)
                {
                    double area = 3.14 * r * r;

                    Console.WriteLine("The area of the circle is: " + area);
                    Console.ReadLine();
                }
                else if (r <= 0)
                {

                    Console.WriteLine("Please enter a positive number");
                    Console.ReadLine();
                
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                    Console.ReadLine();

                }
            

        }
    }
}
