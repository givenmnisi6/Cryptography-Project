using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography_Project.Transposition
{
    class TranspositionText : CreateDictionary
    {
        readonly int encryptionKey;
        public TranspositionText(int encryptionKey) {
            this.encryptionKey = encryptionKey;
        }
        public string Encrypt(string plainText)
        {
            return Process(plainText, Mode.Encrypt);
        }

        public string Decrypt(string cipherText)
        {
            return Process(cipherText, Mode.Decrypt);
        }
        private string Process(string message, Mode mode)
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
        private char[,] FillArray(string message, int rowsCount, int columnsCount, Mode mode)
        {
            int charPosition = 0;
            int length = 0, width = 0;
            char[,] matrix = new char[rowsCount, columnsCount];

            switch (mode)
            {
                case Mode.Encrypt:
                    length = rowsCount;
                    width = columnsCount;
                    break;
                case Mode.Decrypt:
                    matrix = new char[columnsCount, rowsCount];
                    width = rowsCount;
                    length = columnsCount;
                    break;
            }

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (charPosition < message.Length)
                    {
                        matrix[j, i] = message[charPosition];
                    }
                    else
                    {
                        matrix[j, i] = '*';
                    }

                    charPosition++;
                }
            }

            return matrix;
        }
        internal enum Mode
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
                    case Mode.Encrypt:
                        result = (textPosition + keyPosition) % 26;
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
                    textPosition = alphabetSorted[token[i]];
                    keyPosition = alphabetSorted[Key[i]];
                    resPosition = GetAlphabetPosition(textPosition, keyPosition, mode);
                    result += alphabetSorted.Keys.ElementAt(resPosition);
                }
                return result;
            }
        }
    }
}
