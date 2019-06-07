using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The area of a cricle with radius 6.6 is: " + CalcAreaOfCircle(6.6));

            Console.ReadLine();

        }

        //This method has one parameter of type double
        //and has a returnt type of double
        static double CalcAreaOfCircle( double radius)
        {
            return Math.PI * radius * radius;

        }
        


        

        





    }
}
