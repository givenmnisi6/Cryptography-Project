using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography_Project.Vernam
{
    internal class VernamFiles
    {
        // Vernam File Encryption
        //takes 3 parameters: input file, encrypted file, and key file
        //input file is the file to be encrypted
        //encrypted file is the file that will contain the encrypted text
        //key file is the file that will contain the key
        public void VernamFileEncrypt(string inputFile, string encryptedFile, string keyFile)
        {
            byte[] originalBytes;  //store the contents of the input file in bytes

            using (FileStream fileStream = new FileStream(inputFile, FileMode.Open)) //open the input file
            {
                originalBytes = new byte[fileStream.Length];                         //store the length of the input file in bytes
                fileStream.Read(originalBytes, 0, originalBytes.Length);             //read the input file
            }

            byte[] keyBytes = new byte[originalBytes.Length];                       //store the key in bytes
            Random rand = new Random();                                             //create a random number generator
            rand.NextBytes(keyBytes);                                               //generate a random key

            using (FileStream fileStream = new FileStream(keyFile, FileMode.Create)) //create the key file
            {
                fileStream.Write(keyBytes, 0, keyBytes.Length);                     //write the key to the key file
            }
                
            byte[] encryptedBytes = new byte[originalBytes.Length];                 //store the encrypted text in bytes
            VernamEncrypt(originalBytes, keyBytes, ref encryptedBytes);             //encrypt the input file


            using (FileStream fileStream = new FileStream(encryptedFile + ".ver", FileMode.Create)) //create the encrypted file
            {
                fileStream.Write(encryptedBytes, 0, encryptedBytes.Length);
            }
        }

        private void VernamEncrypt(byte[] inputBytes, byte[] keyBytes, ref byte[] outBytes)
        {
            if (inputBytes.Length != keyBytes.Length || (keyBytes.Length != outBytes.Length))
            {
                MessageBox.Show("The length of the original, key, and cipher must be the same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < inputBytes.Length; i++)
                {
                    outBytes[i] = (byte)(inputBytes[i] ^ keyBytes[i]);
                }
            }
        }

        public void VernamFileDecrypt(string encryptedFile, string keyFile, string decryptedFile)
        {
            byte[] encryptedBytes;

            using (FileStream fileStream = new FileStream(encryptedFile, FileMode.Open))
            {
                encryptedBytes = new byte[fileStream.Length];
                fileStream.Read(encryptedBytes, 0, encryptedBytes.Length);
            }

            byte[] keyBytes;
            using (FileStream fileStream = new FileStream(keyFile, FileMode.Open))
            {
                keyBytes = new byte[fileStream.Length];
                fileStream.Read(keyBytes, 0, keyBytes.Length);
            }

            byte[] decryptedData = new byte[encryptedBytes.Length];
            VernamEncrypt(encryptedBytes, keyBytes, ref decryptedData);

            if (encryptedFile.Contains(".ver"))
            {
                encryptedFile.Replace(".ver", "");
                using (FileStream fileStream = new FileStream(decryptedFile, FileMode.Create))
                {
                    fileStream.Write(decryptedData, 0, decryptedData.Length);
                }
            }
            else
            {
                using (FileStream fileStream = new FileStream(decryptedFile, FileMode.Create))
                {
                    fileStream.Write(decryptedData, 0, decryptedData.Length);
                }
            }
        }
    }
}
