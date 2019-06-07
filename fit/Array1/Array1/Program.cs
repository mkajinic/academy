using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declared 10 int variables but they are not initialised (have not been given n initialise value)
            int num1;
            int num2;
            int num3;
            int num4;
            int num5;
            int num6;
            int num7;
            int num8;
            int num9;
            int num10;

            // give/assign each number a value
            num1 = 5; num2 = 5; num3 = 5; num4 = 5; num5 = 5;
            num6 = 5; num7 = 5; num8 = 5; num9 = 5; num10 = 5;

            Console.WriteLine(num10);

            // instead of the above we can use an array
            //create an array of 10 ints
            //this array has 10 elemts. each element is an int
            //each int has also been initialise to zero
            // An Array  has a fixed lenght(it cannot be changed once created
            int[] myNumbers = new int[10];

            //output the first element/member/item in the array 
            Console.WriteLine("The first number in array is: " + myNumbers[0]);



            //The last number in the array
            //index 9 is the 10th element
            Console.WriteLine("The last number in array is: " + myNumbers[9]);

            Console.ReadLine();

        }
    }
}
