
namespace Models.Response
{ 
    public class SalesInvoceDetail_Response
    {
        public int DetailID { get; set; }
        public decimal Prize { get; set; }
        public float Quantity { get; set; }
        public int InvoiceID { get; set; }
        public int ProductID { get; set; }
        public int Client_UserID { get; set; }
        public virtual Product_Response Product { get; set; }
        public virtual SalesInvoce_Response SalesInvoce { get; set; }
    }
}
 