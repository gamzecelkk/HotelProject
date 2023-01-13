using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Countries
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public string CountryPhoneCode { get; set; }
        public string CountryCode { get; set; }
        public bool CountryIsActive { get; set; }
        public string CountryDescription { get; set; }
    }
}
