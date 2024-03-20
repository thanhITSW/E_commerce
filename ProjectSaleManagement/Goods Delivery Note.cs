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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Data.Common;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace ProjectSaleManagement
{
    public partial class GoodDeliveryNote : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        System.Data.DataTable tb;
        String sql = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public GoodDeliveryNote()
        {
            InitializeComponent();
        }

        private void GoodDeliveryNote_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(sql);
            cn.Open();
            formload();
        }
        void formload()
        {
            htGRD1();
            htGRD2();
        }
        void htGRD1()
        {
            string s = "select * from orders";
            htGRD(s, grd1);
        }
        void htGRD2()
        {
            string s = "select * from deliveryBill";
            htGRD(s, grd2);
        }
        void htGRD(string s, DataGridView grd)
        {
            data = new SqlDataAdapter(s, cn);
            tb = new System.Data.DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        private void grd2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grd2.CurrentRow.Selected = true;
            txtID.Text = grd2.Rows[e.RowIndex].Cells["idDeliveryBill"].Value.ToString();
            if (grd2.Rows[e.RowIndex].Cells["orderStatus"].Value.ToString() == "being transferred")
            {
                rdTran.Checked = true;
            }
            else
            {
                rdDeli.Checked = true;
            }

            if (grd2.Rows[e.RowIndex].Cells["paymentStatus"].Value.ToString() == "paid")
            {
                rdPaid.Checked = true;
            }
            else
            {
                rdUnpaid.Checked = true;
            }
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if(rdTran.Checked && rdPaid.Checked) {
                sql = "update deliveryBill set orderStatus = '" + "being transferred" + "', paymentStatus = '" + "paid" + "'where idDeliveryBill = '" + txtID.Text + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                htGRD2();
            }
            else if (rdTran.Checked && rdUnpaid.Checked)
            {
                sql = "update deliveryBill set orderStatus = '" + "being transferred" + "', paymentStatus = '" + "unpaid" + "'where idDeliveryBill = '" + txtID.Text + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                htGRD2();
            }
            else if (rdDeli.Checked && rdPaid.Checked)
            {
                sql = "update deliveryBill set orderStatus = '" + "delivered" + "', paymentStatus = '" + "paid" + "'where idDeliveryBill = '" + txtID.Text + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                htGRD2();
            }
            else
            {
                sql = "update deliveryBill set orderStatus = '" + "delivered" + "', paymentStatus = '" + "unpaid" + "'where idDeliveryBill = '" + txtID.Text + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                htGRD2();
            }
        }

        private void bExport_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < grd1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = grd1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < grd1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < grd1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = grd1.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("E:\\delivery.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }
    }
}
