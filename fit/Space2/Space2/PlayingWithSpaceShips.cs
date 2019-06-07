using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Space2
{
    class PlayingWithSpaceShips
    {
        static void Main(string[] args)
        {
            //Make two spaceships with captains
            //One has 2 crewmembers, other has 3
            //One ship has weapons and the other does not

            CrewMember captain2 = new CrewMember("John Hook", Role.Captain);
            SpaceShip ship2 = new SpaceShip("Neverland", captain2, 2, true);

            CrewMember captain3 = new CrewMember("Bugs Bunny", Role.Captain);
            SpaceShip ship3 = new SpaceShip("LooneyToons", captain3, 3, false);




            //Add crewmembers to each ship
            //Show the crew members of each spaceship, and show the name of spaceship they belong to
            ship2.crewMembers[0] = new CrewMember("Peter Pan", Role.Pilot);
            ship2.crewMembers[1] = new CrewMember("Wendy", Role.Engeneer);

                                                                                        //other way to do crew members
                                                                                        //Crewmember[] crew2 = new CrewMember[3]
                                                                                        //crew2[0] = new CrewMember("Peter Pan", Role.Pilot);
                                                                                        //crew2[1] = new CrewMember("Wendy", Role.Engeneer);   
                                                                                        //ship3.crewMembers = crew2;

            ship3.crewMembers[0] = new CrewMember("Lola", Role.Steward);
            ship3.crewMembers[1] = new CrewMember("Duffy Duck", Role.Cleaner);
            ship3.crewMembers[2] = new CrewMember("Pig", Role.Electrician);

            Console.WriteLine("\n'{0}' with captain {1} in command has following crew members: " , ship2.Name, captain2.Name  );

               


            Console.WriteLine("\n'{0}' with captain {1} in command has following crew members: ", ship3.Name, captain3.Name );
                 for (int i = 0; i < ship3.crewMembers.Length ; i++)
                 {
                Console.WriteLine("Name: " + ship3.crewMembers[i].Name + ",   Role: " + ship3.crewMembers[i].CrewMemberRole );
                 }


            //Try and fire each ships weapons
            //Show what happens when the weapons are depleted
            //Show what happend when the ship has no weapons

            ship2.fireWeapons(2);

            Console.WriteLine("\n\nLoneyToons ship turn: ");
            ship3.fireWeapons(25);

            ship2.ShowAllCrewMembers();
            ship3.ShowAllCrewMembers();
                

            


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
            if (hasWeapons == true) //if spaceship has weapons then shoot, sound weapons
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

        //method to show all crewmembers of the ship
        public void ShowAllCrewMembers()
        {
            foreach (CrewMember  crew in crewMembers )
            {
                Console.WriteLine("{0} the {1} is part of the crew of the {2} ", crew.Name, crew.CrewMemberRole, name );
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
