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
    public class SystemCardDal
    {
        #region Read

        public SystemCardView ReadMe(SqlDataReader systemCardsReader)
        {
            SystemCardView mySystemCard = new SystemCardView();
            while (systemCardsReader.Read())
            {
                mySystemCard.ID = (int)systemCardsReader[0];
                mySystemCard.AccessCode = (string)systemCardsReader[1];
                mySystemCard.EmployerID = (int)systemCardsReader[2];
                mySystemCard.Activity = (bool)systemCardsReader[3];
                mySystemCard.Descriptions = (string)systemCardsReader[4];

            }
            return mySystemCard;
        }

        #endregion

        #region Insert
        public int InsertSystemCard(SystemCards systemCards)
        {
            SqlParameter[] SystemCardParameters =
            {
                new SqlParameter
                {
                    ParameterName ="SystemCardAccessCode",
                    Value = systemCards.SystemCardAccessCode
                },

                new SqlParameter
                {
                    ParameterName = "EmployerID",
                    Value= systemCards.EmployerID
                },

                new SqlParameter
                {
                    ParameterName="SystemCardIsActive",
                    Value = systemCards.SystemCardIsActive
                },
                new SqlParameter
                {
                    ParameterName="SystemCardDescription",
                    Value = systemCards.SystemCardDescription
                }
            };

            int MySystemCard = HotelHelperSQL.MyExecuteNonQuery("sp_AddSystemCard", "sp", SystemCardParameters);
            return MySystemCard;
            
        }
        #endregion

        #region Update
        public int UpdateSystemCard(SystemCards systemCards)
        {
            SqlParameter[] SystemCardParameters =
            {
                new SqlParameter
                {
                    ParameterName ="SystemCardID",
                    Value = systemCards.SystemCardID
                },
                new SqlParameter
                {
                    ParameterName ="SystemCardAccessCode",
                    Value = systemCards.SystemCardAccessCode
                },

                new SqlParameter
                {
                    ParameterName = "EmployerID",
                    Value= systemCards.EmployerID
                },

                new SqlParameter
                {
                    ParameterName="SystemCardIsActive",
                    Value = systemCards.SystemCardIsActive
                },
                new SqlParameter
                {
                    ParameterName="SystemCardDescription",
                    Value = systemCards.SystemCardDescription
                }
            };

            int MySystemCard = HotelHelperSQL.MyExecuteNonQuery("sp_UpdateSystemCard", "sp", SystemCardParameters);
            return MySystemCard;
            
        }
        #endregion

        #region Delete
        public int DeleteSystemCard(SystemCards systemCards)
        {
            SqlParameter[] SystemCardParameters =
            {
                new SqlParameter
                {
                    ParameterName ="SystemCardID",
                    Value = systemCards.SystemCardID
                }
            };

            int MySystemCard = HotelHelperSQL.MyExecuteNonQuery("sp_DeleteSystemCard", "sp", SystemCardParameters);
            return MySystemCard;
            
        }
        #endregion

        #region All SystemCard

        public SystemCardView GetAllSystemCards()
        {
            SqlDataReader systemCardsReader = HotelHelperSQL.MyExecuteReader("select * from vw_SystemCards where Activity = 1", "text", null);
            SystemCardView allSystemCards = ReadMe(systemCardsReader);
            return allSystemCards;
        }

        #endregion
    }
}
