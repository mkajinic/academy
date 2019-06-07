using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Make an array of strings
            string[] s1 = new string[3];

            s1[0] = "Hello";
            s1[1] = "Anything";
            s1[2] = "Last";

            //Make an array of strings
            string[] s2 = { "Happy", "Sleepy", "Dopey" };

            // Iterate trough the collection and display each string to console
            for (int i = 0; i < s1.Length ; i++)
            {
                Console.WriteLine("string at index {0} is {1} ", i ,s1[i]);
            }

            //Iterate trough the array (collection) using foreach loop
            foreach (string  word  in s2)
            {
                Console.WriteLine("The word is: " + word  );
            }

            //Make an array of decimal values
            decimal[] myDecimals = { 12.4M, 23.6M, 33.33M, 102M };


            // Use for loop and foreach to iterate trough the array myDecimals and show each number
            // In the for loop also show index
            for (int   i = 0; i < myDecimals.Length ; i++)
            {
                Console.WriteLine(" Decimals in index {0} is {1} ", i, myDecimals[i]);
            }

            //in foreach loop we cannot see what index we are currently at
            foreach (decimal  numbers in myDecimals )
            {
                Console.WriteLine(" The numbers are: " + numbers );
            }



            //Create an array of ints and use a foreach loop to sume the values in the array
            int[] myNums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //variable to hold result
            int sum = 0;

            foreach (int  number in myNums )
            {
                sum = sum  + number ;
                Console.WriteLine("The current total sum is :" + sum);
            }

            //Create an array of 10 doubles and use a foreach loop to total/sum all the values in the array

            double[] dubNumb  = { 1.2, 2.3d, 3.4d, 4.1, 5.1, 5.4, 21.42d, 9, 1.22, 84.2d };
            double  total = 0;

            foreach (double item in dubNumb )
            {
                total = total + item;
                Console.WriteLine("The current total of doubles  is :" + total );
            }


            Console.WriteLine("The total of doubles in the array is :" + total );
            Console.WriteLine("The sum in the numbers in the array is :" + sum);

            Console.ReadLine();
        }

    }
}
