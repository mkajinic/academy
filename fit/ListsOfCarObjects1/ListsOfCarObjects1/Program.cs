using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsOfCarObjects1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car("Ford", "Focus", "Black", 2015);


            //Check how many car objects we have
            Car.GetTotalCarsCreated();

            car2.MoveForward(23.56);
            car1.MoveForward(42.5);
            car1.MoveBackward(12.3);
            car2.MoveBackward(14.25);

           //car1.Beep();
           //car2.Beep();
           //car1.Beep();
           //car2.Beep();
           //car1.Beep();
           //car2.Beep();

            car1.CountBeep();
            car2.CountBeep();

            //Make an array of Car objects 
            Car[] carArray = new Car[3];

            carArray[0] = new Car(); // now put some car in the array
            carArray[1] = new Car ("Toyota", "Celica", "Red", 1971);
            carArray[2] = new Car();

            carArray[0].Make = "Toyota";
            carArray[0].Model  = "Pirus";
            carArray[0].Color = "Blue";
            carArray[0].Year  = 2010;


            //Make all the cars in array beep 
            foreach (Car currentCar in carArray )
            {
                currentCar.Beep();
            }

            //Make a list of cars
            List<Car> carList = new List<Car>();

            carList.Add(carArray[0]);
            carList.Add(carArray[1]);
            carList.Add(carArray[2]);

            //Change first car in the array from Toyota Pirus to Ford Galaxy 

            carArray[0].Make = "Ford";
            carArray[0].Model = "Galaxy";

            //check the make and model of the first car in the list
            Console.WriteLine("The first car in the lists make is " + carList[0].Make);
            Console.WriteLine("The first car in the lists model is " + carList.ElementAt(0).Model);

            //Lets remove the last car from the list
            carList.RemoveAt(2); // or carList.RemoveAt(carList.Count-1)

            //Lets check the lenght of the list (How many elements are in the list)
            Console.WriteLine("There are now {0} elements in the list", carList.Count);



            //Lets add two new cars on the list
            Car newCar1 = new Car();
            Car newCar2 = new Car("Nissan", "Almera", "Green", 1999);

            carList.Add(newCar1);
            carList.Add(newCar2);

            // Add some more cars to the list without creating a spererate standalone references
            //here we are creating new car objects and passing the return references into the lists 'Add' method
            carList.Add(new Car());
            carList.Add(new Car("BMW", "235i", "Red", 2014));



            //*************************************************************************************************************************

            //What cars are in the array

            Console.WriteLine("\n\n Cars in the array: " );
            for (int i = 0; i < carArray.Length ; i++)
            {
                if (carArray [i].Make != null)
                {
                    Console.WriteLine("Car at index {0}: -> Make: {1},  Model: {2} ", i, carArray[i].Make, carArray[i].Model);
                }
                else
                {
                    Console.WriteLine("Car at index {0}: -> Make: UNKNOWN,  Model: UNKNOWN " , i);
                }


            }
            //*****************************************************************************************************************************


            // What cars are in the list 
            Console.WriteLine("\n\n Cars in the list:");
            for (int i = 0; i < carList.Count ; i++)
            {
                if (carList [i].Make != null)
                {
                    Console.WriteLine("Car at index {0}: -> Make: {1},  Model: {2} ", i, carList[i].Make, carList[i].Model);
                }
                else
                {
                    Console.WriteLine("Car at index {0}: -> Make: UNKNOWN,  Model: UNKNOWN ", i);
                }

            }






            Console.ReadLine();

            
        }
    }


    //new Car class

    class Car
    {
        //A static shared field to hold the number of car created
        private static int totalCars;

        //An instance field to hold the number of times a car has beeped
        private  int beepCount;




        //This is an example of an encapsulation
        //Private data with access controlled trough a public property
        private string make;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }




        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }




        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }




        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }


        //Create a car no argument constructor
        public Car()
        {
            Console.WriteLine("New car object has been created.");
            totalCars++; // Increment the total number of cars
        }
        
        //Overloaded constructor
        public Car (string make, string model, string color, int year)
        {
            //We set the properties of the object
            //(Note we are not directly setting the private data)
            Make = make;
            Model = model;
            Color = color;
            Year = year;
            Console.WriteLine("A new car object has been created.");
            totalCars++; //Increment the total number of cars
        }

            


        // Provide a static method to allow the user of the class to see how many cars there currently are
        //we have total cars in private already, but this will be static method
        public static void GetTotalCarsCreated()
        {
            Console.WriteLine("There are currently {0} Car objects.", totalCars);
        }


        //Some car behaviours / Methods
        //This is an instance method
        public void MoveForward(double distance)
        {
            //if make and moder are not full
            if(this.make != null && this.model != null)
            { 
                //Then show the make and model for the car
                Console.WriteLine("The {0} {1} moved forward {2} meters", this.make , this.model , distance );
            }

            else
            {
                //else just outpout a generic line
                Console.WriteLine("The car moved {0} meters", distance );
            }

        }
    
        //Make a method for the car object to move backward 
        //This method should have a parametar of double for the distance
        //If the make and model in not null then we show which car make, model and color it is when we show it moving, otherwise we will just say the 'car is moving'

        public void MoveBackward (double distance)
        {

            if (make != null && model != null && color != null)
            {
                Console.WriteLine("The {0} {1} {2} moved backward {3} meters", color, make, model, distance );
            }
            else
            {
                Console.WriteLine("The car is moving");
            }


        }

        //Make a mehtod to make cars beep!
        // This methid will not take any parameters, and will show which car object is beeping based on its make and model
        //If the car dos not have a value fro its make/model then it should beep twice

        public void Beep ()
        {
            if (make != null && model != null )
            {
                Console.WriteLine("The {0} {1} {2} is beeping ", color, make, model );
                Console.Beep(650, 350);
                this.beepCount++; // Increment beep count by 1

            }
            else
            {
                Console.WriteLine("The car is beeping");
                Console.Beep(650,  500);
                Console.Beep(650, 500);
                this.beepCount +=2; //Increments beep count by two

            }

        }
      

        //Make a method that showes how many times a particular car instance beeped and show it working in the main method of the Program Class
        public void CountBeep()
        {

            if (make != null && model != null && color != null)
            {
                Console.WriteLine("The {0} {1} {2} {3} has beeped {4} times",year, color, make, model, beepCount );
            }
            else
            {
                Console.WriteLine("The car has beeped {0} times", beepCount );
            }


        }




    }



}
