using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare and initialise an int variable
            int counter = 5;

            Console.WriteLine("Press enter to start looping");
            Console.ReadLine();

            // for (initialisation-happens only once; conditoin to run the loop; what happenes at the end of each iteration)
            // i++  means increment the value of i by 1
            for(int i = 0; i < counter;  i ++)
            {
                Console.WriteLine("The value of the counter is: "+ counter);
                Console.WriteLine("The value of i is " + i);
            }//end of for loop

            Console.ReadLine();
        }
    }
}
