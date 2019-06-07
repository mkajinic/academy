using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists2
{
    class Program
    {
        static void Main(string[] args)
        {

            //List to hold string objects
            List<string> myStrings = new List<string>();

            myStrings.Add("Kiwi");
            myStrings.Add("Pear");
            myStrings.Add("Apple");
            myStrings.Add("Apple");
            myStrings.Add("Kiwi");
            myStrings.Add("Kiwi");
            myStrings.Add("Kiwi");

            //Get the Count property of the list
            Console.WriteLine(" Number of items on te list: " + myStrings.Count );

            //Display the second element in the list (index 1)
            Console.WriteLine(myStrings.ElementAt (1) );

            // Iterate trouhg the list an show all the elements 
            foreach (string  word in myStrings )
            {
                Console.WriteLine (word); // show the string in the list at the current position
            }

           

            //Remove an element from the list
            myStrings.Remove("Apple");
            Console.WriteLine(" \nAfter removing Apple");

            foreach (string word in myStrings)
            {
                Console.WriteLine(word); // show the string in the list at the current position
            }




            //Remove an element at specified index/position in the list
            //Remove at 1st and 2nd element
            myStrings.RemoveAt(0); // 1st
            myStrings.RemoveAt(1); // 2nd

            Console.WriteLine(" \n Index 0 and 1 removed");

           foreach (string word in myStrings)
            {
                Console.WriteLine(word); // show the string in the list at the current position
            }

            Console.WriteLine("Number of items on te list: " + myStrings.Count);





            //Remove all the "Kiwi" string sfrom the lsit using Remove all
            //This useas a lamda expressions as the predicate argument required
            myStrings.RemoveAll(item => item.Equals("Kiwi"));

            Console.WriteLine(" \nAfter removing all the Kiwi's from the list");


            // Iterate trouhg the list an show all the elements 
            foreach (string word in myStrings)
            {
                Console.WriteLine(word); // show the string in the list at the current position
            }

            Console.WriteLine("Number of items on te list: " + myStrings.Count);


            Console.ReadLine();

            


        }
    }
}
