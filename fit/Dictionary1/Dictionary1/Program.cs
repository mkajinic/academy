using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myThings = new List<string>();

            Dictionary<string, string> words = new Dictionary<string, string>();

            words.Add("Cat", "A ferocious animal");
            words.Add("Apple", "A tasty fruit that grows on a tree");
            words.Add("Fishstick", "A tasty stick of fish");

            Console.WriteLine(words["Apple"]);
          

            Dictionary<int, string> things = new Dictionary<int, string>();
            things.Add(12, "Noon");
            things.Add(8, "Eight");
            things.Add(-8, "Eight");


            Console.WriteLine(things[-8]);
            Console.ReadLine();
        }
    }
}
