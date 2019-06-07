using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace MakeVehicles2
{
    class Program
    {
        static void Main(string[] args)
        {
            IRemoteControl[] vehicles = new IRemoteControl[4];

            vehicles[0] = new Car();
            vehicles[1] = new Tank();
            vehicles[2] = new Boat();
            vehicles[3] = new Bicycle();

            Console.WriteLine("*********************************");
            vehicles[3].TurnRight(55.7);

            foreach (var currentVehicles in vehicles)
            {
                if (currentVehicles.GetType() == typeof(Car))
                {
                    
                    currentVehicles.MoveForward(45);
                    currentVehicles.MoveBackWards(13);
                }
                if (currentVehicles.GetType() == typeof(Boat))
                {

                    currentVehicles.MoveForward(74);
                    currentVehicles.TurnLeft(6);
                }

                //OR  if (item is Car)
                //{ ((Car)item.MoveForward(5)) }
                Console.WriteLine("------------------------");
                
            }

            Console.ReadLine();



        }
    }
}
