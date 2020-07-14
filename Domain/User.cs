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

        [StringLength(150)]
        public string Lastname { get; set; }

        [StringLength(150)]
        public string Password { get; set; }

        public int UserTypeID { get; set; }
        public UserType UserType { get; set; }
    }
}
