using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructure;
using Domain;
using System.Security.Cryptography;

namespace Service
{
    public class UserService
    {

        public List<User> Get ()
        {
            List<User> users = null;
            using (var context = new InvoiceContext())
            {
                users = context.Users.ToList();
            }
            return users;
        }

        public User GetById(int id)
        {
            User user = null;
            using (var context= new InvoiceContext())
            {
                user = context.Users.Find(id);
            }
            return user;
        }

        public void Insert (User user)
        {
            using (var context = new InvoiceContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public void Update(User user, int id)
        {
            using (var context = new InvoiceContext())
            {
                var userNew = context.Users.Find(id);
                userNew.Username = user.Username == null ? userNew.Username : user.Username;
                userNew.Password = user.Password == null ? userNew.Password : user.Password;
                userNew.UserTypeID = user.UserTypeID == 0 ? userNew.UserTypeID : user.UserTypeID;

                context.SaveChanges();

            }
        }

    }
}
