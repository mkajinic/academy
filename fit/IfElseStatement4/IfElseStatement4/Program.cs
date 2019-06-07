using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseStatement4
{
    class Program
    {
        static void Main(string[] args)
        {

            //If someone is 18 and has enough money they can buy drink at the bar

            int age;
            bool hasEnoughMoney;

            age = 18;
            hasEnoughMoney = true;

            // we use logical AND by using && operator to specify that both conditions have to be true
            if (age >= 18 && hasEnoughMoney == true)
            {
                Console.WriteLine("Here is your cocktail");
            }

            else
            {
                if (age <=18)
                {
                    Console.WriteLine("you can't buy a drink because you are underage");
                }
                else
                {
                    Console.WriteLine("you can't buy a drink because you are broke jack");
                }
                
            }

            Console.ReadLine();

        }
    }
}
