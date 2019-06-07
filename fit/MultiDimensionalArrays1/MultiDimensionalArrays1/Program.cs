using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArrays1
{
    class Program
    {
        static void Main(string[] args)
        {


            //The char datatype (char means character) but can hold only one character (one letter or symbol)

            char myChar1 = 'S';
            char myChar2 = 'F';
            char myChar3 = '%'; // An ASCII symbol is a character
            char myChar4 = ' '; //A single space is a character
            char myChar5 = '5';

            string myString = "Freedom";


            // Make a one dimensional array of chars

            char[] myCharArray1 = new char[7];

            //Assign values to array

            myCharArray1[0] = 'S';
            myCharArray1[1] = 't';
            myCharArray1[2] = 'u';
            myCharArray1[3] = 'd';
            myCharArray1[4] = 'e';
            myCharArray1[5] = 'n';
            myCharArray1[6] = 't';

            // Loop trough the array
            for (int i = 0; i < myCharArray1.Length; i++)
            {
                Console.Write(myCharArray1[i]);
            }



            // Make 2D  array of chars
            //It will have 10 fows and 20 columns

            int row = 4; // First dimension of the array
            int col  = 5; // Second dimension of the array

            char[,] my2DArray = new char [row,col]; //or [10,20] with no int row, int col

            my2DArray[0, 0] = 'S'; // Row 0 Col 0
            my2DArray[0, 1] = 'F'; // Row 0 Col 1
            my2DArray[0, 2] = 'F'; // Row 0 Col 2
            my2DArray[0, 3] = 'F'; // Row 0 Col 3
            my2DArray[0, 4] = 'S'; // Row 0 Col 4


            //Filling the second row (row index1 )
            my2DArray[1, 0] = 'F';
            my2DArray[1, 1] = 'F';
            my2DArray[1, 2] = 'F';
            my2DArray[1, 3] = 'F';
            my2DArray[1, 4] = 'F';

            //Filling the third row
            my2DArray[2, 0] = 'S'; 
            my2DArray[2, 1] = 'F'; 
            my2DArray[2, 2] = 'F'; 
            my2DArray[2, 3] = 'F'; 
            my2DArray[2, 4] = 'F';

            //Filling the fourth row
            my2DArray[3, 0] = 'S';
            my2DArray[3, 1] = 'S';
            my2DArray[3, 2] = 'F';
            my2DArray[3, 3] = 'S';
            my2DArray[3, 4] = 'S';


            
            Console.ReadLine();




        }
    }
}
