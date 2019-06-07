using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make arrays of 100 ints
            int[] myRandomNumbers = new int[100];

            //Show all current numbers in the array
            //Creat a loop to iterate trough the array and display each number at each index
            for (int i = 0; i < myRandomNumbers.Length ; i++)
            {
                Console.WriteLine("The number at index {0} is: {1}", i,myRandomNumbers [i]);
            }
           

            Random myRandom = new Random();
            //Generate a random number bewteen 1 and 100
            int random = myRandom.Next(1, 101);

            //Console.WriteLine("The random number is: {0}", random);




            //Fill the tray with random numbers between 0 and 100

            for (int i = 0; i < myRandomNumbers.Length; i++)
            {
                //Add a random number at element/index of the array
                myRandomNumbers[i] = myRandom.Next(1, 101);
            }

            //show all the number at each index of the array
            for (int i = 0; i < myRandomNumbers.Length; i++)
            {
                Console.WriteLine("the number at index {0} is ; {1}", i, myRandomNumbers[i]);
            }

            Console.ReadLine();
        }
    }
}
