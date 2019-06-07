using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many random numbers do you want? ");
            //Save user input in a string
            string userInput = Console.ReadLine();

            //Convert the user input to an int
            int numOfRandoms = int.Parse(userInput);

            //Create an instance on the Random Class

            Random r = new Random();

            //create an array the same size as the user input
            int[] randomNumbers = new int[numOfRandoms];

            //A loop to generate the  random number

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = r.Next();
                Console.WriteLine("Row Number " + (i+1) + ":  " + randomNumbers[i]);
            }

            Console.ReadLine();
        }
    }
}
