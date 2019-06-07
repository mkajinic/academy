using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make an array to hold 5 numbers

            int[] myArrayOfInts = new int[5];

            //Assign values of 11,45,67,890,34,2 to the array


            myArrayOfInts[0] = 11;
            myArrayOfInts[1] = 45;
            myArrayOfInts[2] = 67;
            myArrayOfInts[3] = 890;
            myArrayOfInts[4] = 34;


            // Output the 3rd element of the array
            Console.WriteLine("3rd element: " + myArrayOfInts [2]);

            // Output the 2nd last element of the array
            Console.WriteLine("2nd last element: " + myArrayOfInts[3]);

            // Add the 2nd and 4th element of the array and save it,
            // in a variable called result

            int result = myArrayOfInts[1] + myArrayOfInts[3];
            Console.WriteLine("The result is: " + result );

            Console.ReadLine();
       
        }
    }
}
