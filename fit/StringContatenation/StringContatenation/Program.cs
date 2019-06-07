using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringContatenation
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declare a few string variables

            string myString1 = "cat";
            //concatonate two strings to make a new string and assign value to 'myString2'
            string myString2 = myString1 + "fish";


            //We are not adding the int 55  to the string 
            //55 is converted to the string "55" and concatenated with the contents of myString2
            string myString3 = myString2 + 55;

            string myString4 = "4" +"4";

            Console.WriteLine(myString1);
            Console.WriteLine(myString2);
            Console.WriteLine(myString3);
            Console.WriteLine(myString4);

            Console.ReadLine();

            //if ther eis a string i the expression
            //then int's will be converted to strings and concatenation will happen

            Console.WriteLine(4 + 4); //8
            Console.WriteLine("4" + 4); //44
            Console.WriteLine(4 + "4"); //44
            //both expressions below are evaluated from left to right
            //if the first operand is string then subsequent operands are converted to strings
            Console.WriteLine("4" + 4 + 4); //444
            //first operand is an int followed by and int, so the numbersare added then converted to a string,
            //so that result can be concatenated with the strin "4"
            Console.WriteLine(4 + 4 +"4"); //84
            Console.ReadLine();

        }
    }
}
