using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Lets make a list to hold integers
            List<int> numbers = new List<int>();





            //Then we will ask the user for a number and save it to the list
            //We will continuing asking the user if they want to enter another  number repeatedly and add each to the list
            //When they are finished entering number we will show them the total of all numbers they entered


            // loop control variable
            bool keepLooping = true;

            do
            {
                Console.Write("Enter a number to add to the list: ");
                string numberAsString = Console.ReadLine();

                //Handing the exception that could be thrown by the int.Parse method
                try
                {
                    int number = int.Parse(numberAsString);
                    //Add a number to the list
                    numbers.Add(number);
                }
                catch 
                {
                    Console.WriteLine("Not a valid integer.");
                    
                }
               

               

                //Ask the user to go again
                Console.Write("Press 'Enter' to add another number or 'N' to calculate the sum of all number on the list: ");

                //Grab the users choice
                string goAgain = Console.ReadLine();


                //If the user entered 'N' or 'n' then the loop should not continue
                if (goAgain.ToLower().Equals ("n"))
                {
                    keepLooping = false;
                }


                

            } while (keepLooping);

            Console.WriteLine("\nFinish adding numbers");

            int sum = 0;
            //loop to calc the total of the numbers in the array
            foreach (int num in numbers)
            {
                sum = sum + num; //add the current value in the array to the sum
            }

            Console.WriteLine("\nThe sum of all number in the array is: " + sum);


            Console.ReadLine();
        
        



        }
    }
}
