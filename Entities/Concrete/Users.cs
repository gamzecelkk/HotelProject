using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Users
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserEmail { get; set; }
        public bool UserEmailOK { get; set; }
        public string UserPhoneNumber { get; set; }
        public DateTime UserEnrollDate { get; set; }
        public DateTime UserLastLoginDate { get; set; }
        public int ImageID { get; set; }
        public int UserTypeID { get; set; }
        public bool UserIsActive { get; set; }
        public string UserDescription { get; set; }
    }
}
