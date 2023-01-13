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
    public class BedTypeDal
    {
        #region Read

        public BedTypes ReadMe(SqlDataReader bedTypeReader)
        {
            BedTypes myBedType = new BedTypes();
            while (bedTypeReader.Read())
            {
                myBedType.BedTypeID = (int)bedTypeReader[0];
                myBedType.BedTypeName = (string)bedTypeReader[1];
                myBedType.BedTypeIsActive = (bool)bedTypeReader[2];
                myBedType.BedTypeDescription = (string)bedTypeReader[3];

            }
            return myBedType;
        }

        #endregion

        #region Insert
        public int InsertBedType(BedTypes bedTypes)
        {
            SqlParameter[] bedTypeParameters =
            {
                new SqlParameter
                {
                    ParameterName ="BedTypeName",
                    Value = bedTypes.BedTypeName
                },

                new SqlParameter
                {
                    ParameterName = "BedTypeIsActive",
                    Value= bedTypes.BedTypeIsActive
                },

                new SqlParameter
                {
                    ParameterName="BedTypeDescription",
                    Value = bedTypes.BedTypeDescription
                }
            };

            int bedTypeInserted = HotelHelperSQL.MyExecuteNonQuery("sp_AddBedType", "sp", bedTypeParameters);
            return bedTypeInserted;
        }

        #endregion

        #region Update
        public int UpdateBedType(BedTypes bedTypes)
        {
            SqlParameter[] bedTypeParameters =
            {
                new SqlParameter
                {
                    ParameterName ="BedTypeID",
                    Value = bedTypes.BedTypeID
                },
                new SqlParameter
                {
                    ParameterName ="BedTypeName",
                    Value = bedTypes.BedTypeName
                },

                new SqlParameter
                {
                    ParameterName = "BedTypeIsActive",
                    Value= bedTypes.BedTypeIsActive
                },

                new SqlParameter
                {
                    ParameterName="BedTypeDescription",
                    Value = bedTypes.BedTypeDescription
                }
            };

            int bedTypeUpdated= HotelHelperSQL.MyExecuteNonQuery("sp_UpdateBedType", "sp", bedTypeParameters);
            return bedTypeUpdated;
        }
        #endregion

        #region Delete
        public int DeleteBedType(BedTypes bedTypes)
        {
            SqlParameter[] bedTypeParameters =
            {
                new SqlParameter
                {
                    ParameterName ="BedTypeID",
                    Value = bedTypes.BedTypeID
                }
              
            };

            int bedTypeDeleted = HotelHelperSQL.MyExecuteNonQuery("sp_DeleteBedType", "sp", bedTypeParameters);
            return bedTypeDeleted;
        }
        #endregion

        #region All BedTypes

        public BedTypes GetAllBedTypes()
        {
            SqlDataReader bedTypeReader = HotelHelperSQL.MyExecuteReader("select * from BedTypes where BedTypeIsActive = 1", "text", null);
            BedTypes allBedTypes = ReadMe(bedTypeReader);
            return allBedTypes;
        }

        #endregion
    }
}
