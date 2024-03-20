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
    public partial class Login : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        System.Data.DataTable tb;
        String sql = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        private const int WS_SYSMENU = 0x80000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~WS_SYSMENU;
                return cp;
            }
        }
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(sql);
            cn.Open();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit Login", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            string s = "SELECT idAccountant, passAccountant FROM accountant WHERE idAccountant = '" + txtUser.Text + "' AND passAccountant = '" + txtPW.Text + "'";
            data = new SqlDataAdapter(s, cn);
            tb = new System.Data.DataTable();
            data.Fill(tb);

            if(tb.Rows.Count > 0 )
            {
                MessageBox.Show("Login Sucessful!");
                Function function = new Function();
                function.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Invalid login. Please check user or password!");
            }    
        }
    }
}
