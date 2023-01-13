using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Genders
    {
        public int GenderID { get; set; }
        public string GenderName { get; set; }
        public bool GenderIsActive { get; set; }
        public string GenderDescription { get; set; }
    }
}
