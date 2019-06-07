using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingApp1
{
    public enum MediaType {NOATTACHMENT, AUDIO, VIDEO, PICTURE };

    // MMS (Multi Media Message) inherits from SMS
    class MMS : SMS
    {        

        private MediaType mediaType;
        private readonly string filename;       

        // Booleans to represetnt if media types are attached
        private bool audioAttached = false, videoAttached = false, pictureAttached = false;
        /// <summary>
        /// MMS class for sending MMS messages
        /// </summary>
        /// <param name="myNumber">Phone number of sender as string</param>
        /// <param name="recipient">Phone number of receiver as string</param>
        /// <param name="message"> Text of the message as string</param>
        /// <param name="mediaType">Media type stating if attachment is video, picture or audio</param>
        /// <param name="filename">Name of the file user wants to attach</param>
        /// <param name="groupMessage">boolean stating if message is part of the group</param>
        public MMS(string myNumber, string recipient, string message, MediaType mediaType, string filename = null, bool groupMessage = false) 
            : base(myNumber, recipient, message, groupMessage)
        {
            this.mediaType = mediaType;
            this.filename = filename;

            if(mediaType == MediaType.AUDIO)
            {
                audioAttached = true;
                videoAttached = false;
                pictureAttached = false;
            }
            else if (mediaType == MediaType.VIDEO)
            {
                audioAttached = false;
                videoAttached = true;
                pictureAttached = false;
            }
            else if (mediaType == MediaType.PICTURE)
            {
                audioAttached = false;
                videoAttached = false;
                pictureAttached = true;
            }
            else if (mediaType == MediaType.NOATTACHMENT)
            {
                audioAttached = false;
                videoAttached = false;
                pictureAttached = false;
            }

        }

        // Override this inherited method
        // we Need to make Message and status 'protected'
        // in out base/super class SMS
        public override void ReadMessage()
        {
            if (this.status == Status.SENT || this.status == Status.RECEIVED)
            {
                Console.WriteLine("Message from: {0} to {1} Reads: {2} Media Type: {3}", Sender, Recipient, Message, mediaType);
                //Show the attachment media type and file name
                Console.WriteLine("Attachment information: " + mediaType);
                status = Status.RECEIVED;
            }
            else
            {
                Console.WriteLine("Message has not yet been sent.");
            }

        }

        /// <summary>
        /// method to show attachments
        /// </summary>
        public void showAttachment()
        {
            if (audioAttached)
            {
                Console.WriteLine("Audio file '{0}' attached to message.", filename);
            }
            else if (pictureAttached)
            {
                Console.WriteLine("Picture file '{0}' attached to message.", filename);
            }
            else if (videoAttached)
            {
                Console.WriteLine("Video file '{0}' attached to message.", filename);
            }
            else
            {
                Console.WriteLine("No media attached.");
            }

        }


    }
}
