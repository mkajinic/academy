using System;
using EncryptStringSample;
using System.IO;
using System.Windows.Forms;


namespace EncryptTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            
            string filename = desktop + "\\encryptionTest.txt";

            Console.Write("\nPlease enter some plain text to be entered into the file:\n<<encryptionTest.txt>> - which will be placed on the desktop.\nPress enter when done:\n");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            File.WriteAllText(filename, Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\nThe content of the file <<encryptionTest.txt>> on your desktop is:");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(File.ReadAllText(filename));
            

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("\nPress enter to continue when ready.....");
            Console.ReadLine();

            Console.Write("\nPlease enter a password to use to encrypt the file:");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            string password = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            string encryptedstring = StringCipher.Encrypt(File.ReadAllText(filename), password);
            File.WriteAllText(filename, encryptedstring);
            Console.WriteLine("\nEncrypted text is:");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(encryptedstring);            

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("\nPress enter to continue when ready.....");
            Console.ReadLine();

            Console.Write("\nPlease enter the decryption password and press enter:");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            string decryptedstring = StringCipher.Decrypt(File.ReadAllText(filename), Console.ReadLine());
            File.WriteAllText(filename, decryptedstring);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\nYour decrypted file content is is:");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(decryptedstring);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("\n\nPress any key to exit...");
            Console.ReadLine();
        }
    }
}
