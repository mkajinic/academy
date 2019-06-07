using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            a1.number = 45;
            a1.IamAnA();

            B b1 = new B();
            b1.number = 55;
            b1.IamAnA();

            C c1 = new C();
            c1.number = 45;
            c1.IamAnA();

            a1.number = 23;

            b1.number = 34;
            b1.number2 = 34;

            c1.number = 56;
            c1.number2 = 56;
            c1.number3 = 45;

            b1.IamB();

            c1.IamB();


            //Lets see all the IamAnA() methods for each object
            Console.WriteLine();
            a1.IamAnA();
            b1.IamAnA();
            c1.IamAnA();


            Console.ReadLine();
        }
        

    }


    class A //A inherits object ( A : Object ) 
    {
        public int number;

        public A()
        {
            Console.WriteLine("New A object has been created");
        }


        public virtual void IamAnA() //virtual means it can be overwritten by subclasses
        {
            Console.WriteLine("I am an A object");

        }

    }


    //Class B sublclasses Class A (class B extence class A
    //clas B inherits from class A
    class B : A // : means that class B inherits Class A
    {
        public int number2; //instance

        public void IamB()
        {
            Console.WriteLine("I am an B object");
        }

        public override void IamAnA() // implementation of the inherited method
        {
            Console.WriteLine("I am the new Method from the B class ");

        }

    }



    //class C inherits from class B
    class C : B
    {
        public int number3;
    }



}
