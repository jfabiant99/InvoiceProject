using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructure;
using Domain;
using System.Data.Entity.Validation;



namespace Service
{
    public class LoginService
    {
        public User GetByUser(User model)
        {
            User user = null;

            try
            {
                using (var context = new InvoiceContext())
                {
                    user = context.Users.Where(x => x.Username == model.Username && x.Password == model.Password).FirstOrDefault();
                }
            }
            catch (Exception Ex)
            {
                user.Username = "";
                user.Password = "";
            }

            return user;
        }
    }
}
