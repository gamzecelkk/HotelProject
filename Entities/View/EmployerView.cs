using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.View
{
    public class EmployerView
    {
        public int ID { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Addres { get; set; }
        public DateTime BirthDate { get; set; }
        public int Country { get; set; }
        public int City { get; set; }
        public int Street { get; set; }
        public int Roles { get; set; }
        public int Manager { get; set; }
        public int Gender { get; set; }
        public decimal HourlySalary { get; set; }
        public decimal Salary { get; set; }
        public string RegistryNumber { get; set; }
        public bool Disability { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime QuitDate { get; set; }
        public bool Activity { get; set; }
        public string Descriptions { get; set; }
        public int Languages { get; set; }
    }
}
