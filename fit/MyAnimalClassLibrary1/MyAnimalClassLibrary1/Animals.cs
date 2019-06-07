using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAnimalClassLibrary1
{
     public abstract class Animal
    {
        //The Animal constructor first calls Object class constructor 
        //shared static field
        private static int animalCount;

        //instance fields
        public int numberOfLegs;
        public bool canSwim;
        public bool canFly;

        public Animal()
        {
            Console.WriteLine("A new Animal has been created.");
            animalCount++;
        }


        public static void showAnimalCount()
        {
            Console.WriteLine(animalCount + " animals have been created.");
        }

        //behaviour
        public virtual void makeNoise()
        {
            Console.WriteLine("The animal is making noise.");
        }

        //override the inherited toString() method
        public override string ToString()
        {
            string classType = this.GetType().Name;
            return classType;
        }
    }//End of Animal



    //Reptile is a subclass of Animal
   public  abstract class Reptile : Animal
    {
        private static int reptileCount;

        public Reptile()
        {
            //The Reptile constructor first calls it's parents constructor which is Animal
            //Animals constructor code will be executed first and then it returns to finish constructing the Reptile object 

            Console.WriteLine("A new Reptile has been created");
            reptileCount++;
        }

        public static void showReptileCount()
        {
            Console.WriteLine(reptileCount + " reptiles have been created");
        }


    }//end of Reptile

   public class Snake : Reptile
    {
        private static int snakeCount;

        public Snake()
        {
            Console.WriteLine("\nA new Snake has been created");
            snakeCount++;
        }

        public static void showSnakeCount()
        {
            Console.WriteLine(snakeCount + " snakes have been created.");
        }

        //Snakes can slither
        public void slither()
        {
            Console.WriteLine("The slithery snake is slithering");
        }

        //overriding the inherited method
        public override void makeNoise()
        {
            Console.WriteLine("The snake says ssssssss.");
        }
    }

   public class SpecialSnake : Snake
    {

    }

  public  class Lizard : Reptile
    {
        private static int lizardCount;

        public Lizard()
        {
            Console.WriteLine("\nA new Lizard has been created");
            lizardCount++;
        }

        public static void showLizardCount()
        {
            Console.WriteLine(lizardCount + " lizards have been created.");
        }

        //overriding the inherited method
        public override void makeNoise()
        {
            Console.WriteLine("The lizard says ....psszzzzzz...huhzz...");
        }
    }

   public abstract class Mammal : Animal
    {
        private static int mamalCount;

        public Mammal()
        {
            Console.WriteLine("A new Mammal has been created");
            mamalCount++;
        }
        public static void showMammalCount()
        {
            Console.WriteLine(mamalCount + " Mammals have been created.");
        }
    }

   public class Horse : Mammal
    {
        private static int horseCount;

        public Horse()
        {
            Console.WriteLine("A new horse has been created");
            horseCount++;
        }

        public static void showHorseCount()
        {
            Console.WriteLine(horseCount + " horses have been created.");
        }



    }

   public class Unicorn : Horse
    {
        private static int unicornCount;

        public Unicorn()
        {
            Console.WriteLine("A new Unicorn has been created");
            unicornCount++;
        }
        public static void showUnicornCount()
        {
            Console.WriteLine(unicornCount + " horses have been created.");
        }


    }

   public class Pegasus : Horse, IFlyer
    {
        private static int pegasusCount;

        public Pegasus()
        {
            Console.WriteLine("A new Pegasus has been created");
            pegasusCount++;
        }

        public void Dive()
        {
            Console.WriteLine("The pegasus is diving? Really?!");
        }

        public void FlapWings()
        {
            Console.WriteLine("The Pegasus is flaping his wings, cause he can!");
        }

        public void FlyUp()
        {
            Console.WriteLine("Pegasus is flyiiiiiing");
        }

        public void Soar()
        {
            Console.WriteLine("Pegasus is soaring...");
        }
    }


   public class Donkey : Horse
    {
        private static int donkeyCount;

        public Donkey()
        {
            Console.WriteLine("A new Donkey has been created");
            donkeyCount++;
        }
        public static void showDonkeyCount()
        {
            Console.WriteLine(donkeyCount + " horses have been created.");
        }



    }
   public sealed class Mule : Donkey
    {
        private static int muleCount;

        public Mule()
        {
            Console.WriteLine("A new mule has been created");
            muleCount++;
        }

        public static void showMuleCount()
        {
            Console.WriteLine(muleCount + " Mules have been created.");
        }




    }

 public    class Dog : Mammal
    {
        private static int dogCount;

        public Dog()
        {
            Console.WriteLine("A new dog has been created");
            dogCount++;
        }

        public static void showDogCount()
        {
            Console.WriteLine(dogCount + " dogs have been created.");
        }
    }
   public  class Hound : Dog
    {
        private static int houndCount;

        public Hound()
        {
            Console.WriteLine("A new Hound has been created");
            houndCount++;
        }

        public static void showHoundCount()
        {
            Console.WriteLine(houndCount + " Hounds have been created.");
        }
    }
  public   class Terrier : Dog
    {
        private static int terrierCount;

        public Terrier()
        {
            Console.WriteLine("A new Terrier has been created");
            terrierCount++;
        }

        public static void showTerrierCount()
        {
            Console.WriteLine(terrierCount + " Terrier have been created.");
        }
    }

   public class Cairn : Terrier
    {
        private static int cairnCount;

        public Cairn()
        {
            Console.WriteLine("A new Terrier has been created");
            cairnCount++;
        }

        public static void showCairnCount()
        {
            Console.WriteLine(cairnCount + " cairns have been created.");
        }
    }

   public  class Yorkshire : Dog
    {
        private static int yorkshireCount;

        public Yorkshire()
        {
            Console.WriteLine("A new Yorkshire has been created");
            yorkshireCount++;
        }

        public static void showYorkshireCount()
        {
            Console.WriteLine(yorkshireCount + " yorkshires have been created.");
        }

    }

   public class Cat : Mammal
    {
        private static int catCount;

        public Cat()
        {
            Console.WriteLine("A new Cat has been created");
            catCount++;
        }

        public static void showCatCount()
        {
            Console.WriteLine(catCount + " cats have been created.");
        }

    }

   public class Bird : Mammal
    {
        private static int birdCount;

        public Bird()
        {
            Console.WriteLine("A new Bird has been created");
            birdCount++;
        }

        public static void showBirdCount()
        {
            Console.WriteLine(birdCount + " Birds have been created.");
        }
    }

  public   class Pigeon : Bird, IFlyer
    {
        private static int pigeonCount;

        public Pigeon()
        {
            Console.WriteLine("A new Pigeon has been created");
            pigeonCount++;
        }

        public static void showPigeonCount()
        {
            Console.WriteLine(pigeonCount + " Pigeons have been created.");
        }

        public void Dive()
        {
            Console.WriteLine("The pigeon is diving! Ever seen that?...");
        }

        public void FlapWings()
        {
            Console.WriteLine("The pigeon is flapping wings...");
        }

        public void FlyUp()
        {
            Console.WriteLine("The pigeon is flying high...");
        }

        public void Soar()
        {
            Console.WriteLine("The pigeon is soaring in the sky over buildings...");
        }
    }

   public class Chicken : Bird
    {
        private static int chickenCount;

        public Chicken()
        {
            Console.WriteLine("A new Chicken has been created");
            chickenCount++;
        }

        public static void showChickenCount()
        {
            Console.WriteLine(chickenCount + " Chickens have been created.");
        }
    }

    public class Duck : Bird, IFlyer
    {
        private static int duckCount;

        public Duck()
        {
            Console.WriteLine("A new Duck has been created");
            duckCount++;
        }

        public static void showDuckCount()
        {
            Console.WriteLine(duckCount + " Ducks have been created.");
        }
        //Implementation of the IFlyer interface method
        public void FlapWings()
        {
            Console.WriteLine("The duck is flapping wings...");
        }
        public void FlyUp()
        {
            Console.WriteLine("The duck is flying!!");
        }
        public void Dive()
        {
            Console.WriteLine("The duck is diving and looking cute ");
        }
        public void Soar()
        {
            Console.WriteLine("The duck is soaring, whatever that means.. ");
        }

    }

    //Define an interface
  public  interface IFlyer
    {
        //Methods in an interface are by default public and abstract
        //abstract method FlapWings()
        void FlapWings();


        //abstract method FlyUp()
        void FlyUp();


        // abstract method Dive()
        void Dive();


        // abstract method Soar()
        void Soar();


    }
}
