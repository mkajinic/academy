using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeAnimals2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            animals.Add(new Dog());
            animals.Add(new Duck());
            animals.Add(new Chicken());
            animals.Add(new Pigeon());
            animals.Add(new Cat());
            animals.Add(new Snake());
            animals.Add(new Hound());
            animals.Add(new Unicorn());
            animals.Add(new Donkey());
            animals.Add(new Snake());
            animals.Add(new Terrier());
            animals.Add(new Lizard());
            animals.Add(new Snake());
            animals.Add(new Pegasus());
            animals.Add(new Snake());
            animals.Add(new SpecialSnake());
            animals.Add(new SpecialSnake());
            animals.Add(new SpecialSnake());

            Console.WriteLine("***********************************");
            Animal.showAnimalCount();
            Console.WriteLine("***********************************");

            //see if 11th item is a snake
            if (animals[10].GetType() == typeof(Snake))
            {
                Console.WriteLine("Index 10 is a snake");
            }
            

            //see if the 9th Item is a snake
            if (animals [10] is Animal)
            {
                Console.WriteLine("Index 10 is a Animal");
            }
            if (animals[10] is Pegasus)
            {
                Console.WriteLine("Index 10 is a Pegasus");
            }

            //'is' to check if the Class is of the type anywhere in the hierarchy
            if (animals[8] is Mammal)
            {
                Console.WriteLine("Index 8 is a Mamal");
            }
            if (animals[0].GetType() == typeof(Mammal))
            {
                Console.WriteLine("Index 3 is a type of Mammal");
            }

            Console.WriteLine("\n**************find the snake *********************");

            //use a loop to find and count all the snakes in the list

            int snakeCount = 0;

            foreach (Animal currentAnimal in animals)
            {
                if (currentAnimal is Snake)
                {
                    snakeCount++;
                }
                
                /*if(currentAnimal.GetType() == typeOf(Snake))
                 * {
                 * snakeCount++;
                 * }
                */
            }


            int snakeCount2 = 0;
            //Show the indexes of where Snakes were found
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i].GetType() == typeof(Snake))
                {
                    Console.WriteLine("Snake found at index: " + i);
                }
                
            }

            Console.WriteLine("Found '{0}' snakes in the list", snakeCount);


            Console.WriteLine("\n**************find the snake and make them Slither *********************");

            foreach (var currentAnimal in animals)
            {
                //check to see if the current animal reference points to a Snake type
                if (currentAnimal.GetType() == typeof(Snake))
                {
                    //call slither method
                    //cast the current animal reference to a snake reference
                    Snake s1 = (Snake)currentAnimal;
                    s1.slither();
                    s1.makeNoise();
                    //...OR...
                    ((Snake)currentAnimal).slither();
                    currentAnimal.makeNoise();


                }
            }



            Console.ReadLine();

        }

    }

    abstract class Animal
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
    abstract class Reptile : Animal
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

    class Snake : Reptile
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

    class SpecialSnake : Snake
    {

    }

    class Lizard : Reptile
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

    abstract class Mammal : Animal
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

    class Horse : Mammal
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

    class Unicorn : Horse
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

    class Pegasus : Horse, IFlyer
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


    class Donkey : Horse
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
    sealed class Mule : Donkey
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

    class Dog : Mammal
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
    class Hound : Dog
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
    class Terrier : Dog
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

    class Cairn : Terrier
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

    class Yorkshire : Dog
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

    class Cat : Mammal
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

    class Bird : Mammal
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

    class Pigeon : Bird, IFlyer
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

    class Chicken : Bird
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

    class Duck : Bird, IFlyer
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
    interface IFlyer
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
