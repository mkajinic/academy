using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReplacementSyntax1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare some string variables
            string firstName;
            string lastName;
            string age;

            Console.WriteLine("What is your first name?");
            //save the user input to the firstName string
            firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            //save the user input to the firstName string
            lastName = Console.ReadLine();

            Console.WriteLine("What is your age?");
            //save the user input to the firstName string
            age = Console.ReadLine();

            //Hi firstName lastName you are x number of years old
            //We can use string replacement syntax in th writeLine method
            Console.WriteLine("Hi {0} {1} you are {2} years old", firstName, lastName, age);


            //delay the end of the program
            Console.ReadLine();



        }
    }
}
