using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAnimalClassLibrary1;

namespace MakeAnimals3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
            {
                new Duck(), new Donkey(), new Chicken()
            };

            animals.Add(new Dog());

            
        }
    }
}
