using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SaleDal
    {
        #region Insert
        public int InsertSale(Sales sales)
        {
            SqlParameter[] SaleParameters =
            {
                new SqlParameter
                {
                    ParameterName ="SaleDiscount",
                    Value = sales.SaleDiscount
                },

                new SqlParameter
                {
                    ParameterName = "RoomID",
                    Value= sales.RoomID
                },

                new SqlParameter
                {
                    ParameterName="CardID",
                    Value = sales.CardID
                },
                new SqlParameter
                {
                    ParameterName ="ReservationID",
                    Value = sales.ReservationID
                },

                new SqlParameter
                {
                    ParameterName = "EmployerID",
                    Value= sales.EmployerID
                },

                new SqlParameter
                {
                    ParameterName="SaleRoomEntryDate",
                    Value = sales.SaleRoomEntryDate
                },
                new SqlParameter
                {
                    ParameterName ="SaleRoomExitDate",
                    Value = sales.SaleRoomExitDate
                },

                new SqlParameter
                {
                    ParameterName = "SalePrice",
                    Value= sales.SalePrice
                },

                new SqlParameter
                {
                    ParameterName="SaleVAT",
                    Value = sales.SaleVAT
                },
                new SqlParameter
                {
                    ParameterName="PaymentID",
                    Value = sales.PaymentID
                },
                new SqlParameter
                {
                    ParameterName ="ExtraID",
                    Value = sales.ExtraID
                },

                new SqlParameter
                {
                    ParameterName = "SaleIsActive",
                    Value= sales.SaleIsActive
                },

                new SqlParameter
                {
                    ParameterName="SaleDescription",
                    Value = sales.SaleDescription
                }
            };

            int MySale = HotelHelperSQL.MyExecuteNonQuery("sp_AddSale", "sp", SaleParameters);
            return MySale;
        }
        #endregion

        #region Update
        public int UpdateSale(Sales sales)
        {
            SqlParameter[] SaleParameters =
            {
                new SqlParameter
                {
                    ParameterName ="SaleID",
                    Value = sales.SaleID
                },
                new SqlParameter
                {
                    ParameterName ="SaleDiscount",
                    Value = sales.SaleDiscount
                },

                new SqlParameter
                {
                    ParameterName = "RoomID",
                    Value= sales.RoomID
                },

                new SqlParameter
                {
                    ParameterName="CardID",
                    Value = sales.CardID
                },
                new SqlParameter
                {
                    ParameterName ="ReservationID",
                    Value = sales.ReservationID
                },

                new SqlParameter
                {
                    ParameterName = "EmployerID",
                    Value= sales.EmployerID
                },

                new SqlParameter
                {
                    ParameterName="SaleRoomEntryDate",
                    Value = sales.SaleRoomEntryDate
                },
                new SqlParameter
                {
                    ParameterName ="SaleRoomExitDate",
                    Value = sales.SaleRoomExitDate
                },

                new SqlParameter
                {
                    ParameterName = "SalePrice",
                    Value= sales.SalePrice
                },

                new SqlParameter
                {
                    ParameterName="SaleVAT",
                    Value = sales.SaleVAT
                },
                new SqlParameter
                {
                    ParameterName="PaymentID",
                    Value = sales.PaymentID
                },
                new SqlParameter
                {
                    ParameterName ="ExtraID",
                    Value = sales.ExtraID
                },

                new SqlParameter
                {
                    ParameterName = "SaleIsActive",
                    Value= sales.SaleIsActive
                },

                new SqlParameter
                {
                    ParameterName="SaleDescription",
                    Value = sales.SaleDescription
                }
            };

            int MySale = HotelHelperSQL.MyExecuteNonQuery("sp_UpdateSale", "sp", SaleParameters);
            return MySale;
        }
        #endregion

        #region Delete
        public int DeleteSale(Sales sales)
        {
            SqlParameter[] SaleParameters =
            {
                new SqlParameter
                {
                    ParameterName ="SaleID",
                    Value = sales.SaleID
                }
            };

            int MySale = HotelHelperSQL.MyExecuteNonQuery("sp_DeleteSale", "sp", SaleParameters);
            return MySale;
        }
        #endregion
    }
}
