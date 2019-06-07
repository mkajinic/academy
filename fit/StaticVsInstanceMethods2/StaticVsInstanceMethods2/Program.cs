using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVsInstanceMethods2
{
    class Program
    {
        static void Main(string[] args)
        {
            A myA = new A();

            //invoke the instance method on myA object 
            myA.IamAnInstanceMethod();


            //Invoke the static method in class A
            A.IamStaticMethod();

            B myB = new B();

            myB.SomeInstanceMethod();
            B.SomeStaticMethod();


            Console.ReadLine();



        }
    }


    class A
    {
        public void IamAnInstanceMethod()
        {
        Console.WriteLine( "I am an instance metod");
        } 
         
        public static void IamStaticMethod()
        {
            Console.WriteLine("I am an static metod");
        }





    }//end of A class



    class B
    {


        public void SomeInstanceMethod()
        {
            Console.WriteLine("I am an some instance metod in class B");
        }
        

        public static void SomeStaticMethod()
        {
            Console.WriteLine("I am an some static metod in class B");
        }


   
    }//end of B class
    






}
