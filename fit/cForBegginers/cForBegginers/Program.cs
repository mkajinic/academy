using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cForBegginers
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Write a number ");
            double num = Convert.ToDouble (Console.ReadLine());

            Console.Write("Enter another number ");
            double  num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Total: " +( num + num1));

            Console.ReadLine();


        }
    }
}
