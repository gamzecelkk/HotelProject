using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Roles
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public bool RoleIsActive { get; set; }
        public string RoleDescription { get; set; }
    }
}
