using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventArgs1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Brian");

            Owner kevin = new Owner("Kevin");

            //Subscribe the owner event handle to the dog event HasBarked
            dog1.HasBarked += kevin.HearsDog;

            dog1.Bark(Feeling.Tired);

            Console.ReadLine();
        }
    }


    class Dog
    {
        public string Name { get; set; }

        public event EventHandler HasBarked;

        public Dog (string name)
        {
            Name = name;
        }

        public void Bark (Feeling feeling )
        {
            Console.WriteLine("{0} the doggito is barking", Name);
            SoundPlayer player = new SoundPlayer(Properties.Resource1.puppy_barking);
            player.Play();

            if (HasBarked != null)
            {
                HasBarked(this, new HasBarkedArgs(feeling));
            }

        }
    }


    class Owner
    {
        public string Name { get; set; }

        public Owner(string name)
        {
            Name = name;
        }

        //event handler
        public void HearsDog (object o, EventArgs e)
        {
            if (o.GetType() == typeof(Dog))
            {

                if (e.GetType() == typeof(HasBarkedArgs))
                {
                    //casting e to HasBarkedArgs reference
                    //so that we can access the feeling and time
                    HasBarkedArgs args = (HasBarkedArgs)e;

                    if(args.feeling == Feeling.Scared)
                    {
                        Thread.Sleep(2000);
                        Console.WriteLine("{0} the owner says awwww poor {1}", Name, ((Dog)o).Name);
                        SoundPlayer player1 = new SoundPlayer(Properties.Resource1.aww);
                        player1.Play();
                    }
                    else if (args.feeling == Feeling.Tired)
                    {
                        Thread.Sleep(2000);
                        Console.WriteLine("{0} the owner says shush {1} its {2} I wanna sleep!", Name, ((Dog)o).Name, args.time);
                        SoundPlayer player1 = new SoundPlayer(Properties.Resource2.Shush1);
                        player1.Play();
                    }
                    else
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("Be quiet. Luda pasica!", Name, ((Dog)o).Name);
                        SoundPlayer player1 = new SoundPlayer(Properties.Resource2.Shush1);
                        player1.Play();
                        Thread.Sleep(500);
                        player1.Play();
                    }

                    

                    
                }


            }
        }

    }

    class HasBarkedArgs : EventArgs
    {

        public Feeling feeling;

        public string time;


        public HasBarkedArgs(Feeling feels)
        {
            feeling = feels;
            time = DateTime.Now.ToShortTimeString();
        }


    }


    public enum Feeling
    {
        Happy, Sad, Scared, Hungry, Playful, Tired
    }

}
