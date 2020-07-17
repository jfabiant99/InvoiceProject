using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Detail
    {
        [Key]
        public int DetailID { get; set; }
        public int Quantity { get; set; } 
        public int Price { get; set; }
        public User Customer { get; set; } //cliente
        public User Seller { get; set; } //vendedor
        public int InvoiceID { get; set; }
        public int ProductID { get; set; }

        /// <summary>
        /// foreinkey
        /// </summary>
        public Invoice Invoice { get; set; } //no 
        public Product Product { get; set; } //no
      
    }
}
