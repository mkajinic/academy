using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events2
{
    class Program
    {
        static void Main(string[] args)
        {
            Donkey donkey1 = new Donkey("Kevin");
            Donkey donkey2 = new Donkey("Mary");
            Donkey donkey3 = new Donkey("Seamus");
            Donkey donkey4 = new Donkey("Geraldine");

            Farmer farmer1 = new Farmer("Michael Healy Rae");
            Farmer farmer2 = new Farmer("Jacky Healy Rae");

            //subscribe the farmer to the event
            donkey1.HasSpoken += farmer1.HearsDonkey;
            donkey2.HasSpoken += farmer2.HearsDonkey;
            donkey4.HasSpoken += farmer2.HearsDonkey;
            donkey3.HasSpoken += farmer1.HearsDonkey;


            //Make the donkey speak
            donkey1.Speaks();
            donkey2.Speaks();
            donkey3.Speaks();
            donkey4.Speaks();

            //unsubscribe event handlers
            donkey1.HasSpoken -= farmer1.HearsDonkey;
            donkey2.HasSpoken -= farmer2.HearsDonkey;
            donkey4.HasSpoken -= farmer2.HearsDonkey;
            donkey3.HasSpoken -= farmer1.HearsDonkey;

            Console.WriteLine("\nAll event handlers are unsubscribed");

            //Make the donkey speak
            donkey1.Speaks();
            donkey2.Speaks();
            donkey3.Speaks();
            donkey4.Speaks();

            //Subscribe the donkeys to the farmers HasCalledDonkey event
            farmer1.HasCalledDonkey += donkey1.HearsFarmer;
            farmer1.HasCalledDonkey += donkey2.HearsFarmer;
            farmer1.HasCalledDonkey += donkey3.HearsFarmer;

            farmer1.CallDonkey();

            Console.ReadLine();
                


        }
    }


    class Donkey
    {
        public string Name { get; set; }

        //Declare that Donkey has an event HasSpoken
        public event EventHandler HasSpoken;

        public Donkey(string name)
        {
            Name = name;
        }

        public void Speaks()
        {
            Console.WriteLine("Hee haw... hee haw...");
            //Only if the HasSpoken event has subscribers then we will raise the event
            if (HasSpoken != null)
            {
                HasSpoken(this, EventArgs.Empty);
            }

            
        }


        //Event handler to handle/respond to the CallsDonkey  event
        public void HearsFarmer( object o, EventArgs e)
        {
            if (o.GetType() == typeof(Farmer))
            {
                Farmer f = (Farmer)o;
                Console.WriteLine("{0} the donkey hears {1} the farmer", Name, f.Name);
            }
        }



    }



    class Farmer
    {
        public string Name { get; set; }

        //Farmers calls Donkey
        public event EventHandler HasCalledDonkey;

        public Farmer (string name)
        {
            Name = name;
        }
        

        //method
        public void CallDonkey()
        {
            Console.WriteLine("{0} calls the donkey! Here donkey donkey!", Name);
            //if the event has subscribers
            if(HasCalledDonkey != null)
            {
                //then rais the event
                HasCalledDonkey(this, EventArgs.Empty);
            }
            
        }



        //Event handler to handle/respond to the HasSpoken Donkey event
        public void HearsDonkey (object objectThatRaisedTheEvent, EventArgs e)
        {
            //cast the object reference to a donkey reference
            //d is a donkey reference
            //If is there because it's always better to check the type of the object
            if ( objectThatRaisedTheEvent.GetType() == typeof(Donkey))
            {
                Donkey d = (Donkey)objectThatRaisedTheEvent;
                Console.WriteLine("{0} hears {1} the donkey", Name, d.Name);
            }
        }
            
    }


}




