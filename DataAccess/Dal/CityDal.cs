using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CityDal
    {
        #region Insert
        public int InsertCity(Cities cities)
        {
            SqlParameter[] CityParameters =
            {
                new SqlParameter
                {
                    ParameterName ="CityName",
                    Value = cities.CityName
                },

                new SqlParameter
                {
                    ParameterName = "CountryID",
                    Value= cities.CountryID
                },

                new SqlParameter
                {
                    ParameterName="CityCode",
                    Value = cities.CityCode
                },

                new SqlParameter
                {
                    ParameterName = "CityIsActive",
                    Value= cities.CityIsActive
                },

                new SqlParameter
                {
                    ParameterName="CityDescription",
                    Value = cities.CityDescription
                }
            };

            int MyCity = HotelHelperSQL.MyExecuteNonQuery("sp_AddCity", "sp", CityParameters);
            return MyCity;
        }
        #endregion

        #region Update
        public int UpdateCity(Cities cities)
        {
            SqlParameter[] CityParameters =
            {
                new SqlParameter
                {
                    ParameterName ="CityID",
                    Value = cities.CityID
                },
                new SqlParameter
                {
                    ParameterName ="CityName",
                    Value = cities.CityName
                },

                new SqlParameter
                {
                    ParameterName = "CountryID",
                    Value= cities.CountryID
                },

                new SqlParameter
                {
                    ParameterName="CityCode",
                    Value = cities.CityCode
                },

                new SqlParameter
                {
                    ParameterName = "CityIsActive",
                    Value= cities.CityIsActive
                },

                new SqlParameter
                {
                    ParameterName="CityDescription",
                    Value = cities.CityDescription
                }
            };

            int MyCity = HotelHelperSQL.MyExecuteNonQuery("sp_UpdateCity", "sp", CityParameters);
            return MyCity;
        }
        #endregion

        #region Delete
        public int DeleteCity(Cities cities)
        {
            SqlParameter[] CityParameters =
            {
                new SqlParameter
                {
                    ParameterName ="CityID",
                    Value = cities.CityID
                },
            };

            int MyCity = HotelHelperSQL.MyExecuteNonQuery("sp_DeleteCity", "sp", CityParameters);
            return MyCity;
        }
        #endregion
    }
}
