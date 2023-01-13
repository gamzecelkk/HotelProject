using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Policy;
using Entities.View;

namespace DataAccess
{
    public class CustomerDal
    {
        #region ReadCustomers

        private CustomerView ReadMe(SqlDataReader CustomersReader)
        {
            CustomerView MyCustomers = new CustomerView();
            while (CustomersReader.Read())
            {
                MyCustomers.ID = Convert.ToInt32(CustomersReader[0]);
                MyCustomers.IdentityNumber = CustomersReader[1].ToString();
                MyCustomers.FirstName = CustomersReader[2].ToString();
                MyCustomers.LastName = CustomersReader[3].ToString();
                MyCustomers.BirthDate = Convert.ToDateTime(CustomersReader[4]);
                MyCustomers.PhoneNumber = CustomersReader[5].ToString();
                MyCustomers.Email = CustomersReader[6].ToString();
                MyCustomers.Addres = CustomersReader[7].ToString();
                MyCustomers.IsCompany = Convert.ToBoolean(CustomersReader[8]);
                MyCustomers.Company = CustomersReader[9].ToString();
                MyCustomers.TaxNumber = CustomersReader[10].ToString();
                MyCustomers.Country = Convert.ToInt32(CustomersReader[11]);
                MyCustomers.City = Convert.ToInt32(CustomersReader[12].ToString());
                MyCustomers.Street = Convert.ToInt32(CustomersReader[13]);
                MyCustomers.Languages = Convert.ToInt32(CustomersReader[14]);
                MyCustomers.Gender = Convert.ToInt32(CustomersReader[15]);
                MyCustomers.Activity = Convert.ToBoolean(CustomersReader[16]);
                MyCustomers.Descriptions = CustomersReader[17].ToString();

            }
            return MyCustomers;
        }

        #endregion

        #region GetAllCustomer
        public CustomerView GetAllCustomers()
        {
            SqlDataReader customersReader = HotelHelperSQL.MyExecuteReader("select * from vw_Customers", "text",null);
            CustomerView allCustomers = ReadMe(customersReader);
            return allCustomers;
        }
        #endregion

        #region GetWithIdentity
        public CustomerView GetCustomerWithIdentity(string identity)
        {
            SqlParameter[] CustomerParameters =
            {
                new SqlParameter
                {
                    ParameterName = "IdentityNumber",
                    Value = identity
                }
            };

            SqlDataReader CustomersReader = HotelHelperSQL.MyExecuteReader("sp_SearchCustomerWithIdentityNumber", "sp", CustomerParameters);
            CustomerView customerIdentity = ReadMe(CustomersReader);
            return customerIdentity;
        }

        #endregion

        #region GetWithFirstName
        public CustomerView GetCustomerWithFirstName(string CustomerFirstName)
        {
            SqlParameter[] CustomerParameters =
            {
                new SqlParameter
                {
                    ParameterName = "FName",
                    Value = CustomerFirstName
                }
            };

            SqlDataReader CustomersReader = HotelHelperSQL.MyExecuteReader("sp_SearchCustomerWithFirstName", "sp", CustomerParameters);
            CustomerView customerFirstName = ReadMe(CustomersReader);
            return customerFirstName;
        }
        #endregion

        #region GetWithLastName
        public CustomerView GetCustomerWithLastName(string CustomerLastName)
        {
            SqlParameter[] CustomerParameters =
            {
                new SqlParameter
                {
                    ParameterName = "LName",
                    Value= CustomerLastName
                }
            };

            SqlDataReader CustomersReader = HotelHelperSQL.MyExecuteReader("sp_SearchCustomerWithLastName", "sp", CustomerParameters);
            CustomerView customerLastName = ReadMe(CustomersReader);
            return customerLastName;
        }
        #endregion

        #region GetIsCompany
        public CustomerView GetCustomerIsCompany()
        {
            SqlDataReader CustomersReader = HotelHelperSQL.MyExecuteReader("sp_SearchCustomerIsCompany", "sp", null);
            CustomerView customerIsCompany = ReadMe(CustomersReader);
            return customerIsCompany;
        }
        #endregion

        #region GetWithCompanyName
        public CustomerView GetCustomerWithCompanyName(string CustomerCompanyName)
        {
            SqlParameter[] CustomerParameters =
            {
                new SqlParameter
                {
                    ParameterName="CompanyName",
                    Value= CustomerCompanyName
                }
            };

            SqlDataReader CustomersReader = HotelHelperSQL.MyExecuteReader("sp_SearchCustomerWithCompanyName", "sp", CustomerParameters);
            CustomerView customerCompanyName = ReadMe(CustomersReader);
            return customerCompanyName;

        }
        #endregion

