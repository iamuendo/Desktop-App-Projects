using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickMartPOS
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public VatCategory VatCategory { get; set; }

        public Product(string name, decimal price, VatCategory vatCategory)
        {
            Name = name;
            Price = price;
            VatCategory = vatCategory;
        }

        public decimal GetVatAmount()
        {
            var rate = VatRates.Rates[VatCategory];
            return Price * rate;
        }

        public decimal GetTotalPrice()
        {
            return Price + GetVatAmount();
        }
    }
}
