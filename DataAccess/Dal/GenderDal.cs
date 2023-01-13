using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class GenderDal
    {
        #region Insert
        public int InsertGender(Genders genders)
        {
            SqlParameter[] GenderParameters =
            {
                new SqlParameter
                {
                    ParameterName ="GenderName",
                    Value = genders.GenderName
                },

                new SqlParameter
                {
                    ParameterName = "GenderIsActive",
                    Value= genders.GenderIsActive
                },

                new SqlParameter
                {
                    ParameterName="GenderDescription",
                    Value = genders.GenderDescription
                }
            };

            int MyGender = HotelHelperSQL.MyExecuteNonQuery("sp_AddGender", "sp", GenderParameters);
            return MyGender;
        }
        #endregion

        #region Update
        public int UpdateGender(Genders genders)
        {
            SqlParameter[] GenderParameters =
            {
                new SqlParameter
                {
                    ParameterName ="GenderID",
                    Value = genders.GenderID
                },
                new SqlParameter
                {
                    ParameterName ="GenderName",
                    Value = genders.GenderName
                },

                new SqlParameter
                {
                    ParameterName = "GenderIsActive",
                    Value= genders.GenderIsActive
                },

                new SqlParameter
                {
                    ParameterName="GenderDescription",
                    Value = genders.GenderDescription
                }
            };

            int MyGender = HotelHelperSQL.MyExecuteNonQuery("sp_UpdateGender", "sp", GenderParameters);
            return MyGender;
        }
        #endregion

        #region Delete
        public int DeleteGender(Genders genders)
        {
            SqlParameter[] GenderParameters =
            {
                new SqlParameter
                {
                    ParameterName ="GenderID",
                    Value = genders.GenderID
                },
            };

            int MyGender = HotelHelperSQL.MyExecuteNonQuery("sp_DeleteGender", "sp", GenderParameters);
            return MyGender;
        }
        #endregion


    }
}
