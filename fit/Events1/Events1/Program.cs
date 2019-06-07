using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events1
{
    class Program
    {
        static void Main(string[] args)
        {
            Farmer joe = new Farmer();
            Farmer george = new Farmer();
            Donkey lolo = new Donkey();
            

            

            //subscribe the farmers HearsDonkey event handler method to the Donkey Speaks Event
            lolo.Speaks += joe.HearsDonkey;
            lolo.Speaks += george.HearsDonkey;

            lolo.SayNey();

            //Unsubscribe farmer george
            lolo.Speaks -= george.HearsDonkey;


            lolo.SayNey();

            //Unsubscribe farmer joe
            lolo.Speaks -= joe.HearsDonkey;

            lolo.SayNey();

            //Make a third farmer and subscribe his HearDonkey method to the event
            Farmer bill = new Farmer();
            lolo.Speaks += bill.HearsDonkey;


            //then make the donkey say ney
            lolo.SayNey();




            Console.ReadLine();

               
        }
    }

    class Donkey
    {
        //Declare that the Donkey has a Speaks event

        public event EventHandler Speaks;

        
        public void SayNey()
        {
            Console.WriteLine("Hee haw...");
            //Raise the Speaks event 
            //but only if it has subscribers
            if (Speaks != null)
            {
                Speaks(this, EventArgs.Empty);
            }
            
        }
    }

    class Farmer
    {
        //Declare an Event handler to respond to the Donkey Speaks event 
        public void HearsDonkey(object o, EventArgs e)
        {
            Console.WriteLine("Farmer hears donkey");
        }
    }

}
