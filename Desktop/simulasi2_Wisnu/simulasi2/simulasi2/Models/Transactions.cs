using System;
using System.Collections.Generic;
using System.Text;

namespace simulasi2.Models
{
    internal class Transactions
    {
        public int TransactionsID { get; set; }
        public int TableID { get; set; }
        public string CustomerName { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Status { get; set; }
    }
}
