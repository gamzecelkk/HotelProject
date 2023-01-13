using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ShiftDal
    {
        #region Insert
        public int InsertShift(Shifts shifts)
        {
            SqlParameter[] ShiftsParameters =
            {
                new SqlParameter
                {
                    ParameterName ="ShiftName",
                    Value = shifts.ShiftName
                },

                new SqlParameter
                {
                    ParameterName = "ShiftDate",
                    Value= shifts.ShiftDate
                },

                new SqlParameter
                {
                    ParameterName="ShiftTimeID",
                    Value = shifts.ShiftTimeID
                },
                new SqlParameter
                {
                    ParameterName ="OverTimeIsThere",
                    Value = shifts.OverTimeIsThere
                },

                new SqlParameter
                {
                    ParameterName = "OverTime",
                    Value= shifts.OverTime
                },

                new SqlParameter
                {
                    ParameterName="ShiftIsActive",
                    Value = shifts.ShiftIsActive
                },
                new SqlParameter
                {
                    ParameterName="ShiftDescription",
                    Value = shifts.ShiftDescription
                }
            };

            int MyShift = HotelHelperSQL.MyExecuteNonQuery("sp_AddShift", "sp", ShiftsParameters);
            return MyShift;
        }
        #endregion

        #region Update
        public int UpdateShift(Shifts shifts)
        {
            SqlParameter[] ShiftsParameters =
            {
                 new SqlParameter
                {
                    ParameterName ="ShiftID",
                    Value = shifts.ShiftID
                },
                new SqlParameter
                {
                    ParameterName ="ShiftName",
                    Value = shifts.ShiftName
                },

                new SqlParameter
                {
                    ParameterName = "ShiftDate",
                    Value= shifts.ShiftDate
                },

                new SqlParameter
                {
                    ParameterName="ShiftTimeID",
                    Value = shifts.ShiftTimeID
                },
                new SqlParameter
                {
                    ParameterName ="OverTimeIsThere",
                    Value = shifts.OverTimeIsThere
                },

                new SqlParameter
                {
                    ParameterName = "OverTime",
                    Value= shifts.OverTime
                },

                new SqlParameter
                {
                    ParameterName="ShiftIsActive",
                    Value = shifts.ShiftIsActive
                },
                new SqlParameter
                {
                    ParameterName="ShiftDescription",
                    Value = shifts.ShiftDescription
                }
            };

            int MyShift = HotelHelperSQL.MyExecuteNonQuery("sp_UpdateShift", "sp", ShiftsParameters);
            return MyShift;
        }
        #endregion

        #region Delete
        public int DeleteShift(Shifts shifts)
        {
            SqlParameter[] ShiftsParameters =
            {
                new SqlParameter
                {
                    ParameterName ="ShiftID",
                    Value = shifts.ShiftID
                }
            };

            int MyShift = HotelHelperSQL.MyExecuteNonQuery("sp_DeleteShift", "sp", ShiftsParameters);
            return MyShift;
        }
        #endregion
    }
}
