using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Core
{
    class Inventory
    {
        public int InventoryID { get; set; }
        public string StockID { get; set; }
        public char StockType { get; set; }     // Equity / Margin / Option
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public float Rate { get; set; }

    }
}
