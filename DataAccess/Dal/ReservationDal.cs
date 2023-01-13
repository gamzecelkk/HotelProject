using Entities.Concrete;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ReservationDal
    {
        #region Insert
        public int InsertReservation(Reservations reservations)
        {
            SqlParameter[] ReservationParameters =
            {
                new SqlParameter
                {
                    ParameterName ="ReservationTransactionDate",
                    Value = reservations.ReservationTransactionDate
                },

                new SqlParameter
                {
                    ParameterName = "ReservationStartDate",
                    Value= reservations.ReservationStartDate
                },

                new SqlParameter
                {
                    ParameterName="ReservationEndDate",
                    Value = reservations.ReservationEndDate
                },
                new SqlParameter
                {
                    ParameterName ="CustomerID",
                    Value = reservations.CustomerID
                },

                new SqlParameter
                {
                    ParameterName = "ReservationTypeID",
                    Value= reservations.ReservationTypeID
                },

                new SqlParameter
                {
                    ParameterName="PackageID",
                    Value = reservations.PackageID
                },
                new SqlParameter
                {
                    ParameterName ="CampaignID",
                    Value = reservations.CampaignID
                },

                new SqlParameter
                {
                    ParameterName = "RoomID",
                    Value= reservations.RoomID
                },

                new SqlParameter
                {
                    ParameterName="ReservationAdvancePayment",
                    Value = reservations.ReservationAdvancePayment
                },
                new SqlParameter
                {
                    ParameterName ="ReservationDiscount",
                    Value = reservations.ReservationDiscount
                },

                new SqlParameter
                {
                    ParameterName = "ReservationIsActive",
                    Value= reservations.ReservationIsActive
                },

                new SqlParameter
                {
                    ParameterName="ReservationDescription",
                    Value = reservations.ReservationDescription
                },
            };

            int MyReservation = HotelHelperSQL.MyExecuteNonQuery("sp_AddReservation", "sp", ReservationParameters);
            return MyReservation;
        }
        #endregion

        #region Update
        public int UpdateReservation(Reservations reservations)
        {
            SqlParameter[] ReservationParameters =
            {
                new SqlParameter
                {
                    ParameterName ="ReservationID",
                    Value = reservations.ReservationID
                },
                new SqlParameter
                {
                    ParameterName ="ReservationTransactionDate",
                    Value = reservations.ReservationTransactionDate
                },

                new SqlParameter
                {
                    ParameterName = "ReservationStartDate",
                    Value= reservations.ReservationStartDate
                },

                new SqlParameter
                {
                    ParameterName="ReservationEndDate",
                    Value = reservations.ReservationEndDate
                },
                new SqlParameter
                {
                    ParameterName ="CustomerID",
                    Value = reservations.CustomerID
                },

                new SqlParameter
                {
                    ParameterName = "ReservationTypeID",
                    Value= reservations.ReservationTypeID
                },

                new SqlParameter
                {
                    ParameterName="PackageID",
                    Value = reservations.PackageID
                },
                new SqlParameter
                {
                    ParameterName ="CampaignID",
                    Value = reservations.CampaignID
                },

                new SqlParameter
                {
                    ParameterName = "RoomID",
                    Value= reservations.RoomID
                },

                new SqlParameter
                {
                    ParameterName="ReservationAdvancePayment",
                    Value = reservations.ReservationAdvancePayment
                },
                new SqlParameter
                {
                    ParameterName ="ReservationDiscount",
                    Value = reservations.ReservationDiscount
                },

                new SqlParameter
                {
                    ParameterName = "ReservationIsActive",
                    Value= reservations.ReservationIsActive
                },

                new SqlParameter
                {
                    ParameterName="ReservationDescription",
                    Value = reservations.ReservationDescription
                },
            };

            int MyReservation = HotelHelperSQL.MyExecuteNonQuery("sp_UpdateReservation", "sp", ReservationParameters);
            return MyReservation;
        }
        #endregion

        #region Delete
        public int DeleteReservation(Reservations reservations)
        {
            SqlParameter[] ReservationParameters =
            {
                new SqlParameter
                {
                    ParameterName ="ReservationID",
                    Value = reservations.ReservationID
                },

            };

            int MyReservation = HotelHelperSQL.MyExecuteNonQuery("sp_DeleteReservation", "sp", ReservationParameters);
            return MyReservation;
        }
        #endregion
    }
}
