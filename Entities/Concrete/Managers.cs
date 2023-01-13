using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Managers
    {
        public int ManagerID { get; set; }
        public string ManagerIdentityNumber { get; set; }
        public string ManagerFirstName{ get; set; }
        public string ManagerLastName { get; set; }
        public string ManagerPhoneNumber { get; set; }
        public string ManagerEmail { get; set; }
        public string ManagerAddress { get; set; }
        public DateTime  ManagerBirthDate { get; set; }
        public int CountryID { get; set; }
        public int CityID { get; set; }
        public int StreetID { get; set; }
        public int RoleID { get; set; }
        public int GenderID { get; set; }
        public int LanguageID { get; set; }
        public decimal  ManagerSalary { get; set; }
        public DateTime  ManagerStartDate { get; set; }
        public DateTime ManagerQuitDate { get; set; }
        public bool ManagerIsActive { get; set; }
        public string ManagerDescription { get; set; }
    }
}
