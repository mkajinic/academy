using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DuckHunter1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Male Ducks and Hunter
            //When the Ducks quack any hunter listening shuld take a shot at it

            Duck duck1 = new Duck("Sid");
            Duck duck2 = new Duck("Arnold");


            Hunter hunter1 = new Hunter("Emer");
            Hunter hunter2 = new Hunter("Joe");

            duck1.HasQuacked += hunter1.HearsDuck;
            duck1.HasQuacked += hunter2.HearsDuck;

            duck2.HasQuacked += hunter1.HearsDuck;
            duck2.HasQuacked += hunter2.HearsDuck;


            duck1.Quack();
            duck2.Quack();

            
           
            Console.ReadLine();
        }
    }


    class Duck
    {   //Ducks have a name
        public string Name { get; set; }

        public Duck(string name) //Constructor to give them name
        {
            Name = name;
        }


        //Ducks can Quack and raise an event that Hunters hear

        public event EventHandler HasQuacked;

        public void Quack()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0} says Quack..Quack...Quack", Name);
            Console.ForegroundColor = ConsoleColor.Blue;

            SoundPlayer player = new SoundPlayer(Properties.Resource1.QuackQuack);
            player.Play();
            Thread.Sleep(1500);

            //if there is subscribers then they can quack/ raise the HasQuacked event
            if (HasQuacked != null)
            {
                HasQuacked(this, EventArgs.Empty);
            }

        }

        //Event handler to handle/respond to the ShootDuck  event
        


    }

    class Hunter
    {
        //Hunters have a name
        public string Name { get; set; }


        public Hunter (string name)
        {
            Name = name;
        }

        //When a hunter hears a duck i takes a shot at it

        public void HearsDuck (object o, EventArgs e) //event handler
        {
            if (o.GetType() == typeof(Duck))
            {
                //cast eh object ref to a duck
                Duck duck = (Duck)o;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hunter {0} shoots at {1} the duck!", Name, duck.Name);
                

                SoundPlayer player3 = new SoundPlayer(Properties.Resource1.gunshot1);
                player3.Play();

                Thread.Sleep(1000);
            }
            
        }

    }


}
