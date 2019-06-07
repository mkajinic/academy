using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MessagingApp1
{
    // Declare an enum bla bla....
    public enum Status { CREATED, SENT, RECEIVED };

    // SMS Class (Short Messaging Service)
    class SMS
    {        
        // Status can be accessed from outside the class but only 
        // set within the class  or set within any class tht subclasses this (SMS) class 
        public Status status { get; protected set; }

        // 'readonly' will only allow the value to 
        // be set inside the constructor 
        // it cannot be changed anywhere 
        // else inside the class
        // public readonly string sender;

        private string sender;
        public string Sender
        {
            get { return sender; }
            private set {
                string pattern = @"^0[0-9]{9,20}$";
                Regex rx = new Regex(pattern);
                if (rx.IsMatch(value))
                {
                    sender = value;
                }
                else
                {
                    throw new InvalidPhoneNumberException(String.Format("Sender number entered '{0}' must start with 0 and contain 10 or more digits.", value));
                }                
            }
        }

        private string recipient;
        public string Recipient
        {
            get { return recipient; }
            private set
            {
                string pattern = @"^0[0-9]{9,20}$";
                Regex rx = new Regex(pattern);
                if (rx.IsMatch(value))
                {
                    recipient = value;
                }
                else
                {
                    throw new InvalidPhoneNumberException(String.Format("Recipient number entered '{0}' must start with 0 and contain 10 or more digits.", value));
                }
            }
        }

        // Private field to hold the message data
        protected string Message;

        public readonly bool IsGroupoMessage;

        /// <summary>
        /// Create a new instance of the SMS class
        /// </summary>
        /// <param name="myNumber">The phone number of the sender</param>
        /// <param name="recipient"> The phone number of the person receiving the message</param>
        /// <param name="message">Text of the message</param>
        /// <param name="groupMessage"> boolean stating if message is part of the group</param>
        public SMS(string myNumber, string recipient, string message, bool groupMessage = false)
        {
            Sender = myNumber;
            Recipient = recipient;
            Message = message;
            IsGroupoMessage = groupMessage;
            if(groupMessage)
            {
                Console.WriteLine("A new group message has been sent to: '{0}' from '{1}'", recipient, myNumber);
            }
            else
            {
                Console.WriteLine("A new message has been sent: \nFrom '{0}' to '{1}' \nMessage: '{2}'", myNumber, recipient, message);
            }

            this.status = Status.CREATED;            
        }

        // Public 'setter' method to send the message and set the status to SENT
        public void SendMessage()
        {
            this.status = Status.SENT;
        }

        // MMS should override this mnethod to
        // implement its own behaviour
        public virtual void ReadMessage()
        {
            if(this.status == Status.SENT || this.status == Status.RECEIVED)
            {
                Console.WriteLine("Message from: {0} to {1} Reads: {2}", Sender, Recipient, Message);
                this.status = Status.RECEIVED;
            }
            else
            {
                Console.WriteLine("Message has not yet been sent.");
            }
            
        }


    }// end of SMS class

    
}
