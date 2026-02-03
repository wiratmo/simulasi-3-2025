using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulasi.Models
{
    public class TransactionModel
    {
        public int TransactionId { get; set; }
        public int TableId { get; set; }
        public string CustomerName { get; set; }
        public DateTime TransactionDate { get; set; }
        public string status { get; set; }

    }
}
