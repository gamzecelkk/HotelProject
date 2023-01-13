using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ReservationTypeDal
    {
        #region Insert
        public int InsertReservationType(ReservationTypes reservationTypes)
        {
            SqlParameter[] ReservationTypeParameters =
            {
                new SqlParameter
                {
                    ParameterName ="ReservationTypeName",
                    Value = reservationTypes.ReservationTypeName
                },

                new SqlParameter
                {
                    ParameterName = "ReservationTypeIsActive",
                    Value= reservationTypes.ReservationTypeIsActive
                },

                new SqlParameter
                {
                    ParameterName="ReservationTypeDescription",
                    Value = reservationTypes.ReservationTypeDescription
                }
            };

            int MyReservationType = HotelHelperSQL.MyExecuteNonQuery("sp_AddReservationType", "sp", ReservationTypeParameters);
            return MyReservationType;
        }
        #endregion

        #region Update
        public int UpdateReservationType(ReservationTypes reservationTypes)
        {
            SqlParameter[] ReservationTypeParameters =
            {
                new SqlParameter
                {
                    ParameterName ="ReservationTypeID",
                    Value = reservationTypes.ReservationTypeID
                },
                new SqlParameter
                {
                    ParameterName ="ReservationTypeName",
                    Value = reservationTypes.ReservationTypeName
                },

                new SqlParameter
                {
                    ParameterName = "ReservationTypeIsActive",
                    Value= reservationTypes.ReservationTypeIsActive
                },

                new SqlParameter
                {
                    ParameterName="ReservationTypeDescription",
                    Value = reservationTypes.ReservationTypeDescription
                }
            };

            int MyReservationType = HotelHelperSQL.MyExecuteNonQuery("sp_UpdateReservationType", "sp", ReservationTypeParameters);
            return MyReservationType;
        }
        #endregion

        #region Delete
        public int DeleteReservationType(ReservationTypes reservationTypes)
        {
            SqlParameter[] ReservationTypeParameters =
            {
                new SqlParameter
                {
                    ParameterName ="ReservationTypeID",
                    Value = reservationTypes.ReservationTypeID
                },

            };

            int MyReservationType = HotelHelperSQL.MyExecuteNonQuery("sp_DeleteReservationType", "sp", ReservationTypeParameters);
            return MyReservationType;
        }
        #endregion
    }
}
