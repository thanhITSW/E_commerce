using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSaleManagement
{
    public partial class Statictical : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        System.Data.DataTable tb;
        String sql = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public Statictical()
        {
            InitializeComponent();
        }

        private void Statictical_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(sql);
            cn.Open();
        }
        void htGRD(string s, DataGridView grd)
        {
            data = new SqlDataAdapter(s, cn);
            tb = new System.Data.DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        private void bIncoming_Click(object sender, EventArgs e)
        {
            String s = "select i.nameItem, sum(quantity) as quantity, sum(quantity*price) as totalMoney from detailReceipt dr, item i where dr.idItem = i.idItem group by  i.nameItem ";
            htGRD(s, grd);
        }

        private void bOutgoing_Click(object sender, EventArgs e)
        {
            String s = "select i.nameItem, sum(quantity) as quantity, sum(quantity*price) as totalMoney from detailOrder orders, item i where orders.idItem = i.idItem group by  i.nameItem ";
            htGRD(s, grd);
        }
    }
}
