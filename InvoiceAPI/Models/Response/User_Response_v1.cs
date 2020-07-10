using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InvoiceAPI.Models.Response
{
    public class User_Response_v1
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int UserTypeID { get; set; }
    }
}