using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call the method to calculate the area of a circle with radius of 6.6

            AreaOfCircle(6.6);


            //radius of 7, (int value is implicitly converted to double
            AreaOfCircle(7);
            Console.ReadLine();

        }


       //create a method to calc the area of a circle 
       // Area of circle is PI*radius*radius


            //Void means that method does not return anything
        static void AreaOfCircle(double radius)
        {
            
            double area = Math.PI  * radius * radius;
            Console.WriteLine("The area of a circle with radius of {0} is: {1} ", radius , area );
        }







    }
}
