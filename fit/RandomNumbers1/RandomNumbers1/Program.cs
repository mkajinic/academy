using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers1
{
    class Program
    {
        static void Main(string[] args)
        {

            //We can use a built in class to generate random number
            //it is called the..... 'Random' class


            //we first create a new instance of the class
            //in order to use it to create random numbers

            Random myRandom = new Random();

            //Next() returns a non negative random number
            int randomNumber1 = myRandom.Next();
            Console.WriteLine("My randomNumber1 is: " + randomNumber1);

            randomNumber1 = myRandom.Next();
            Console.WriteLine("My randomNumber1 is: " + randomNumber1);

           randomNumber1 = myRandom.Next();
            Console.WriteLine("My randomNumber1 is: " + randomNumber1);

            //show the next 100 randon numbers

            for (int i = 0; i < 100; i++)
            {
                randomNumber1 = myRandom.Next();
                Console.WriteLine("My randomNumber1 is: " + randomNumber1);
            }


            //Generate a random number between 0 and 49 (50 is not included)
            int myRandomNumber2 = myRandom.Next(50);
            Console.WriteLine("myRandomNumber2 is: " + myRandomNumber2);


            //Generate a random number between 1000 and 2000 
            int myRandomNumber3 = myRandom.Next(1000, 2001);
            Console.WriteLine("myRandomNumber3 is: " + myRandomNumber3);

            //*************************************************************************************

            //Generating random doubles
            //Generates a random double between 0.0 and 1.0 (but never actually 1.0)
             double  myRandomDouble1 = myRandom.NextDouble();
               Console.WriteLine("my Random Double 1 is: " + myRandomDouble1);

            //Generating random doubles
            //Generates a random double between 0.0 and 100.0 (but never actually 1.0)
             myRandomDouble1 = (myRandom.NextDouble()) * 101;
            Console.WriteLine("my Random Double 1 is: " + myRandomDouble1);





            Console.ReadLine();       
        }
    }
}
