using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create a loop that asks user to enter play names 
            //the looop cannot run more than 5 times
            //loop will stop if the user types the word "Finish"

            int counter = 1;
            string playName = "";

            while (counter < 11) // - boolean expression that controls the loop
            {
                // do stuff..

                Console.WriteLine("Inside the loop");
                Console.WriteLine("Please enter a play name and hit enter: ");
                playName = Console.ReadLine();

                if (playName.Equals ("Finish"))
                {
                    //break the loop
                    break;

                }

                //Increment the counter by 1
                counter++;

            } // end of while loop

            Console.WriteLine("Finished!");
            Console.ReadLine();

        }
    }
}
