using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingApp1
{
    // Custom Exception which will be thrown
    // if a sender/recipient number does not match
    // the specified phone number pattern
    class InvalidPhoneNumberException : Exception
    {
        public InvalidPhoneNumberException(string errorMessage) 
            : base (errorMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            // Do other stuff like log the error to a file
        }
    }
}
