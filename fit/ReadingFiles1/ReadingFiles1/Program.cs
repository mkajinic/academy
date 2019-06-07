using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Needed for the StreamReader method


namespace ReadingFiles1
{
    class Program
    {
        static void Main(string[] args)
        {

            // create a new instance of the StreamReader class
            // pointing to Stream of data contained in the file c:\\plays\\PlaysFile1.txt
            // We can use a streamReader ovject to read text from a file

            StreamReader inputFile = File.OpenText(@"c:\plays\PlaysFile1.txt");

            //Read all the character from the current position to the end of the file in to the string 'contentsOfTextFile'
            string contentsOfTextFile = inputFile.ReadToEnd();

            // Display the 'contentsOfTextFile'  string to console
            Console.WriteLine(contentsOfTextFile );
            Console.ReadLine();




        }

  
    }
}
