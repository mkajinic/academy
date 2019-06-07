using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "   Mary had a little lamb chop?   ";

            string s2 = "Mary";

            Console.WriteLine(s1); // Output s1 to console

            // Trim the white space of the string
            // We use the String Trim () method
            // Trim method does not have any arguments

            s1 = s1.Trim();

            Console.WriteLine(s1); // Output s1 to console

            //get the lenght property of teh string s1
            int s1Lenght = s1.Length;

            Console.WriteLine("The lenght of s1 is: {0}", s1Lenght ); //giving a string {0} and int s1Lenght
            Console.WriteLine("The lenght of s1 is: {0}", s1.Length);
            Console.WriteLine("The lenght of s1 is: " + s1Lenght);
            Console.WriteLine("The lenght of s1 is: " + s1.Length );


            // Get the index of the first ocuurance  of the letter 'l'
            //in s1. we can use the string 'indexOf(String) method

            int indexOfFirstL = s1.IndexOf('l');
            Console.WriteLine("the index of the first 'l' in s1 is: " + indexOfFirstL);


            //Convert the whole s1 string to uppercase
            s1 = s1.ToUpper();
            Console.WriteLine("s1 in uppercase: " + s1);


            //Convert the whole s1 string to lowercase
            s1 = s1.ToLower ();
            Console.WriteLine("s1 in lowercase: " + s1);


            // Does the string contain the sequence 'lam' ?
            // We can use th contains (string) method.
            //The contain method returns a boolean value of true or false

            bool isLamInS1 = s1.Contains("lam");
            Console.WriteLine("Is 'lam' in s1 ? " + isLamInS1); // Console.WriteLine(isLamInS1); will return 'True'


            // Ask the user to enter  a list of the names of some fruits
            // and check to see if it contains 'apple'

            Console.Write("List of fruits please: ");
            string userInput = Console.ReadLine();
            //Make th userInput all lower case first
            userInput = userInput.ToLower();

            if (userInput.Contains ("apple"))
            {
                Console.WriteLine(" I see you like apples too");
            }

            else
            {
                Console.WriteLine("You did not mention apple. :( ");
            }




            // we can get the substring of string
            //The substring() method returns the part of the string between the start and end indexes, or to the end of the string.

            // say we want the first 8 characters in s1 
            // Frist parameter is the starting index
            // and th esecond is the lenght of the characters to return
            string subString = s1.Substring(0, 8);
            Console.WriteLine("The first 8 characters in s1 are: " + subString  );

            // Say we want all the characters from the 6th index to the end
            //the single parameter ditates the starting index
            string subString2 = s1.Substring(6);
            Console.WriteLine("The substring after the 5th character of s1 is : " + subString2);


            //See is a string starts with a  specific sequence of characters
            // We can use the StartWith(String) method (this method returs a boolean

            if (s2.StartsWith ("Ma"))
            {
                Console.WriteLine("s2 starts with 'Ma' ");
            }


            // Similary we have the EndsWith(String) method

            if (s2.EndsWith("y"))
            {
                Console.WriteLine("s2 ends with 'y' ");
            }


            Console.ReadLine();




        }
    }
}
