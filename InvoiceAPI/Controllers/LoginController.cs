using Common.HttpHelpers;
using Domain;
using Service;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;

namespace InvoiceAPI.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
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
