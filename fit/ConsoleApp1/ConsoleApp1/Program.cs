using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x++ < 5)
            {
                if (x % 2 == 0)
                    x+=2;
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
