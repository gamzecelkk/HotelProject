using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Entities.Concrete;
using Entities.View;

namespace DataAccess
{
    public  class ManagerDal 
    {
        #region ReadManagers
        private ManagerView ReadMe(SqlDataReader managersReader)
        {

            ManagerView myManager = new ManagerView();

            while (managersReader.Read())
            {
                myManager.ManagerID = Convert.ToInt32(managersReader[0].ToString().DefaultIfEmpty());
                myManager.IdentityNumber = (string)managersReader[1].ToString().DefaultIfEmpty();
                myManager.FirstName = (string)managersReader[2].ToString().DefaultIfEmpty();
                myManager.LastName = (string)managersReader[3].ToString().DefaultIfEmpty();
                myManager.PhoneNumber = (string)managersReader[4].ToString().DefaultIfEmpty();
                myManager.Email = (string)managersReader[5].ToString().DefaultIfEmpty();
                myManager.Addres = (string)managersReader[6].ToString().DefaultIfEmpty();
                myManager.BirthDate = Convert.ToDateTime(managersReader[7]);
                myManager.Country = Convert.ToInt32(managersReader[8].ToString().DefaultIfEmpty());
                myManager.City = Convert.ToInt32(managersReader[9].ToString().DefaultIfEmpty());
                myManager.Street = Convert.ToInt32(managersReader[10].ToString().DefaultIfEmpty());
                myManager.Role = Convert.ToInt32(managersReader[11].ToString().DefaultIfEmpty());
                myManager.Gender = Convert.ToInt32(managersReader[12].ToString().DefaultIfEmpty());
                myManager.Salary = Convert.ToDecimal(managersReader[13].ToString().DefaultIfEmpty());
                myManager.StartDate = Convert.ToDateTime(managersReader[14]);
                myManager.QuitDate = Convert.ToDateTime(managersReader[15]);
                myManager.Activity = Convert.ToBoolean(managersReader[16].ToString().DefaultIfEmpty());
                myManager.Descriptions = (string)managersReader[17].ToString().DefaultIfEmpty();
                myManager.Languages = Convert.ToInt32(managersReader[18].ToString().DefaultIfEmpty());
            }
            return myManager;
        }

        #endregion

        #region GetWithIdentity
        public ManagerView GetManagersWithIdentity(string managerIdentity)
        {
            SqlParameter[] managerParameters =
            {
                new SqlParameter
                {
                    ParameterName = "ManagerIdentityNumber",
                    Value = managerIdentity
                } 
            };

           SqlDataReader managersReader = HotelHelperSQL.MyExecuteReader("sp_SearchManagerWithIdentity", "sp", managerParameters);
            ManagerView managersWithIdentity = ReadMe(managersReader);
            
            return managersWithIdentity;
        }
        #endregion

        #region GetWithFirstName
        public ManagerView GetManagersWithFirstName(string firstName)
        {
            SqlParameter[] managerParameters =
            {
                    new SqlParameter
                    {
                        ParameterName = "FName",
                        Value = firstName
                    }
            };
            SqlDataReader managersReader = HotelHelperSQL.MyExecuteReader("sp_SearchManagerWithFirstName", "sp", managerParameters);
            ManagerView managerWithFirstName = ReadMe(managersReader);
            return managerWithFirstName;
        }
        #endregion

        #region GetWithLastName
        public ManagerView GetManagerWithLastName(string lastName)
        {
            SqlParameter[] managerParameters =
            {
                new SqlParameter
                {
                    ParameterName="LName",
                    Value = lastName
                }
            };

            SqlDataReader managersReader = HotelHelperSQL.MyExecuteReader("sp_SearchManagerWithLastName", "sp", managerParameters);
            ManagerView managerWithLastName = ReadMe(managersReader);
            return managerWithLastName;
        }
        #endregion

        #region Get All Managers
        public ManagerView GetAllManagers()
        {
            SqlDataReader managersReader = HotelHelperSQL.MyExecuteReader("select * from vw_Managers", "text", null);
            ManagerView allManagers = ReadMe(managersReader);
            return allManagers;
        }


        #endregion

