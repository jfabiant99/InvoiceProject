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
                var usuario = new Object();
                using (var context = new InvoiceContext())
                {
                    usuario = context.Users
                        .Where(x => x.Username == model.Username && x.Password == model.Password)
                        .FirstOrDefault();
                    response.Object = context.Users
                        .Where(x => x.Username == model.Username && x.Password == model.Password)
                        .FirstOrDefault();
                    
                }
                if (usuario == null)
                {
                    response.IsSuccess = false;
                    response.Message = "Sus credenciales no existen";
                }
                else
                {
                    response.IsSuccess = true;
                    response.Message = "Bienvenido a la app";
                }
              
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
