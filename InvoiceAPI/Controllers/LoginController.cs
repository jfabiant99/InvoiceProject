using AutoMapper;
using Common.HttpHelpers;
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
using System.Web.Http.Results;

namespace InvoiceAPI.Controllers
{
    public class LoginController : ApiController
    {
        private LoginService service = new LoginService();

        // POST: api/Login
        [HttpPost]
        public JsonResult<EResponseBase<User>> Post(User user)
        {
            return Json(service.GetUser(user));
        }
    }
}
