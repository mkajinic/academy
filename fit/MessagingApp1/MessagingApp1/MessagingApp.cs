using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MessagingApp1
{
    class MessagingApp
    {
        // A list to hold SMS and and MMS messages
        private static List<SMS> messages = new List<SMS>();

        static void Main(string[] args)
        {
            
            try
            {
                //Make SMS and MMS mesaages and test them etc...
                SMS sms1 = new SMS("08700042500", "087741258963", "I love dogs.", true);

                SMS sms2 = new SMS("08580032134", "0858554537", "I want to have a dog.", true);

                //Make SMS and MMS mesaages and test them etc...
                MMS mms1 = new MMS("0858003213", "0878554563", "Name of the dog would be...",MediaType.AUDIO,"tada.wav",true);

                //Make SMS and MMS mesaages and test them etc...
                MMS mms2 = new MMS("0858003213", "0878554563", "Dogs are cool.", 
                    MediaType.NOATTACHMENT,null, true);

                //Adding messages to the list
                messages.AddRange(new List<SMS>() { sms1, sms2, mms1, mms2 });


                Console.Clear(); // Clean the console

                                           

            }
            catch (InvalidPhoneNumberException e)
            {
                Console.WriteLine("Error occurred!\n" + e.Message + "\nMessage cannot be created!");
            }


            // Showing main menu 
            bool showMainMenu = true;                       

            while (showMainMenu)
            {
                PrintMainMenu();
                ConsoleKeyInfo keypressed = Console.ReadKey();
                

                if (keypressed.Key == ConsoleKey.NumPad1 || keypressed.KeyChar == 49)
                {
                    ShowAllMessages();

                    // Loop control variable
                    bool showMessageOptions = true;
                    while (showMessageOptions)
                    {
                        if (messages.Count > 0)
                        {
                            PrintMessageOptions();
                            ConsoleKeyInfo userchoice = Console.ReadKey();

                            //exit the app if user presses E
                            if (userchoice.Key == ConsoleKey.X)
                            {
                                ExitApp();
                            }

                            //Back to main menu
                            else if (userchoice.Key == ConsoleKey.B)
                            {
                                //Break the loop and go back to outer loop
                                showMessageOptions = false;
                            }

                            //Shows help with message options
                            else if (userchoice.Key == ConsoleKey.H)
                            {
                                ShowHelp(HelpType.INMESSAGES);
                            }

                            // Option to read the message (if message is sent)
                            else if (userchoice.Key == ConsoleKey.NumPad1 || userchoice.KeyChar == 49)
                            {
                                Console.Write("\nEnter message ID and press enter.");
                                try
                                {
                                    int messageNumber = int.Parse(Console.ReadLine());
                                    Console.WriteLine("\n\tMessage {0} content: ", messageNumber);
                                    messages[messageNumber - 1].ReadMessage();
                                }
                                catch (ArgumentOutOfRangeException ex1)
                                {

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("That message number does not exist");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                catch (Exception ex2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("That wasnt a valid message ID");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                            }


                            //Option to send the message if user presses number 2 
                            else if (userchoice.Key == ConsoleKey.NumPad2 || userchoice.KeyChar == 50)
                            {
                                Console.Write("\nEnter message ID number and press enter.");
                                try
                                {
                                    int messageNumber = int.Parse(Console.ReadLine());
                                    messages[messageNumber - 1].SendMessage();
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("\n\tMessage {0} has been sent", messageNumber);
                                    ShowAllMessages();
                                }
                                catch (ArgumentOutOfRangeException ex1)
                                {

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("That message ID number does not exist");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                catch (Exception ex2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("That wasnt a valid message ID");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                            }

                            
                            //Option to delete the message
                            else if (userchoice.Key == ConsoleKey.NumPad3 || userchoice.KeyChar == 51)
                            {
                                //Delete message from list
                                Console.Write("\nPlease enter message ID and press enter.");

                                try
                                {
                                    int messageNumber = int.Parse(Console.ReadLine());
                                    messages.RemoveAt(messageNumber - 1);
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("\n\tMessage  {0} deleted!", messageNumber);
                                    ShowAllMessages();
                                }
                                catch (ArgumentOutOfRangeException ex1)
                                {

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("That message ID number does not exist");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                catch (Exception ex2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("That wasnt a valid message ID");
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

                }

                //Creates a new message
                else if (keypressed.Key == ConsoleKey.NumPad2 || keypressed.KeyChar == 50)
                {
                    try
                    {
                        messages.Add(CreateNewMessage());
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }
                }
            
                //opens Help menu
                else if (keypressed.Key == ConsoleKey.H)
                {
                    ShowHelp(HelpType.MAINMENU);
                }

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

        }//end of Main


        /// <summary>
        /// prints out the options on console, for user to select 
        /// </summary>
        private static void PrintMainMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n Messaging App Testing System");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" Please choose and option:");
            Console.WriteLine("\t(1) Show all messages.");
            Console.WriteLine("\t(2) Create new Message.");
            Console.WriteLine("\t(h) Show help.");
            Console.WriteLine("\t(x) Exit");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("\tSelect Option: ");
            Console.BackgroundColor = ConsoleColor.Black;
        }


        /// <summary>
        /// method to close the app
        /// </summary>
        private static void ExitApp()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\nApplication closed!");
            Thread.Sleep(2000);
            Environment.Exit(0);
        }


        /// <summary>
        /// Prints options for user to choose from
        /// </summary>
        private static void PrintMessageOptions()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nMessage options:");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nPlease choose an option:");

            Console.WriteLine("\t(1)Read Message");
            Console.WriteLine("\t(2)Send Message");
            Console.WriteLine("\t(3)Delete Message");
            Console.WriteLine("\t(h)Help");
            Console.WriteLine("\t(b)Back to Main Menu");
            Console.WriteLine("\t(x)Exit Application");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nSelect option:");
            Console.BackgroundColor = ConsoleColor.Black;
        }


        /// <summary>
        /// Method to create new SMS or MMS
        /// MMS or SMS can be part of group message
        /// if MMS is created, user will be asked for name and type of the file user wants to attach
        /// </summary>
        /// <returns></returns>
        private static SMS CreateNewMessage()
        {
            MediaType attachmentType = MediaType.NOATTACHMENT;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\nCreate New Message");
            Console.ForegroundColor = ConsoleColor.Gray;

            //Ask the user for sender number
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter the sender number and press enter: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            string sender = Console.ReadLine().Trim();

            //Ask the user for sender number
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter the recipient number and press enter: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            string recipient = Console.ReadLine().Trim();

            // Ask the user for text of the message
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter the text message and press enter: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            string message = Console.ReadLine().Trim();

            //Ask the user if message is part of the group 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Is this message part of the group message?\n Press Y for Yes, or N for No, and press enter: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            bool groupMessage = (Console.ReadLine().Trim().ToLower().StartsWith("y")) ? true : false ;


            //Ask does the message has attachment
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Do you want to attach a file? \n Press Y for Yes, or N for No, and press enter: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            bool isMMS = (Console.ReadLine().Trim().ToLower().StartsWith("y")) ? true : false;


            //Ask the user for file type
            if (isMMS)
            {
                //ask for fileName
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please enter attachment name and press enter: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                string fileName = Console.ReadLine().Trim();

                bool choiceValid = false;

                do
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Enter the attachement type: ");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    Console.WriteLine("\t(1) Audio");
                    Console.WriteLine("\t(2) Video");
                    Console.WriteLine("\t(3) Picture");
                    Console.WriteLine("\t(4) If there is no attachment press 4");
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("\tEnter option number:");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    string choice = Console.ReadLine().Trim();

                    switch (choice)
                    {
                        case "1":
                            attachmentType = MediaType.AUDIO;
                            choiceValid = true;
                            break;
                        case "2":
                            attachmentType = MediaType.VIDEO;
                            choiceValid = true;
                            break;
                        case "3":
                            attachmentType = MediaType.PICTURE;
                            choiceValid = true;
                            break;
                        case "4":
                            attachmentType = MediaType.NOATTACHMENT;
                            choiceValid = true;
                            break;

                        default:
                            Console.WriteLine("Invalid choice please try again.");
                            break;
                    }

                } while (!choiceValid);
                return new MMS(sender, recipient, message, attachmentType, fileName, groupMessage);
            }
            else
            {
                return new SMS(sender, recipient, message, groupMessage);
            }



        }


        /// <summary>
        /// Method to call help options user may need in two different situations
        /// help for Main menu describing options for show all messages,create and exit
        /// help for InMessages describing options for, Read, Sent, Delete, Back, Exit
        /// </summary>
        /// <param name="helpType">refers to two enum parameters (MAIN MENU, INMESSAGES)</param>
        private static void ShowHelp(HelpType helpType)
        {
            if(helpType == HelpType.MAINMENU)
            {
                Console.WriteLine("\n\tOption (1) will show all messages.");
                Console.WriteLine("\tOption (2) will give option to create a new SMS or MMS.");
                Console.WriteLine("\tOption (e) will exit the application.");

            }
            else if (helpType == HelpType.INMESSAGES)
            {
                Console.WriteLine("\tOption (1) Read will read the message if message is sent.");
                Console.WriteLine("\tOption (2) Send will send the message when message ID is entered");
                Console.WriteLine("\tOption (3) Delete will delete message when message ID is entered");
                Console.WriteLine("\tOption (b) Back to Main Menu will bring back Main menu");
                Console.WriteLine("\tOption (e) will exit the application.");


            }
        }


        /// <summary>
        /// Enum to hold help options for two types of help user may need 
        /// </summary>
        public enum HelpType {MAINMENU, INMESSAGES }

        /// <summary>
        /// method to show all messages created, sent, received
        /// If there is no messages to show, user will be warned there is no messages
        /// </summary>
        private static void ShowAllMessages()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            if (messages.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n--There are no messages in the system --");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.WriteLine("\nShowing all messages: \n");
                

            }

            Console.ForegroundColor = ConsoleColor.Gray;



            // Show all (SMS and MMS) messages in the list
            for (int i = 0; i < messages.Count; i++)
                {
                    Console.Write("({0})",(i+1));

                    // If the objec in the list of messages is a typeof SMS
                    if(messages[i].GetType() == typeof(SMS))
                    {
                        Console.Write("\tSMS");
                    }
                    else if(messages[i].GetType() == typeof(MMS))
                    {
                        Console.Write("\tMMS");
                    }

                    Status status = messages[i].status;

                    Console.Write(" Status: ");

                    if (status == Status.CREATED)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else if (status == Status.SENT)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (status == Status.RECEIVED)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write(status);

                    Console.ForegroundColor = ConsoleColor.Gray;

                    Console.Write("\n\tFrom: {0} \n\tTo: {1}", messages[i].Sender, messages[i].Recipient + "\n\n");
                                    

            }
            
        }//End of show all messages

       
    
    }

}
