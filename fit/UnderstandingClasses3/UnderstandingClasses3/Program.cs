using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingClasses3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car is the type/class
            //car is the reference to a Car object
            //new - create a new Car object in memory from our blueprint for Car Objects
            //Car() - is a constructor ( A special method)
            Car car1 = new Car();

            Car car2 = new Car();
            Car car3 = new Car();

            Console.ReadLine();

            //Define a Car type reference (variable)
            Car car4;
            car4 = new Car();  // create a new Car object and assign it the car4 reference


            //Define a Car type reference (variable)
            Car car5;

            // car5 and car4 are pointing to same object ( car5 is a reference to the same object that car4 is pointing to)
            //We still have only 4 car objects in memory
            car5 = car4;


            // Assign values to the properties of car4
            car4.Reg = "25R54M";
            car4.Color = "White";
            car4.Make = "Ford";
            car4.Model = "Focus";
            car4.NumOfWheels = 4;


            //Now lets check the calues of the properties of car5
            Console.WriteLine("Make and model of car5: {0} {1}", car5.Make, car5.Model );

            //car4 and car5 are the same object
            Console.WriteLine("Make and model of car4: {0} {1}", car4.Make, car4.Model);

            //We can acces the same ovject with either reference and change its properties
            car5.Make = "Toyota";
            car4.Model = "Yaris";

            Console.WriteLine("Make and model of car4: {0} {1}", car4.Make, car5.Model);


            // Lets check the  properties for car1 

            Console.WriteLine("car1 make: " + car1.Make );
            Console.WriteLine("car1 Model: " + car1.Model );
            Console.WriteLine("car1 color: " + car1.Color );
            Console.WriteLine("car1 Reg: " + car1.Reg );
            Console.WriteLine("car1 number of wheels: " + car1.NumOfWheels );


            //Create abitger car reference
            Car car6 = null; // this will have value of 'null'

            //is car6 'null' ???
            if (car6 == null)
            {
                Console.WriteLine("car6 is not pointing to an object");
            }

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
        public Car ()
        {
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


    } // end fo Car class


}
