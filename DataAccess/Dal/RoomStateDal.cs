using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess
{
    public class RoomStateDal
    {
        #region Insert
        public int InsertRoomState(RoomStates roomStates)
        {
            SqlParameter[] RoomStateParameters =
            {
                new SqlParameter
                {
                    ParameterName ="RoomStateName",
                    Value = roomStates.RoomStateName
                },

                new SqlParameter
                {
                    ParameterName = "RoomStateIsActive",
                    Value= roomStates.RoomStateIsActive
                },

                new SqlParameter
                {
                    ParameterName="RoomStateDescription",
                    Value = roomStates.RoomStateDescription
                }
            };

            int MyRoomState = HotelHelperSQL.MyExecuteNonQuery("sp_AddRoomState", "sp", RoomStateParameters);
            return MyRoomState;
        }
        #endregion

        #region Update
        public int UpdateRoomState(RoomStates roomStates)
        {
            SqlParameter[] RoomStateParameters =
            {
                new SqlParameter
                {
                    ParameterName ="RoomStateID",
                    Value = roomStates.RoomStateID
                },
                new SqlParameter
                {
                    ParameterName ="RoomStateName",
                    Value = roomStates.RoomStateName
                },

                new SqlParameter
                {
                    ParameterName = "RoomStateIsActive",
                    Value= roomStates.RoomStateIsActive
                },

                new SqlParameter
                {
                    ParameterName="RoomStateDescription",
                    Value = roomStates.RoomStateDescription
                }
                
            };

            int MyRoomState = HotelHelperSQL.MyExecuteNonQuery("sp_UpdateRoomState", "sp", RoomStateParameters);
            return MyRoomState;
        }
        #endregion

        #region Delete
        public int DeleteRoomState(RoomStates roomStates)
        {
            SqlParameter[] RoomStateParameters =
            {
                new SqlParameter
                {
                    ParameterName ="RoomStateID",
                    Value = roomStates.RoomStateID
                }

            };

            int MyRoomState = HotelHelperSQL.MyExecuteNonQuery("sp_DeleteRoomState", "sp", RoomStateParameters);
            return MyRoomState;
        }
        #endregion
    }
}
