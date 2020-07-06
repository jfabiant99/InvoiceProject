using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Infraestructure;

namespace Service
{
    public class UserTypeService
    {
        public List<UserType> Get()
        {
            List<UserType> userTypes = null;
            using (var context = new InvoiceContext())
            {

                userTypes = context.UserTypes.ToList();

            }
            return userTypes;
        }

        public UserType GetById(int id)
        {
            UserType userType = null;
            using (var context = new InvoiceContext())
            {
                userType = context.UserTypes.Find(id);

            }
            return userType;
        }

        public void Insert(UserType userType)
        {
            using (var context = new InvoiceContext())
            {
                context.UserTypes.Add(userType);
                context.SaveChanges();
            }
        }

        public void Update (UserType userType, int id)
        {
            using (var context = new InvoiceContext())
            {
                var userTypeNew = context.UserTypes.Find(id);
                userTypeNew.UserTypeName = userType.UserTypeName == null ? userTypeNew.UserTypeName : userType.UserTypeName;
                context.SaveChanges();
            }
        }

        public void Delete (int id)
        {
            using (var context = new InvoiceContext())
            {
                var userType = context.UserTypes.Find(id);
                context.UserTypes.Remove(userType);
                context.SaveChanges();

            }
        }

    }
}
