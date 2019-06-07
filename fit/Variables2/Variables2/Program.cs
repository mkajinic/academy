using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare some int variables
            int x,y,z;

            x = 6;
            y = 5;
            z = 2;

            //int can hold only whole number
            int result = x / (z + y);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
