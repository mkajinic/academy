using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // we need this for the StreamWriter Class

namespace WritingToFiles1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "c:\\Plays\\WriteFile1.txt";

            //To write text to file we can use a StreamWriter
            // Any text writen to the file will be over written

            StreamWriter outputFile = new StreamWriter(filePath);

            //text to write to the file
            string textToWrite = "Positive mindset";

            // Write the text to the file
            outputFile.WriteLine(textToWrite);

            // Close the StreamWriter
            outputFile.Close();

            Console.ReadLine();

        }
    }
}
