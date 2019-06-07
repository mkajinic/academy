using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use the method
            string myString = "        Hello     EverybODy !";

            TrimAndLowerCaseString(myString);
            TrimAndLowerCaseString("    TraTRADA di da bu DI  BU DAAA   !");


            // Ask the user for a string and show tthem the string timmerd and in in lowercase
            Console.Write("Type in any word: ");
            string userString = Console.ReadLine();

            TrimAndLowerCaseString(userString);


            Console.ReadLine();
        }

        //a method to trim a string and conver it to upper case

        static void TrimAndLowerCaseString(string theString)
        {
            theString = theString.Trim();
            theString = theString.ToLower();
            Console.WriteLine("Trimmed and lower cased: " + theString  );
        }







    }
}
