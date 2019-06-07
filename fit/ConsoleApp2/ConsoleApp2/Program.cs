using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        //Main is a special method which is the 
        //entry point for our programme
        static void Main(string[] args)
        {
            //Passing literal string to the writeLine Method
            Console.WriteLine("Hello");

            //Create variable to hold a string 
            //Declare a string variable
            string myString1;

            //Assign a value to our string 'myString1'
            myString1 = "Everybody.";

            //Pass the string 'myString1' to the WriteLine method
            Console.WriteLine(myString1);

            //Assing a new value to variable myString1
            myString1 = "John";

            //Write the new value to the console
            Console.WriteLine(myString1);

            //Concantenate another string on to 'myString1'
            myString1 = myString1 + " Murphy";

            //Here we both declare a new string variable and 
            //initialise it with new value
            string myString2 = " Senior";

            //Concantenate another value  on to 'myString1'
            myString1 = myString1 + myString2;

            //Write new value to the console
            Console.WriteLine(myString1);

            //Call/iInvoke the ReadLine method of the Console class

            /*start of the multiline comment
             
            Console.ReadLine();
            end of a multiline comment
            */


        } //End of Main method

    } // End of the program

} // End of namespace
