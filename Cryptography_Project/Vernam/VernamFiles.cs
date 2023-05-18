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
        public void VernamFileEncrypt(string inputFile, string encryptedFile, string keyFile)
        {
            byte[] originalBytes; 

            using (FileStream fileStream = new FileStream(inputFile, FileMode.Open)) 
            {
                originalBytes = new byte[fileStream.Length];                         
                fileStream.Read(originalBytes, 0, originalBytes.Length);             
            }

            byte[] keyBytes = new byte[originalBytes.Length];                      
            Random rand = new Random();                                            
            rand.NextBytes(keyBytes);                                               

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

        public void VernamFileDecrypt(string encryptedFiles, string keyFile, string decryptedFile)
        {
            byte[] encryptedBytes;

            using (FileStream fileStream = new FileStream(encryptedFiles, FileMode.Open))
            {
                encryptedBytes = new byte[fileStream.Length];
                fileStream.Read(encryptedBytes, 0, encryptedBytes.Length);
            }

            byte[] keyFileBytes;
            using (FileStream fileStream = new FileStream(keyFile, FileMode.Open))
            {
                keyFileBytes = new byte[fileStream.Length];
                fileStream.Read(keyFileBytes, 0, keyFileBytes.Length);
            }

            byte[] decryptedData = new byte[encryptedBytes.Length];
            VernamEncrypt(encryptedBytes, keyFileBytes, ref decryptedData);

            if (encryptedFiles.Contains(".ver"))
            {
                encryptedFiles.Replace(".ver", "");
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
