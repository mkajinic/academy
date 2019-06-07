using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVsInstanceMethods1
{
    class Program
    {


        static void Main(string[] args)
        {
            //'p' is an instance of the class ('p' is an object)
            Program p = new Program();

            //Static method needs to be accessed though the class (not an object)
            Program.TestStaticMethod(); //we can call the TestStaticMethod method without calling the Program. (eg. we can just write TestStaticMethod();

            p.TestInstanceMethod();
           // p.TestStaticMethod();  // this can't be accesed 
            Console.ReadLine();


        }

        //static class method
        static void TestStaticMethod()
        {
            Console.WriteLine("I am static void Method Inside the programme class");
        }

        //An instance method
        void TestInstanceMethod()
        {
            Console.WriteLine("I am instance  Method Inside the Programme class object");
        }



    }







}
