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
    public partial class updatestock : Form
    {
        string sid = "sid_";
        public updatestock()
        {
            InitializeComponent();
        }
        private void autogeneratestockid()
        {
            Autogenerateclass a1 = new Autogenerateclass();
            int i = a1.autogenerateid("stocktransaction");
            sid = sid + i;
            txtstockid.Text = sid;
        }
        private void additemtypes()
        {
            Autogenerateclass a1 = new Autogenerateclass();
            DataSet ds = a1.binditemtypes();
            cbitemtype.DataSource = ds.Tables[0];
            cbitemtype.DisplayMember = "itype";
            cbitemtype.ValueMember = "ityno";
        }

        private void updatestock_Load(object sender, EventArgs e)
        {
            autogeneratestockid();
            additemtypes();
        }
        
       private void cbitemname_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void txtqty_Leave(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select price from items where iname='"+cbitemname.Text+"'", con);
            double price = Convert.ToDouble(cmd.ExecuteScalar());
            int qty = int.Parse(txtqty.Text);
            double amount = qty * price;
            txtamount.Text = amount.ToString();
        }

        private void cbitemtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            Autogenerateclass a1 = new Autogenerateclass();
            DataSet ds = a1.binditemnames(cbitemtype.SelectedValue.ToString());
            cbitemname.DataSource = ds.Tables[0];
            cbitemname.DisplayMember = "iname";
            cbitemname.ValueMember = "ino";
        }

        private void btnupdstock_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            string q1 = "update items set qty='" + txtqty.Text + "'where iname='" + cbitemname.Text + "'";
            string q2 = "insert into stocktransaction values('" + txtstockid.Text + "','" + cbitemname.SelectedValue.ToString() + "','" + txtqty.Text + "','" + txtamount.Text + "','" + System.DateTime.Now.ToShortDateString() + "')";
            SqlCommand cmd = new SqlCommand(q1 + ";" + q2,con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Stock Updated Successfully");
        }
    }
}
