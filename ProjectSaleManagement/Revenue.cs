using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjectSaleManagement
{
    public partial class Revenue : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        System.Data.DataTable tb;
        String sql = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public Revenue()
        {
            InitializeComponent();
        }

        private void Revenue_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(sql);
            cn.Open();
        }

        private void bShow_Click(object sender, EventArgs e)
        {
            string revenue = "select year(rc.creationDate) as year, month(rc.creationDate) as month, (sum(ord.totalPrice)-sum(rc.totalPrice)) as revenue from orders ord, deliveryBill db, receipt rc where ord.idOrder = db.idOrder and month(ord.creationDate) = month(rc.creationDate) group by month(rc.creationDate), year(rc.creationDate) order by month(rc.creationDate), year(rc.creationDate)";
            data = new SqlDataAdapter(revenue, cn);
            tb = new System.Data.DataTable();
            data.Fill(tb);

            chart1.Series["Revenue"].Points.Clear();
            foreach (DataRow dr in tb.Rows)
            {
                if (dr[0].ToString() == txtYear.Text)
                {

                    if(dr[1].ToString() == "1")
                    {
                        chart1.Series["Revenue"].Points.AddXY("January", dr[2].ToString());
                    }

                    if (dr[1].ToString() == "2")
                    {
                        chart1.Series["Revenue"].Points.AddXY("February", dr[2].ToString());
                    }

                    if (dr[1].ToString() == "3")
                    {
                        chart1.Series["Revenue"].Points.AddXY("March", dr[2].ToString());
                    }

                    if (dr[1].ToString() == "4")
                    {
                        chart1.Series["Revenue"].Points.AddXY("April", dr[2].ToString());
                    }

                    if (dr[1].ToString() == "5")
                    {
                        chart1.Series["Revenue"].Points.AddXY("May", dr[2].ToString());
                    }

                    if (dr[1].ToString() == "6")
                    {
                        chart1.Series["Revenue"].Points.AddXY("June", dr[2].ToString());
                    }

                    if (dr[1].ToString() == "7")
                    {
                        chart1.Series["Revenue"].Points.AddXY("July", dr[2].ToString());
                    }

                    if (dr[1].ToString() == "8")
                    {
                        chart1.Series["Revenue"].Points.AddXY("August", dr[2].ToString());
                    }

                    if (dr[1].ToString() == "9")
                    {
                        chart1.Series["Revenue"].Points.AddXY("September", dr[2].ToString());
                    }

                    if (dr[1].ToString() == "10")
                    {
                        chart1.Series["Revenue"].Points.AddXY("October", dr[2].ToString());
                    }

                    if (dr[1].ToString() == "11")
                    {
                        chart1.Series["Revenue"].Points.AddXY("November", dr[2].ToString());
                    }

                    if (dr[1].ToString() == "12")
                    {
                        chart1.Series["Revenue"].Points.AddXY("December", dr[2].ToString());
                    }
                }
            }
        }
    }
}
