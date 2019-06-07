using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratedTypes1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("I am blue");

            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("I am Magenta");

            string theMonth = "hfajd"; ///this is not great

            myMonths month = myMonths.Dec;
            Console.WriteLine(month );

            Employee emp1 = new Employee();
            Employee emp2 = new Employee();

            //Set the name and job description for each employee

            emp1.name = "Joe Smoe";
            emp1.jobDesc = JobDescription.Minion;

            emp2.name = "Mary Lou";
            emp2.jobDesc = JobDescription.Janitor;

            

            Console.ReadLine();
        }
    }

    //This will be an enumerated list of months of the year
    enum myMonths
    {
        Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec
    }

    enum JobDescription
    {
        Director, Minion, Janitor
    }


    class Employee
    {
        public string name;
        public  JobDescription jobDesc;

       
    }



}
