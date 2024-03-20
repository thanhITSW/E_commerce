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
    public partial class GoodReceived : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        System.Data.DataTable tb;
        String sql = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public GoodReceived()
        {
            InitializeComponent();
        }

        private void GoodReceived_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(sql);
            cn.Open();
            formload();
        }
        void formload()
        {
            htGRD2();
            //grd1.Columns.Add("ID item","ID item");
            //grd1.Columns.Add("Name item", "Name item");
            //grd1.Columns.Add("Quantity", "Quantity");
            //grd1.Columns.Add("Price", "Price");
            txtRe.Text = genMS();
            txtAc.Focus();
            htGRD1();
            htGRD2();
        }
        void htGRD2()
        {
            string s = "select * from receipt";
            htGRD(s, grd2);
        }
        void htGRD1()
        {
            string s = "select * from detailReceipt where idReceipt = '" + txtRe.Text + "'";
            htGRD(s, grd1);
        }
        void htGRD(string s, DataGridView grd)
        {
            data = new SqlDataAdapter(s, cn);
            tb = new System.Data.DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }
        public string genMS()
        {
            string s = "select top 1 idReceipt from receipt order by idReceipt desc";
            //string s = "select count(*) from receipt";
            data = new SqlDataAdapter(s, cn);
            tb = new System.Data.DataTable();
            data.Fill(tb);
            if (tb.Rows.Count > 0)
            {
                s = tb.Rows[0][0].ToString();
                s = s.Substring(s.Length - 1, 1);
                int stt = int.Parse(s) + 1;
                s = "rc" + stt.ToString();

            }
            else
                s = "rc" + "1";

            return s;
        }

        public void clearInformation()
        {
            txtIdItem.Clear();
            txtNameItem.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
        }
        private void addDetailReceipt()
        {
            string s = "insert into detailReceipt values ('" + txtRe.Text + "', '" + txtIdItem.Text + "', '" + txtQuantity.Text + "','" + txtPrice.Text + "')";
            cm = new SqlCommand(s, cn);
            cm.ExecuteNonQuery();
        }
        private void bAdd_Click(object sender, EventArgs e)
        {
            if (txtIdItem.Text != "" && txtQuantity.Text != "" && txtPrice.Text != "") {
                addNewItem(txtIdItem.Text);
                addDetailReceipt();
                htGRD1();
                updateTotalPrice(txtRe.Text);
            }
            else
            {
                MessageBox.Show("Information not enough. Please fill all");
                clearInformation();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string idReceipt = txtRe.Text;
            string idAccountant = txtAc.Text;
            var createDates = dateDate.Value;
            int year = createDates.Year;
            int month = createDates.Month;
            int day = createDates.Day;
            string creationDate = string.Format("{0}/{1}/{2}", month, day, year);

            string s = "insert into receipt values ('" + idReceipt + "', '" + idAccountant + "', '" + creationDate.ToString() + "','" + 0 + "')";
            cm = new SqlCommand(s, cn);
            cm.ExecuteNonQuery();
            htGRD2();
        }
        private void updateTotalPrice(string idReceipt)
        {
            string s = "";

            s = "update receipt set totalPrice = (select sum(price * quantity) as amount from detailReceipt where idReceipt = '" + idReceipt + "') where idReceipt = '" + idReceipt + "'";
            cm = new SqlCommand(s, cn);
            cm.ExecuteNonQuery();
            htGRD2();
        }

        private void addNewItem(string idItem)
        {

            if (ExistItem(idItem) == false)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                string s = "insert into item values ('" + idItem+ "', '" + txtNameItem.Text + "', '" + txtPrice.Text + "','" + "" + "', '" + 0 + "')";
                cm = new SqlCommand(s, cn);
                adapter.InsertCommand = new SqlCommand(s, cn);
                adapter.InsertCommand.ExecuteNonQuery();
                updateInventory(idItem, txtQuantity.Text);
            }
            else
            {
                updateInventory(idItem, txtQuantity.Text);
            }
          
        }
        private Boolean ExistItem(string idItem)
        {
            SqlDataReader dataReader;
            String Output = "";
            string s = "Select count(*) from item where idItem = '" + idItem + "'";
            cm = new SqlCommand(s, cn);
            dataReader = cm.ExecuteReader();

            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0);
            }
            int count = Int32.Parse(Output);
            dataReader.Close();
            cm.Dispose();
            if (count > 0)
                return true;
            else
                return false;
        }
        private void updateInventory(string idItem, string quantity)
        {
            String s = "Update item set inventory = inventory + " + quantity + "where idItem = '" + idItem + "'";
            cm = new SqlCommand(s, cn);
            cm.ExecuteNonQuery();
        }

        private void bPrint_Click(object sender, EventArgs e)
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
            for (int i = 1; i < grd2.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = grd2.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < grd2.Rows.Count - 1; i++)
            {
                for (int j = 0; j < grd2.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = grd2.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("E:\\receipt.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }

        private void grd2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.grd2.Rows[e.RowIndex];
            string tmp = row.Cells[0].Value.ToString();
            string s = "select * from detailReceipt where idReceipt = '" + tmp + "'";
            htGRD(s, grd1);
        }

        private void AllowNumbersOnly(Object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void grd1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if(grd1.CurrentCell.ColumnIndex == 4)
            {
                e.Control.KeyPress -= AllowNumbersOnly;
                e.Control.KeyPress += AllowNumbersOnly;
            }
        }

        private void grd1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (grd1.CurrentRow.Cells[0].Value != DBNull.Value) 
            { 
                if(MessageBox.Show("Are you sure delete ?","DataGridView",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cm = new SqlCommand("delete", cn);
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.AddWithValue("@idReceipt", Convert.ToString(grd1.CurrentRow.Cells[0].Value));
                    cm.ExecuteNonQuery(); 
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else { e.Cancel = true; }
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            sql = "update detailReceipt set idItem = '" + txtIdItem.Text + "', quantity = '" + txtQuantity.Text+ "', price = '" + txtPrice.Text + "' where idItem = '" + txtIdItem.Text + "'";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            updateTotalPrice(txtRe.Text);
            updateInventory(txtIdItem.Text, txtQuantity.Text);
            htGRD1();
            htGRD2();
        }
    }
}
