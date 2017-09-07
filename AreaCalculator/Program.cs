using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AreaCalculator
{
    /// <summary>
    /// Quick and easy program to compute the circumference and area of a circle
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for a radius.
            Console.Write("Enter the radius of the circle:  ");
            
            // The user will type a number and that must be converted into
            // a type double because the ReadLine method returns a String.
            double radius = Convert.ToDouble(Console.ReadLine());

            // Compute the circumference of the circle
            double circumference = 2 * Math.PI * radius;

            // Compute the area of the circle.
            double area = Math.PI * radius * radius;

            Console.WriteLine("The circumference is {0}u\nThe area is {1}u^2", circumference, area);
            Console.ReadKey();
        }
    }
}
