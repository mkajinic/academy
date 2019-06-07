using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make an array of 5 ints
            int[] myNums = new int[] { 1, 2, 3, 4, 5 };

            //Make two array of 5 strings in two different ways
            string[] myStrings1 = new string[5];
            myStrings1[0] = "Mary ";
            myStrings1[1] = "had ";
            myStrings1[2] = "a ";
            myStrings1[3] = "litle ";
            myStrings1[4] = "Lamb ";

            //Both arrays are the same lenght and have the same values
            string[] myStrings2 = new string[] { "Mary ", "had ", "a ", "little ", "lamb" };


            //Make two arrays of 5 doublles in two different ways
            double[] myDoubles1 = new double[5];

            myDoubles1[0] = 12.45;
            myDoubles1[1] = 5.5;
            myDoubles1[2] = 3;      //all ints fit inside double
            myDoubles1[3] = 100;    //all ints fit inside double
            myDoubles1[4] = 34.8f; //all floats fit inside double type
            
           
        
            //Another double array
            double[] myDoubles2 = new double[] {12.45, 5.5, 3, 100, 34.8f };

            //Creat a string called sentance that concatenates all the values in the string array myString1
            //but put spaces between each string
            //Display the string to the console

            string sentance = myStrings1[0] + myStrings1[1] + myStrings1[2] + myStrings1[3] + myStrings1[4]; // add literal space " " if thee is no space declared in variable
            Console.WriteLine(sentance);
            


            //Create a new double array. In this array save the addition of each corresponding index to the correspoding index in the newly created array
            //(index 1 of new array should hold the addition of the value at indexes 1 in the myDoubles1 arrays and the value of the myDoubles2 array

            double[] myResults = new double[5] { myDoubles1[0] + myDoubles2[0], myDoubles1[1] + myDoubles2[1], myDoubles1[2] + myDoubles2[2], myDoubles1[3] + myDoubles2[3], myDoubles1[4] + myDoubles2[4] };
            
            /*            or like this
            myResults[0] = myDoubles1[0] + myDoubles2[0];
            myResults[1] = myDoubles1[1] + myDoubles2[1];
            myResults[2] = myDoubles1[2] + myDoubles2[2];
            myResults[3] = myDoubles1[3] + myDoubles2[3];
            myResults[4] = myDoubles1[4] + myDoubles2[4];
            */


            Console.WriteLine("Addition result at index 0 is: {0}", myResults[0]);
            Console.WriteLine("Addition result at index 1 is: {0}", myResults[1]);
            Console.WriteLine("Addition result at index 2 is: {0}", myResults[2]);
            Console.WriteLine("Addition result at index 3 is: {0}", myResults[3]);
            Console.WriteLine("Addition result at index 4 is: {0}", myResults[4]);

            Console.ReadLine();
        }
    }
}
