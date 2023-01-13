using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UserTypeDal
    {
        #region Insert
        public int InsertUserType(UserTypes userTypes)
        {
            SqlParameter[] UserTypeParameters =
            {
                
                new SqlParameter
                {
                    ParameterName ="UserTypeName",
                    Value = userTypes.UserTypeName
                },

                new SqlParameter
                {
                    ParameterName = "UserTypeIsActive",
                    Value= userTypes.UserTypeIsActive
                },

                new SqlParameter
                {
                    ParameterName="UserTypeDescription",
                    Value = userTypes.UserTypeDescription
                }
                
            };

            int MyUserType = HotelHelperSQL.MyExecuteNonQuery("sp_AddUserType", "sp", UserTypeParameters);
            return MyUserType;
        }
        #endregion

        #region Update
        public int UpdateUserType(UserTypes userTypes)
        {
            SqlParameter[] UserTypeParameters =
            {
                new SqlParameter
                {
                    ParameterName="UserTypeID",
                    Value = userTypes.UserTypeID
                },
                new SqlParameter
                {
                    ParameterName ="UserTypeName",
                    Value = userTypes.UserTypeName
                },

                new SqlParameter
                {
                    ParameterName = "UserTypeIsActive",
                    Value= userTypes.UserTypeIsActive
                },

                new SqlParameter
                {
                    ParameterName="UserTypeDescription",
                    Value = userTypes.UserTypeDescription
                }
            };

            int MyUserType = HotelHelperSQL.MyExecuteNonQuery("sp_UpdateUserType", "sp", UserTypeParameters);
            return MyUserType;
        }
        #endregion

        #region Delete
        public int DeleteUserType(UserTypes userTypes)
        {
            SqlParameter[] UserTypeParameters =
            {
                
                new SqlParameter
                {
                    ParameterName="UserTypeID",
                    Value = userTypes.UserTypeID
                }
            };

            int MyUserType = HotelHelperSQL.MyExecuteNonQuery("sp_DeleteUserType", "sp", UserTypeParameters);
            return MyUserType;
        }
        #endregion
    }
}
