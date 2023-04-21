using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography_Project
{
    public partial class FileForm : Form
    {
        public FileForm()
        {
            InitializeComponent();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            browseTextbox.Text = "";
            keyTextbox.Text = "";
            outputTextbox.Text = "";
            comboBox1.SelectedItem = null;
            encryptionRadiobtn.Checked = false;
            decryptionRadiobtn.Checked = false;
        }
    }
}
