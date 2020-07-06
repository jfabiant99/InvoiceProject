using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Domain;
using Service;

namespace InvoiceAPI.Controllers
{
    public class UserTypeController : ApiController
    {
        private UserTypeService service = new UserTypeService();

        public List<UserType> Get()
        {
            var response = (from c in service.Get()
                            select
                            new UserType
                            {
                                UserTypeID = c.UserTypeID,
                                UserTypeName = c.UserTypeName
                            }).ToList();
            
            return response;
        }

        public UserType Get (int id)
        {
            return service.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] UserType request)
        {
            UserType userType = new UserType();
            userType.UserTypeName = request.UserTypeName;
            service.Insert(userType);
        }

        [HttpPost]
        public void Update([FromBody] UserType request)
        {
            service.Update(request, request.UserTypeID);
        }
        [HttpPost]
        public void Delete([FromBody] UserType request)
        {
            service.Delete(request.UserTypeID);
        }

    }
}
