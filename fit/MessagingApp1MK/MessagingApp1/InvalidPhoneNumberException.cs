using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingApp1
{
    //we are making our own valid exception
    //if a sender/recepient number does not match the required specified phone number pattern
    class InvalidPhoneNumberException : Exception
    {
        public InvalidPhoneNumberException(string errorMessage) : base(errorMessage)
        {
            //Do other stuff like log the error to a file
        }
    }
}
