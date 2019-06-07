using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadingAndWritingToFile1
{
    class Program
    {
        static void Main(string[] args)
        {

            string directory = @"c:\plays\";

            Console.Write("Please enter a file name: ");
            string fileName = Console.ReadLine();

            string filePath = directory + fileName + ".txt";

            Console.WriteLine("File path : " + filePath);

            //Create the StreamWriter
            StreamWriter writer = new StreamWriter(filePath, true);

            // boolena to vontrol a loop

            bool keepWriting = true;
            string textTowrite = " ";

            while (keepWriting) //while this remains true it will keep looping
            {
                //Ask the user for text. If the text = 'finish', then we break the loop
                //oterwise we write the text to eh file using the StreamWriter

                Console.WriteLine("Give me some text: ");

                textTowrite  = Console.ReadLine();

                if (!textTowrite.Equals("Finish"))
                {
                    writer.WriteLine(textTowrite);
                }
                else
                {
                    keepWriting = false ;
                }
            
            }

            writer.Close();

            // lets open the file again, read all the text into a string and disply back to user

            StreamReader reader = File.OpenText(filePath);

            //Read all the text to the end and save it as a string
            string contentOfFile = reader.ReadToEnd();

            Console.WriteLine("Contents of file: " + filePath+ "\n");
            Console.WriteLine(contentOfFile);

            Console.WriteLine("\nPress enter to exit");


            reader.Close();
            //Finalise the file writing and close the StreamWriter
            writer.Close();
                


            Console.ReadLine();


        }
    }
}
