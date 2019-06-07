using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingApp1
{
    class MessagingApp
    {
        // A list to hold SMS and MMS
        private static List<SMS> messages = new List<SMS>();




        static void Main(string[] args)
        {
            //What should out Messaging App be able to do with these SMS and MMS objects

            // 1) A menu of option for user
            // 2) Read, Send, View all/list of messages, Delete a message
            // 3) Exit

           
            try
            { 
                // Make SMS and MMS messages test them etc...
                SMS sms1 = new SMS("08384557000", "083458963000", "Hungry");
                SMS sms2 = new SMS("08784557000", "088458963000", "LaLalala");
                //Console.WriteLine(sms1.Sender);

                MMS mms1 = new MMS("08384557410", "0838455741444", "Still hungry", MediaType.AUDIO, "splash.wav", true);

                //Adds mesages to collection
                messages.Add(sms1);
                messages.Add(sms2);
                messages.Add(mms1);


                //sms1.ReadMessage();
                sms2.SendMessage();
                mms1.ReadMessage();
            }
            catch (InvalidPhoneNumberException e)
            {

                Console.WriteLine("Error occured!\n" + e.Message + "\nMessage was not sent!");
            }


            







            
        }


        
          
    }


    
}
