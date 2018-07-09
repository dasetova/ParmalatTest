using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParmalatTest.Models
{
    public class ParmalatInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ParmalatContext>
    {
        protected override void Seed(ParmalatContext context)
        {
            var productCategories = new List<ProductCategory>
            {
                new ProductCategory {Description = "Product Category A"},
                new ProductCategory {Description = "Product Category B"},
                new ProductCategory {Description = "Product Category C"},
                new ProductCategory {Description = "Product Category D"}
            };
            productCategories.ForEach(pc => context.ProductCategories.Add(pc));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product {Description = "Product A", UnitValue = 2000, ProductCategoryID = 1},
                new Product {Description = "Product B", UnitValue = 3000, ProductCategoryID = 1},
                new Product {Description = "Product C", UnitValue = 4000, ProductCategoryID = 2},
                new Product {Description = "Product D", UnitValue = 5000, ProductCategoryID = 2},
                new Product {Description = "Product E", UnitValue = 6000, ProductCategoryID = 3},
                new Product {Description = "Product F", UnitValue = 7000, ProductCategoryID = 3},
                new Product {Description = "Product G", UnitValue = 8000, ProductCategoryID = 4},
                new Product {Description = "Product H", UnitValue = 9000, ProductCategoryID = 4}
            };
            products.ForEach(p => context.Products.Add(p));
            context.SaveChanges();

            var customers = new List<Customer>
            {
                new Customer {CustomerID="1234",Name="Daniel Torres",Address="Calle 123",Email="dasetova@gmail.com",Telephone="83423943"},
                new Customer {CustomerID="5678",Name="Felipe Rivera",Address="Carrera 56",Email="test@gmail.com",Telephone="83423943"},
                new Customer {CustomerID="9012",Name="Andres Castellanos",Address="Autopista Norte",Email="other@gmail.com",Telephone="83423943"},
                new Customer {CustomerID="3456",Name="Alexander Castillo",Address="Diagonal sur",Email="another@gmail.com",Telephone="83423943"}
            };
            customers.ForEach(c => context.Customers.Add(c));
            context.SaveChanges();

            var orders = new List<Order>
            {
                new Order {CustomerID="1234", TotalValue=5000},
                new Order {CustomerID="1234", TotalValue=9000},
                new Order {CustomerID="5678", TotalValue=13000},
                new Order {CustomerID="5678", TotalValue=17000},
                new Order {CustomerID="9012", TotalValue=5000},
                new Order {CustomerID="9012", TotalValue=9000},
                new Order {CustomerID="3456", TotalValue=13000},
                new Order {CustomerID="3456", TotalValue=17000}
            };
            orders.ForEach(o => context.Orders.Add(o));
            context.SaveChanges();

            var orderDetails = new List<OrderDetail>
            {
                new OrderDetail {OrderID = 1, ProductID = 1, Quantity = 1, Subtotal = 2000},
                new OrderDetail {OrderID = 1, ProductID = 2, Quantity = 1, Subtotal = 3000},
                new OrderDetail {OrderID = 2, ProductID = 3, Quantity = 1, Subtotal = 4000},
                new OrderDetail {OrderID = 2, ProductID = 4, Quantity = 1, Subtotal = 5000},
                new OrderDetail {OrderID = 3, ProductID = 5, Quantity = 1, Subtotal = 6000},
                new OrderDetail {OrderID = 3, ProductID = 6, Quantity = 1, Subtotal = 7000},
                new OrderDetail {OrderID = 4, ProductID = 7, Quantity = 1, Subtotal = 8000},
                new OrderDetail {OrderID = 4, ProductID = 8, Quantity = 1, Subtotal = 9000},
                new OrderDetail {OrderID = 5, ProductID = 1, Quantity = 1, Subtotal = 2000},
                new OrderDetail {OrderID = 5, ProductID = 2, Quantity = 1, Subtotal = 3000},
                new OrderDetail {OrderID = 6, ProductID = 3, Quantity = 1, Subtotal = 4000},
                new OrderDetail {OrderID = 6, ProductID = 4, Quantity = 1, Subtotal = 5000},
                new OrderDetail {OrderID = 7, ProductID = 5, Quantity = 1, Subtotal = 6000},
                new OrderDetail {OrderID = 7, ProductID = 6, Quantity = 1, Subtotal = 7000},
                new OrderDetail {OrderID = 8, ProductID = 7, Quantity = 1, Subtotal = 8000},
                new OrderDetail {OrderID = 8, ProductID = 8, Quantity = 1, Subtotal = 9000}
            };
            orderDetails.ForEach(od => context.OrderDetails.Add(od));
            context.SaveChanges();
        }
    }
}