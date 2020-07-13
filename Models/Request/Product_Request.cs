using System;
using System.Collections.Generic;

namespace Models.Request
{
    public class Product_Request
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public Decimal Price { get; set; }
        public bool Enable { get; set; }
    }
}
