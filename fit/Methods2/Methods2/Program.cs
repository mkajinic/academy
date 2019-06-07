using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {

            //invoke/call our Display() method
            Display();
            Display();
            Display();
            Display();
            // invoke Loop() method
            Loop();
            LoopXTimes(8);

            Console.WriteLine(" I am back in the display method");
            Console.ReadLine();

        }//end of main method






        // Custom defined void method
        static void Display()
        {
            Console.WriteLine(" I am inside the display method");
           
        }


        static void Loop()
        {
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine("I have looped " + (i+1) + "times");
            }
        }//end of Loop method



        // A method with one single parametar of an int
        static void LoopXTimes(int numOfLoops)
        {
            for (int i = 0; i < numOfLoops ; i++)
            {
                Console.WriteLine("Inside the LoopXTimes. I have looped " + (i+1) + "times");
            }

        }//end of LoopXTimes()





       


    }
}
