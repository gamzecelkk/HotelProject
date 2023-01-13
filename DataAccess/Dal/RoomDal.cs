using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RoomDal
    {
        #region Insert
        public int InsertRoom(Rooms rooms)
        {
            SqlParameter[] RoomParameters =
            {
                new SqlParameter
                {
                    ParameterName ="RoomNumber",
                    Value = rooms.RoomNumber
                },

                new SqlParameter
                {
                    ParameterName = "RoomTypeID",
                    Value= rooms.RoomTypeID
                },

                new SqlParameter
                {
                    ParameterName="RoomPrice",
                    Value = rooms.RoomPrice
                },
                new SqlParameter
                {
                    ParameterName ="RoomIsEmpty",
                    Value = rooms.RoomIsEmpty
                },

                new SqlParameter
                {
                    ParameterName = "FloorID",
                    Value= rooms.FloorID
                },

                new SqlParameter
                {
                    ParameterName="RoomIsClean",
                    Value = rooms.RoomIsClean
                },
                new SqlParameter
                {
                    ParameterName ="RoomSize",
                    Value = rooms.RoomSize
                },

                new SqlParameter
                {
                    ParameterName = "AirConditioningIsActive",
                    Value= rooms.AirConditioningIsActive
                },

                new SqlParameter
                {
                    ParameterName="MinibarIsActive",
                    Value = rooms.MinibarIsActive
                },
                new SqlParameter
                {
                    ParameterName ="HairDryerIsActive",
                    Value = rooms.HairDryerIsActive
                },

                new SqlParameter
                {
                    ParameterName = "WifiIsActive",
                    Value= rooms.WifiIsActive
                },

                new SqlParameter
                {
                    ParameterName="SafeIsActive",
                    Value = rooms.SafeIsActive
                },
                new SqlParameter
                {
                    ParameterName = "TVIsActive",
                    Value= rooms.TVIsActive
                },

                new SqlParameter
                {
                    ParameterName="BalconyIsActive",
                    Value = rooms.BalconyIsActive
                },
                new SqlParameter
                {
                    ParameterName ="RoomBedType",
                    Value = rooms.RoomBedType
                },

                new SqlParameter
                {
                    ParameterName = "RoomIsActive",
                    Value= rooms.RoomIsActive
                },

                new SqlParameter
                {
                    ParameterName="RoomDescription",
                    Value = rooms.RoomDescription
                }
            };

            int MyRoom = HotelHelperSQL.MyExecuteNonQuery("sp_AddRoom", "sp", RoomParameters);
            return MyRoom;
        }
        #endregion

        #region Update
        public int UpdateRoom(Rooms rooms)
        {
            SqlParameter[] RoomParameters =
            {
                new SqlParameter
                {
                    ParameterName ="RoomID",
                    Value = rooms.RoomID
                },
                new SqlParameter
                {
                    ParameterName ="RoomNumber",
                    Value = rooms.RoomNumber
                },

                new SqlParameter
                {
                    ParameterName = "RoomTypeID",
                    Value= rooms.RoomTypeID
                },

                new SqlParameter
                {
                    ParameterName="RoomPrice",
                    Value = rooms.RoomPrice
                },
                new SqlParameter
                {
                    ParameterName ="RoomIsEmpty",
                    Value = rooms.RoomIsEmpty
                },

                new SqlParameter
                {
                    ParameterName = "FloorID",
                    Value= rooms.FloorID
                },

                new SqlParameter
                {
                    ParameterName="RoomIsClean",
                    Value = rooms.RoomIsClean
                },
                new SqlParameter
                {
                    ParameterName ="RoomSize",
                    Value = rooms.RoomSize
                },

                new SqlParameter
                {
                    ParameterName = "AirConditioningIsActive",
                    Value= rooms.AirConditioningIsActive
                },

                new SqlParameter
                {
                    ParameterName="MinibarIsActive",
                    Value = rooms.MinibarIsActive
                },
                new SqlParameter
                {
                    ParameterName ="HairDryerIsActive",
                    Value = rooms.HairDryerIsActive
                },

                new SqlParameter
                {
                    ParameterName = "WifiIsActive",
                    Value= rooms.WifiIsActive
                },

                new SqlParameter
                {
                    ParameterName="SafeIsActive",
                    Value = rooms.SafeIsActive
                },
                new SqlParameter
                {
                    ParameterName = "TVIsActive",
                    Value= rooms.TVIsActive
                },

                new SqlParameter
                {
                    ParameterName="BalconyIsActive",
                    Value = rooms.BalconyIsActive
                },
                new SqlParameter
                {
                    ParameterName ="RoomBedType",
                    Value = rooms.RoomBedType
                },

                new SqlParameter
                {
                    ParameterName = "RoomIsActive",
                    Value= rooms.RoomIsActive
                },

                new SqlParameter
                {
                    ParameterName="RoomDescription",
                    Value = rooms.RoomDescription
                }
            };

            int MyRoom = HotelHelperSQL.MyExecuteNonQuery("sp_UpdateRoom", "sp", RoomParameters);
            return MyRoom;
        }
        #endregion

        #region Delete
        public int DeleteRoom(Rooms rooms)
        {
            SqlParameter[] RoomParameters =
            {
                new SqlParameter
                {
                    ParameterName ="RoomID",
                    Value = rooms.RoomID
                }
            };

            int MyRoom = HotelHelperSQL.MyExecuteNonQuery("sp_DeleteRoom", "sp", RoomParameters);
            return MyRoom;
        }
        #endregion
    }
}
