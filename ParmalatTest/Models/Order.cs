using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParmalatTest.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string CustomerID { get; set; }
        public double TotalValue { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}