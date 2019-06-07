using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseStatement3
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;

            //Ask the user for the name of a food stuff

            Console.WriteLine("Tell me a food you like");

            userInput = Console.ReadLine();

            //then we are going to check if we know the food, and thell them if we like it

            string message = "'Hm '" + userInput + " 'let me see if I like that";
            Console.WriteLine(message);

            if(userInput == "pizza")
            {
                Console.WriteLine("Yum, I like pizza too!");
            }

           else if (userInput == "oranges")
            {
                Console.WriteLine("I am not a fa of oranges");
            }

            else if (userInput == "strawberry")
            {
                Console.WriteLine("Nice. Love them");
            }

            else if (userInput == "cabbage")
            {
                Console.WriteLine("Seriously?! Veggies!?");
            }


            //Otherwise we will tell them we don't know it
            else
            {
                //Console.WriteLine("I don't know what ' " + userInput + " ' is, but I'd like to try it!");
                Console.WriteLine("I don't know what ' {0} ' is but i'd like to try it,", userInput);

            }


            Console.ReadLine();

            
        
        }
    }
}
