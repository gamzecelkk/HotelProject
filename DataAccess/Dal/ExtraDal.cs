using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Entities.View;
using System.Data.SqlClient;

namespace DataAccess
{
    public class ExtraDal
    {
        #region Read

        public ExtraView ReadMe(SqlDataReader extrasReader)
        {
            ExtraView myExtras = new ExtraView();
            while (extrasReader.Read())
            {
                myExtras.ID = (int)extrasReader[0];
                myExtras.ExtrasName = (string)extrasReader[1];
                myExtras.Price = (decimal)extrasReader[2];
                myExtras.Activity = (bool)extrasReader[3];
                myExtras.Descriptions = (string)extrasReader[4];

            }
            return myExtras;
        }

        #endregion

        #region Insert
        public int InsertExtra(Extras extras)
        {
            
            SqlParameter[] extraParameters =
            {
                new SqlParameter
                {
                    ParameterName ="ExtraName",
                    Value = extras.ExtraName
                },

                new SqlParameter
                {
                    ParameterName = "ExtraPrice",
                    Value= extras.ExtraPrice
                },

                new SqlParameter
                {
                    ParameterName="ExtraIsActive",
                    Value = extras.ExtraIsActive
                },
                new SqlParameter
                {
                    ParameterName="ExtraDescription",
                    Value = extras.ExtraDescription
                }
            };

            int extraInserted = HotelHelperSQL.MyExecuteNonQuery("sp_AddExtra", "sp", extraParameters);
            return extraInserted;
        }
        #endregion

        #region Update

        public int UpdateExtra(Extras extras)
        {
            SqlParameter[] extraParameters =
            {
                new SqlParameter
                {
                    ParameterName ="ExtraID",
                    Value = extras.ExtraID
                },
                new SqlParameter
                {
                    ParameterName ="ExtraName",
                    Value = extras.ExtraName
                },

                new SqlParameter
                {
                    ParameterName = "ExtraPrice",
                    Value= extras.ExtraPrice
                },

                new SqlParameter
                {
                    ParameterName="ExtraIsActive",
                    Value = extras.ExtraIsActive
                },
                new SqlParameter
                {
                    ParameterName="ExtraDescription",
                    Value = extras.ExtraDescription
                }
            };

            int extraUpdated = HotelHelperSQL.MyExecuteNonQuery("sp_UpdateExtra", "sp", extraParameters);
            return extraUpdated;
        }

        #endregion

        #region Delete
        public int DeleteExtra(Extras extras)
        {
            SqlParameter[] extraParameters =
            {
                new SqlParameter
                {
                    ParameterName ="ExtraID",
                    Value = extras.ExtraID
                },

            };

            int extraDeleted = HotelHelperSQL.MyExecuteNonQuery("sp_DeleteExtra", "sp", extraParameters);
            return extraDeleted;
        }
        #endregion

        #region Get All Extras

        public ExtraView GetAllExtras()
        {
            SqlDataReader extrasReader = HotelHelperSQL.MyExecuteReader("select * from vw_Extras where Activity = 1", "text", null);
            ExtraView allExtras = ReadMe(extrasReader);
            return allExtras;
        }

        #endregion
    }
}
