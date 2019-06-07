using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseStatement2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 18;

            if (age >= 66)
            {
                Console.WriteLine("You are an pensioner");
            }
            // && is logical AND and for the whole condition to be true, both conditions must evaluate to true
            else if ( age < 66 && age >= 18)
            {
                Console.WriteLine("You are an adult");
            }
            else
            {
                Console.WriteLine("hey kid!");
            }

            Console.ReadLine();
        }
    }
}
