using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ReservationTypes
    {

        public int ReservationTypeID { get; set; }
        public string ReservationTypeName { get; set; }
        public bool ReservationTypeIsActive { get; set; }
        public string ReservationTypeDescription { get; set; }

    }
}
