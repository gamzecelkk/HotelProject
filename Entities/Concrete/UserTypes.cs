using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class UserTypes
    {
        public int UserTypeID { get; set; }
        public string UserTypeName { get; set; }
        public bool UserTypeIsActive { get; set; }
        public string UserTypeDescription { get; set; }
    }
}
