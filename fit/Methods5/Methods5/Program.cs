using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods5
{
    class Program
    {
        static void Main(string[] args)
        {


            //compute the are aof circle with radius 6.6

            double area = ComputeAreaOfCircle(6.6);

            Console.WriteLine("the area of circle with raidus 6.6 is: " + area );
            Console.ReadLine();
        }

        //A method to calc the area of cirlce and 'return' the computed area (static double)co

        static double ComputeAreaOfCircle( double radius)
        {
            double area = Math.PI * radius * radius;

            //return the computed area

            return area;


        }








    }
}
