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
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private void Textbtn_Click(object sender, EventArgs e)
        {
            //creating an instance of the TextEncryption form
            TextForm text = new TextForm();
            text.ShowDialog();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            this.Close();
        }

        private void Filesbtn_Click(object sender, EventArgs e)
        {
            //creating an instance of the TextEncryption form
            FileForm file = new FileForm();
            file.ShowDialog();
        }
    }
}
