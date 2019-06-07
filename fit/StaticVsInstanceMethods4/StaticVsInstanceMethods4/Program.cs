using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVsInstanceMethods4
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit1 = new Fruit();
            Fruit fruit2 = new Fruit();

            fruit1.PriceName("apple", "7");
                
            


            Console.ReadLine();

        }
    }


    //Create a fruit class
    class Fruit
    {

        public static int count;

        public int FruitPrice { get; set; }

        public Fruit()
        {
            count++;
            Console.WriteLine("fruit");
        }
            

      
    }
       
   



}
