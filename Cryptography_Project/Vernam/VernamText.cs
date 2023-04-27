using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography_Project.Vernam
{
    internal class VernamText
    {
        //Uses a simple XOR-based encryption algorithm
        public string VernamEncryptionAndDecryption(string plainText, string key)
        {
            var encryptedText = new StringBuilder(); //

            for (int cipherText = 0; cipherText < plainText.Length; cipherText++) //This for loop goes through the plainText
            {
                //get the current character from the plainText & take next character from string
                char character = plainText[cipherText]; //This is the character that will be encrypted

                //cast the character to a 32-bit unsigned interger.
                uint charCode = (uint)character; //This is the character code

                // calculate the index of the key character for the plaintext
                // this line his ensures that the key is used in a repeating
                // pattern to encrypt or decrypt the plaintext
                int keyPosition = cipherText % key.Length; //This is the position of the key character

                //take the key character at the calculated index
                char keyChar = key[keyPosition]; //This is the key character

                //cast the key character to a 32-bit unsigned integer
                uint keyCode = (uint)keyChar; //This is the key character code

                // perform XOR on the two character codes to produce a new 32-bit unsigned character
                uint combinedCode = charCode ^ keyCode; //This is the combined code

                //cast the combined code back to a char
                char combinedChar = (char)combinedCode; 

                //Append the combined character 
                encryptedText.Append(combinedChar);
            }
            //the StringBuilder contains the encrypted or decrypted text
            return encryptedText.ToString(); //This returns the encrypted or decrypted text
        }
    }
}

