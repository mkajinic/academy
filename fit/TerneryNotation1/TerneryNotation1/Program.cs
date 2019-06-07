using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerneryNotation1
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 5;

            //if x eaquals 5
            // == is the equality operator
            if(x==5)
            {
                Console.WriteLine("x is 5");
            }

            else
            {
                Console.WriteLine("x is not 5");
            }

            //Ternery notation
            //(condition)? true : false
            string message = (x == 5) ? "x is 5" : "x is not 5";
            Console.WriteLine(message);


            Console.ReadLine();

        }
    }
}
