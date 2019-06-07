using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 


namespace WritingToFiles2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"c:\plays\writefile2.txt";


            // Create a StreamWriter to append text to a file
            //second argument of true causes text to be appended(added) to file instead of over written
            StreamWriter writer = new StreamWriter(filePath, true);

            string textToWrite = "Amazing content goes here bala.";

            //Append the content of textToWrite to the existing content of the file
            writer.WriteLine(textToWrite);

            //Close the writer
            writer.Close();

            Console.WriteLine ("Finish");
            Console.ReadLine();
        }
    }
}
