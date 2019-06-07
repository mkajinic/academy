using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declare and initialise two ints x and y

            int x = 7,   y = 3;

            //Declare an int array
            int[] myInts1 = new int[2];

            //Assign new value to array
            myInts1[0] = 50;
            myInts1[1] = 100;

            //Declare and initialise array of lenght 2 with out own values in one statement
            int[] myInts2 = new int[] {50,100};

            //Add all values from both arrays and varialbles x and y together and save in a variable called result
            //show the result in the console

            int result = x + y + myInts1[0]+ myInts1[1] + myInts2[0] + myInts2[1];
         

            Console.WriteLine("The total of the values is: {0} " + result );

            Console.ReadLine();






        }
    }
}
