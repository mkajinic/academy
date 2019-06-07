using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysOf_References1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stuff[] things = new Stuff[5];
            things[0] = new Stuff();
            things[1] = new Stuff();
            things[2] = new Stuff();
            things[3] = new Stuff();
            things[4] = new Stuff();


            things[2].description = "A cuddly monkey toy";
            things[2].name = "George";

            // a standaline reference to the same object in things[2]
            Stuff thirdThing = things[2];

            thirdThing.name = "Kevin";

          


        }
    }


    class Stuff
    {
        public string name;
        public string description;
    }

}
