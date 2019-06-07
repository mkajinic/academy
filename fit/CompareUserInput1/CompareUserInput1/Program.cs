using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareUserInput1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ask the user for a word and see if it equals the word "Fishcake"
            //Ignore the case of the letters

            /* my example
            string s1 = "Fishcake";
            bool keepLooping = true;

            while (keepLooping == true) 
            {
                Console.WriteLine("Please enter a word: ");
                string userInput1 = Console.ReadLine();
           
              if (userInput1 .Equals(s1, StringComparison.OrdinalIgnoreCase))
              {
                    keepLooping = false;
              }

            }
            Console.ReadLine();
            
    */

            //Thomas example

            Console.Write("Give us the word: ");
            string userWord = Console.ReadLine();
            string word = "Fishcake";

            if (word.Equals (userWord ,StringComparison.OrdinalIgnoreCase ))
            {
                Console.WriteLine("you entered '{0}! I know that word!", userWord);
            }
            else
            {
                Console.WriteLine("I dont know that word");
            }




//************************************************************************************************************************************************


            /*

            //Ask the user for a number and see if it equals 99, (my example)

             bool looping = true;

             while (looping ==true) 
             {
                 Console.WriteLine("Please enter a number: ");
                 string  userNumber = Console.ReadLine();

                 if (userNumber.Equals ("99"))
                 {
                     looping = false;
                 }
             }


             Console.ReadLine();
             
    */

            //Ask the user for a number and see if it equals 99, Thomas example

            Console.WriteLine("Give me a number ");
            string userNumber = Console.ReadLine();

            int userNumberAsInt = int.Parse(userNumber); //convert to int if we want

            if (userNumberAsInt ==99)
            {
                Console.WriteLine("You entered 99");
            }
            else
            {
                Console.WriteLine("Thats not  99");
            }



            //***********************************************************************************************************************************






            //Ask the user for a number and check to se if the number is between 50 and 100

            Console.Write("give me a nnumber");
            userNumber = Console.ReadLine();

            userNumberAsInt = int.Parse(userNumber);

            if (userNumberAsInt >= 50 && userNumberAsInt <=100)
            {
                Console.WriteLine("That number is between 50 and 100");
            }
            else
            {
                Console.WriteLine("That number is not between 50 and 100");
            }

            //Ask the user for a numeber. Multiply the number provided by 5
            //Show the answer

            Console.WriteLine("Give me a number to multiply the number provided by 5");
            userNumber = Console.ReadLine();

            userNumberAsInt = int.Parse(userNumber);
            int result = userNumberAsInt * 5;


            Console.WriteLine("{0} by 5 is {1}" , userNumber, result ) ;


            Console.WriteLine("\n press enter to exit");
            Console.ReadLine();

        }
    }
}
