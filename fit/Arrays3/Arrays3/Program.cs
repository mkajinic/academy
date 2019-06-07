using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays3
{
    class Program
    {
        static void Main(string[] args)
        {


            //Create an array fo 4 ints
            int[] myInts = new int[4];

            //assign value of 10, 20, 30, 40 to the array
            myInts[0] = 10;
            myInts[1] = 20;
            myInts[2] = 30;
            myInts[3] = 40;

            
            int x = 5;
            //subract 1 from x and save result in x
            //Another way of saying that is decrement x by 1
  
            x = x - 1; // x is now 4
            Console.WriteLine(" X is: " + x);
            //Another way of decrementing x by 1 using the '--' unary operator
            x--;
            Console.WriteLine(" X is: " + x);

            //Subtract 1 from each element and save it to he same place int the array
            myInts[0] --;
            myInts[1] --;
            myInts[2] --;
            myInts[3] --;
            
            //show all the values in the array
            Console.WriteLine("Value at index 0 is: " + myInts[0]);
            Console.WriteLine("Value at index 1 is: " + myInts[1]);
            Console.WriteLine("Value at index 2 is: " + myInts[2]);
            Console.WriteLine("Value at index 3 is: " + myInts[3]);

            Console.ReadLine();
        }
    }
}
