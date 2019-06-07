using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingClasses4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car();


            car1.Make  = "Ford";
            car1.Model  = "Focus";
            car1.Color = "white";
            car1.Reg = "1254d154";
            car1.NumOfWheels = 4;

            //Show some of the properties of car1
            Console.WriteLine("Make: " + car1.Make );
            Console.WriteLine("Model: " + car1.Model );

            // null the reference to car1
            car1 = null;

            //Show some of the properties of car1
            //The below code would not generate an Exception as car1 is null reference
            //Console.WriteLine("Make: " + car1.Make);
            //Console.WriteLine("Model: " + car1.Model);

            //Lets set some properties of car2

            car2.Make = "Toyota";
            car2.Model = "Pirus";

            //Create a reference to a Car type pointing to the same object as car2
            Car car3 = car2;


            //null the car2 reference 
            //car2 = null;

           // Console.WriteLine("car3 Make: " + car3.Make);
            //Console.WriteLine("car3 Model: " + car3.Model );

            //let's check the properties of car2
            //car2 is a null reference
           // Console.WriteLine("car2 Make: " + car2.Make);
           // Console.WriteLine("car2 Model: " + car2.Model);

            //If we null all references to an object it is no longer accesible, and it will be garbage collected by the .Net runtime
            car3 = null;
            //this will generate null reference exception
            Console.WriteLine(" car3 make: " + car3.Make);

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
