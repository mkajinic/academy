using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays6
{
    class Program
    {
        static void Main(string[] args)
        {
            //An array of string

            string[] myWords = new string[] 
            { "Mary",
              "had",
              "a",
              "little",
              "lamb",
              "its",
              "fleece",
              "was",
              "white",
              "as",
              "snow",
              "everwhere",
              "that",
              "Mary",
              "went",
              "the",
              "lamb",
              "was",
              "sure",
              "to",
              "go"

            }; //end of string array declaration

            //get the lenght of the array and assign the value to the variable lengtOfArray
            int lenghtOfArray = myWords.Length;

            Console.WriteLine("The lenght of the array is : {0}", lenghtOfArray);
            //Same output as above
            Console.WriteLine("The lenght of the array is : {0}", myWords.Length);

            //We can use a for loop to iterate trough tour array
            //getting the value stored at each element and writintg it to the console
            for (int i = 0; i < myWords.Length ; i++)
            {
                //Write out the value at index 'i' and 
                Console.Write(myWords[i] + " ");

            }

            
            Console.ReadLine();
        }
    }
}
