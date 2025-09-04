using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mk2_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            tbpassword.PasswordChar = '*'; 
        }

        private void cbshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbshowpassword.Checked)
            {
                tbpassword.PasswordChar = '\0'; 
            }
            else
            {
                tbpassword.PasswordChar = '*'; 
            }
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            string user = tbusername.Text;
            string pass = tbpassword.Text;

            if (user == "noah" && pass == "noahganteng")
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password salah!", "Login Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btclear_Click(object sender, EventArgs e)
        {
            tbusername.Clear();
            tbpassword.Clear();
            cbshowpassword.Checked = false;
            tbusername.Focus();
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
