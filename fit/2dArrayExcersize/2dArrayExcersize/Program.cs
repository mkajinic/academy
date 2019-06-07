using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dArrayExcersize
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] rowLetters = { 'A', 'B', 'C', 'D','E' , 'F' };

            char[,] seats = new char[6, 6];
           

     
            seats[0, 0] = 'S'; 
            seats[0, 1] = 'F'; 
            seats[0, 2] = 'F'; 
            seats[0, 3] = 'F'; 
            seats[0, 4] = 'F'; 


       
            seats[1, 0] = 'F';
            seats[1, 1] = 'F';
            seats[1, 2] = 'S';
            seats[1, 3] = 'F';
            seats[1, 4] = 'F';
            
            seats[2, 0] = 'F';
            seats[2, 1] = 'F';
            seats[2, 2] = 'F';
            seats[2, 3] = 'F';
            seats[2, 4] = 'F';

      
            seats[3, 0] = 'S';
            seats[3, 1] = 'S';
            seats[3, 2] = 'F';
            seats[3, 3] = 'S';
            seats[3, 4] = 'S';

            
            seats[4, 0] = 'F';
            seats[4, 1] = 'F';
            seats[4, 2] = 'F';
            seats[4, 3] = 'F';
            seats[4, 4] = 'F';

      
            seats[5, 0] = 'S';
            seats[5, 1] = 'S';
            seats[5, 2] = 'F';
            seats[5, 3] = 'S';
            seats[5, 4] = 'S';

            for (int row = 0; row < seats.GetLength(0); row++)
            {
                
                for (int col = 0; col < seats.GetLength(1); col++)
                {
                    
                    Console.Write("{0}{1}:{2}\t", rowLetters[row], col + 1, seats[row, col]);

                    
                }

               
                Console.Write("\n");
            }


            Console.ReadLine();


        }
    }
}
