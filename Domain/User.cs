using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User
    {
        public int UserID { get; set; }

        [StringLength(150, MinimumLength = 3)]
        public string Username { get; set; }

        [StringLength(150, MinimumLength = 3)]
        public string Password { get; set; }

        //Conventions
        public int UserTypeID { get; set; }
        public UserType UserType { get; set; }
    }
}
