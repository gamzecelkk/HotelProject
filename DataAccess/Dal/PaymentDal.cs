using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PaymentDal
    {
        #region Insert
        public int InsertPayment(Payments payments)
        {
            SqlParameter[] PaymentParameters =
            {
                new SqlParameter
                {
                    ParameterName ="PaymentType",
                    Value = payments.PaymentType
                },

                new SqlParameter
                {
                    ParameterName = "PaymentDiscount",
                    Value= payments.PaymentDiscount
                },

                new SqlParameter
                {
                    ParameterName="PaymentIsActive",
                    Value = payments.PaymentIsActive
                },
                new SqlParameter
                {
                    ParameterName="PaymentDescription",
                    Value = payments.PaymentDescription
                }
            };

            int MyPayment = HotelHelperSQL.MyExecuteNonQuery("sp_AddPayment", "sp", PaymentParameters);
            return MyPayment;
        }
        #endregion

        #region Update
        public int UpdatePayment(Payments payments)
        {
            SqlParameter[] PaymentParameters =
            {
                new SqlParameter
                {
                    ParameterName ="PaymentID",
                    Value = payments.PaymentID
                },
                new SqlParameter
                {
                    ParameterName ="PaymentType",
                    Value = payments.PaymentType
                },

                new SqlParameter
                {
                    ParameterName = "PaymentDiscount",
                    Value= payments.PaymentDiscount
                },

                new SqlParameter
                {
                    ParameterName="PaymentIsActive",
                    Value = payments.PaymentIsActive
                },
                new SqlParameter
                {
                    ParameterName="PaymentDescription",
                    Value = payments.PaymentDescription
                }
            };

            int MyPayment = HotelHelperSQL.MyExecuteNonQuery("sp_UpdatePayment", "sp", PaymentParameters);
            return MyPayment;
        }
        #endregion

        #region Delete
        public int DeletePayment(Payments payments)
        {
            SqlParameter[] PaymentParameters =
            {
                new SqlParameter
                {
                    ParameterName ="PaymentID",
                    Value = payments.PaymentID
                },

            };

            int MyPayment = HotelHelperSQL.MyExecuteNonQuery("sp_DeletePayment", "sp", PaymentParameters);
            return MyPayment;
        }
        #endregion
    }
}
