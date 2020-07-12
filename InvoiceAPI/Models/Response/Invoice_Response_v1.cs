using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InvoiceAPI.Models.Response
{
    public class Invoice_Response_v1
    {
        public DateTime Date { get; set; }
        public string InvoiceNumber { get; set; }
        public List<Detail> Details { get; set; }
        public int InvoiceID { get; internal set; }
    }
}