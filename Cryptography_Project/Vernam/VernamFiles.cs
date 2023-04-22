using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography_Project.Vernam
{
    internal class VernamFiles
    {
        // Vernam File Encryption
        //takes 3 parameters: input file, encrypted file, and key file
        //input file is the file to be encrypted
        //encrypted file is the file that will contain the encrypted text
        //key file is the file that will contain the key
        public void VernamFileEncryption(string input, string encrypted, string key) 
        {
            byte[] original; //store the contents of the input file in bytes

            using (FileStream open = new FileStream(input, FileMode.Open)) //open the input file
            {
                original = new byte[open.Length]; //store the length of the input file in bytes
                open.Read(original, 0, original.Length); //read the input file
            }
            byte[] keyByte = new byte[original.Length]; //store the key in bytes

            Random rand = new Random(); //create a random number generator
            rand.NextBytes(keyByte); //generate a random key

            using (FileStream keyFile = new FileStream(key, FileMode.Create)) //create the key file
            {
                keyFile.Write(keyByte, 0, keyByte.Length); //write the key to the key file
            }
            byte[] cipherByte = new byte[original.Length]; //store the encrypted text in bytes

            EncryptFile (original, keyByte, cipherByte); //encrypt the input file

            using (FileStream cipherFile = new FileStream(encrypted + ".ver", FileMode.Create)) //create the encrypted file
            {
                cipherFile.Write(cipherByte, 0, cipherByte.Length);
            }
        }
        public void EncryptFile(byte[] original, byte[] key, byte[] cipher)
        {
            if (original.Length != key.Length || (key.Length != cipher.Length))
            {
                throw new Exception("The length of the original, key, and cipher must be the same.");
            }
            else
            {
                for (int i = 0; i < original.Length; i++)
                {
                    cipher[i] = (byte)(original[i] ^ key[i]);
                }
            }
        }
    }
}
