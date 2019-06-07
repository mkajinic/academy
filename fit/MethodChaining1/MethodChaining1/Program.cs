using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodChaining1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "     cheese  ";

            // I want to trim the string and make it upper case

            s1 = s1.Trim();
            s1 = s1.ToUpper();

            Console.WriteLine(s1);

            // I want to trim the string and make it upper case
            string s2 = "     banana ";

            s2 = s2.Trim().ToUpper();

            Console.WriteLine(s2);


            // I want to trim the string and make it upper case and get first three letters (subString)
            string s3 = "      NoVeMBBer   ";
            s3.Trim().ToUpper().Substring(0, 3);// we did not assign = to substing back to s3 variable
            Console.WriteLine("s3 is now: " + s3); //s3 is now:       NoVeMBBer



            s3 =  s3.Trim().ToUpper().Substring(0, 3);
            Console.WriteLine("s3 is now: " + s3); //s3 is now: NOV

            Console.WriteLine(s3 );


            // Trim the string and make it uppercase, get the first three letters (substring) and get the index of the letter 'N'  
            //if it exist in the subString IndexOf(char) -> returns an int

            string fish = "fish";
            Console.WriteLine(fish.IndexOf('h')); // index 3
            Console.WriteLine(fish.IndexOf('x')); // -1 as there is no ''x' in 'fish'

            string s4 = "   NoVemBEr  ";

            int indexOfN = s4.Trim().ToUpper().Substring(0, 3).IndexOf('N');

            Console.WriteLine("Index of N: " + indexOfN); //"Index of N: 0
            Console.WriteLine(s4); //NoVemBEr

            Console.ReadLine();
        }
    }
}