        #region Insert
        public  int InsertManagers(Managers managers)
        {
            SqlParameter[] ManagerParameters =
            {
     
                new SqlParameter
                {
                    ParameterName = "ManagerIdentityNumber",
                    Value = managers.ManagerIdentityNumber
                },
                new SqlParameter
                {
                    ParameterName = "ManagerFirstName",
                    Value = managers.ManagerFirstName
                },
                new SqlParameter
                {
                    ParameterName = "ManagerLastName",
                    Value = managers.ManagerLastName
                },
                new SqlParameter
                {
                    ParameterName = "ManagerPhoneNumber",
                    Value =managers.ManagerPhoneNumber
                },
                new SqlParameter
                {
                    ParameterName = "ManagerEmail",
                    Value = managers.ManagerEmail
                },
                new SqlParameter
                {
                    ParameterName = "ManagerAddress",
                    Value = managers.ManagerAddress
                },
                new SqlParameter
                {
                    ParameterName = "ManagerBirthDate",
                    Value = managers.ManagerBirthDate
                },
                new SqlParameter
                {
                    ParameterName = "CountryID",
                    Value =managers.CountryID
                },
                new SqlParameter
                {
                    ParameterName = "CityID",
                    Value = managers.CityID
                },
                new SqlParameter
                {
                    ParameterName = "StreetID",
                    Value = managers.StreetID
                },
                new SqlParameter
                {
                    ParameterName = "RoleID",
                    Value = managers.RoleID
                },

                new SqlParameter
                {
                    ParameterName = "GenderID",
                    Value =managers.GenderID
                },
                new SqlParameter
                {
                    ParameterName = "ManagerSalary",
                    Value = managers.ManagerSalary
                },
                new SqlParameter
                {
                    ParameterName = "ManagerStartDate",
                    Value = managers.ManagerStartDate
                },
                new SqlParameter
                {
                    ParameterName = "ManagerQuitDate",
                    Value =managers.ManagerQuitDate
                },
                new SqlParameter
                {
                    ParameterName = "ManagerIsActive",
                    Value = managers.ManagerIsActive
                },
                new SqlParameter
                {
                    ParameterName = "ManagerDescription",
                    Value = managers.ManagerDescription
                },
                new SqlParameter
                {
                    ParameterName="LanguageID",
                    Value=managers.LanguageID
                }

                
            };

            int AddedMyManager = HotelHelperSQL.MyExecuteNonQuery("sp_AddManager","sp",ManagerParameters);
            return AddedMyManager;


        }

        #endregion

        #region Update
        public  int UpdateManagers(Managers managers)
        {
            SqlParameter[] ManagerParameters =
            {
                new SqlParameter
                {
                    ParameterName = "ManagerID",
                    Value =managers.ManagerID
                },
                new SqlParameter
                {
                    ParameterName = "ManagerIdentityNumber",
                    Value = managers.ManagerIdentityNumber
                },
                new SqlParameter
                {
                    ParameterName = "ManagerFirstName",
                    Value = managers.ManagerFirstName
                },
                new SqlParameter
                {
                    ParameterName = "ManagerLastName",
                    Value = managers.ManagerLastName
                },
                new SqlParameter
                {
                    ParameterName = "ManagerPhoneNumber",
                    Value =managers.ManagerPhoneNumber
                },
                new SqlParameter
                {
                    ParameterName = "ManagerEmail",
                    Value = managers.ManagerEmail
                },
                new SqlParameter
                {
                    ParameterName = "ManagerAddress",
                    Value = managers.ManagerAddress
                },
                new SqlParameter
                {
                    ParameterName = "ManagerBirthDate",
                    Value = managers.ManagerBirthDate
                },
                new SqlParameter
                {
                    ParameterName = "CountryID",
                    Value =managers.CountryID
                },
                new SqlParameter
                {
                    ParameterName = "CityID",
                    Value = managers.CityID
                },
                new SqlParameter
                {
                    ParameterName = "StreetID",
                    Value = managers.StreetID
                },
                new SqlParameter
                {
                    ParameterName = "RoleID",
                    Value = managers.RoleID
                },

                new SqlParameter
                {
                    ParameterName = "GenderID",
                    Value =managers.GenderID
                },
               
                new SqlParameter
                {
                    ParameterName = "ManagerSalary",
                    Value = managers.ManagerSalary
                },
                new SqlParameter
                {
                    ParameterName = "ManagerStartDate",
                    Value = managers.ManagerStartDate
                },
                new SqlParameter
                {
                    ParameterName = "ManagerQuitDate",
                    Value =managers.ManagerQuitDate
                },
                new SqlParameter
                {
                    ParameterName = "ManagerIsActive",
                    Value = managers.ManagerIsActive
                },
                new SqlParameter
                {
                    ParameterName = "ManagerDescription",
                    Value = managers.ManagerDescription
                }
            };

            int UpdatedMyManager = HotelHelperSQL.MyExecuteNonQuery("sp_UpdateManager", "sp", ManagerParameters);
            return UpdatedMyManager;
        }
        #endregion

        #region Delete
        public int DeleteManager(Managers managers)
        {
            SqlParameter[] ManagerParameters =
            {
                new SqlParameter
                {
                    ParameterName = "ManagerIdentityNumber",
                    Value =managers.ManagerIdentityNumber
                }
            };

            int DeletedMyManager = HotelHelperSQL.MyExecuteNonQuery("sp_DeleteManagerWithIdentity", "sp", ManagerParameters);
            return DeletedMyManager;
        }
        
       

        #endregion
        
    }

}
