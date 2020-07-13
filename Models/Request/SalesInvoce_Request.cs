using System;
using System.Collections.Generic;

namespace Models.Request
{
    public class SalesInvoce_Request
    {
        public int InvoiceID { get; set; }
        public string InvoiceNumber { get; set; }
        public bool Payed { get; set; }
     //   public int Discount { get; set; }
     //    public string Reason { get; set; }
        public int CustomerID { get; set; }
     //    public int SellerID { get; set; }
    }
}
