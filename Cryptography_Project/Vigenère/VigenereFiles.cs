using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;

namespace Cryptography_Project.Vigenère
{
    internal class VigenereFiles
    {
        public void VigenereFileEncrypt(string inputFile, string encryptedFile, string keyFile)
        {
            byte[] plainBytes;

            using (FileStream fileStream = new FileStream(inputFile, FileMode.Open))
            {
                plainBytes = new byte[fileStream.Length];
                fileStream.Read(plainBytes, 0, plainBytes.Length);
            }

            byte[] encryptionkeyBytes = new byte[plainBytes.Length];
            Random rand = new Random();
            rand.NextBytes(encryptionkeyBytes);

            using (FileStream fileStream = new FileStream(keyFile, FileMode.Create)) //create the key file
            {
                fileStream.Write(encryptionkeyBytes, 0, encryptionkeyBytes.Length);                     //write the key to the key file
            }

            byte[] encryptedBytes = new byte[plainBytes.Length];                 //store the encrypted text in bytes
            VigenereEncrypt(plainBytes, encryptionkeyBytes, ref encryptedBytes);             //encrypt the input file


            using (FileStream fileStream = new FileStream(encryptedFile + ".vig", FileMode.Create)) //create the encrypted file
            {
                fileStream.Write(encryptedBytes, 0, encryptedBytes.Length);
            }
        }

        private void VigenereEncrypt(byte[] inputBytes, byte[] encryptionkeyBytes, ref byte[] outBytes)
        {
            if (inputBytes.Length != encryptionkeyBytes.Length || (encryptionkeyBytes.Length != outBytes.Length))
            {
                MessageBox.Show("The length of the original, key, and cipher must be the same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < inputBytes.Length; i++)
                {
                    outBytes[i] = (byte)(inputBytes[i] ^ encryptionkeyBytes[i]);
                }
            }
        }

        public void VigenereFileDecrypt(string encryptedFiles, string keyFile, string decryptedFile)
        {
            byte[] encryptedBytes;

            using (FileStream fileStream = new FileStream(encryptedFiles, FileMode.Open))
            {
                encryptedBytes = new byte[fileStream.Length];
                fileStream.Read(encryptedBytes, 0, encryptedBytes.Length);
            }

            byte[] bytesOfKey;
            using (FileStream fileStream = new FileStream(keyFile, FileMode.Open))
            {
                bytesOfKey = new byte[fileStream.Length];
                fileStream.Read(bytesOfKey, 0, bytesOfKey.Length);
            }

            byte[] decryptedData = new byte[encryptedBytes.Length];
            VigenereEncrypt(encryptedBytes, bytesOfKey, ref decryptedData);

            if (encryptedFiles.Contains(".vig"))
            {
                encryptedFiles.Replace(".vig", "");
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
