using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ProjectSaleManagement
{
    public partial class Item : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;
        int dk = 0;
        String sql = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public Item()
        {
            InitializeComponent();
        }

        void formload()
        {
            string s = "select idItem, nameItem, priceItem, inventory from item";
            htGRD(s);
        }
        void htGRD(string s)
        {
            data = new SqlDataAdapter(s, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(sql);
            cn.Open();
            formload();
        }

        private void txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            string sql = "select idItem, nameItem, priceItem, inventory from item where nameItem like N'%" + txtFind.Text + "%'";
            htGRD(sql);
        }
    }
}
