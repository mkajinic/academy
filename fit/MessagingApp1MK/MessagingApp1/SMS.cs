using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MessagingApp1
{
    //Enum in a namespace
    public enum Status2 { CREATED, SENT, RECEIVED };


    //SMS Class (Short Mesaging Service)
    class SMS
    {
         public enum Status {CREATED, SENT, RECEIVED};

        //Status can be accessed from outside the class 
        //but only set within the class
        public Status status { get; private set; }        


        // readonly will only allow the value to be set inside the constructor
        // it cannot be changed anywhere else inside the class
        //public readonly string sender;


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
                    throw new InvalidPhoneNumberException(String.Format("Sender number entered '{0}' must start with 0 and have 10 digits.", value));
                }
                
            }
        }




        private string recipient;     //(propfull tab)

        public string  Recipient
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
                    throw new InvalidPhoneNumberException(String.Format("Recipient number '{0}' must start with 0 and contain more than 10 digits.", value));
                }

            }

        }

        //private field to hold the message data
        private string Message;

        public readonly bool IsGroupMessage;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="myNumber"></param>
        /// <param name="recipient"></param>
        /// <param name="message"></param>
        /// <param name="groupMessage"></param>


        public SMS (string myNumber, string recipient,  string message, bool groupMessage = false)
        {
            Sender = myNumber;
            Recipient = recipient;
            Message = message;
            IsGroupMessage = groupMessage;
            if (groupMessage)
            {
                Console.WriteLine("A new group message has been sent to: '{0}' from '{1}'", recipient, myNumber);
            }
            else
            {
                Console.WriteLine("A new message has been sent to: '{0}' from '{1}'", recipient, myNumber);
            }


            this.status = Status.CREATED;
                //Console.WriteLine("Message says: " + message + "\n");
        }

        //Public 'setter' method to send the message and set the status to SENT
        public void SendMessage()
        {
            this.status = Status.SENT;
        }

        public void ReadMessage()
        {
            if (this.status == Status.SENT || this.status == Status.RECEIVED)
            {
                Console.WriteLine("Message from: {0} to {1} Reads: {2}", Sender, Recipient, Message);
                this.status = Status.RECEIVED;
            }
            else
            {
                Console.WriteLine("Message has not yet been sent.");
            }
                
            
        }







    }//end of sms class
}
