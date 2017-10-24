using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoCustomActionPaneAndRibbon.Models
{
    public class ProductEntity
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<short> UnitsInStock { get; set; }
        public Nullable<short> UnitsOnOrder { get; set; }
        public Nullable<short> ReorderLevel { get; set; }
        public string ProductCategory { get; set; }
    }
}
