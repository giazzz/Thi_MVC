using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Thi.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public int QuantityPerUnit { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public int UnitInOrder { get; set; }
        public int ReorderLevel { get; set; }
        public int Discontinued { get; set; }
        public virtual Category Categoty { get; set; }
    }
}