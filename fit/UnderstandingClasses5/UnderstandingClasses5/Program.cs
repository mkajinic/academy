using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingClasses5
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Ford";

            Car car2 = new Car("Toyota", "Pirus", "White", "45454D", 4);


            Console.WriteLine("car2 make: " + car2.Make );
            Console.WriteLine("car2 Model: " + car2.Model);
            Console.WriteLine("car2 Color: " + car2.Color );
            Console.WriteLine("car2 REg: " + car2.Reg );
            Console.WriteLine("car2 number of wheels: " + car2.NumOfWheels );

            Console.ReadLine();



            Car car3 = new Car("VW", "Golf", "white", "21545D", 4);




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


    } // end fo Car class





}
