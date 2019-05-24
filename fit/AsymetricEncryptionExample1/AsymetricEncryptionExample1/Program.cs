using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AsymetricEncryptionExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Show the Asymetric encryption in Action
            int keySize = 1024;
            var keys = EncryptorRSA.GenerateKeys(keySize);

            string text = "Piu piu";

            string encryptedText = EncryptorRSA.EncryptText(text, keys.PublicKey);

            Console.WriteLine("Plain text " + text);
            Console.WriteLine("Encrypted text " + encryptedText);

            string decryptedText = EncryptorRSA.DecryptText(encryptedText, keys.PrivateKey);
            Console.WriteLine("Decrypted text " + decryptedText);

            Console.ReadLine();
        }

        public static void EncryptionRSATest()
        {
            int keySize = 1024;
            var keys = EncryptorRSA.GenerateKeys(keySize);

            string text = "text for encryption";

            string encrypted = EncryptorRSA.EncryptText(text, keys.PublicKey);
            string decrypted = EncryptorRSA.DecryptText(encrypted, keys.PrivateKey);
            

         
        }
    }


    public class EncryptorRSAKeys
    {
        public string PublicKey { get; set; }
        public string PrivateKey { get; set; }
    }

    public static class EncryptorRSA
    {
        private static bool _optimalAsymmetricEncryptionPadding = false;

        public static EncryptorRSAKeys GenerateKeys(int keySize)
        {
            if (keySize % 2 != 0 || keySize < 512)
                throw new Exception("Key should be multiple of two and greater than 512.");

            var response = new EncryptorRSAKeys();

            using (var provider = new RSACryptoServiceProvider(keySize))
            {
                var publicKey = provider.ToXmlString(false);
                var privateKey = provider.ToXmlString(true);

                var publicKeyWithSize = IncludeKeyInEncryptionString(publicKey, keySize);
                var privateKeyWithSize = IncludeKeyInEncryptionString(privateKey, keySize);

                response.PublicKey = publicKeyWithSize;
                response.PrivateKey = privateKeyWithSize;
            }

            return response;
        }

        public static string EncryptText(string text, string publicKey)
        {
            int keySize = 0;
            string publicKeyXml = "";

            GetKeyFromEncryptionString(publicKey, out keySize, out publicKeyXml);

            var encrypted = Encrypt(Encoding.UTF8.GetBytes(text), keySize, publicKeyXml);
            return Convert.ToBase64String(encrypted);
        }

        private static byte[] Encrypt(byte[] data, int keySize, string publicKeyXml)
        {
            if (data == null || data.Length == 0) throw new ArgumentException("Data are empty", "data");
            int maxLength = GetMaxDataLength(keySize);
            if (data.Length > maxLength) throw new ArgumentException(String.Format("Maximum data length is {0}", maxLength), "data");
            if (!IsKeySizeValid(keySize)) throw new ArgumentException("Key size is not valid", "keySize");
            if (String.IsNullOrEmpty(publicKeyXml)) throw new ArgumentException("Key is null or empty", "publicKeyXml");

            using (var provider = new RSACryptoServiceProvider(keySize))
            {
                provider.FromXmlString(publicKeyXml);
                return provider.Encrypt(data, _optimalAsymmetricEncryptionPadding);
            }
        }

        public static string DecryptText(string text, string privateKey)
        {
            int keySize = 0;
            string publicAndPrivateKeyXml = "";

            GetKeyFromEncryptionString(privateKey, out keySize, out publicAndPrivateKeyXml);

            var decrypted = Decrypt(Convert.FromBase64String(text), keySize, publicAndPrivateKeyXml);
            return Encoding.UTF8.GetString(decrypted);
        }

        private static byte[] Decrypt(byte[] data, int keySize, string publicAndPrivateKeyXml)
        {
            if (data == null || data.Length == 0) throw new ArgumentException("Data are empty", "data");
            if (!IsKeySizeValid(keySize)) throw new ArgumentException("Key size is not valid", "keySize");
            if (String.IsNullOrEmpty(publicAndPrivateKeyXml)) throw new ArgumentException("Key is null or empty", "publicAndPrivateKeyXml");

            using (var provider = new RSACryptoServiceProvider(keySize))
            {
                provider.FromXmlString(publicAndPrivateKeyXml);
                return provider.Decrypt(data, _optimalAsymmetricEncryptionPadding);
            }
        }

        public static int GetMaxDataLength(int keySize)
        {
            if (_optimalAsymmetricEncryptionPadding)
            {
                return ((keySize - 384) / 8) + 7;
            }
            return ((keySize - 384) / 8) + 37;
        }

        public static bool IsKeySizeValid(int keySize)
        {
            return keySize >= 384 &&
                    keySize <= 16384 &&
                    keySize % 8 == 0;
        }

        private static string IncludeKeyInEncryptionString(string publicKey, int keySize)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(keySize.ToString() + "!" + publicKey));
        }

        private static void GetKeyFromEncryptionString(string rawkey, out int keySize, out string xmlKey)
        {
            keySize = 0;
            xmlKey = "";

            if (rawkey != null && rawkey.Length > 0)
            {
                byte[] keyBytes = Convert.FromBase64String(rawkey);
                var stringKey = Encoding.UTF8.GetString(keyBytes);

                if (stringKey.Contains("!"))
                {
                    var splittedValues = stringKey.Split(new char[] { '!' }, 2);

                    try
                    {
                        keySize = int.Parse(splittedValues[0]);
                        xmlKey = splittedValues[1];
                    }
                    catch (Exception e) { }
                }
            }
        }
    }
}
