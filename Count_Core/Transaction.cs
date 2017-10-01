using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Core
{
    class Transaction
    {
        public int TransactionID { get; set; }
        public char Type { get; set; }  // Buy/sell/intraday
        public string StockID { get; set; }
        public float Price { get; set; }
        public DateTime TranscDate { get; set; }
        public int BrokerageID { get; set; }
        public float BrokerageAmt { get; set; }
        public int TaxID { get; set; }
        public float TaxAmt { get; set; }
        public float TotalAmt { get; set; }

    }
}
