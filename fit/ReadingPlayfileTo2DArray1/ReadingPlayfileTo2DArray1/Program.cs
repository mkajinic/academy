using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadingPlayfileTo2DArray1
{
    class Program
    {
        static void Main(string[] args)
        {

            string  filePath = @"c:\plays\PlaysFile1.txt";

            //Open the file for reading, using stringReader Object
            //reader will be humble to the file
            StreamReader reader = new StreamReader(filePath);

            //read the first whole line into the string 'playDetails' 
            string playDetails = reader.ReadLine();

            //testc the line read
            Console.WriteLine(playDetails);

            // A 2D char array of 10 rows and 20 columns
            char[,] seats = new char[10,20];

            for (int row = 0; row < seats.GetLength(0) ; row++)
            {
                for (int col = 0; col < seats.GetLength(1); col++)
                {
                    // .Read() <- reads the next character from the stream and advanced the character position by 1
                    //Read () returns an int so in our case we need to cast the in to a char
                    seats[row, col] =(char) reader.Read();

                }

                
            }

            for (int row = 0; row < seats.GetLength(0); row++)
            {
                for (int col = 0; col < seats.GetLength(1); col++)
                {
                    Console.Write(seats[row,col]);

                }

                // Read pas the Cr and LF hidden characters in the file
                //Which will advance character position to he star of the next line
                reader.ReadLine();

            }







            reader.Close();
            Console.ReadLine();


        





        }
    }
}
