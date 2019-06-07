using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableScope1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10; //local variable with scope withing main method where it was declared
            int y = 20;

            WhatNumberAmI(5);
            Console.WriteLine("x is: " + x );
            Console.WriteLine(" y is: " + y);
            Console.ReadLine();

        }


        static void WhatNumberAmI(int x)
        {
            int y = 44;

            Console.WriteLine("The number was: " + x);
            Console.WriteLine("y is: " + y);
        }





    }
}
