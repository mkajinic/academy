using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseStatement1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            //if x is greater than or eaqual to 10
            if (x >= 10)
            {
                Console.WriteLine("x is greater than 10");
            }

            else
            {
                Console.WriteLine("x is not greater than 10");
            }

            Console.ReadLine();
        }
    }
}
