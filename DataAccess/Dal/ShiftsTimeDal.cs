using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ShiftsTimeDal
    {
        #region Insert
        public int InsertShiftsTime(ShiftsTime shiftsTime)
        {
            SqlParameter[] ShiftsTimeParameters =
            {
                new SqlParameter
                {
                    ParameterName ="ShiftTime",
                    Value = shiftsTime.ShiftTime
                },

                new SqlParameter
                {
                    ParameterName = "ShiftTimeIsActive",
                    Value= shiftsTime.ShiftTimeIsActive
                },

                new SqlParameter
                {
                    ParameterName="ShiftTimeDescription",
                    Value = shiftsTime.ShiftTimeDescription
                }
            };

            int MyShiftsTime = HotelHelperSQL.MyExecuteNonQuery("sp_AddShiftsTime", "sp", ShiftsTimeParameters);
            return MyShiftsTime;
        }
        #endregion

        #region Update
        public int UpdateShiftsTime(ShiftsTime shiftsTime)
        {
            SqlParameter[] ShiftsTimeParameters =
            {
                new SqlParameter
                {
                    ParameterName ="ShiftTimeID",
                    Value = shiftsTime.ShiftTimeID
                },
                new SqlParameter
                {
                    ParameterName ="ShiftTime",
                    Value = shiftsTime.ShiftTime
                },

                new SqlParameter
                {
                    ParameterName = "ShiftTimeIsActive",
                    Value= shiftsTime.ShiftTimeIsActive
                },

                new SqlParameter
                {
                    ParameterName="ShiftTimeDescription",
                    Value = shiftsTime.ShiftTimeDescription
                }
            };

            int MyShiftsTime = HotelHelperSQL.MyExecuteNonQuery("sp_UpdateShiftsTime", "sp", ShiftsTimeParameters);
            return MyShiftsTime;
        }
        #endregion

        #region Delete
        public int DeleteShiftsTime(ShiftsTime shiftsTime)
        {
            SqlParameter[] ShiftsTimeParameters =
            {
                new SqlParameter
                {
                    ParameterName ="ShiftTimeID",
                    Value = shiftsTime.ShiftTimeID
                }
            };

            int MyShiftsTime = HotelHelperSQL.MyExecuteNonQuery("sp_DeleteShiftsTime", "sp", ShiftsTimeParameters);
            return MyShiftsTime;
        }
        #endregion
    }
}
