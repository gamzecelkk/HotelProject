using Entities.Concrete;
using Entities.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    

    public class EmployerDal
    {
        #region ReadEmployers
        private EmployerView ReadMe(SqlDataReader employersReader)
        {
            EmployerView myEmployer = new EmployerView();

            while (employersReader.Read())
            {
                myEmployer.ID = Convert.ToInt32(employersReader[0]);
                myEmployer.IdentityNumber = employersReader[1].ToString();
                myEmployer.FirstName = employersReader[2].ToString();
                myEmployer.LastName = employersReader[3].ToString();
                myEmployer.PhoneNumber = employersReader[4].ToString();
                myEmployer.Email = employersReader[5].ToString();
                myEmployer.Addres = employersReader[6].ToString();
                myEmployer.BirthDate = Convert.ToDateTime(employersReader[7]);
                myEmployer.Country = Convert.ToInt32(employersReader[8]);
                myEmployer.City = Convert.ToInt32(employersReader[9]);
                myEmployer.Street = Convert.ToInt32(employersReader[10]);
                myEmployer.Roles = Convert.ToInt32(employersReader[11]);
                myEmployer.Manager = Convert.ToInt32(employersReader[12]);
                myEmployer.Gender = Convert.ToInt32(employersReader[13]);
                myEmployer.HourlySalary = Convert.ToDecimal(employersReader[14]);
                myEmployer.Salary = Convert.ToDecimal(employersReader[15]);
                myEmployer.RegistryNumber = employersReader[16].ToString();
                myEmployer.Disability = Convert.ToBoolean(employersReader[17]);
                myEmployer.ContactName = employersReader[18].ToString();
                myEmployer.ContactPhone = employersReader[19].ToString();
                myEmployer.StartDate = Convert.ToDateTime(employersReader[20]);
                myEmployer.QuitDate = Convert.ToDateTime(employersReader[21]);
                myEmployer.Activity = Convert.ToBoolean(employersReader[22]);
                myEmployer.Descriptions = employersReader[23].ToString();
                myEmployer.Languages = Convert.ToInt32(employersReader[24]);

            }
            return myEmployer;
        }
        #endregion

        #region GetWithIdentity
        public EmployerView GetEmployersWithIdentity(string employerIdentity)
        {
            SqlParameter[] employerParameters =
            {
                new SqlParameter
                {
                    ParameterName = "EmployerIdentityNumber",
                    Value = employerIdentity
                } 
            };

            SqlDataReader employersReader = HotelHelperSQL.MyExecuteReader("sp_SearchEmployerWithIdentity", "sp", employerParameters);

            EmployerView employerWithIdentity = ReadMe(employersReader);
            return employerWithIdentity;
        }
        #endregion

        #region GetWithFirstName

        public EmployerView GetEmployersWithFirstName(string FirstName)
        {
            SqlParameter[] EmployerParameters =
            {
                new SqlParameter
                {
                    ParameterName = "Fname",
                    Value = FirstName
                }
            };

            SqlDataReader EmployersReader = HotelHelperSQL.MyExecuteReader("sp_SearchEmployerWithFirstName", "sp", EmployerParameters);
            EmployerView MyEmployer = ReadMe(EmployersReader);
            return MyEmployer;
        }

        #endregion

        #region GetWithLastName

        public EmployerView GetEmployersWithLastName(string lastName)
        {
            SqlParameter[] employerParameters =
            {
                new SqlParameter
                {
                    ParameterName = "@LName",
                    Value = lastName
                }
            };

            SqlDataReader EmployersReader = HotelHelperSQL.MyExecuteReader("sp_SearchEmployerWithLastName", "sp", employerParameters);

            EmployerView employerWithLastName = ReadMe(EmployersReader);
            return employerWithLastName;

        }

        #endregion

        #region Insert

        public int InsertEmployer(Employers employers)
        {
            SqlParameter[] EmployerParameters =
            {
                new SqlParameter
                {
                    ParameterName = "EmployerIdentityNumber",
                    Value = employers.EmployerIdentityNumber
                },
                new SqlParameter
                {
                    ParameterName = "EmployerFirstName",
                    Value = employers.EmployerFirstName
                },
                new SqlParameter
                {
                    ParameterName="EmployerLastName",
                    Value = employers.EmployerLastName
                },
                new SqlParameter
                {
                    ParameterName= "EmployerBirthDate",
                    Value = employers.EmployerBirthDate
                },
                new SqlParameter
                {
                    ParameterName="EmployerPhoneNumber",
                    Value= employers.EmployerPhoneNumber
                },
                new SqlParameter
                {
                    ParameterName="EmployerEmail",
                    Value = employers.EmployerEmail
                },
                new SqlParameter
                {
                    ParameterName = "EmployerAddress",
                    Value = employers.EmployerAddress
                },
                new SqlParameter
                {
                    ParameterName = "CountryID",
                    Value = employers.CountryID
                },
                new SqlParameter
                {
                    ParameterName="CityID",
                    Value = employers.CityID
                },
                new SqlParameter
                {
                    ParameterName = "StreetID",
                    Value = employers.StreetID
                },
                new SqlParameter
                {
                    ParameterName = "RoleID",
                    Value = employers.RoleID
                },
                new SqlParameter
                {
                    ParameterName = "GenderID",
                    Value = employers.GenderID
                },
                new SqlParameter
                {
                    ParameterName = "ManagerID",
                    Value = employers.ManagerID
                },
                new SqlParameter
                {
                    ParameterName = "EmployerHourlySalary",
                    Value = employers.EmployerHourlySalary
                },
                new SqlParameter
                {
                    ParameterName = "EmployerSalary",
                    Value = employers.EmployerSalary
                },
                new SqlParameter
                {
                    ParameterName = "EmployerRegistryNumber",
                    Value = employers.EmployerRegistryNumber
                },
                new SqlParameter
                {
                    ParameterName = "EmployerStartDate",
                    Value = employers.EmployerStartDate
                },
                new SqlParameter
                {
                    ParameterName = "EmployerQuitDate",
                    Value = employers.EmployerQuitDate
                },
                new SqlParameter
                {
                    ParameterName = "EmployerIsActive",
                    Value = employers.EmployerIsActive
                },
                new SqlParameter
                {
                    ParameterName = "EmployerDisability",
                    Value = employers.EmployerDisability
                },
                new SqlParameter
                {
                    ParameterName = "EmployerDescription",
                    Value = employers.EmployerDescription
                },
                new SqlParameter
                {
                    ParameterName = "EmergencyContactName",
                    Value = employers.EmergencyContactName
                },
                new SqlParameter
                {
                    ParameterName = "EmergencyContactPhone",
                    Value = employers.EmergencyContactPhone
                }


                };

            int MyEmployer = HotelHelperSQL.MyExecuteNonQuery("sp_AddEmployer", "sp", EmployerParameters);
            return MyEmployer;
        }

        #endregion

        #region Update

        public int UpdateEmployer(Employers employers)
        {
            SqlParameter[] EmployerParameters =
            {
                new SqlParameter
                {
                    ParameterName = "EmployerID",
                    Value = employers.EmployerID
                },
                new SqlParameter
                {
                    ParameterName = "EmployerIdentityNumber",
                    Value = employers.EmployerIdentityNumber
                },
                new SqlParameter
                {
                    ParameterName = "EmployerFirstName",
                    Value = employers.EmployerFirstName
                },
                new SqlParameter
                {
                    ParameterName="EmployerLastName",
                    Value = employers.EmployerLastName
                },
                new SqlParameter
                {
                    ParameterName= "EmployerBirthDate",
                    Value = employers.EmployerBirthDate
                },
                new SqlParameter
                {
                    ParameterName="EmployerPhoneNumber",
                    Value= employers.EmployerPhoneNumber
                },
                new SqlParameter
                {
                    ParameterName="EmployerEmail",
                    Value = employers.EmployerEmail
                },
                new SqlParameter
                {
                    ParameterName = "EmployerAddress",
                    Value = employers.EmployerAddress
                },
                new SqlParameter
                {
                    ParameterName = "CountryID",
                    Value = employers.CountryID
                },
                new SqlParameter
                {
                    ParameterName="CityID",
                    Value = employers.CityID
                },
                new SqlParameter
                {
                    ParameterName = "StreetID",
                    Value = employers.StreetID
                },
                new SqlParameter
                {
                    ParameterName = "RoleID",
                    Value = employers.RoleID
                },
                new SqlParameter
                {
                    ParameterName = "GenderID",
                    Value = employers.GenderID
                },
                new SqlParameter
                {
                    ParameterName = "ManagerID",
                    Value = employers.ManagerID
                },
                new SqlParameter
                {
                    ParameterName = "EmployerHourlySalary",
                    Value = employers.EmployerHourlySalary
                },
                new SqlParameter
                {
                    ParameterName = "EmployerSalary",
                    Value = employers.EmployerSalary
                },
                new SqlParameter
                {
                    ParameterName = "EmployerRegistryNumber",
                    Value = employers.EmployerRegistryNumber
                },
                new SqlParameter
                {
                    ParameterName = "EmployerStartDate",
                    Value = employers.EmployerStartDate
                },
                new SqlParameter
                {
                    ParameterName = "EmployerQuitDate",
                    Value = employers.EmployerQuitDate
                },
                new SqlParameter
                {
                    ParameterName = "EmployerIsActive",
                    Value = employers.EmployerIsActive
                },
                new SqlParameter
                {
                    ParameterName = "EmployerDisability",
                    Value = employers.EmployerDisability
                },
                new SqlParameter
                {
                    ParameterName = "EmployerDescription",
                    Value = employers.EmployerDescription
                },
                new SqlParameter
                {
                    ParameterName = "EmergencyContactName",
                    Value = employers.EmergencyContactName
                },
                new SqlParameter
                {
                    ParameterName = "EmergencyContactPhone",
                    Value = employers.EmergencyContactPhone
                }
            };

            int MyEmployer = HotelHelperSQL.MyExecuteNonQuery("sp_UpdateEmployer", "sp", EmployerParameters);
            return MyEmployer;
        }

        #endregion

        #region Delete

        public int DeleteEmployer(Employers employers)
        {
            SqlParameter[] EmployerParameters =
            {
                new SqlParameter
                {
                    ParameterName = "EmployerIdentityNumber",
                    Value = employers.EmployerIdentityNumber
                }
            };

            int MyEmployer = HotelHelperSQL.MyExecuteNonQuery("sp_DeleteEmployerWithIdentity", "sp", EmployerParameters);
            return MyEmployer;
        }

        #endregion

        #region Get All Employers

        public EmployerView GetAllEmployers()
        {
            SqlDataReader employersReader = HotelHelperSQL.MyExecuteReader("select * from vw_Employers", "text", null);
            EmployerView allEmployers = ReadMe(employersReader);
            return allEmployers;
        }

        #endregion
    }
}
