using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Default;

            string plainText = "Zebra";

            string cipherText = Caesar(plainText, 2000);

            Console.WriteLine("Plain text: " + plainText);
            Console.WriteLine("Cipher text: " + cipherText);

            string deciryptedText = Caesar(cipherText, -2000);
            Console.WriteLine("Decrypted text: " + deciryptedText);

                Console.ReadLine();

        }

        //cipher to shift each character int a string up or down based on parametar 
        public static string  Caesar (string text, int shift)
        {
            char[] chars = text.ToCharArray();

            //Loop trough the char array
            for (int i = 0; i < chars.Length; i++)
            {

                int charInt = ((chars[i] + shift) % 128);

                if (charInt < 0)
                {
                    chars[i] = (char) (charInt + 128);
                }
                else
                {
                    chars[i] = (char)charInt;
                }
            }


            return new string (chars); 
        }

    }


    



}
