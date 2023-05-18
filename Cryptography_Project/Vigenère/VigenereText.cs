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
            string encryptedText = "";

            int i = 0;

            //loop through the plain text
            try {
                foreach (char elements in plain)
                {
                    //if the character is not a letter, add it to the cipher text
                    if (!Char.IsLetter(elements))
                    {
                        encryptedText += elements;
                    }
                    else
                    {
                        sbyte firstOrder = AlphabetOrder.FirstOrDefault(x => x.Value == elements).Key; //get the order of the letter in the alphabet
                        sbyte lastOrder = AlphabetOrder.FirstOrDefault(x => x.Value == key[i]).Key; //get the order of the letter in the alphabet
                        sbyte finalValue = (sbyte)(firstOrder + lastOrder); //add the two orders together
                        
                        if (finalValue > 25) //if the final order is greater than 25, subtract 26
                        {
                            finalValue -= 26;
                        }
                        encryptedText += AlphabetOrder[finalValue]; //add the letter to the cipher text
                        i++;
                    }
                    if (i == key.Length) //if the key is shorter than the plain text, start over
                    {
                        i = 0;
                    }
                }
                return encryptedText;
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
            string decryptedText = "";

            int i = 0;

            try
            {
                //loop through the cipher text
                foreach (char elements in mixed)
                {
                    if (!Char.IsLetter(elements))
                    {
                        decryptedText += elements;
                    }
                    else
                    {
                        sbyte firstOrder = AlphabetOrder.FirstOrDefault(x => x.Value == elements).Key; //get the order of the letter in the alphabet
                        sbyte lastOrder = AlphabetOrder.FirstOrDefault(x => x.Value == key[i]).Key;
                        sbyte finalValue = (sbyte)(firstOrder - lastOrder);
                        if (finalValue < 0) //if the final order is less than 0, add 26
                        {
                            finalValue += 26;
                        }
                        decryptedText += AlphabetOrder[finalValue]; //add the letter to the plain text
                         
                        i++;
                    }
                    if (i == key.Length) //if the key is shorter than the cipher text, start over
                    {
                        i = 0;
                    }
                }
                return decryptedText;
            }
            catch (Exception e)
            {
                return ("Error" + e.Message);
            }
        }
    }
}
