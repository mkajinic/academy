using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods7
{
    class Program
    {
        static void Main(string[] args)
        {
            //We call the ThreeStrigConcat method with the arguments (Mary had curry)
            string newString1 = ThreeStringConcat("Marry", "had", "curry.");
            Console.WriteLine( newString1 );

            Console.WriteLine(ThreeStringConcat ("It", "was" , "delicius :P " ) );

            string newString2 = ThreeStringConcat("Then", "she went", "home" );
            Console.WriteLine(newString2);

            //*************************************************************************************

            double result1 = AddNumbers(45, 45.45);
            Console.WriteLine(result1);

            double result2 = AddNumbers(30, 45);
            Console.WriteLine(result2);


            Console.ReadLine() ;
         }


        //Make a method that takes in three strings and returns the concatenation of the three strings with a space ' '  between each string

        static string ThreeStringConcat (string s1, string s2, string s3 )
        {
            //string concatenatedString = s1 + " " + s2 + " " + s3;
            return   s1 + " " + s2 + " " + s3;    //return = concatenatedString;
        }


        //Make a method that take two paramters an int and a double. Method should return the addition of these two values as a double



        static double AddNumbers(int number1, double number2)
        {
            return number1 + number2;

        }



    }
}
