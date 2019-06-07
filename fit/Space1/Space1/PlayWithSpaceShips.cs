using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Space1
{
    class PlayWithSpaceShips
    {
        static void Main(string[] args)
        {

            CrewMember crewMember1 = new CrewMember("Mary Murphy", Role.Engeneer);

            //We can get the name of the CrewMember trough the  public property 'Name'
            Console.WriteLine(crewMember1.Name);

            //Show the role
            Console.WriteLine(crewMember1.CrewMemberRole);

            //Name is read only, can't change it
            //crewMember1.Name = "John Murphy";

            //Make a new crew member with role of captain
            CrewMember captain1 = new CrewMember("Jim Starboard", Role.Captain);

            //Lets make a spaceship..
            //It has weapons (true), 3 crew and a captain
            SpaceShip enterprise = new SpaceShip("The Enterprise", captain1, 3, true);

            //Show the number of crew capacity of the enterprise spaceship object
            Console.WriteLine("Number of crew mambers: " + enterprise.crewMembers.Length);

            // Now we want to put crew members in the enterprise
            enterprise.crewMembers[0] = crewMember1;
            enterprise.crewMembers[1] = new CrewMember("Josh Pluto", Role.Pilot);
            enterprise.crewMembers[2] = new CrewMember("Luke Skywalker", Role.Cook);


            //show the name of the 2nd crew member
            Console.WriteLine("The name of 2nd crew member is: " + enterprise.crewMembers[1].Name);

            //Show the role of the 2nd crew member
            Console.WriteLine("The role  of 2nd crew member is: " + enterprise.crewMembers[1].CrewMemberRole);

            //Show all of the crews names and roles (Loop)
            Console.WriteLine("\n'{0}' has the following crew members: ", enterprise.Name);



            //Loop trough the crew members
            for (int i = 0; i < enterprise.crewMembers.Length; i++)
            {
                Console.WriteLine(enterprise.crewMembers[i].Name + " - " + enterprise.crewMembers[i].CrewMemberRole);
            }


            foreach (CrewMember item in enterprise.crewMembers)
            {
                Console.WriteLine("Name: " + item.Name + "  Role: " + item.CrewMemberRole);
            }

            //Lets fire the ships weapons
            enterprise.fireWeapons(10);
            //fire the ship weapon again
            enterprise.fireWeapons(15);
            enterprise.fireWeapons(10);



            Console.ReadLine();
        }
    }

    class SpaceShip
    {
        //private instance field (all spaceships will have this)
        //this denotes weather spaceship has weapons
        private bool hasWeapons;

        private int weaponsCapacity = 20;



        //Field to hold the number of spaceships in the system 
        private static int spaceShipCount;


        private string name;
        //Read only Name (no 'set' accessesor)
        public string Name { get { return name; } }

        //Reference to a CrewMember object 
        CrewMember captain;

        //Private field to hold the capacity
        private int CrewCapacity;

        //Reference to CrewMember array object (never created an array)
        public CrewMember[] crewMembers;



        public SpaceShip(string name, CrewMember captain, int shipCapacity, bool hasWeapons)
        {
            this.name = name;
            this.captain = captain;
            this.CrewCapacity = shipCapacity;
            this.hasWeapons = hasWeapons;



            //Create the array of crew members
            //So that we can an array that can hold the required number of crew members
            crewMembers = new CrewMember[shipCapacity];

            spaceShipCount++;
            Console.WriteLine
              ("A new Spaceship called '{0}' is has been created," +
              " and the captain is '{1}' who commands {2} crew members",
                this.name, captain.Name, shipCapacity);

        }//end of constructor


        // Instance method to fire weapons
        public void fireWeapons(int fireTimes)
        {
            if (hasWeapons == true ) //if spaceship has weapons then shoot, sound weapons
            {

                Console.WriteLine("\nFiring weapons...");

                for (int i = 0; i < fireTimes; i++)
                {
                    //If we have weapons then fire
                    if (weaponsCapacity > 0)
                    {
                        Console.Beep(200, 300);
                        Console.Write("Phew! ");
                        Thread.Sleep(300); //to slow  down the shound (beep will go to sleep for 200 miliseconds)
                        weaponsCapacity--;
                    }
                    //otherwise we are a ded duck and time to abandon ship
                    else
                    { 
                        //Call 'ToTheEscapePods' just before we break the loop
                        ToTheEscapePods();
                        break; // break the loop as we have no weaponCapacity left

                    }//end of else

                }//end of for loop



            }
            else
            {
                ToTheEscapePods();
            }



        }//end of fireWeapons method



        private void ToTheEscapePods()
        {
            Console.WriteLine("Crikey. This ship has weapons we are a dead duck!");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("TO THE ESCAPE PODS! ");
                Console.Beep(650, 1000);
                Console.Beep(500, 1000);

            }
        }




    }

    enum Role
    {
        Captain, Engeneer, Cook, Electrician, Pilot, Steward, Cleaner
    }

    class CrewMember
    {
        //this is a private instance field
        private string name;

        //public read only property(because we removed set)
        public string Name { get { return name; } }

        public Role CrewMemberRole { get; set; }

        //Constructor to create the object and set the private field name
        public CrewMember(string name, Role role)
        {
            //this.name is not the property
            //it is the actual private field
            this.name = name;

            //Sets the enumerated value role
            CrewMemberRole = role;

        }


    }






}
