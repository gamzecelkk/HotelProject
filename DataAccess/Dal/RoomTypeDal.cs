using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RoomTypeDal
    {
        #region Insert
        public int InsertRoomType(RoomTypes roomTypes)
        {
            SqlParameter[] RoomTypeParameters =
            {
                new SqlParameter
                {
                    ParameterName ="RoomTypeProperties",
                    Value = roomTypes.RoomTypeProperties
                },

                new SqlParameter
                {
                    ParameterName = "RoomTypeBeds",
                    Value= roomTypes.RoomTypeBeds
                },

                new SqlParameter
                {
                    ParameterName="BedTypeID",
                    Value = roomTypes.BedTypeID
                },
                new SqlParameter
                {
                    ParameterName ="RoomTypePersons",
                    Value = roomTypes.RoomTypePersons
                },

                new SqlParameter
                {
                    ParameterName = "RoomTypeIsActive",
                    Value= roomTypes.RoomTypeIsActive
                },

                new SqlParameter
                {
                    ParameterName="RoomTypeDescription",
                    Value = roomTypes.RoomTypeDescription
                }
            };

            int MyRoomType = HotelHelperSQL.MyExecuteNonQuery("sp_AddRoomType", "sp", RoomTypeParameters);
            return MyRoomType;
        }
        #endregion

        #region Update
        public int UpdateRoomType(RoomTypes roomTypes)
        {
            SqlParameter[] RoomTypeParameters =
            {
                new SqlParameter
                {
                    ParameterName ="RoomTypeID",
                    Value = roomTypes.RoomTypeID
                },
                new SqlParameter
                {
                    ParameterName ="RoomTypeProperties",
                    Value = roomTypes.RoomTypeProperties
                },

                new SqlParameter
                {
                    ParameterName = "RoomTypeBeds",
                    Value= roomTypes.RoomTypeBeds
                },

                new SqlParameter
                {
                    ParameterName="BedTypeID",
                    Value = roomTypes.BedTypeID
                },
                new SqlParameter
                {
                    ParameterName ="RoomTypePersons",
                    Value = roomTypes.RoomTypePersons
                },

                new SqlParameter
                {
                    ParameterName = "RoomTypeIsActive",
                    Value= roomTypes.RoomTypeIsActive
                },

                new SqlParameter
                {
                    ParameterName="RoomTypeDescription",
                    Value = roomTypes.RoomTypeDescription
                }
            };

            int MyRoomType = HotelHelperSQL.MyExecuteNonQuery("sp_UpdateRoomType", "sp", RoomTypeParameters);
            return MyRoomType;
        }
        #endregion

        #region Delete
        public int DeleteRoomType(RoomTypes roomTypes)
        {
            SqlParameter[] RoomTypeParameters =
            {
                new SqlParameter
                {
                    ParameterName ="RoomTypeID",
                    Value = roomTypes.RoomTypeID
                }
            };

            int MyRoomType = HotelHelperSQL.MyExecuteNonQuery("sp_DeleteRoomType", "sp", RoomTypeParameters);
            return MyRoomType;
        }
        #endregion
    }
}
