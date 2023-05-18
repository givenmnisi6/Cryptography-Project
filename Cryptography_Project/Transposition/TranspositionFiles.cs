using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography_Project.Transposition
{
    internal class TranspositionFiles
    {
        public void Transpose(string input, string output, int status)
        {
            byte[] bytes;

            using(FileStream fileStream = new FileStream(input, FileMode.Open))
            {
                bytes = new byte[fileStream.Length];
                fileStream.Read(bytes, 0, bytes.Length);    
            }

            byte[] inputArr = bytes;
            Array.Reverse(inputArr, 0, inputArr.Length);


            if (status == 1)
            {
                using(FileStream fileStream = new FileStream(output + ".trans", FileMode.Create)) {
                    fileStream.Write(inputArr, 0, inputArr.Length);
                }
            } else
            {
                if(input.Contains(".trans"))
                {
                    input.Replace(".trans", " ");
                    using (FileStream fileStream = new FileStream(output, FileMode.Create))
                    {
                        fileStream.Write(inputArr, 0, inputArr.Length);
                    } 
                } else
                {
                    using (FileStream fileStream = new FileStream(output,FileMode.Create))
                    {
                        fileStream.Write(inputArr, 0, inputArr.Length);
                    }
                }
            }

        }

    }
}
