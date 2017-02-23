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
    public partial class Adminhome : Form
    {
        public Adminhome()
        {
            InitializeComponent();
        }

        private void iTEMTYPEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            additemstype a1 = new additemstype();
            a1.Show();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            additems a1 = new additems();
            a1.Show();
        }

        private void salesPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addsalesperson a1 = new Addsalesperson();
            a1.Show();

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updatestock a1 = new updatestock();
            a1.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            adminlogin a1 = new adminlogin();
            a1.Show();
        }
    }
}
