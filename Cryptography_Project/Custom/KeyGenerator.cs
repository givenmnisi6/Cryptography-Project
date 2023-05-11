using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography_Project.Custom
{
    internal class KeyGenerator
    {
        private const string VALID = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        private const int LENGTH = 15;

        public byte[] generateKey()
        {
            using (RNGCryptoServiceProvider rngCSP = new RNGCryptoServiceProvider())
            {
                byte[] randomBytes = new byte[LENGTH];
                rngCSP.GetBytes(randomBytes);
                return randomBytes;
            }
        }

        public byte[] generateKey(int length)
        {
            using (RNGCryptoServiceProvider rngCSP = new RNGCryptoServiceProvider())
            {
                byte[] randomBytes = new byte[length];
                rngCSP.GetBytes(randomBytes);
                return randomBytes;
            }
        }
    }
}
