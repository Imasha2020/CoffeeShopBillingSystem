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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void AddOrdersBtn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddOrdersForm addOrder = new AddOrdersForm();
            addOrder.Show();
        }

        private void viewOrdersBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewOrders viewOrders = new ViewOrders();
            viewOrders.Show();
        }
    }
}
