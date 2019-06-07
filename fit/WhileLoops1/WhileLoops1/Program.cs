using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops1
{
    class Program
    {
        static void Main(string[] args)
        {

            //the while loop

            string input = "";
            bool keepLooping = true;
;
            while (keepLooping == true) //While the condition is true we continue looping
            {
                Console.WriteLine("Inside the loop");
                Console.Write("What is your favourite Language? ");
                input = Console.ReadLine();

                if (input.Equals ("c#"))
                {
                    keepLooping = false;
                }
                    
            }

            Console.WriteLine("outside the loop");


            Console.ReadLine();




        }
    }
}
