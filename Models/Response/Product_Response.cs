using System;
using System.Collections.Generic;


namespace Models.Response
{
    public class Product_Response
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public Decimal Price { get; set; }
        public DateTime CreateAt { get; set; }
        public bool Enable { get; set; }
        public virtual ICollection<SalesInvoceDetail_Response> SalesInvoceDetails { get; set; }
    }
}
