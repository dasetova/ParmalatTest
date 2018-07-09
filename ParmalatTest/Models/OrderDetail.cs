﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParmalatTest.Models
{
    public class OrderDetail
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public double Subtotal { get; set; }

        public int ProductID { get; set; }
        public int OrderID { get; set; }

        public Product Product { get; set; }
        public Order Order { get; set; }
        
    }
}