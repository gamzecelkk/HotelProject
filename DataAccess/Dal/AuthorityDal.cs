using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Entities.View;


namespace DataAccess
{
    public class AuthorityDal
    {
        #region Read

        public Authorities ReadMe(SqlDataReader authorityReader)
        {
            Authorities myAuthority = new Authorities();
            while (authorityReader.Read())
            {
                myAuthority.AuthorityID = (int)authorityReader[0];
                myAuthority.AuthorityName = (string)authorityReader[1];
                myAuthority.AuthorityAccessCode = (string)authorityReader[2];
                myAuthority.AuthorityIsActive = (bool)authorityReader[3];
                myAuthority.AuthorityDescription = (string)authorityReader[4];

            }
            return myAuthority;
        }

        #endregion

        #region Insert
        public int InsertAuthority(Authorities authorities)
        {
            SqlParameter[] authorityParameters =
            {
                new SqlParameter
                {
                    ParameterName ="AuthorityName",
                    Value = authorities.AuthorityName
                },

                new SqlParameter
                {
                    ParameterName = "AuthorityAccess",
                    Value= authorities.AuthorityAccessCode
                },
                new SqlParameter
                {
                    ParameterName = "AuthorityIsActive",
                    Value= authorities.AuthorityIsActive
                },
                new SqlParameter
                {
                    ParameterName = "AuthorityDescription",
                    Value = authorities.AuthorityDescription
                }
            };

            int authorityInserted = HotelHelperSQL.MyExecuteNonQuery("sp_AddAuthority", "sp", authorityParameters);
            return authorityInserted;
        }

        #endregion

        #region Update
        public int UpdateAuthority(Authorities authorities)
        {
            SqlParameter[] authorityParameters =
            {
                new SqlParameter
                {
                    ParameterName = "AuthorityID",
                    Value = authorities.AuthorityID

                },
                new SqlParameter
                {
                    ParameterName ="AuthorityName",
                    Value = authorities.AuthorityName
                },

                new SqlParameter
                {
                    ParameterName = "AuthorityAccess",
                    Value= authorities.AuthorityAccessCode
                },
                
                new SqlParameter
                {
                    ParameterName = "AuthorityDescription",
                    Value = authorities.AuthorityDescription
                }
            };
            int authorityUpdated = HotelHelperSQL.MyExecuteNonQuery("sp_UpdateAuthority", "sp", authorityParameters);
            return authorityUpdated;

        }
        #endregion

        #region Delete
        public int DeleteAuthority(Authorities authorities)
        {
            SqlParameter[] authorityParameters =
            {
                new SqlParameter
                {
                    ParameterName = "AuthorityID",
                    Value = authorities.AuthorityID
                }
            };

            int authorityDeleted = HotelHelperSQL.MyExecuteNonQuery("sp_DeleteAuthority", "sp", authorityParameters);
            return authorityDeleted;
        }
        #endregion

        #region All Authorities

        public Authorities GetAllAuthorities()
        {
            SqlDataReader authorityReader = HotelHelperSQL.MyExecuteReader("select * from Authorities ", "text", null);
            Authorities allAuthorities = ReadMe(authorityReader);
            return allAuthorities;
        }

        #endregion
    }
}
