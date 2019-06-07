using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVsInstanceMethods3
{
    class Program
    {
        static void Main(string[] args)
        {

           // A.count = 10; //count is a private static field

            A myA1 = new A();
            A myA2 = new A();

            myA2.number = 10; // number is an instance propety
            myA1.number = 20;

            // myA1.TestPrivateMethod();    Unaccesible as its private
            // A.TestPrivateMethod();       Not a static method and its private 

            // Using the instance method to retrieve the static field 'count'
            myA1.HowManyObjectsAreThereNOw();
            myA2.HowManyObjectsAreThereNOw();


            Console.ReadLine();
        }

    }//End of Program class


    class A
    {
        // A class static field
        public static int count;


        //property -all object of type A will have its own copy
         public int number { get; set;  }



        public A()
        {
            count++; 
            Console.WriteLine("A new A object has been created");
            Console.WriteLine("There are now {0} A Objects", count);
            TestPrivateMethod();
        }

        //private instance method
        private void TestPrivateMethod()
        {
            Console.WriteLine("I am the private instance method");
        }
       
        // Public instance method that retrives (displayes) value stored in the shared class field 'count'
        public void HowManyObjectsAreThereNOw()
        {
            Console.WriteLine("There are now {0} A Objects", count);
        }

    }




}
