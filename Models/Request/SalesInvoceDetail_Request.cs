
namespace Models.Request
{
    public class SalesInvoceDetail_Request
    {
        public int DetailID { get; set; }
        public decimal Prize { get; set; }
        public float Quantity { get; set; }
        public int InvoiceID { get; set; }
        public int ProductID { get; set; }
        public int Client_UserID { get; set; }
    }
}
