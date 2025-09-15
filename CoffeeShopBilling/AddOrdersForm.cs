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
    public partial class AddOrdersForm : Form
    {
        public AddOrdersForm()
        {
            InitializeComponent();
        }

        private void backHomeBtn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void addOrderBtn2_Click(object sender, EventArgs e)
        {
            //1.get User Inputs
            String name = CustomNameTxtBox.Text;
            DateTime orderDate = OrderDate.Value;
            int quantity = (int)Qauntity.Value;
            String coffeeType = "";

            if (EspressoRadio.Checked)
                coffeeType = "espresso";
            if (LatteRadio.Checked)
                coffeeType = "latte";
            if (CappuccionRadio.Checked)
                coffeeType = "cappuccino";

            //2.Base Coffee

            ICoffee coffee = new BaseCoffee(quantity, coffeeType);

            if (SugarChk.Checked)
                coffee = new Sugar(coffee);
            if (MilkChk.Checked)
                coffee = new MilkDecorator(coffee);
            if (WhippedChk.Checked)
                coffee = new Whipped(coffee);
            if (SyrupChk.Checked)
                coffee = new Syrup(coffee);
            if(ExtraShotChk.Checked)
                coffee = new ExtraShot(coffee);

            //3.Get Total Cost and Add-Ons

            double totalCost = coffee.GetCost();
            string adds_on = coffee.GetDescription();

            //4.Save order

            int no = OrderList.GetNextOrderNumber();

            Order order = new Order 
            {
                No = no ,
                customerName = name ,
                OrderDate = orderDate ,
                CoffeeType = coffeeType,
                quantity = quantity ,
                addsOn = adds_on ,
                netPayement = totalCost
            };

            OrderList.AddOrder(order);
            MessageBox.Show("Order Added Successfully");
        }
    }
}
