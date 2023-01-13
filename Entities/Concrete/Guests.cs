using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Guests
    {

        public int GuestID { get; set; }
        public string GuestIdentityNumber { get; set; }
        public string GuestFirstName { get; set; }
        public string GuestLastName { get; set; }
        public DateTime GuestBirthDate { get; set; }
        public string GuestPhoneNumber { get; set; }
        public string GuestEmail { get; set; }
        public string GuestAddress { get; set; }
        public int CountryID { get; set; }
        public int CityID { get; set; }
        public int StreetID { get; set; }
        public int LanguageID { get; set; }
        public int GenderID { get; set; }
        public bool GuestIsActive { get; set; }
        public string GuestDescription { get; set; }
    }
}
