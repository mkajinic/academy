using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting1
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 77;
            //the compiler will implicity convert x to double
            double d = x;

            double d2 = 2500000000.999999;


            //Explicitly cast the double d to int 
            //This will truncate the decimal component of the double
            // its gonna round the number
            int x2 = (int) d2;

            Console.WriteLine(x2);

            int myInt = 67;

            //We can cast ain int  to char
            char myChar = (char) myInt;
            Console.WriteLine(myChar );



            //Implicit conversation happens
            char myChar2 = 'B';
            int myInt2 = myChar2;

            Console.WriteLine(myInt2 );
            Console.ReadLine();





        }
    }
}
