using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal.Model
{
    internal class Item
    {
        public int IDinvoice { get; set; }
        public int IDitem { get; set; }
        public string product { get; set; }
        public double value { get; set; }

        public Item(int IDinvoice, int IDitem, string product, double value)
        {
            this.IDinvoice = IDinvoice;
            this.IDitem = IDitem;
            this.product = product;
            this.value = value;
        }
    }
}
