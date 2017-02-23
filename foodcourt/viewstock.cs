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
    public partial class viewstock : Form
    {
        public viewstock()
        {
            InitializeComponent();
        }
        private void Binditemtypes()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_binditemtypes", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                while(dr.Read())
                {
                    cbitemtype.Items.Add(dr[0].ToString());
                }
            }
            con.Close();
        }

        private void viewstock_Load(object sender, EventArgs e)
        {
            Binditemtypes();
        }

        private void cbitemtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbitemname.Items.Clear();
            cbitemname.Text = "";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_binditemnames", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@itype",cbitemtype.SelectedItem.ToString());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cbitemname.Items.Add(dr[0].ToString());
                }
            }
            con.Close();

        }

        private void cbitemname_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_displayqtyprice", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iname", cbitemname.SelectedItem.ToString());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtqty.Text = dr[0].ToString();
                    txtprice.Text = dr[1].ToString();
                }
            }
            con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            salepersonhome s1 = new salepersonhome();
            s1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            makesales m1 = new makesales();
            m1.Show();
        }
    }
}
