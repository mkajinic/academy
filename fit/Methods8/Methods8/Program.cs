using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods8
{
    class Program
    {
        static void Main(string[] args)
        {

            int myNumber = 10;

            //Call the Add22 method and assign the returned value the myNumber variable
             myNumber = Add22(myNumber);

            //Call the Minus55 method and assign the returned value the myNumber variable
            myNumber = Minus55 (myNumber);

            //Call the MultiplyBy3 method and assign the returned value the myNumber variable
            myNumber = MultiplyBy3  (myNumber);

            Console.WriteLine("MyNumber is now: " + myNumber );



           int  myNumber2 = 100;

            myNumber2 = MultiplyBy3 (Minus55 (Add22 (myNumber2) ) );

            Console.WriteLine("MyNumber2 is now: " + myNumber2);


            //Create a variable with a value of 50, and take 55 away, then mulitply it by 3 then add 22 then add 22 again
            //Then save the value

            int myNumber3 = 50;

            myNumber3 = Add22  (Add22  (MultiplyBy3 ( Minus55  (myNumber3) ) ) );
            Console.WriteLine("MyNumber3 is now: " + myNumber3 );


            Console.ReadLine();
        
        }//end of main method




        static int Add22 (int number)
        {
            return number + 22;
        }//end of Add22





        static int Minus55 (int number)
        {
            return number - 55;
        }//end of Minus5




        static int MultiplyBy3 (int number)
        {
            return number * 3;
        }//end of MultiplyBy3










    }
}
