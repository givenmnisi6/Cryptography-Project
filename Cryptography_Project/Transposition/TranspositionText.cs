using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography_Project.Transposition
{
    class TranspositionText : CreateDictionary
    {
        //This is the encryption key
        readonly int encryptionKey;
        
        public TranspositionText(int encryptionKey) { //This is the constructor
            this.encryptionKey = encryptionKey; //This sets the encryption key
        }

        //Encrypts the text
        public string Encrypt(string plainText)  //This is the encrypt method
        {
            return Process(plainText, Mode.Encrypt); //This calls the main method
        }

        //Decrypts the text
        public string Decrypt(string cipherText) //This is the decrypt method
        {
            return Process(cipherText, Mode.Decrypt); //This calls the main method
        }


        private string Process(string message, Mode mode) //This is the main method that calls the other methods
        {
            int rows = encryptionKey;
            int columns = (int)Math.Ceiling((double)message.Length / (double)rows);
            char[,] matrix = FillArray(message, rows, columns, mode);
            string result = "";
            foreach (char c in matrix)
            {
                result += c;
            }
            return result;
        }
        //This method fills the array with the message
        private char[,] FillArray(string message, int rowsCount, int columnsCount, Mode mode) //
        {
            int charPosition = 0; //This is the position of the character in the message
            int length = 0, width = 0; //These are the length and width of the array
            char[,] matrix = new char[rowsCount, columnsCount]; //This is the array that will be filled with the message


            switch (mode) //This switch statement sets the length and width of the array depending on the mode
            {
                case Mode.Encrypt: //If the mode is encrypt, the length is the number of rows and the width is the number of columns
                    length = rowsCount;
                    width = columnsCount;
                    break;
                case Mode.Decrypt: //If the mode is decrypt, the length is the number of columns and the width is the number of rows
                    matrix = new char[columnsCount, rowsCount];
                    width = rowsCount;
                    length = columnsCount;
                    break;
            }

            //This for loop fills the array with the message
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (charPosition < message.Length)
                    {
                        matrix[j, i] = message[charPosition]; //This fills the array with the message
                    }
                    else
                    {
                        matrix[j, i] = '*'; //This fills the rest of the array with asterisks
                    }

                    charPosition++; //This increments the position of the character in the message
                }
            }

            return matrix; //This returns the array
        }
        internal enum Mode //This is the mode enum
        {
            Encrypt, Decrypt
        }

        internal class Common 
        {
            //This retrieves the new value for a given letter based on the numerical value of the alphabet character and the key
            internal static int GetAlphabetPosition(int textPosition, int keyPosition, Mode mode)
            {
                int result = 0;

                switch (mode)
                {
                    case Mode.Encrypt: //This gets the new value for the alphabet character
                        result = (textPosition + keyPosition) % 26; //This gets the new value for the alphabet character
                        break;
                    case Mode.Decrypt:
                        result = textPosition - keyPosition;

                        if (result < 0)
                        {
                            result += 26;
                        }
                        break;
                }
                return result;
            }

            //This 'shifts' the keys into the correct position, it receives the alphabet in numerical order,
            //the key value and the input string, it then returns the new string result
            internal static string Shift(string token, string Key, Mode mode, Dictionary<char, int> alphabetSorted) 
            {
                string result = "";
                int textPosition, keyPosition, resPosition = 0;
                for (int i = 0; i < token.Length; i++)
                {
                    textPosition = alphabetSorted[token[i]]; //This gets the numerical value of the alphabet character
                    keyPosition = alphabetSorted[Key[i]];    //This gets the numerical value of the key character
                    resPosition = GetAlphabetPosition(textPosition, keyPosition, mode); //This gets the new value for the alphabet character
                    result += alphabetSorted.Keys.ElementAt(resPosition); //This adds the new value to the result string
                }
                return result; //This returns the result string
            }
        }
    }
}
