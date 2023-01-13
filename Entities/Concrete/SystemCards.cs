using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SystemCards
    {
        public int SystemCardID { get; set; }
        public string SystemCardAccessCode { get; set; }
        public int EmployerID { get; set; }
        public bool SystemCardIsActive { get; set; }
        public string SystemCardDescription { get; set; }
    }
}
