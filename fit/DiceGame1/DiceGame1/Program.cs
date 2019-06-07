using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make two dice, dice1 and dice2

            // You win if dice1 is either 1 or 6, and then dice2 is also  either 2 or 5
            // if both dices  are 4  you win a special prize

            byte dice1 = 5;
            byte dice2 = 1;

            if ((dice1 == 1 || dice1 == 6)  && (dice2 == 2 || dice2 == 5))
            {
                         Console.WriteLine("You won!!!");
            }
           
            else if (dice1 == 4 && dice2 == 4)
            {
                Console.WriteLine("Special prize");
            }

            else
            {
                Console.WriteLine("Try again");
            }

            Console.ReadLine();




           

        


        }
    }
}
