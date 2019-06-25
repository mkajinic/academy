using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PayrollCalculations1
{
    class Program
    {

        struct Employee
        {
            public string name;
            public string pps;
            public double PersonalTaxCredit;
            public double PAYETaxCredit;
            public char prsiClass;
            public double salary;

        }

        //Declare an array to hold Employees structures
       static Employee[] employees;


        static void Main(string[] args)
        {
           
           

            Employee emp1 = new Employee();
            emp1.name = "John Smith";
            emp1.prsiClass = 'A';
            emp1.salary = 500;
            emp1.pps = "14E7854L";


            Employee emp2 = new Employee();
            emp2.name = "Jenny Toll";
            emp2.prsiClass = 'A';
            emp2.salary = 600;
            emp2.pps = "17L7758L";

            Employee emp3 = new Employee();
            emp3.name = "Mark Rust";
            emp3.prsiClass = 'A';
            emp3.salary = 600;
            emp3.pps = "74T7410";

            Employee emp4 = new Employee();
            emp4.name = "Tina Elis";
            emp4.prsiClass = 'A';
            emp4.salary = 550;
            emp4.pps = "741I8034";


            //Initialise the array
            employees = new Employee[4];

            //Get the employees in to the array
            employees[0] = emp1;
            employees[1] = emp2;
            employees[2] = emp3;
            employees[3] = emp4;



             double weeklySalary = 500;
            double taxCredits = 3300;


            // double usc;

            // Console.WriteLine("Weekly salary: " + weeklySalary);

            double annualSalary = CalculateAnnualSalary(weeklySalary);

           // Console.WriteLine("Annual Net Income: " +  annualSalary);

          //  Console.WriteLine("PAYE income tax: " + CalculatePAYE(annualSalary, taxCredits));

          //  Console.WriteLine("USC: " + CalculateUSC(annualSalary));
          //  Console.WriteLine("PRSI: " + CalculateWeeklyPRSI(weeklySalary, 'A')*52);

          //  PrintWeeklyNetPay(annualSalary);

           // PrintMainMenu();

           // Console.ReadLine();


            // Showing main menu 
            bool showMainMenu = true;

            while (showMainMenu)
            {
                PrintMainMenu();
                ConsoleKeyInfo keypressed = Console.ReadKey();

                //Main menu choice...If pressed 1 show all employees, if pressed X close app
                if (keypressed.Key == ConsoleKey.NumPad1 || keypressed.KeyChar == 49)
                {
                    ShowAllEmployees(employees);

                    Console.Write("\nEnter employee number and press enter.");

                    // Loop control variable
                    bool employeeList = true;
                    while (employeeList)
                    {
                        if (employees.Length > 0)
                        {
                          
                            ConsoleKeyInfo userchoice = Console.ReadKey();

                            //exit the app if user presses X
                            if (userchoice.Key == ConsoleKey.X)
                            {
                                ExitApp();
                            }

                            //Back to main menu
                            else if (userchoice.Key == ConsoleKey.B)
                            {
                                //Break the loop and go back to outer loop
                                employeeList = false;
                            }



                            // Option to PrintPayrolOptions for each employee
                            if (userchoice.Key == ConsoleKey.NumPad1 || userchoice.KeyChar == 49)
                            {
                                DisplaySubMenu();
                                try
                                {
                                    int optionNumber = int.Parse(Console.ReadLine());
                                    Console.WriteLine("\nWeekly salary of this employee is ", optionNumber);
                                    PrintWeeklyNetPay(annualSalary);
                                    PrintMainMenu();
                                    
                                }
                                catch (ArgumentOutOfRangeException ex1)
                                {

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("That option does not exist");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                catch (Exception ex2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("That wasn't a valid option");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                            }


                            //Option to show payslip if user presses number 2 
                            else if (userchoice.Key == ConsoleKey.NumPad2 || userchoice.KeyChar == 50)
                            {
                                
                                try
                                {
                                    int optionNumber = int.Parse(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("\n\tPayslip details for employee {0} ", optionNumber);
                                    PrintPayslip(employees[optionNumber -1].salary);
                                    PrintPayslip(weeklySalary);
                                   // PrintMainMenu();


                                }
                                catch (ArgumentOutOfRangeException ex1)
                                {

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("That option ID  does not exist");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                catch (Exception ex2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("That wasnt a valid option");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                            }


                            //If pressed no 3 show main menu
                            else if (userchoice.Key == ConsoleKey.NumPad3 || userchoice.KeyChar == 51)
                            {
                                //Back to Main menu
                                Console.Write("\nBack to Main menu.");
                                
                                try
                                {

                                    PrintMainMenu();
                                }
                                catch (ArgumentOutOfRangeException ex1)
                                {

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("That option does not exist");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                catch (Exception ex2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("That wasnt a valid option");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n\n Invalid option. Please choose a valid option");
                            }

                        }
                    }//end of while showMessageOptions

                }//end if pressed 1

                
            
               

                //E for exit, exit the App
                else if (keypressed.Key == ConsoleKey.X)
                {
                    ExitApp();
                    showMainMenu = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\nInvalid option selected. Please choose a valid option.");
                }



                Console.WriteLine();


            }// end of while loop




        }



        //Calculate income tax based on annual salary
        static double CalculatePAYE (double annualSalary, double taxCredits)
        {
            double incomeTax = 0;

            // 20% paid on the first €35,300 of earnings
            //40% paid on portion of earnings over €35,300
            if (annualSalary <= 0)
            {
                return incomeTax;
            }
            else
            {
                if (annualSalary <= 35300)
                {
                    //Tax at 20% 
                    incomeTax = annualSalary * .2;
                }
                else
                {
                    //40% paid on portion of earnings over €35,300
                    incomeTax = ((annualSalary - 35300) * .4) + (35300 * .2);
                }
            }


            // The PAYE Income tax liability is the total calculated tax - persons
            //tax credits
            double taxLiability =  incomeTax - taxCredits;

            //Tierny notiation
            //Retun income tax liabilty if it is greater
            return (taxLiability <= 0) ? 0 : taxLiability;

        }

        static double CalculateAnnualSalary (double weeklySalary)
        {
            return weeklySalary * 52;
        }



        static double CalculateUSC(double annualSalary)
        {
            double usc = 0;

            //if salary is greater than 13 000 and greater than 0
            if (annualSalary > 13000 && annualSalary > 0)
            {
                if (annualSalary > 70044)
                {
                    usc = ((annualSalary - 70044) * .08) + ((70044 - 19874) * .045) + ((19874 - 12012) * .02) + (12012 * .005);
                }
                else if(annualSalary <= 70044 && annualSalary > 19874)
                {
                    usc = ((annualSalary - 19874) * .045) + ((19874 - 12012) * .02) + (12012 * .005);     
                }
                else if (annualSalary <= 19874 && annualSalary >=12012)
                {
                    usc = ((annualSalary - 12012) * .02) + (12012 * .005);
                }
            }

            // if Salary was less than 1300 then no usc due and usc with a value of '0' will be returned 
            //otherwicse the correct usc value will have been calcualted in the if/else block above
            return usc;

       
        }

        //not done
        static double CalculateWeeklyPRSI(double weeklySalary, char prsiClass)
        {
            double prsiDue = 0;
            double prsiCredit = 12;

            //only calculate PRSi ifor class A and weekly salary if >=0
            if (prsiClass == 'A' && weeklySalary >= 0)
            {
                if (weeklySalary <= 0)
                {
                    return 0;
                }
                else if (weeklySalary > 352 && weeklySalary <424)
                {
                    double oneSixthEarnings = (weeklySalary - 352.01)/6;
                    prsiCredit = prsiCredit - oneSixthEarnings;
                    prsiDue = (weeklySalary * .04) - prsiCredit;
                    return prsiDue;
                }
                else if (weeklySalary >= 424)
                {
                    prsiDue = (weeklySalary * .04);
                    return prsiDue;
                }
            }
            return prsiDue;
        }

        static void PrintWeeklyNetPay(double annualSalary)
        {
            double weeklyGrossPay = annualSalary / 52;

            double weeklyNetPay = weeklyGrossPay - CalculatePAYE(annualSalary, 3300)/52 - CalculateUSC(annualSalary/52) - CalculateWeeklyPRSI(annualSalary/52, 'A');

            Console.WriteLine("Weekly net pay after dedcution: " + weeklyNetPay);
        }


        /// <summary>
        /// prints out the options on console, for user to select 
        /// </summary>
         static void PrintMainMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n *****Payroll System*****");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" Main Menu:");
            Console.WriteLine("\t(1) Show all employees.");
            Console.WriteLine("\t(x) Exit");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("\tSelect Option: ");
            Console.BackgroundColor = ConsoleColor.Black;
        }

        /// <summary>
        /// method to close the app
        /// </summary>
         static void ExitApp()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\nApplication closed!");
            Thread.Sleep(2000);
            Environment.Exit(0);
        }


        //Show all employees in array
         static void ShowAllEmployees(Employee[] employees)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            if (employees.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n--There are no employees in the system --");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.WriteLine("\nShowing all Employees: \n");
            }

            Console.ForegroundColor = ConsoleColor.Gray;

            // Show all employees in the array
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine("({0}) {1} ", i+1, employees[i].name);
            }

        }



        //Print options for employee
        static void DisplaySubMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n Options:");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nPlease choose an option:");

            Console.WriteLine("\t(1)Show Net Pay");
            Console.WriteLine("\t(2)Print Payslip");
            Console.WriteLine("\t(3)Back to Main menu");
            Console.WriteLine("\t(x)Exit Application");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nSelect option: ");
            Console.BackgroundColor = ConsoleColor.Black;
        }


        static void PrintPayslip(double weeklySalary)
        {
            double taxCredits = 3300;

            Console.WriteLine("Weekly salary: " + weeklySalary);

            double annualSalary = CalculateAnnualSalary(weeklySalary);

            Console.WriteLine("Annual Net Income: " + annualSalary);

            Console.WriteLine("PAYE income tax: " + CalculatePAYE(annualSalary, taxCredits));

            Console.WriteLine("USC: " + CalculateUSC(annualSalary));
            Console.WriteLine("PRSI: " + CalculateWeeklyPRSI(weeklySalary, 'A') * 52);
        }
    }
}
