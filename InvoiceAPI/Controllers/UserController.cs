using Service;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using InvoiceAPI.Models.Response;
using InvoiceAPI.Models.Request;

namespace InvoiceAPI.Controllers
{
    public class UserController : ApiController
    {
        private UserService service = new UserService();

        public List<User_Response_v1> Get()
        {
            var response = (from c in service.Get()
                            select
                            new User_Response_v1
                            {
                                UserID = c.UserID,
                                Username = c.Username,
                                Password = c.Password,
                                UserTypeID = c.UserTypeID
                            }).ToList();
            return response;
        }
        public User_Response_v1 Get(int id)
        {
            User user = service.GetById(id);

            User_Response_v1 response = new User_Response_v1();
            response.UserID = user.UserID;
            response.Username = user.Username;
            response.Password = user.Password;
            response.UserTypeID = user.UserTypeID;
            
            return response;

        }
        public void Post([FromBody] User_Request_v1 request)
        {

            User user = new User();
            user.Username = request.Username;
            user.Password = request.Password;
            user.UserTypeID = request.UserTypeID;
            service.Insert(user);
        }

        [HttpPost]
        public void Update([FromBody] User request)
        {
            service.Update(request, request.UserID);
        }
        [HttpPost]
        public void Delete([FromBody] User request)
        {
            service.Delete(request.UserID);
        }


    }
}
