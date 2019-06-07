using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketPrintLayout1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *************************************************
             The Peoples Theatre

             <Play Name> 				Date <dd/mm/yy>
             Row: <row>                 Seat Number: <seat>
             Price: € <price>

             **************************************************

            */
            Console.OutputEncoding = Encoding.Default; //fix euro symbol nos showing

            string playName = "Little Shop of Horrors";
            string playDate = "10/10/2019";
            string rowLetter = "A";
            string seatNumber = "7";
            string price = "7.5";

            Console.WriteLine("************************************************");
            Console.WriteLine("         The Peoples Theatre Presents  ");
            Console.WriteLine("\n");
            Console.WriteLine(playName + "\t  " + "      Date: " + playDate);
       
            Console.WriteLine("Row: " + rowLetter + "\t\t\t\tSeat: " + seatNumber );
            Console.WriteLine("Price € " + price + "\n" );
            Console.WriteLine("************************************************");


            Console.ReadLine();
        }
    }
}
