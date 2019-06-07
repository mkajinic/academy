using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStringAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user to type in any month in a year
            Console.Write("Write the name of any month in a year: ");
            string month = Console.ReadLine();

            //Trim any white space of the string
            month = month.Trim();
            Console.WriteLine(month);

            // convert the string to uppercase and show it to the user
            month = month.ToUpper();
            Console.WriteLine("Month you choose (uppercase) is: " + month );

            // conver the string to lowercase and show it to user
            month = month.ToLower();
            Console.WriteLine("Month you coose (lowercase) is: " + month);

            //Tell t he user the lenght of the string they entered
            Console.WriteLine("The length of the month you entereed is: " + month.Length );

            //Check and see if the string starts with 'j' and tell the user if it does or does not

            if (month.StartsWith  ("j"))
            {
                Console.WriteLine("Choosen month starts with letter 'j'" );
            }
            else
            {
                Console.WriteLine("Choosen month does not start with letter 'j'");
            }

            //check and see if the string ends with 'er' and tell the user if it does or not
            if (month.EndsWith("er"))
            {
                Console.WriteLine("Choosen month ends with letter 'er'");
            }
            else
            {
                Console.WriteLine("Choosen month does not end with letters 'er'");
            }

            //Find the index of the letter 'u' in the string and if it does not exist,then tell the user that it was not found.
            //If found thell the user where it was located
            
            if (month.Contains ("u"))
            {
                Console.WriteLine("Letter 'u' was found at " + month.IndexOf('u'));
            }
            else
            {
                Console.WriteLine("Letter 'u' not was found" + month.IndexOf ('u'));
            }
            /* Thomas example
            int indexOf = month.IndexOf('u');

            if (indexOf  !=-1)
            {
                Console.WriteLine(" 'u' was found at index; " + indexOf);
            }
            else
            {
                Console.WriteLine("'u' wasn't found in tha word");
            }
        */
            // see if the letter 'b' is containtd in the string and tell the user if it does or does not exist

            if (month.Contains("b"))
            {
                Console.WriteLine("Letter 'b' was found.");
            }
            else
            {
                Console.WriteLine("Letter 'b' not was found.");
            }


            //show the user the substring of the first 3 letter of the string
            string subString = month.Substring(0,3);

            Console.WriteLine("The substring of the first 3 letters are: " + subString );

            Console.ReadLine();

           
        }
    }
}
