using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InvoiceAPI.Models.Response
{
    public class Detail_Response_v1
    {
        public int DetailID { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public Product Product { get; set; }
        public Invoice Invoice { get; set; }

    }
}