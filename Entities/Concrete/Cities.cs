using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Cities
    {

        public int CityID { get; set; }
        public string CityName { get; set; }
        public int CountryID { get; set; }
        public string CityCode { get; set; }
        public bool CityIsActive { get; set; }
        public string CityDescription { get; set; }
    }
}
