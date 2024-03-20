using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSaleManagement
{
    public partial class Function : Form
    {
        public Function()
        {
            InitializeComponent();
        }

        private void bItem_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.ShowDialog();
        }

        private void bGR_Click(object sender, EventArgs e)
        {
            GoodReceived goodReceived = new GoodReceived();
            goodReceived.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GoodDeliveryNote gooddelivery = new GoodDeliveryNote();
            gooddelivery.ShowDialog();
        }

        private void bStatictical_Click(object sender, EventArgs e)
        {
            Statictical statictical = new Statictical();
            statictical.ShowDialog();
        }

        private void bRevenue_Click(object sender, EventArgs e)
        {
            Revenue revenue = new Revenue();
            revenue.ShowDialog();
        }
    }
}
