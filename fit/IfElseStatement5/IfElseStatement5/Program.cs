using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseStatement5
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte can store 0 - 255
            byte dice = 4;

           // if the dice is either a 3  or a 5  you win a prize


            //logical OR || operator
            // if either condition is true then the whole condition is true
            if (dice == 3 || dice ==5)
            {
                Console.WriteLine("You won!!!");
            }
            else
            {
                Console.WriteLine("Hard Luck!!!");
            }

            Console.ReadLine();

        }
    }
}
