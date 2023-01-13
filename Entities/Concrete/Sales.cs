using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Sales
    {

        public int SaleID { get; set; }
        public decimal SaleDiscount { get; set; }
        public int RoomID { get; set; }
        public int CardID { get; set; }
        public int ReservationID { get; set; }
        public int EmployerID { get; set; }
        public DateTime SaleRoomEntryDate { get; set; }
        public DateTime SaleRoomExitDate { get; set; }
        public decimal SalePrice { get; set; }
        public decimal SaleVAT { get; set; }
        public int PaymentID { get; set; }
        public int ExtraID { get; set; }
        public bool SaleIsActive { get; set; }
        public string SaleDescription { get; set; }
    }
}
