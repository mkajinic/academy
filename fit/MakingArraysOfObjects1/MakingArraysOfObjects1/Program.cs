using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingArraysOfObjects1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make an array of 10 ints
            int[] myInts = new int[10];

            //we assign value 5 to the fourth index
            //All other lements have a default value of '0'
            myInts[3] = 5;

            //create an array of strings
            //Each element is a null reference by default
            //as string is an object (reference type)
            string[] myString = new string[5];

            myString[0] = "I am the first string";
            myString[3] = "I am the fourth string";

            //Loop trough the myString array and see whats inside each element
            for (int i = 0; i < myString.Length ; i++)
            {
                Console.WriteLine(myString[i]);
            }


            //Make an array of 5 cars
            // new - is making array of type Car that can hold 5 cars
            // but we currently don't have any cars in it
            Car[] cars = new Car[5];

            //Lets put cars in the array! Yay!!!
            cars[0] = new Car();
            cars[1] = new Car("Ford", "focus", "Red", "1548", 4);
            cars[2] = new Car();
            cars[3] = new Car ("VW", "Golf", "Red", "1548", 4);
            cars[4]= new Car();

            //Lets show all the details of the 4th car in the array
            Console.WriteLine("4th car make: " +cars[3].Make );
            Console.WriteLine("4th car model: " + cars[3].Model );
            Console.WriteLine("4th car color: "+ cars[3].Color);
            Console.WriteLine("4th car reg: " + cars[3].Reg );
            Console.WriteLine("4th car wheels: " + cars[3].NumOfWheels);


            //Set the make the last car to "Nissan"
            cars[4].Make = "Nissan";



            //Make the 3rd and 4h beep  their horns

            //cars[2].BeepHorn(1000, false);
            //cars[2].BeepHorn(1000, true);
            


            //Make the 2nd car turn left and then move forward
            cars[1].TurnLeft();
            cars[1].MoveForward();

            //Make a car reference which points to the car in the third index of the array
            Car car3rd = cars[2];

            //set the properties of the car3rd
            car3rd.Make = "Nissan";
            car3rd.Model = "Almera";

            //check the properties of the 3rd car in the array
            Console.WriteLine("3rd Car make: " + cars[2].Make );
            Console.WriteLine("3rd Car model: " + cars[2].Model);

            //shows the same as above as both references point to the same car
            Console.WriteLine("3rd Car make: " + car3rd .Make);
            Console.WriteLine("3rd Car model: " + car3rd .Model);

            Console.ReadLine();

        }
    }



    class Car
    {
        // state / characteristics
        // Properties
        public string Reg { get; set; }
        public int NumOfWheels { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }


        //Define the default (no argument) constructor 
        //note this has no return type keyword (no void, int or string)
        public Car()
        {
            Console.WriteLine(" A new Car object has been created");
        }


        //Define another constructor 
        // that with 5 parameters
        public Car(string Make, string Model, string Color, string Reg, int wheels)
        {
            // 'this' is a special keyword that referst to the object itself
            // Prepending ' this.' to th eproperty in case will disambiguate between the object property 'Make' and the methods parameter 'Make'
            this.Make = Make;
            this.Model = Model;
            this.Color = Color;
            this.Reg = Reg;
            //no ambiguity here so no need for 'this' keyword
            NumOfWheels = wheels;

            Console.WriteLine(" A new Car object has been created");
        }



        // behaviours
        public void MoveForward()
        {
            Console.WriteLine("The car moves forward.");
        }

        public void MoveBackward()
        {
            Console.WriteLine("The car moves backward.");
        }

        public void TurnRight()
        {
            Console.WriteLine("The car turns right.");
        }

        public void TurnLeft()
        {
            Console.WriteLine("The car turns left.");
        }

        public void BeepHorn(int duration, bool angryBeep)
        {
            if (angryBeep == true)
            {
                Console.Beep(650, (duration + 1000));
                Console.Beep(650, (duration + 1000));
                Console.Beep(650, (duration + 1000));
                Console.Beep(650, (duration + 2000));
            }
            else
            {
                // Beep(frequency, duration in milliseconds)
                Console.Beep(650, duration);
                // Put the thread to sleep
                //Thread.Sleep(250);
                Console.Beep(650, duration + 500);
            }

        }


    } // end of Car class
}
