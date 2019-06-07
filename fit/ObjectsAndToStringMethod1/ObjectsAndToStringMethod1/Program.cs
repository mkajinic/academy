using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndToStringMethod1
{
    class Program
    {
        static void Main(string[] args)
        {
            object o = new object();
            Console.WriteLine(o.ToString());

            //The ToString method or an object will be called on any object passed to Console.WriteLine();
            Console.WriteLine(o);

            Car car1 = new Car();
            car1.make = "Ford";



            Console.WriteLine(car1); //same as car.ToString();
            Console.WriteLine(car1.ToString ());

            Console.ReadLine();
        }
    }


    class Car
    {
        public string make;

        //override the inherited ToString method
        public override string ToString()
        {
            return "This " + this.GetType().ToString() + " is a " + make;
        }
        

    }


}
