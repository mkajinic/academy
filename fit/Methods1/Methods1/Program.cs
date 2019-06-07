using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Calculate the area of rectangle

            int width = 5;
            int lenght = 6;
            int area = width * lenght;

            Console.WriteLine("The area of a rectangle with a width of " + width  + " and lenght of " + lenght + " is: " + area);

            // Calc the area of another rectangle
            width = 67;
            lenght = 23;
            area = width * lenght;

            Console.WriteLine("The area of a rectangle with a width of " + width + " and lenght of " + lenght + " is: " + area);

            //invoke the CalcAreaOfRectangle method
            //Compute a rect angle with width of 6 and lenght of 77
            // We pass in arguments of 6 and 77
            CalcAreaOfRectangle(6, 77);


            // Compute the area of a few more rectangles
            // width: 55, height: 78
            // width: 100, height: 150
            // width: 99, height: 99
            CalcAreaOfRectangle(55, 78);
            CalcAreaOfRectangle(100, 150);
            CalcAreaOfRectangle(99, 99);


            Console.ReadLine();


            
        }//end of main method

        //this method should take thwo parametarrs that correspond to the with dna lenght of a rectangle in order ot compute the area
        static void CalcAreaOfRectangle(int width, int lenght)
        {
            int area = width * lenght; //Compute the area
            
            //Display area to console
            Console.WriteLine("The area of a rectangle with a width of " + width + " and lenght of " + lenght + " is: " + area);

        }




    }
}
