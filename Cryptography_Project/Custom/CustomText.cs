using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Cryptography_Project.Custom
{
    internal class CustomText
    {
        //String plainText;

        public String swapText(String plainText)
        {
            int indexFirstPosition, indexLastPosition, temp;
            string newPlainText, middlePosition, firstPosition, lastPosition;

            indexFirstPosition = 0;
            indexLastPosition = plainText.Length - 1;

            middlePosition = plainText.Substring(1, indexLastPosition - 1);

            temp = indexFirstPosition;
            indexFirstPosition = indexLastPosition;
            indexLastPosition = temp;

            firstPosition = plainText.Substring(indexFirstPosition, 1);
            lastPosition = plainText.Substring(indexLastPosition, 1);

            newPlainText = firstPosition + middlePosition + lastPosition;

            return newPlainText;
        }

        public String reverseText(String inputText)
        {
            string reversedText = "";
            for (int i = inputText.Length - 1; i >= 0; i--)
            {
                reversedText += inputText[i];
            }
            return reversedText;
        }

        public String encryptedText(string plainText)
        {
            char[] charArray = plainText.ToCharArray();

            string newCipherText = "";
            char charInArray, newCharInArray;
            int ASCIIValue, newASCIIValue;

            for (int i = 0; i < plainText.Length; i++)
            {
                charInArray = charArray[i];

                ASCIIValue = (char)charInArray;
                newASCIIValue = ASCIIValue + 3;

                newCharInArray = (char) newASCIIValue;
                newCipherText += newCharInArray;
            }
            return newCipherText;
        }

        public String decryptedText(string plainText)
        {
            char[] charArray = plainText.ToCharArray();

            string newCipherText = "";
            char charInArray, newCharInArray;
            int ASCIIValue, newASCIIValue;

            for (int i = 0; i < plainText.Length; i++)
            {
                charInArray = charArray[i];

                ASCIIValue = (char)charInArray;
                newASCIIValue = ASCIIValue - 3;

                newCharInArray = (char) newASCIIValue;
                newCipherText += newCharInArray;
            }
            return newCipherText;
        }
    }
}
