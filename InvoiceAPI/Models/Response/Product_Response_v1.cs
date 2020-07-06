using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InvoiceAPI.Models.Response
{
    public class Product_Response_v1
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    }
}