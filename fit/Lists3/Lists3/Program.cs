using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists3
{
    class Program
    {
        static void Main(string[] args)
        {
            //short syntax to create the array and some elements
            List<string> myWords = new List<string>()
            { "Cat", "Dog", "Chicken", "Chicken","Chicken", "Turkey", "Bird"};

            foreach (string animal in myWords )
            {
                Console.WriteLine(animal);
            }


            Console.Write("Please enter the index you wish to retrieve between 0 and {0}: ", (myWords.Count-1));

            //Get the choice and convert to an int
            string choice = Console.ReadLine();
            int index = int.Parse(choice);

            Console.WriteLine("That is a '{0}'. ", myWords.ElementAt (index));

            //We can index into a list to assign a new object to that position/index
            //This will replace element at the  3td index with the string "Pigeon"
            myWords[3] = "Pigeon";

            
            //Ask the user what element they would like to change (index)
            Console.Write("Please enter the index you wish to change between 0 and {0}: ", (myWords.Count - 1));
            string theIndex = Console.ReadLine();
            int indexToChange = int.Parse(theIndex );

       
            // Ask them what word they would like to place in that index

            Console.Write("What word you would like to input instead?");
            string newWord = Console.ReadLine();

            //Replace the index given with the word
            myWords[indexToChange] = newWord;
            Console.WriteLine("\nList has been updated");

            //Show the updated list foreach loop
            foreach (string animal in myWords )
            {
                Console.WriteLine(animal);
            }
           

            Console.ReadLine();


        }
    }
}
