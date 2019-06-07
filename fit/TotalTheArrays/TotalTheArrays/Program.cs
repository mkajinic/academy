using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalTheArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create an array of 1000 random numbers
            int[] myRandomNumbers = new int[1000];

            //Create a new random object
            Random r = new Random();

            //Use the random object to fenerate random numbers between 1 and 100 and fill the array also
            for (int i = 0; i < myRandomNumbers.Length; i++)
            {
                //next method takesa min and exclusive max value as input
                //Assign the random number to the current array index
                myRandomNumbers[i] = r.Next(1, 101);
            }


            //Show each number in the array
            for (int i = 0; i < myRandomNumbers.Length; i++)
            {
                Console.Write(myRandomNumbers[i] + " ");
            }
            //Sum all numbers in the array and display the total

            //Variable to hold the sum of the numbers in the array
            int sumOfAllNumbers = 0;

            for (int i = 0; i < myRandomNumbers.Length ; i++)
            {
                // Add the current value in the array at index 'i' to the sumOfAllNumbers
                sumOfAllNumbers = sumOfAllNumbers + myRandomNumbers[i];
            }

            // Show the sum of all numbers in the array
            Console.WriteLine(); //dummy line break to meke bottom line in a new line instead puting it  in the line with numbers
            //We can also use a special escape sequence in a string to generate a line break. We can use '\n'

            Console.WriteLine("\nThe sum of all numbers is: " + sumOfAllNumbers);

            Console.ReadLine();

        }
    }
}
