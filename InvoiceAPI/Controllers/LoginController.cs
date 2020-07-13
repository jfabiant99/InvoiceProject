using AutoMapper;
using Domain;
using InvoiceAPI.Models.Request;
using InvoiceAPI.Models.Response;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InvoiceAPI.Controllers
{
    public class LoginController : ApiController
    {
        private LoginService service = new LoginService();

        [HttpPost]
        public void Post([FromBody] User_Request_v1 request)
        {
            User user = new User();
            user.Username = request.Username;
            user.Password = request.Password;
            service.GetByUser(user);
        }
    }
}
