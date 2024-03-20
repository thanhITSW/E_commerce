using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unitest
{
    public class TestLogin
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        System.Data.DataTable tb;
        public int CheckLogin(string username, string password)
        {
            string sql = "initial catalog = finalSW; data source = DESKTOP-0H7G9I2\\SQLEXPRESS; integrated security = true";
            cn = new SqlConnection(sql);
            cn.Open();
            string s = "SELECT idAccountant, passAccountant FROM accountant WHERE idAccountant = '" + username + "' AND passAccountant = '" + password + "'";
            data = new SqlDataAdapter(s, cn);
            tb = new System.Data.DataTable();
            data.Fill(tb);

            if (tb.Rows.Count > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
