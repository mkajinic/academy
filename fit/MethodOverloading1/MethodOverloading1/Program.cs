using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.MoveForward();
            car1.MoveForward(23.5);
            car1.MoveBackward(30.5);

            Program.TestStaticMethod();
            Console.ReadLine();
            
                


        }

        static void TestStaticMethod()
        {
            Console.WriteLine(" I am a static method that is part of the Program class");
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
        //These are instant methods (as opposed to static methods)
        public void MoveForward()
        {
            Console.WriteLine("The car moves forward.");
        }

        //an Overloaded version of 'MoveForward' method, that takes parametar that signify how far the car should move
        public void MoveForward(double meters)
        {
            Console.WriteLine("The car moves forward: {0} meters.", meters);
        }


        public void MoveBackward()
        {
            Console.WriteLine("The car moves backward.");
        }

        //an Overloaded version of 'MoveBackward' method, that takes parametar that signify how far the car should move
        public void MoveBackward(double meters)
        {
            Console.WriteLine("The car moves backwards : {0} meters." , meters);
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
