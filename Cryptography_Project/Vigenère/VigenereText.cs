using System;
using System.Collections.Generic;
using System.Linq;

namespace Cryptography_Project
{
    class VigenereText
    {
        //Vigenere Text Encryption
        public String VigenereTextEncrypt(String plain, String key)
        {
            //create a dictionary to store the alphabet
            Dictionary<sbyte, char> AlphabetOrder = new Dictionary <sbyte, char> ();

            //add the letters to the dictionary
            AlphabetOrder.Add(0, 'A'); 
            AlphabetOrder.Add(1, 'B');
            AlphabetOrder.Add(2, 'C');
            AlphabetOrder.Add(3, 'D');
            AlphabetOrder.Add(4, 'E');
            AlphabetOrder.Add(5, 'F');
            AlphabetOrder.Add(6, 'G');
            AlphabetOrder.Add(7, 'H');
            AlphabetOrder.Add(8, 'I');
            AlphabetOrder.Add(9, 'J');
            AlphabetOrder.Add(10, 'K');
            AlphabetOrder.Add(11, 'L');
            AlphabetOrder.Add(12, 'M');
            AlphabetOrder.Add(13, 'N');
            AlphabetOrder.Add(14, 'O');
            AlphabetOrder.Add(15, 'P');
            AlphabetOrder.Add(16, 'Q');
            AlphabetOrder.Add(17, 'R');
            AlphabetOrder.Add(18, 'S');
            AlphabetOrder.Add(19, 'T');
            AlphabetOrder.Add(20, 'U');
            AlphabetOrder.Add(21, 'V');
            AlphabetOrder.Add(22, 'W');
            AlphabetOrder.Add(23, 'X');
            AlphabetOrder.Add(24, 'Y');
            AlphabetOrder.Add(25, 'Z');

            //make the key and plain text uppercase
            key = key.ToUpper();
            plain = plain.ToUpper();

            //store the cipher Text
            string cipherText = "";

            int i = 0;

            //loop through the plain text
            try {
                foreach (char element in plain)
                {
                    //if the character is not a letter, add it to the cipher text
                    if (!Char.IsLetter(element))
                    {
                        cipherText += element;
                    }
                    else
                    {
                        sbyte TOrder = AlphabetOrder.FirstOrDefault(x => x.Value == element).Key; //get the order of the letter in the alphabet
                        sbyte KOrder = AlphabetOrder.FirstOrDefault(x => x.Value == key[i]).Key; //get the order of the letter in the alphabet
                        sbyte Final = (sbyte)(TOrder + KOrder); //add the two orders together
                        if (Final > 25) //if the final order is greater than 25, subtract 26
                        {
                            Final -= 26;
                        }
                        cipherText += AlphabetOrder[Final]; //add the letter to the cipher text
                        i++;
                    }
                    if (i == key.Length) //if the key is shorter than the plain text, start over
                    {
                        i = 0;
                    }
                }
                return cipherText;
            } catch (Exception e)
            {
                return ("Error" + e.Message);
            }
            
        }

        //Vigenere Text Decryption
        public String VigenereTextDecrypt(String mixed, String key)
        {
            //create a dictionary to store the alphabet
            Dictionary <sbyte, char> AlphabetOrder = new Dictionary <sbyte, char>();

            //add the letters to the dictionary
            AlphabetOrder.Add(0, 'A'); 
            AlphabetOrder.Add(1, 'B');
            AlphabetOrder.Add(2, 'C');
            AlphabetOrder.Add(3, 'D');
            AlphabetOrder.Add(4, 'E');
            AlphabetOrder.Add(5, 'F');
            AlphabetOrder.Add(6, 'G');
            AlphabetOrder.Add(7, 'H');
            AlphabetOrder.Add(8, 'I');
            AlphabetOrder.Add(9, 'J');
            AlphabetOrder.Add(10, 'K');
            AlphabetOrder.Add(11, 'L');
            AlphabetOrder.Add(12, 'M');
            AlphabetOrder.Add(13, 'N');
            AlphabetOrder.Add(14, 'O');
            AlphabetOrder.Add(15, 'P');
            AlphabetOrder.Add(16, 'Q');
            AlphabetOrder.Add(17, 'R');
            AlphabetOrder.Add(18, 'S');
            AlphabetOrder.Add(19, 'T');
            AlphabetOrder.Add(20, 'U');
            AlphabetOrder.Add(21, 'V');
            AlphabetOrder.Add(22, 'W');
            AlphabetOrder.Add(23, 'X');
            AlphabetOrder.Add(24, 'Y');
            AlphabetOrder.Add(25, 'Z');

            //make the key and cipher text uppercase
            key = key.ToUpper();
            mixed = mixed.ToUpper();

            //store the plain text
            string plainText = "";

            int i = 0;

            try
            {
                //loop through the cipher text
                foreach (char element in mixed)
                {
                    if (!Char.IsLetter(element))
                    {
                        plainText += element;
                    }
                    else
                    {
                        sbyte TOrder = AlphabetOrder.FirstOrDefault(x => x.Value == element).Key; //get the order of the letter in the alphabet
                        sbyte KOrder = AlphabetOrder.FirstOrDefault(x => x.Value == key[i]).Key;
                        sbyte Final = (sbyte)(TOrder - KOrder);
                        if (Final < 0) //if the final order is less than 0, add 26
                        {
                            Final += 26;
                        }
                        plainText += AlphabetOrder[Final]; //add the letter to the plain text
                         
                        i++;
                    }
                    if (i == key.Length) //if the key is shorter than the cipher text, start over
                    {
                        i = 0;
                    }
                }
                return plainText;
            }
            catch (Exception e)
            {
                return ("Error" + e.Message);
            }
        }
    }
}
