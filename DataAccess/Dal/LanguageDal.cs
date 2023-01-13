using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class LanguageDal
    {
        #region Insert
        public int InsertLanguage(Languages languages)
        {
            SqlParameter[] LanguageParameters =
            {
                new SqlParameter
                {
                    ParameterName ="LanguageName",
                    Value = languages.LanguageName
                },

                new SqlParameter
                {
                    ParameterName = "LanguageCode",
                    Value= languages.LanguageCode
                },

                new SqlParameter
                {
                    ParameterName="LanguageIsActive",
                    Value = languages.LanguageIsActive
                },
                new SqlParameter
                {
                    ParameterName="LanguageDescription",
                    Value = languages.LanguageDescription
                }
            };

            int MyLanguage = HotelHelperSQL.MyExecuteNonQuery("sp_AddLanguage", "sp", LanguageParameters);
            return MyLanguage;
        }
        #endregion

        #region Update
        public int UpdateLanguage(Languages languages)
        {
            SqlParameter[] LanguageParameters =
            {
                new SqlParameter
                {
                    ParameterName ="LanguageID",
                    Value = languages.LanguageID
                },
                new SqlParameter
                {
                    ParameterName ="LanguageName",
                    Value = languages.LanguageName
                },

                new SqlParameter
                {
                    ParameterName = "LanguageCode",
                    Value= languages.LanguageCode
                },

                new SqlParameter
                {
                    ParameterName="LanguageIsActive",
                    Value = languages.LanguageIsActive
                },
                new SqlParameter
                {
                    ParameterName="LanguageDescription",
                    Value = languages.LanguageDescription
                }
            };

            int MyLanguage = HotelHelperSQL.MyExecuteNonQuery("sp_UpdateLanguage", "sp", LanguageParameters);
            return MyLanguage;
        }
        #endregion

        #region Delete
        public int DeleteLanguage(Languages languages)
        {
            SqlParameter[] LanguageParameters =
            {
                new SqlParameter
                {
                    ParameterName ="LanguageID",
                    Value = languages.LanguageID
                },
            };

            int MyLanguage = HotelHelperSQL.MyExecuteNonQuery("sp_DeleteLanguage", "sp", LanguageParameters);
            return MyLanguage;
        }
        #endregion
    }
}
