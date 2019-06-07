using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello.");

            //string variable
            string myText = "Magdalena";

            Console.WriteLine(myText);

            //Pause the console and wait for input
            string youSaid = Console.ReadLine();

            Console.WriteLine("You said: " + youSaid);

            //Pause the console again with a ReadLine
            Console.ReadLine();


        }
    }
}
