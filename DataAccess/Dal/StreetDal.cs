using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class StreetDal
    {
        #region Insert
        public int InsertStreet(Streets streets)
        {
            SqlParameter[] StreetParameters =
            {
                new SqlParameter
                {
                    ParameterName ="StreetName",
                    Value = streets.StreetName
                },

                new SqlParameter
                {
                    ParameterName = "CountryID",
                    Value= streets.CountryID
                },

                new SqlParameter
                {
                    ParameterName="CityID",
                    Value = streets.CityID
                },

                new SqlParameter
                {
                    ParameterName = "StreetIsActive",
                    Value= streets.StreetIsActive
                },

                new SqlParameter
                {
                    ParameterName="StreetDescription",
                    Value = streets.StreetDescription
                }
            };

            int MyStreet = HotelHelperSQL.MyExecuteNonQuery("sp_AddStreet", "sp", StreetParameters);
            return MyStreet;
        }
        #endregion

        #region Update
        public int UpdateStreet(Streets streets)
        {
            SqlParameter[] StreetParameters =
            {
                new SqlParameter
                {
                    ParameterName ="StreetID",
                    Value = streets.StreetID
                },
                new SqlParameter
                {
                    ParameterName ="StreetName",
                    Value = streets.StreetName
                },

                new SqlParameter
                {
                    ParameterName = "CountryID",
                    Value= streets.CountryID
                },

                new SqlParameter
                {
                    ParameterName="CityID",
                    Value = streets.CityID
                },

                new SqlParameter
                {
                    ParameterName = "StreetIsActive",
                    Value= streets.StreetIsActive
                },

                new SqlParameter
                {
                    ParameterName="StreetDescription",
                    Value = streets.StreetDescription
                }
            };

            int MyStreet = HotelHelperSQL.MyExecuteNonQuery("sp_UpdateStreet", "sp", StreetParameters);
            return MyStreet;
        }
        #endregion

        #region Delete
        public int DeleteStreet(Streets streets)
        {
            SqlParameter[] StreetParameters =
            {
                new SqlParameter
                {
                    ParameterName ="StreetID",
                    Value = streets.StreetID
                },
            };

            int MyStreet = HotelHelperSQL.MyExecuteNonQuery("sp_DeleteStreet", "sp", StreetParameters);
            return MyStreet;
        }
        #endregion
    }
}
