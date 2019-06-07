using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine ("Hello");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");

            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();

            //for loop
            //used when  we can teremine the number of times 
            //code can be repeadetly executed


            for(int i =0 ; i < 4 ; i++ )
            {

                //code to be executed
                Console.WriteLine("Hello from inside the for loop");
            }//end of the for loop


            Console.ReadLine();
        }
    }
}
