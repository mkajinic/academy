using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeVehicles1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Tank tank1 = new Tank();
            Bicycle bike1 = new Bicycle();
            Boat boat1 = new Boat();

            Console.ReadLine();

           
        }


           
        }
    }

    public  class Car : IRemoteControl
    {
        private static int carCount;
        public int numOfWheels;
        public string carReg;
        public string carcolor;

        public Car()
        {

            Console.WriteLine("A new car has been created");
            carCount++;
        }


        public static void ShowCarCount()
        {
            Console.WriteLine(carCount + " cars have been created.");
        }

        public void MoveForward(double distance)
        {
            Console.WriteLine("Car Moved forward {0} meters. ", distance);
        }

        public void MoveBackWards(double distance)
        {
            Console.WriteLine("Car Moved backward {0} meters. ", distance);
        }

        public void TurnRight(double degrees)
        {
            Console.WriteLine("Car Turned left {0} degrees. ", degrees);
        }

        public void TurnLeft(double degrees)
        {
            Console.WriteLine("Car Turned left {0} degrees. ", degrees);
        }
    }

    public class Tank : IRemoteControl
    {
        private static int tankCount;
        public string tankReg;
        public string tankColor;

        public Tank()
        {

            Console.WriteLine("A new tank has been created");
            tankCount++;
        }

        public static void ShowTankCount()
        {
            Console.WriteLine(tankCount + " tanks have been created.");
        }

        public void MoveBackWards(double distance)
        {
            Console.WriteLine("Tank Moved backward {0} meters. ", distance);
        }

        public void MoveForward(double distance)
        {
            Console.WriteLine("Tank Moved forward {0} meters. ", distance);
        }

        public void TurnLeft(double degrees)
        {
            Console.WriteLine("Tank Turned left {0} degrees. ", degrees);
        }

        public void TurnRight(double degrees)
        {
            Console.WriteLine("Tank Turned right {0} degrees. ", degrees);
        }
    }


    public class Bicycle : IRemoteControl
    {
        private static int bicycleCount;
        public static string bikeColor;
        public string typeOfBike;

        public Bicycle()
        {

            Console.WriteLine("A new bike has been created");
            bicycleCount++;
        }

        public static void ShowBikeColor()
        {
            Console.WriteLine("Bicycle is {0}", bikeColor );
        }

        public void MoveForward(double distance)
        {
            Console.WriteLine("Bike Moved forward {0} meters. ", distance);
        }

        public void MoveBackWards(double distance)
        {
            Console.WriteLine("Bike Moved backwards {0} meters. ", distance);
        }

        public void TurnRight(double degrees)
        {
            Console.WriteLine("Bike Turned Right {0} degrees. ", degrees);
        }

        public void TurnLeft(double degrees)
        {
            Console.WriteLine("Bike Turned left {0} degrees. ", degrees);
        }
    }


    public class Boat : IRemoteControl
    {
        private static int boatCount;
        public string size;
        public string boatColor;

        public Boat()
        {

            Console.WriteLine("A new Boat has been created");
            boatCount++;
        }


        public static void ShowBoatCount()
        {
            Console.WriteLine(boatCount + " boats have been created.");
        }

        public void MoveBackWards(double distance)
        {
            Console.WriteLine("Boat Moved backward {0} meters. ", distance);
        }

        public void MoveForward(double distance)
        {
            Console.WriteLine("Boat Moved forward {0} meters. ", distance);
        }

        public void TurnLeft(double degrees)
        {
            Console.WriteLine("Boat Turned left {0} degrees. ", degrees);
        }

        public void TurnRight(double degrees)
        {
            Console.WriteLine("Boat Turned right {0} degrees. ", degrees);
        }
    }



     public interface IRemoteControl
     {

        void MoveForward(double distance);

        void MoveBackWards(double distance);

        void TurnRight(double degrees);

        void TurnLeft(double degrees);




     }
        



}
