using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Streets
    {
        public int StreetID { get; set; }
        public string StreetName { get; set; }
        public int CountryID { get; set; }
        public int CityID { get; set; }
        public bool StreetIsActive { get; set; }
        public string StreetDescription { get; set; }

    }
}
