using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParmalatTest.Models
{
    public class ProductCategory
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}