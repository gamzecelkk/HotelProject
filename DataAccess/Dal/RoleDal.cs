using Entities.Concrete;
using Entities.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RoleDal
    {
        #region Read

        public RoleView ReadMe(SqlDataReader rolesReader)
        {
            RoleView myRoles = new RoleView();
            while (rolesReader.Read())
            {
                myRoles.ID = (int)rolesReader[0];
                myRoles.RoleType = (string)rolesReader[1];
                myRoles.Activity = (bool)rolesReader[2];
                myRoles.Descriptions = (string)rolesReader[3];

            }
            return myRoles;
        }

        #endregion

        #region Insert
        public int InsertRole(Roles roles)
        {
            SqlParameter[] roleParameters =
            {
                new SqlParameter
                {
                    ParameterName ="RoleName",
                    Value = roles.RoleName
                },

                new SqlParameter
                {
                    ParameterName = "RoleIsActive",
                    Value= roles.RoleIsActive
                },

                new SqlParameter
                {
                    ParameterName="RoleDescription",
                    Value = roles.RoleDescription
                }
            };

            int roleInserted = HotelHelperSQL.MyExecuteNonQuery("sp_AddRole", "sp", roleParameters);
            return roleInserted;
        }
        #endregion

        #region Update
        public int UpdateRole(Roles roles)
        {
            SqlParameter[] RoleParameters =
            {
                new SqlParameter
                {
                    ParameterName ="RoleID",
                    Value = roles.RoleID
                },
                new SqlParameter
                {
                    ParameterName ="RoleName",
                    Value = roles.RoleName
                },

                new SqlParameter
                {
                    ParameterName = "RoleIsActive",
                    Value= roles.RoleIsActive
                },

                new SqlParameter
                {
                    ParameterName="RoleDescription",
                    Value = roles.RoleDescription
                }
            };

            int MyRole = HotelHelperSQL.MyExecuteNonQuery("sp_UpdateRole", "sp", RoleParameters);
            return MyRole;
        }
        #endregion

        #region Delete
        public int DeleteRole(Roles roles)
        {
            SqlParameter[] RoleParameters =
            {
                new SqlParameter
                {
                    ParameterName ="RoleID",
                    Value = roles.RoleID
                }
            };

            int MyRole = HotelHelperSQL.MyExecuteNonQuery("sp_DeleteRole", "sp", RoleParameters);
            return MyRole;
        }
        #endregion

        #region All Roles

        public RoleView GetAllRoles()
        {
            SqlDataReader rolesReader = HotelHelperSQL.MyExecuteReader("select * from vw_Roles where Activity = 1", "text", null);
            RoleView allRoles = ReadMe(rolesReader);
            return allRoles;
        }

        #endregion
    }
}
