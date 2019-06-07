using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables3
{
    class Program
    {
        static void Main(string[] args)
        {

            // The double type can be used to hold
            //number which have a decimal component

            double d;
            d = 12.5; //Assign a literal double value

            double d2;
            d2 = 12; //Assign a lieral int valude to d2

            int x = 40;

            //Assigning an int value to a double variable type
            double d3 = x;

            //We cannot assign double value to an int type
            //(without some additonal work on our part)
           // int y = d2;

            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            Console.ReadLine();

        }
    }
}
