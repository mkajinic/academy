using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinerMax3000.Business;

namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Menu> MenusFromDatabase = Menu.GetAllMenus();
            Menu firstMenu = MenusFromDatabase[0];
            firstMenu.SaveNewMenuItem("Sarma", "Traditional Croatian dish", 30);
            MenusFromDatabase = Menu.GetAllMenus();


            Order hungryGuestOrder = new Order(); //instance of an order object

            foreach (Menu currentMenu in MenusFromDatabase)
            {

                foreach (MenuItem currentItem in currentMenu.Items)
                 {
                hungryGuestOrder.items.Add(currentItem);
                  }
            }

            Console.WriteLine("The total is: " + hungryGuestOrder.Total);

         
            Console.ReadLine();
             

        }
    }
}
