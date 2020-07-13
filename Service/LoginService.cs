using Common.HttpHelpers;
using Domain;
using Infraestructure;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class LoginService : IServiceBase<User>
    {
              
        public EResponseBase<User> GetUser(User model)
        {
            EResponseBase<User> response = new EResponseBase<User>();
            try
            {
                using (var context = new InvoiceContext())
                {
                    response.Object = context.Users.Where(x => x.Username == model.Username && x.Password == model.Password).FirstOrDefault();
                }
                response.IsSuccess = true;
                response.Message = "Success";
                return response;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.IsSuccess = false;
                return response;
            }
        }
    }
}
