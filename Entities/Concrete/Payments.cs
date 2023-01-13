using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Payments
    {

        public int PaymentID { get; set; }
        public string PaymentType { get; set; }
        public decimal PaymentDiscount { get; set; }
        public bool PaymentIsActive { get; set; }
        public string PaymentDescription { get; set; }

    }
}
