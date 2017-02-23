using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace foodcourt
{
    public partial class Addsalesperson : Form
    {
        string eno = "eno_";
        public Addsalesperson()
        {
            InitializeComponent();
        }
        private void autogenerateempno()
        {
            Autogenerateclass a1 = new Autogenerateclass();
            int i = a1.autogenerateid("employee");
            eno = eno + i;
            txteno.Text = eno;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Addsalesperson_Load(object sender, EventArgs e)
        {
            autogenerateempno();
        }

        private void btnaddemployee_Click(object sender, EventArgs e)
        {
            try
            {
                //create connection
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
                //open connection
                con.Open();
                //pass the procedure
                SqlCommand cmd = new SqlCommand("proc_createemployee", con);
                //mention that we are working with stored procedure
                cmd.CommandType = CommandType.StoredProcedure;
                //pass the value to the parameter
                cmd.Parameters.AddWithValue("@eid", txteno.Text);
                cmd.Parameters.AddWithValue("@ename", txtename.Text);
                cmd.Parameters.AddWithValue("@password", txtpassword.Text);
                cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                cmd.Parameters.AddWithValue("@phoneno", txtphoneno.Text);
                cmd.Parameters.AddWithValue("@hint", txthints.Text);
                //execute the procedure
                int i = cmd.ExecuteNonQuery();
                //close the connection
                con.Close();
                if(i==1)
                {
                    MessageBox.Show(txtename.Text + "added successfully");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
                eno = "eno_";
                txtename.Text = "";
                autogenerateempno();
            }
            catch(Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }
    }
}
