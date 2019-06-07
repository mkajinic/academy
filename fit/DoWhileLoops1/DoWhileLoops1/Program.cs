using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoops1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = ""; //empty string

            //do-while loop
            // Repeat untill the condition is met
            do
            {
                Console.WriteLine("Inside the loop");
                Console.WriteLine("What is your favourite programming language? ");
                input = Console.ReadLine();

            } while (!input.Equals("c#")); //the condition

            Console.WriteLine("Outside the loop now");

            Console.ReadLine();
        }
    }
}
