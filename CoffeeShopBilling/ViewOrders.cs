using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopBilling
{
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
            var orders = OrderList.getOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders;
        }

        private void backHomeBtn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
