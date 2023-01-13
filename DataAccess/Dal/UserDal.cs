using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UserDal
    {
        #region Login
        public int UserLogin(Users user )
        {
            SqlParameter[] UserParameters =
            {
                new SqlParameter
                {
                    ParameterName="UserEmail",
                    Value = user.UserEmail
                },
                new SqlParameter
                {
                    ParameterName = "UserPassword",
                    Value = user.UserPassword
                }, 

            };

            int MyUser = (int)HotelHelperSQL.MyExecuteSkalar("sp_UserLogin", "sp", UserParameters);
            return MyUser;
        }
        #endregion

        #region Forget Password

        //public Users ForgetPassword(string UserEmail)
        //{
        //    SqlParameter[] UserParameters =
        //    {
        //        new SqlParameter
        //        {
        //            ParameterName = "UserEmail",
        //            Value = UserEmail
        //        }
        //    };
        //    Users users = new Users();
        //    SqlDataReader UsersReader = HotelHelperSQL.MyExecuteReader("sp_ForgetPassword", "sp", UserParameters);
        //    users.UserEmail = (string)UsersReader[0];
        //    users.UserPassword = (string)UsersReader[1];
        //    return users ;
        //}

        #endregion

        #region PasswordReset

        public string PasswordReset(Users users)
        {
            SqlParameter[] UserParameters =
            {
                new SqlParameter
                {
                    ParameterName = "UserEmail",
                    Value= users.UserEmail
                },
                new SqlParameter
                {
                    ParameterName = "TempPassword",
                    Value = users.UserPassword
                }
            };

            string MyUser = (string)HotelHelperSQL.MyExecuteSkalar("sp_PasswordReset", "sp", UserParameters);
            return MyUser;
        }

        #endregion

        #region Insert
        public int InsertUser(Users users)
        {
            SqlParameter[] UserParameters =
            {
                new SqlParameter
                {
                    ParameterName ="UserName",
                    Value = users.UserName
                },

                new SqlParameter
                {
                    ParameterName = "UserPassword",
                    Value= users.UserPassword
                },

                new SqlParameter
                {
                    ParameterName="UserEmail",
                    Value = users.UserEmail
                },

                new SqlParameter
                {
                    ParameterName ="UserEmailOK",
                    Value = users.UserEmailOK
                },

                new SqlParameter
                {
                    ParameterName = "UserPhoneNumber",
                    Value= users.UserPhoneNumber
                },

                new SqlParameter
                {
                    ParameterName="UserEnrollDate",
                    Value = users.UserEnrollDate
                },
                new SqlParameter
                {
                    ParameterName ="UserLastLoginDate",
                    Value = users.UserLastLoginDate
                },

                new SqlParameter
                {
                    ParameterName = "ImageID",
                    Value= users.ImageID
                },

                new SqlParameter
                {
                    ParameterName="UserTypeID",
                    Value = users.UserTypeID
                },
                new SqlParameter
                {
                    ParameterName = "UserIsActive",
                    Value= users.UserIsActive
                },

                new SqlParameter
                {
                    ParameterName="UserDescription",
                    Value = users.UserDescription
                }
            };

            int MyUser = HotelHelperSQL.MyExecuteNonQuery("sp_AddUser", "sp", UserParameters);
            return MyUser;
        }
        #endregion

        #region Update
        public int UpdateUser(Users users)
        {
            SqlParameter[] UserParameters =
            {
                new SqlParameter
                {
                    ParameterName="UserID",
                    Value=users.UserID
                },
                new SqlParameter
                {
                    ParameterName ="UserName",
                    Value = users.UserName
                },

                new SqlParameter
                {
                    ParameterName = "UserPassword",
                    Value= users.UserPassword
                },

                new SqlParameter
                {
                    ParameterName="UserEmail",
                    Value = users.UserEmail
                },

                new SqlParameter
                {
                    ParameterName ="UserEmailOK",
                    Value = users.UserEmailOK
                },

                new SqlParameter
                {
                    ParameterName = "UserPhoneNumber",
                    Value= users.UserPhoneNumber
                },

                new SqlParameter
                {
                    ParameterName="UserEnrollDate",
                    Value = users.UserEnrollDate
                },
                new SqlParameter
                {
                    ParameterName ="UserLastLoginDate",
                    Value = users.UserLastLoginDate
                },

                new SqlParameter
                {
                    ParameterName = "ImageID",
                    Value= users.ImageID
                },

                new SqlParameter
                {
                    ParameterName="UserTypeID",
                    Value = users.UserTypeID
                },
                new SqlParameter
                {
                    ParameterName = "UserIsActive",
                    Value= users.UserIsActive
                },

                new SqlParameter
                {
                    ParameterName="UserDescription",
                    Value = users.UserDescription
                }
            };

            int MyUser = HotelHelperSQL.MyExecuteNonQuery("sp_UpdateUser", "sp", UserParameters);
            return MyUser;
        }
        #endregion

        #region Delete
        public int DeleteUser(Users users)
        {
            SqlParameter[] UserParameters =
            {
                new SqlParameter
                {
                    ParameterName ="UserID",
                    Value = users.UserID
                }
            };

            int MyUser = HotelHelperSQL.MyExecuteNonQuery("sp_DeleteUser", "sp", UserParameters);
            return MyUser;
        }
        #endregion
    }
}
