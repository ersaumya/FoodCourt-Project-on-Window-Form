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
    public partial class additems : Form
    {
        string ino = "ino_";
        public additems()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void autogenerateitemno()
        {
            Autogenerateclass a1 = new Autogenerateclass();
            int i = a1.autogenerateid("items");
            ino = ino + i;
            txtitemno.Text = ino;
        }
        private void additems_Load(object sender, EventArgs e)
        {
            autogenerateitemno();
            
            additemstype();
        }
        private void additemstype()
        {
            Autogenerateclass a1 = new Autogenerateclass();
            DataSet ds =a1.binditemtypes();
            cbitemtype.DataSource = ds.Tables[0];
            cbitemtype.DisplayMember = "itype";
            cbitemtype.ValueMember = "ityno";

        }

        private void btbadd_Click(object sender, EventArgs e)
        {
            //create the connection
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            //open the connection
            con.Open();
            //pass the procedure
            SqlCommand cmd = new SqlCommand("proc_additems", con);
            //mention that we are working with storedprocedure
            cmd.CommandType = CommandType.StoredProcedure;
            //pass the values to the parameters
            cmd.Parameters.AddWithValue("@ino", txtitemno.Text);
            cmd.Parameters.AddWithValue("@iname", txtitemname.Text);
            cmd.Parameters.AddWithValue("@qty", 0);
            cmd.Parameters.AddWithValue("@price", txtprice.Text);
            cmd.Parameters.AddWithValue("@ityno", cbitemtype.SelectedValue.ToString());
            //execute the procedure
            int i = cmd.ExecuteNonQuery();
            //close the connection
            con.Close();
            if(i==1)
            {
                MessageBox.Show(txtitemname.Text + "  added successfully");
            }
            else
            {
                MessageBox.Show("Failed");

            }
            ino = "ino_";
            txtitemname.Text = "";
            autogenerateitemno();


        }
    }
}
