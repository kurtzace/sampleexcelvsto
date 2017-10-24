// Author: Gokuldas Chandgadkar
// Last Update: 15/12/2013
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoCustomActionPaneAndRibbon.Models
{
    
    /// <summary>
    /// Facade Class which provides common interface between GUI & Business/Data Layer.
    /// </summary>
    class BONorthwindFacade
    {
        private NORTHWNDEntities _context = new NORTHWNDEntities();
        private string _connectionString = string.Empty;

        public BONorthwindFacade() {
           
        }

        public NORTHWNDEntities DBContext
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Method:GetCustomers
        /// Purpose:Returns collection of Customers from NorthWind database
        /// </summary>
        /// <returns></returns>
        public List<Customer> GetCustomers() {

            var customers = from c in _context.Customers
                            select c;
            return customers.ToList<Customer>();
        }


        /// <summary>
        /// Method:GetOrders
        /// Purpose:Returns orders for the customer selected.
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        public List<Order> GetOrders(string customerID)
        { 
            var orders= from  od in _context.Orders
                        where od.CustomerID.Equals(customerID)
                        select od;
            return orders.ToList<Order>();

        }


        /// <summary>
        /// Method:GetProducts
        /// Purpose:Returns products from NorthWind database and projects as collection of Custom class ProductEntity.
        /// </summary>
        /// <returns></returns>
        public List<ProductEntity> GetProducts()
        {
            var products =from p in _context.Products
                          select new ProductEntity {
                          
                            ProductID =p.ProductID,
                            ProductName=p.ProductName,
                            ProductCategory =p.Category.CategoryName,
                            QuantityPerUnit=p.QuantityPerUnit,
                            ReorderLevel=p.ReorderLevel,
                            UnitPrice=p.UnitPrice
                            
                          };
            return products.ToList<ProductEntity>();
        }
    }
}
