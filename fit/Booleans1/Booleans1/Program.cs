using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booleans1
{
    class Program
    {
        static void Main(string[] args)
        {
            // A boolean data type has only two values 'true' and 'false'

            bool myBoolean1 = true;
            bool myBoolean2 = false;

            if (myBoolean1 == true)
            {
                Console.WriteLine("myBoolean1 has a value of 'true'.");
            }


            else
            {
                Console.WriteLine("myBoolean1 has a value of 'false'.");
            }

            if (myBoolean2 == true)
            {
                Console.WriteLine("myBoolean2 has a value of 'true'.");
            }


            else
            {
                Console.WriteLine("myBoolean2 has a value of 'false'.");
            }



            // != not equal operator
            //if true is not equal to true, it is false......  if true != true
            if (myBoolean1 != true)
            {
                Console.WriteLine("myBoolean1 has a value of 'false'.");
            }

            else
            {
                Console.WriteLine("myBoolean1 has a value of 'true'.");
            }



            // != not equal operator
            //if (false != true) <- That's true!
            if (myBoolean2 != true)
            {
                Console.WriteLine("myBoolean2 has a value of 'false'.");
            }

            else
            {
                Console.WriteLine("myBoolean2 has a value of 'true'.");
            }


            // '!' negation operator
            //it will reverse the value of a boolean
            if (!myBoolean1 == false)
            {
                Console.WriteLine("myBoolean1 has a value of 'true'.");
            }

            //Using the negation operation (!) and the not equal (!=) operator
            if(!myBoolean1 != true ) //if false != false which is true
            {
                Console.WriteLine("myBoolean2 has a value of 'true'.");
            }


           


            Console.ReadLine();

        }
    }
}
