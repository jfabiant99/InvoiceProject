using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InvoiceAPI.Models.Request
{
    public class Invoice_Request_v1
    {
        public DateTime Date { get; set; }
        public string InvoiceNumber { get; set; }

    }
}