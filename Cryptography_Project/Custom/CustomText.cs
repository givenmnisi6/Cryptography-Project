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
        //Swap the first and last character of the string and store it into new string, Given - > ivenG
        //Reverse the string and store it into new string, ivenG - > Gnevi
        //Move each character 3 positions forward in ASCII table and store it into new string, Gnevi - > Jhylq
        public String swapText(String plainText)
        {
            int indexFirstPosition, indexLastPosition, temp;
            string newPlainText, middlePosition, firstPosition, lastPosition;

            indexFirstPosition = 0;                     //index of first position
            indexLastPosition = plainText.Length - 1;   //index of last position

            middlePosition = plainText.Substring(1, indexLastPosition - 1); //middle position

            //swapping the position of first and last character
            temp = indexFirstPosition;                  
            indexFirstPosition = indexLastPosition;     
            indexLastPosition = temp;

            //getting the first and last character
            firstPosition = plainText.Substring(indexFirstPosition, 1); 
            lastPosition = plainText.Substring(indexLastPosition, 1);

            //new string
            newPlainText = firstPosition + middlePosition + lastPosition;

            return newPlainText;
        }

        public String reverseText(String inputText)
        {
            string reversedText = "";
            for (int i = inputText.Length - 1; i >= 0; i--) //for loop to reverse the string
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

            for (int i = 0; i < plainText.Length; i++) //for loop to move each character 3 positions forward in ASCII table
            {
                charInArray = charArray[i];

                ASCIIValue = (char)charInArray;
                newASCIIValue = ASCIIValue + 3; //moving 3 positions forward in ASCII table

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
                newASCIIValue = ASCIIValue - 3; //moving 3 positions backward in ASCII table

                newCharInArray = (char) newASCIIValue;
                newCipherText += newCharInArray;
            }
            return newCipherText;
        }
    }
}
