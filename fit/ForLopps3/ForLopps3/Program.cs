using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLopps3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ask the  user how many loop they would like

            Console.Write("How many loops would you like? ");

            //Declare a string and assign it the return value from the ReadLine() method
            string userInput= Console.ReadLine();


            //Try and convert the user 'string' input to an int
            int numOfLoops;

            //use  the Parse method from the int class to try and convert the string user input to an integer
            numOfLoops = int.Parse(userInput);

            Console.WriteLine("You entered: " + userInput);
    
            //Loop that many times

            for (int i = 0; i < numOfLoops; i++)
            {
                // the part of the expression inside the brackets/parenthesis is evaluated first
                //so (i+1) resulst in an int value as both 1 and i are ints
                //The rest of the expression is then evaluated from left to right
                Console.WriteLine("Looping " + (i + 1) + " times");
            }

            Console.ReadLine();
        }
    }
}
