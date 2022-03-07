using System;
using System.Collections.Generic;

namespace Entity.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ChildCategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
    }
        
}