        #region Insert
        public int InsertCustomer(Customers customers)
        {
            SqlParameter[] CustomerParameters =
            {
                new SqlParameter
                {
                    ParameterName = "CustomerIdentityNumber",
                    Value = customers.CustomerIdentityNumber
                },
                new SqlParameter
                {
                    ParameterName = "CustomerFirstName",
                    Value = customers.CustomerFirstName
                },
                new SqlParameter
                {
                    ParameterName = "CustomerLastName",
                    Value = customers.CustomerLastName
                },
                new SqlParameter
                {
                    ParameterName = "CustomerBirthDate",
                    Value =customers.CustomerBirthDate
                },
                new SqlParameter
                {
                    ParameterName = "CustomerPhoneNumber",
                    Value = customers.CustomerPhoneNumber
                },
                new SqlParameter
                {
                    ParameterName = "CustomerEmail",
                    Value = customers.CustomerEmail
                },
                new SqlParameter
                {
                    ParameterName = "CustomerAddress",
                    Value = customers.CustomerAddress
                },
                new SqlParameter
                {
                    ParameterName = "CustomerIsCompany",
                    Value =customers.CustomerIsCompany
                },
                new SqlParameter
                {
                    ParameterName = "CompanyName",
                    Value = customers.CustomerCompanyName
                },
                new SqlParameter
                {
                    ParameterName = "CompanyTaxNumber",
                    Value = customers.CompanyTaxNumber
                },
                new SqlParameter
                {
                    ParameterName = "CountryID",
                    Value = customers.CountryID
                },

                new SqlParameter
                {
                    ParameterName = "CityID",
                    Value =customers.CityID
                },

                new SqlParameter
                {
                    ParameterName = "StreetID",
                    Value = customers.StreetID
                },
                new SqlParameter
                {
                    ParameterName = "LanguageID",
                    Value = customers.LanguageID
                },
                new SqlParameter
                {
                    ParameterName = "GenderID",
                    Value =customers.GenderID
                },
                new SqlParameter
                {
                    ParameterName = "CustomerIsActive",
                    Value = customers.CustomerIsActive
                },
                new SqlParameter
                {
                    ParameterName = "CustomerDescription",
                    Value = customers.CustomerDescription
                }
            };

            int insertCustomer = HotelHelperSQL.MyExecuteNonQuery("sp_AddCustomer", "sp", CustomerParameters);
            return insertCustomer;
        }
        #endregion

        #region Update
        public int UpdateCustomer(Customers customers)
        {
            SqlParameter[] CustomerParameters =
            {
                new SqlParameter
                {
                    ParameterName = "CustomerIdentityNumber",
                    Value = customers.CustomerIdentityNumber
                },
                new SqlParameter
                {
                    ParameterName = "CustomerFirstName",
                    Value = customers.CustomerFirstName
                },
                new SqlParameter
                {
                    ParameterName = "CustomerLastName",
                    Value = customers.CustomerLastName
                },
                new SqlParameter
                {
                    ParameterName = "CustomerBirthDate",
                    Value =customers.CustomerBirthDate
                },
                new SqlParameter
                {
                    ParameterName = "CustomerPhoneNumber",
                    Value = customers.CustomerPhoneNumber
                },
                new SqlParameter
                {
                    ParameterName = "CustomerEmail",
                    Value = customers.CustomerEmail
                },
                new SqlParameter
                {
                    ParameterName = "CustomerAddress",
                    Value = customers.CustomerAddress
                },
                new SqlParameter
                {
                    ParameterName = "CustomerIsCompany",
                    Value =customers.CustomerIsCompany
                },
                new SqlParameter
                {
                    ParameterName = "CompanyName",
                    Value = customers.CustomerCompanyName
                },
                new SqlParameter
                {
                    ParameterName = "CompanyTaxNumber",
                    Value = customers.CompanyTaxNumber
                },
                new SqlParameter
                {
                    ParameterName = "CountryID",
                    Value = customers.CountryID
                },

                new SqlParameter
                {
                    ParameterName = "CityID",
                    Value =customers.CityID
                },

                new SqlParameter
                {
                    ParameterName = "StreetID",
                    Value = customers.StreetID
                },
                new SqlParameter
                {
                    ParameterName = "LanguageID",
                    Value = customers.LanguageID
                },
                new SqlParameter
                {
                    ParameterName = "GenderID",
                    Value =customers.GenderID
                },
                new SqlParameter
                {
                    ParameterName = "CustomerIsActive",
                    Value = customers.CustomerIsActive
                },
                new SqlParameter
                {
                    ParameterName = "CustomerDescription",
                    Value = customers.CustomerDescription
                }
            };

            int updateCustomer = HotelHelperSQL.MyExecuteNonQuery("sp_UpdateCustomer", "sp", CustomerParameters);
            return updateCustomer;
        }
        #endregion

        #region Delete
        public int DeleteCustomerWithIdentityNumber(Customers customers) 
        {
            SqlParameter[] CustomerParameters =
            {
                new SqlParameter
                {
                    ParameterName="CustomerIdentityNumber",
                    Value= customers.CustomerIdentityNumber
                }
            };

            int deleteCustomer = HotelHelperSQL.MyExecuteNonQuery("sp_DeleteCustomerWithIdentity", "sp", CustomerParameters);
            return deleteCustomer;
        }
        #endregion
    }
}
