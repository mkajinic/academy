using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings2
{
    class Program
    {
        static void Main(string[] args)
        {

            //string myString = " That summer we took threes across the board  ";

            //myString = myString.Substring(6, 14);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(6, 14);

            /*
            myString = String.Format("Lenght before: {0} -- Lenght after: {1}",
                myString.Length, myString.Trim().Length);
                */

            string myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
