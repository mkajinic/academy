using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop4
{
    class Program
    {
        static void Main(string[] args)
        {
            //As the user to enter a number and save it

            //Ask the user to enter another number and save it

            //Then the code should pick the lagest of two numbers and run a loop the same number of times as the largest number

            //The loop should  show the number of the iteration which it currently is in 
            //(Example: Looping 1 times)


            Console.WriteLine("Choose any number ");
            string userInput1 = Console.ReadLine();


            Console.WriteLine("Choose another number ");
            string userInput2 = Console.ReadLine();

            int numOfLoops;
            numOfLoops = int.Parse(userInput1);
         

            for (int i = 0 ; i < numOfLoops; i++)
            {
                Console.WriteLine("Looping " + i + " times");
            }

            Console.ReadLine();
        }
    }
}
