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
    public partial class makesales : Form
    {
        string billid = "bid_";
        string bmid = "bmid_";
        double price = 0.0;
        int qtyinitems = 0;
        double totalamount = 0.0;
        public makesales()
        {
            InitializeComponent();
        }
        public void BindItemsType()
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
                con.Close();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = System.DateTime.Now.ToString();
        }
        private void autogeneratebillid()
        {
            Autogenerateclass a1 = new Autogenerateclass();
            int i = a1.autogenerateid("billtransaction");
            billid = billid + 1;
            txtbillid.Text = billid;
        }
        private void autogeneratebillmasterid()
        {
            Autogenerateclass a1 = new Autogenerateclass();
            int i = a1.autogenerateid("billmaster");
            bmid = bmid + i;
        }

        private void makesales_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            autogeneratebillid();
            autogeneratebillmasterid();
            BindItemsType();
        }

        private void cbitemtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbitemname.Items.Clear();
            cbitemname.Text = "";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_binditemnames", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@itype", cbitemtype.SelectedItem.ToString());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cbitemname.Items.Add(dr[0].ToString());
                }
                con.Close();
            }
        }

        private void cbitemname_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_getprice", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iname", cbitemname.Text);
            price = double.Parse(cmd.ExecuteScalar().ToString());
            txtprice.Text = price.ToString();
        }

        private void txtqty_Leave(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_getqty", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iname", cbitemname.Text);
            qtyinitems = int.Parse(cmd.ExecuteScalar().ToString());
            int qty = int.Parse(txtqty.Text);
            if(qty>qtyinitems)
            {
                MessageBox.Show("no stock");
            }
            else
            {
                totalamount = qty * price;
                txttotalamount.Text = totalamount.ToString();
            }
        }
    }
}
