using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Cryptography_Project.Custom
{
    internal class CustomText
    {
        public String CustomTextEncryption(String plain, String key)
        {
            //Dictionary - class in C# which takes two parameters
            //int - key type of the dictionary,used to retrieve values from the dictionary.
            //Same as char.
            Dictionary<int, char> unicode = new Dictionary<int, char>();    


            int minimum = 0;
            int maximum = 5000;
            int plainText;

            //Populating the unicode dictionary with Unicode characters from 0 - 5000 out of the 149 186 characters
            for (plainText = minimum; plainText < maximum - 1; plainText++)
            {
                // Get Unicode character.
                //cast the plainText int to its corresponding Unicode character.
                char cipherText = (char) plainText;

                //Add the new value key-value to the Unicode dictionary
                unicode.Add(plainText, cipherText);
            }
            //The Unicode is now populated with 1000 characters

            string ciphertext = "";

            int i = 0;

            //it uses the unicode dictionary and a plain text and a key
            //Steps 1 : Find the integer value of the Unicode character
            //in the plain string by looking up the character in the unicode
            //dictionary using the FirstOrDefault method
            foreach (char element in plain)
            {
                //Looking for the integer value of the Unicode character in the plain string
                //by looking up the character in the unicode dictionary
                int TOrder = unicode.FirstOrDefault(x => x.Value == element).Key;

                //Looking for the integer value of the Unicode character in the key string
                //by looking up the character in the unicode dictionary
                int KOrder = unicode.FirstOrDefault(x => x.Value == key[i]).Key;
                
                //adds the int values found above. 
                int finalUnicode = (int)(TOrder + KOrder);

                if (finalUnicode > 255) 
                {
                    finalUnicode = finalUnicode - 256; 
                }

                ciphertext += unicode[finalUnicode];

                i++;

                if (i == key.Length) 
                {
                    i = 0; 
                }
            }
            //return the encrypted string
            return ciphertext;
        }

        public String CustomTextDecryption(String mixed, String key)
        {
            Dictionary<int, char> unicode = new Dictionary<int, char>();

            int minimum = 0;
            int maximum = 5000;
            int plainText;

            for (plainText = minimum; plainText < maximum; plainText++)
            {
                char cipherText = (char)plainText;

                unicode.Add(plainText, cipherText);
            }

            string plaintext = "";
            int i = 0;

            foreach (char element in mixed)
            {
                int TOrder = unicode.FirstOrDefault(x => x.Value == element).Key;

                int KOrder = unicode.FirstOrDefault(x => x.Value == key[i]).Key;

                int finalUnicode = (int)(TOrder - KOrder);

                if (finalUnicode < 0) 
                { 
                    finalUnicode = finalUnicode + 256; 
                }
                plaintext += unicode[finalUnicode];

                i++;

                if (i == key.Length) 
                { 
                    i = 0; 
                }
            }
            return plaintext;
        }
    }
}
