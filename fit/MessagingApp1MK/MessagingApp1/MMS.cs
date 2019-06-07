using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingApp1
{

    public enum MediaType { AUDIO, VIDEO, PICTURE };
    // MMS inherits from SMS
    class MMS : SMS
    {
       

        private MediaType mediaType;
        private readonly string filename;
        //public readonly string extension;

        //Booleans to represent if media types are attached
        private bool audioAttached = false, videoAttached = false, pictureAttached = false;



        public MMS(string myNumber, string recipient, string message, MediaType mediaType, string filename, bool groupMessage = false) 
            : base ( myNumber,  recipient,  message, groupMessage)
        {
            this.mediaType = mediaType;
            this.filename = filename;

            if (mediaType == MediaType.AUDIO)
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



        }
         public void showAttachment()
        {
            if (audioAttached)
            {
                Console.WriteLine("Audio file {0} attached to message.", filename);
            }
            else if (pictureAttached)
            {
                Console.WriteLine("Picture file {0} attached to message.", filename);
            }
            else if (videoAttached)
            {
                Console.WriteLine("Video file {0} attached to message.", filename);
            }
            else
            {
                Console.WriteLine("No media attached");
            }
        }
  

    }
}
