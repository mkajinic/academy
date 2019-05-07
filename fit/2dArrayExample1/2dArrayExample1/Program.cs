using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dArrayExample1
{
    class Program
    {
        static void Main(string[] args)

        {
            // an array to hold the seat letters A,B,C,D
            //We declare and initialise the array in one statemet
            char[] rowLetters = { 'A', 'B', 'C', 'D' };


            //Declare and inititialize  a 2D arra of chars
            char[,] seats = new char[4,5];

            //Row 1, seats 1- 5
            seats [0, 0] = 'S'; // Row 0 Col 0
            seats[0, 1] = 'F'; // Row 0 Col 1
            seats[0, 2] = 'F'; // Row 0 Col 2
            seats[0, 3] = 'F'; // Row 0 Col 3
            seats[0, 4] = 'F'; // Row 0 Col 4


            //Filling the second row (1 -5  )
            seats[1, 0] = 'F';
            seats[1, 1] = 'F';
            seats[1, 2] = 'S';
            seats[1, 3] = 'F';
            seats[1, 4] = 'F';

            //Filling the third row
            seats[2, 0] = 'F';
            seats[2, 1] = 'F';
            seats[2, 2] = 'F';
            seats[2, 3] = 'F';
            seats[2, 4] = 'F';

            //Filling the fourth row
            seats[3, 0] = 'S';
            seats[3, 1] = 'S';
            seats[3, 2] = 'F';
            seats[3, 3] = 'S';
            seats[3, 4] = 'S';

            //Show the array contents in the console

            //go in the to first dimension
            for (int row = 0; row < seats.GetLength (0); row++)
            {
                //go in to the second dimension
                for (int col = 0; col < seats.GetLength(1); col++)
                {
                    //Print ou the value at each point in the array
                    // Console.Write(seats[row, col]);
                    // \t gives us a tab
                    Console.Write("{0}{1}:{2}\t", rowLetters[row], col + 1, seats[row, col]);

                    //same as the above, without using substitution syntax
                    //Console.Write(" " + rowLetters[row] + (col + 1) + ":" + seats[row, col] + " ");
                }

                //Line break
                Console.Write("\n");
            }


            Console.ReadLine();
           
        }
    }
}
