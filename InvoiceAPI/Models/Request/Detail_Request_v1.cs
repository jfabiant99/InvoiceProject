using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InvoiceAPI.Models.Request
{
    public class Detail_Request_v1
    {
        public int Quantity { get; set; }
        public int Prize { get; set; }

    }
}