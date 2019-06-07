using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] s = { "Fish", "Cheese", "Apple" };
            //Change the string in the array
            s[0] = "Orange";
            s[1] = "Kiwi";
            s[2] = "Pear";

            //null a element in the array
            s[1] = null;
            
            //The array is still the same lenght
            Console.WriteLine("s array lenght is: " + s.Length );

            //We can use a list instead withic is a collection which will allow us to add and remove elements
            //We dont have to specify an initial lenght
            //Lists are dynamicly sized
            List<string> myWords = new List<string>();

            //Check the current size of the list
            Console.WriteLine("Size of myWords list is " + myWords.Count);

            //Add some elements to the list
            myWords.Add("Apple");
            myWords.Add("Pear");
            myWords.Add("Kiwi");

            string s2 = "Bannana";
            myWords.Add(s2);
            myWords.Add("Banana");


            //Check the current size of the list
            Console.WriteLine("Size of myWords list is " + myWords.Count);


            //Remoe elements from the list
            myWords.Remove("Bannana");

            //Check the current size of the list
            Console.WriteLine("Size of myWords list is now " + myWords.Count + " as we removed Bannana");

            Console.ReadLine();



        }
    }
}
