using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search2dArray
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] rowLetters = { 'A', 'B', 'C', 'D', 'E' };

            // Declare and initilise a 2D array of chars.
            // The first vlaue is the length of the 
            // the first dimension which is our rows.
            // The second is our columns or seat numbers.
            char[,] seats = new char[5, 6];

            // Row 1 Seats 1 -> 6
            seats[0, 0] = 'S';
            seats[0, 1] = 'R';
            seats[0, 2] = 'S';
            seats[0, 3] = 'R';
            seats[0, 4] = 'F';
            seats[0, 5] = 'F';

            // Row 2 Seats 1 -> 6
            seats[1, 0] = 'F';
            seats[1, 1] = 'F';
            seats[1, 2] = 'S';
            seats[1, 3] = 'F';
            seats[1, 4] = 'F';
            seats[1, 5] = 'F';

            // Row 3 Seats 1 -> 6
            seats[2, 0] = 'F';
            seats[2, 1] = 'F';
            seats[2, 2] = 'R';
            seats[2, 3] = 'F';
            seats[2, 4] = 'F';
            seats[2, 5] = 'F';

            // Row 4 Seats 1 -> 6
            seats[3, 0] = 'S';
            seats[3, 1] = 'R';
            seats[3, 2] = 'R';
            seats[3, 3] = 'F';
            seats[3, 4] = 'S';
            seats[3, 5] = 'F';

            // Row 4 Seats 1 -> 6
            seats[4, 0] = 'F';
            seats[4, 1] = 'R';
            seats[4, 2] = 'F';
            seats[4, 3] = 'F';
            seats[4, 4] = 'S';
            seats[4, 5] = 'R';

            //search 2D array and print out the SOLD seats 'S'
            for (int row = 0; row < seats.GetLength (0) ; row++)
            {
                for (int col = 0; col < seats.GetLength (1); col++)
                    //only print the row and seat number of seats that are sold
                    if (seats[row, col] == 'S')

                    {
                    Console.Write("{0}{1}:S ", rowLetters[row], (col + 1), seats[row, col]);
                    }
            }
            Console.ReadKey();

        }
    }
}
