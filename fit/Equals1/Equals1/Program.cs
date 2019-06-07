using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equals1
{
    class Program
    {
        static void Main(string[] args)
        {
            // int, long, char, double, are primitive types
            int x = 5;
            int y = 5;
            int z = 6;
            int i = 12;
            int c = 'A';

            long l1 = 5;
            long l2 = 6L;
            long l3 = 5L;

            char char1 = 'A' ;
            char char2 = 'a';
            char char3 = 'A';

            double d1 = 23.45f;
            double d2 = 12;
            double d3 = 23.45;

           

            // == checks to see if the two values are the same (when it comes to primititive types
            
            if (x == y)
            {
                Console.WriteLine("x and y have the same value");
            }


            if (x == z)
            {
                Console.WriteLine("x and z have the same value");
            }

            //not equal operator !=
            if (char1  != char2 )
            {
                Console.WriteLine("char1 and char2 do not have the same value");
            }


            if (char3 == char2)
            {
                Console.WriteLine("char3 and char2 have the same value");
            }


            if (x == l1) //see the int value is equal to the long value, this works as the x (int) is promoted to a long
            {
                Console.WriteLine("x and l1 have the same value");
            }


            if (i == d2)//see the int value i is equal to the double value d2, this works as the i (int) is promoted to a double
            {
                Console.WriteLine("i  and d2 have the same value");
            }

            if (c == char1)
            {
                Console.WriteLine("c  and char1 have the same value");
            }

            //string type is an Object (not primitive type!)    
            string s1 = "Hello";
            string s2 = "hello";
            string s3 = "Hello";
            string s4 = "hello";

            // Comparing strings
            // == with objects checks to see if the two strings are actually the same object in memory
            if (s1 == s2)
            {
                Console.WriteLine("s1 and s2 are the same string");
            }

            if (s1 == s3)
            {
                Console.WriteLine("s1 and s3 are the same string");
            }

            //compare the values stored in strings
            if (s1.Equals(s3))
            {
                Console.WriteLine("s1 and s3 have the same value");
            }


            //compare the values stored in strings
            //This compares using case sensitivity
            if (s1.Equals(s2))
            {
                Console.WriteLine("s1 and s2 have the same value");
            }


            //compare the values stored in strings
            //This compares using case sensitivity
            if (s1.Equals(s2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("s1 and s2 have the same value");
            }

            Console.ReadLine();


        }
    }
}
