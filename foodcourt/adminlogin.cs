using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foodcourt
{
    public partial class adminlogin : Form
    {
        public adminlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if(txtusername.Text=="admin"&& txtpassword.Text=="admin")
            {
                timer1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invalid User");
            }
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {

            if(txtusername.Text=="")
            {
                MessageBox.Show("Username should not be empty");
                txtusername.Focus();
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if(txtpassword.Text=="")
            {
                MessageBox.Show("Password should not be empty");
                txtpassword.Focus();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 5;
            if(progressBar1.Value>=100)
            {
                timer1.Enabled = false;
                Adminhome a1 = new Adminhome();
                a1.Show();
            }
        }
    }
}
