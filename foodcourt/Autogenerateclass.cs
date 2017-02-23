using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace foodcourt
{
    class Autogenerateclass
    {
        public int autogenerateid(string tablename)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from " + tablename, con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            i++;
            return i;
        }
        public DataSet binditemtypes()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            SqlDataAdapter da = new SqlDataAdapter("select * from itemmaster", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "itemmaster");
            return ds;
        }
        public DataSet binditemnames(string itypeno)
        {
             SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            SqlDataAdapter da = new SqlDataAdapter("select * from items where ityno='"+itypeno+"'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "items");
            return ds;

        }

       
    }
}
