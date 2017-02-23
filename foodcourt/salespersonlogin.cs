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
    public partial class salespersonlogin : Form
    {
        public static string uname { set; get; }
        SqlConnection con;
        public salespersonlogin()
        {
            InitializeComponent();
        }

        private void salespersonlogin_Load(object sender, EventArgs e)
        {

        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            try {
                uname = txtusername.Text;
                //create connection
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
                //open connection
                con.Open();
                //pass the procedure
                SqlCommand cmd = new SqlCommand("proc_login", con);
                //mention that we are working with stored procedure
                cmd.CommandType = CommandType.StoredProcedure;
                //pass the value to the parameter
                cmd.Parameters.AddWithValue("@ename", txtusername.Text);
                cmd.Parameters.AddWithValue("@password", txtpwd.Text);
                //execute the query
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        salepersonhome s1 = new salepersonhome();
                        s1.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User");
                }
            }
            catch(Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminlogin a1 = new adminlogin();
            a1.Show();
        }
    }
}
