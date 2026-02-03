using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulasi.Models
{
    public class OrderModel
    {
        public int OrderId { get; set; }
        public int TransactionId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderTime { get; set; }
    }
}
