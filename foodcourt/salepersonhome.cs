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
    public partial class salepersonhome : Form
    {
        public salepersonhome()
        {
            InitializeComponent();
        }

        private void salepersonhome_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome" +" "+  salespersonlogin.uname;
        }

        private void viewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewstock v1 = new viewstock();
            v1.Show();
        }

        private void makeSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makesales a1 = new makesales();
            a1.Show();
        }
    }
}
