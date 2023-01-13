using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customers
    {
        public int CustomerID { get; set; }
        public string CustomerIdentityNumber { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public DateTime CustomerBirthDate { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerAddress { get; set; }
        public bool CustomerIsCompany { get; set; }
        public string CustomerCompanyName { get; set; }
        public string CompanyTaxNumber { get; set; }
        public int CountryID { get; set; }
        public int CityID { get; set; }
        public int StreetID { get; set; }
        public int LanguageID { get; set; }
        public int GenderID { get; set; }
        public bool CustomerIsActive { get; set; }
        public string CustomerDescription { get; set; }
    }
}
