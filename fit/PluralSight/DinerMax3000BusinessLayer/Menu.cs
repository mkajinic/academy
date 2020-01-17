using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinerMax3000.Business.dsDinerMax3000TableAdapters; 

namespace DinerMax3000.Business
{
    public class Menu
    {
    
        public Menu() //constructor
        {
            Items = new List<MenuItem>();
        }

        private int _databaseId;

        public void SaveNewMenuItem(string Name, string Description, double Price)
        {
            MenuItemTableAdapter taMenuItem = new MenuItemTableAdapter();
            taMenuItem.InsertNewMenuItem(Name, Description, Price, DatabaseId);
        }

       public static List<Menu> GetAllMenus()
        {
            MenuTableAdapter taMenu = new MenuTableAdapter(); //create an instance of menuTableAdapter
            var dtMenu = taMenu.GetData(); //get mehtod will return the data table to us (var is used to sort out the type of object returned by method)

            //get the menu Items for the menu (outside the loop so we dont need to create it for every iteration
            MenuItemTableAdapter taMenuItem = new MenuItemTableAdapter();

            //create a list we want to return from our method
            List<Menu> allMenus = new List<Menu>();
            foreach (dsDinerMax3000.MenuRow menuRow in dtMenu.Rows) 
            {//within the loop we want to create a menu object based on values in the current row

                //create a new menu object
                Menu currentMenu = new Menu();

                currentMenu.DatabaseId = menuRow.Id; //set the value


                //set the values from the row
                currentMenu.Name = menuRow.Name;

                //finnaly add resulting object to the list
                allMenus.Add(currentMenu);

                var dtMenuItems = taMenuItem.GetMenuItemsByMenuId(menuRow.Id);
                foreach (dsDinerMax3000.MenuItemRow menuItemRow in dtMenuItems.Rows)
                {
                    currentMenu.AddMenuItem(menuItemRow.Name, menuItemRow.Description, menuItemRow.Price);
                }

            }
            return allMenus;

        }



        public void AddMenuItem(string Title, string Description, double Price)
        {
            MenuItem item = new MenuItem();
            item.Title = Title;
            item.Description = Description;
            item.Price = Price;
            Items.Add(item);
           
        }


        public string Name { get; set; }
        //create list to hold Items on the menu
        public List<MenuItem> Items { get; set; }

        public int DatabaseId
        {
            get
            {
                return _databaseId;
            }

            set
            {
                _databaseId = value;
            }
        }
    }
}
