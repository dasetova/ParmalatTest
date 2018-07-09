using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParmalatTest.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public double UnitValue { get; set; }
        public int ProductCategoryID { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
    }
}