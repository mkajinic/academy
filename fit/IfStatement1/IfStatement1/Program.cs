using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatement1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            x = 10;

            // if true...
            //code inside in the block will only get extecuted if the condition is true
            if (x > 5) //inside the () is condition of the if statement
            {
                Console.WriteLine(" x is greater than 5");
            }

            Console.ReadLine();
        }
    }
}
