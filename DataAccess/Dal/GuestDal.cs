using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using System.Data.SqlClient;

namespace DataAccess
{
    public class GuestDal
    {
        #region Insert
        public int InsertGuest(Guests guests)
        {
            SqlParameter[] GuestParameters =
            {
                new SqlParameter
                {
                    ParameterName ="GuestIdentityNumber",
                    Value = guests.GuestIdentityNumber
                },

                new SqlParameter
                {
                    ParameterName = "GuestFirstName",
                    Value= guests.GuestFirstName
                },

                new SqlParameter
                {
                    ParameterName="GuestLastName",
                    Value = guests.GuestLastName
                },
                new SqlParameter
                {
                    ParameterName ="GuestBirthDate",
                    Value = guests.GuestBirthDate
                },

                new SqlParameter
                {
                    ParameterName = "GuestPhoneNumber",
                    Value= guests.GuestPhoneNumber
                },

                new SqlParameter
                {
                    ParameterName="GuestEmail",
                    Value = guests.GuestEmail
                },
                new SqlParameter
                {
                    ParameterName ="GuestAddress",
                    Value = guests.GuestAddress
                },

                new SqlParameter
                {
                    ParameterName = "CountryID",
                    Value= guests.CountryID
                },

                new SqlParameter
                {
                    ParameterName="CityID",
                    Value = guests.CityID
                },
                new SqlParameter
                {
                    ParameterName ="StreetID",
                    Value = guests.StreetID
                },

                new SqlParameter
                {
                    ParameterName = "LanguageID",
                    Value= guests.LanguageID
                },

                new SqlParameter
                {
                    ParameterName="GenderID",
                    Value = guests.GenderID
                },
                new SqlParameter
                {
                    ParameterName ="GuestIsActive",
                    Value = guests.GuestIsActive
                },

                new SqlParameter
                {
                    ParameterName = "GuestDescription",
                    Value= guests.GuestDescription
                },

                
            };

            int MyGuest = HotelHelperSQL.MyExecuteNonQuery("sp_AddGuest", "sp", GuestParameters);
            return MyGuest;
        }
        #endregion

        #region Update
        public int UpdateGuest(Guests guests)
        {
            SqlParameter[] GuestParameters =
            {
                new SqlParameter
                {
                    ParameterName ="GuestID",
                    Value = guests.GuestID
                },
                new SqlParameter
                {
                    ParameterName ="GuestIdentityNumber",
                    Value = guests.GuestIdentityNumber
                },

                new SqlParameter
                {
                    ParameterName = "GuestFirstName",
                    Value= guests.GuestFirstName
                },

                new SqlParameter
                {
                    ParameterName="GuestLastName",
                    Value = guests.GuestLastName
                },
                new SqlParameter
                {
                    ParameterName ="GuestBirthDate",
                    Value = guests.GuestBirthDate
                },

                new SqlParameter
                {
                    ParameterName = "GuestPhoneNumber",
                    Value= guests.GuestPhoneNumber
                },

                new SqlParameter
                {
                    ParameterName="GuestEmail",
                    Value = guests.GuestEmail
                },
                new SqlParameter
                {
                    ParameterName ="GuestAddress",
                    Value = guests.GuestAddress
                },

                new SqlParameter
                {
                    ParameterName = "CountryID",
                    Value= guests.CountryID
                },

                new SqlParameter
                {
                    ParameterName="CityID",
                    Value = guests.CityID
                },
                new SqlParameter
                {
                    ParameterName ="StreetID",
                    Value = guests.StreetID
                },

                new SqlParameter
                {
                    ParameterName = "LanguageID",
                    Value= guests.LanguageID
                },

                new SqlParameter
                {
                    ParameterName="GenderID",
                    Value = guests.GenderID
                },
                new SqlParameter
                {
                    ParameterName ="GuestIsActive",
                    Value = guests.GuestIsActive
                },

                new SqlParameter
                {
                    ParameterName = "GuestDescription",
                    Value= guests.GuestDescription
                },
            };

            int MyGuest = HotelHelperSQL.MyExecuteNonQuery("sp_UpdateGuest", "sp", GuestParameters);
            return MyGuest;
        }
        #endregion

        #region Delete
        public int DeleteGuest(Guests guests)
        {
            SqlParameter[] GuestParameters =
            {
                new SqlParameter
                {
                    ParameterName ="GuestID",
                    Value = guests.GuestID
                }
            };

            int MyGuest = HotelHelperSQL.MyExecuteNonQuery("sp_DeleteGuest", "sp", GuestParameters);
            return MyGuest;
        }
        #endregion
    }
}
