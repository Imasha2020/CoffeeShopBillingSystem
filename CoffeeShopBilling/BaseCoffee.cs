using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopBilling
{
    public class BaseCoffee : ICoffee
    {
        private double baseCost;
        private string baseDescription;
        private int qauntity;

        public BaseCoffee(int qauntity, string CoffeeType) {
            this.qauntity = qauntity;
            this.baseDescription = "";
            if (CoffeeType == "espresso")
                baseCost = 200;
            else if (CoffeeType == "latte")
                baseCost = 300;
            else if (CoffeeType == "cappuccino")
                baseCost = 350;
        }

        public double GetCost()
        { 
            return baseCost * qauntity;
        }

        public string GetDescription()
        {
            return baseDescription;
        }

    }
}
