using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch1
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 5;

            if (x > 10)
            {
                Console.WriteLine("x is greater than 6");
            }
           else if (x > 8)
            {
                Console.WriteLine("x is greater than 8");
            }
            else if (x > 6 )
            {
                Console.WriteLine("x is greater than 6");
            }
            else 
            {
                Console.WriteLine("x is a mistery");
            }
            


            var y = 6;
            switch (y)
            {
                case 10: Console.WriteLine("y is 10");
                    break;
                case 9: Console.WriteLine("y is 9");
                    break;
                case 8: Console.WriteLine("y is 8");
                    break;
                case 7:
                case 6:
                case 5:
                    Console.WriteLine("y is 5, 6 or 7");
                    break;
                default:
                    Console.WriteLine("y is a mistery");
                    break;
            }//end of switch
            Console.ReadLine();









        }
    }
}
