using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingReferences1
{
    class Program
    {
        static void Main(string[] args)
        {
            Form1 myA = new Form1();

            Form2 myB = new Form2(myA);

            myA.number = 45;
            Console.WriteLine(myB.a.number);


            myB.a.number = 76;
            Console.WriteLine(myB.a.number);


            Console.ReadLine();

        }
    }




    class Form1
    {
        public int number { get; set; } //prop (tab-tab)

        public void IamAnA()
        {
            Console.WriteLine("I am an A object");
        }
            


    }//end of class A




    class Form2
    {
        public  Form1 a;


        public Form2(Form1 frm1)//constructor
        {
            this.a = frm1;
        }





    }//End of class B










}
