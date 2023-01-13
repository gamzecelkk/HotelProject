using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Authorities
    {
        public int AuthorityID { get; set; }
        public string AuthorityName { get; set; }
        public string AuthorityAccessCode { get; set; }
        public bool AuthorityIsActive { get; set; }
        public string AuthorityDescription { get; set; }
    }
}
