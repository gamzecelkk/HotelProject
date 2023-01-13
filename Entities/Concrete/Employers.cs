using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Employers
    {
        public int EmployerID { get; set; }
        public string EmployerIdentityNumber { get; set; }
        public string EmployerFirstName { get; set; }
        public string EmployerLastName { get; set; }
        public DateTime EmployerBirthDate { get; set; }
        public string EmployerPhoneNumber { get; set; }
        public string EmployerEmail { get; set; }
        public string EmployerAddress { get; set; }
        public int CountryID { get; set; }
        public int CityID { get; set; }
        public int StreetID { get; set; }
        public int RoleID { get; set; }
        public int ManagerID { get; set; }
        public int GenderID { get; set; }
        public decimal EmployerHourlySalary { get; set; }
        public decimal EmployerSalary { get; set; }
        public int LanguageID { get; set; }
        public string EmployerRegistryNumber { get; set; }
        public bool EmployerDisability { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactPhone { get; set; }
        public DateTime EmployerStartDate { get; set; }
        public DateTime EmployerQuitDate { get; set; }
        public bool EmployerIsActive { get; set; }
        public string EmployerDescription { get; set; }
    }
}
