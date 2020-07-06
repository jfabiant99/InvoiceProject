using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InvoiceAPI.Models.Request
{
    public class Product_Request_v1
    {
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }

    }
}