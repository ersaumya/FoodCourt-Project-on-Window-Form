using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace foodcourt
{
    public partial class additemstype : Form
    {
        string itemtyno = "it_";
        public additemstype()
        {
            InitializeComponent();
        }
        private void autogenerateitemtypeno()
        {
            Autogenerateclass a1 = new Autogenerateclass();
            int i = a1.autogenerateid("itemmaster");
            itemtyno = itemtyno + i;
            txttypeno.Text = itemtyno;
        }
        private void additemstype_Load(object sender, EventArgs e)
        {
            autogenerateitemtypeno();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open(); ;
            SqlCommand cmd = new SqlCommand("proc_additemtypes", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ityno", txttypeno.Text);
            cmd.Parameters.AddWithValue("@itype", txttype.Text);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if(i==1)
            {
                MessageBox.Show(txttype.Text + " added successfully");
            }
            else
            {
                MessageBox.Show("Failed");
            }
            itemtyno = "it_";
            txttype.Text = "";
            autogenerateitemtypeno();
        }
    }
}
