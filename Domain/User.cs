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
        [Key]
        public int UserID { get; set; }

        [StringLength(150)]
        public string Username { get; set; }

<<<<<<< HEAD
        [StringLength(150, MinimumLength = 3)]
        public string Lastname { get; set; }

        [StringLength(150, MinimumLength = 3)]
=======
        [StringLength(150)]
>>>>>>> ab1686d7b46f507825b18f0ffedf35a744757d98
        public string Password { get; set; }

        //Conventions
        public int UserTypeID { get; set; }
        public UserType UserType { get; set; }
    }
}
