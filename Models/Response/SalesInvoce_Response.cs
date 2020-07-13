using System;
using System.Collections.Generic;

namespace Models.Response
{
    public class SalesInvoce_Response
    {
        public int InvoiceID { get; set; }
        public string InvoiceNumber { get; set; }
        public bool Payed { get; set; }
        public DateTime Date { get; set; }

      //  public int CustomerID { get; set; }
     //   public int SellerID { get; set; }

      //  public virtual Customer_Response Customer { get; set; }
     //   public virtual Seller_Response Seller { get; set; }
        public virtual ICollection<SalesInvoceDetail_Response> SalesInvoceDetails { get; set; }
    }
}
