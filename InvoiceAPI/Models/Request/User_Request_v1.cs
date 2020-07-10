using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InvoiceAPI.Models.Request
{
    public class User_Request_v1
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int UserTypeID { get; set; }

    }
}