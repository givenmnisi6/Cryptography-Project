using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Cryptography_Project
{
    public partial class CustomFileForm : Form
    {
        string key;
        public CustomFileForm()
        {
            InitializeComponent();
        }

        private void Openbtn_Click(object sender, EventArgs e)
        {
            string input;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                input = openFileDialog1.FileName;
                plainTextbox.Text = input;
            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            string output;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                output = saveFileDialog1.FileName;
                encryptionTextbox.Text = output;
            }
        }

        private void Opentwobtn_Click(object sender, EventArgs e)
        {
            string outputtwo;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                outputtwo = saveFileDialog1.FileName;
                cipherTextbox.Text = outputtwo;
            }
        }
    }
}
