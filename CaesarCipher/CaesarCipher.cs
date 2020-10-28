using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    public class CaesarCipher
    {
        public static char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        static void Main(string[] args)
        {
            string message = "testz";
            int key = 2;
            string resultEnc = EncryptionCaesar(message, key);
            Console.WriteLine("---------------");
            Console.WriteLine("Text to encrypt: " + message);
            Console.WriteLine("Encryption key: " + key);
            Console.WriteLine("---------------");
            Console.WriteLine("Encrypted text: " + resultEnc);
            string resultDec = DecryptionCaesar(resultEnc, key);
            Console.WriteLine("Decrypted text: " + resultDec);

        }

        public static string EncryptionCaesar(string message, int key)
        {
            StringBuilder encrypedMessage = new StringBuilder();
            char[] messageSplit = message.ToCharArray();
            for (int i = 0; i < messageSplit.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    int letterPos = j + key;
                    string currentLetter = messageSplit[i].ToString();
                    if (currentLetter.Equals(alphabet[j].ToString(), StringComparison.CurrentCultureIgnoreCase))
                    {
                        if (letterPos > alphabet.Length)
                        {
                            int newPos = letterPos - alphabet.Length;
                            encrypedMessage.Insert(encrypedMessage.Length, alphabet[0 + newPos]);
                            break;
                        }
                        else
                        {
                            encrypedMessage.Insert(encrypedMessage.Length, alphabet[j + key]);
                            break;
                        }
                    }
                }
            }
            return encrypedMessage.ToString();
        }


        public static string DecryptionCaesar(string message, int key)
        {
            StringBuilder decrypedMessage = new StringBuilder();
            char[] messageSplit = message.ToCharArray();
            for (int i = 0; i < messageSplit.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    int letterPos = j - key;
                    string currentLetter = messageSplit[i].ToString();
                    if (currentLetter.Equals(alphabet[j].ToString(), StringComparison.CurrentCultureIgnoreCase))
                    {
                        if (letterPos < 0)
                        {
                            int newPos = Math.Abs(letterPos);
                            decrypedMessage.Insert(decrypedMessage.Length, alphabet[alphabet.Length - newPos]);
                        }
                        else
                        {
                            decrypedMessage.Insert(decrypedMessage.Length, alphabet[j - key]);
                            break;
                        }
                    }
                }
            }
            return decrypedMessage.ToString();
        }
    }
}
