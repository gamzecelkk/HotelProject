using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Reservations
    {

        public int ReservationID { get; set; }
        public DateTime ReservationTransactionDate { get; set; }
        public DateTime ReservationStartDate { get; set; }
        public DateTime ReservationEndDate { get; set; }
        public int CustomerID { get; set; }
        public int ReservationTypeID { get; set; }
        public int PackageID { get; set; }
        public int CampaignID { get; set; }
        public int RoomID { get; set; }
        public decimal ReservationAdvancePayment { get; set; }
        public decimal ReservationDiscount { get; set; }
        public bool ReservationIsActive { get; set; }
        public string ReservationDescription { get; set; }

    }
}
