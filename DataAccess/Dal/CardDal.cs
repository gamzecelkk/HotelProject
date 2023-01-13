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
    public class CardDal
    {
        #region Read

        public CardView ReadMe(SqlDataReader cardReader)
        {
            CardView myCard = new CardView();
            while (cardReader.Read())
            {
                myCard.ID = (int)cardReader[0];
                myCard.Room = (int)cardReader[1];
                myCard.Activity = (bool)cardReader[2];
                myCard.Descriptions = (string)cardReader[3];

            }
            return myCard;
        }

        #endregion

        #region Insert
        public int InsertCard(Cards cards)
        {
            SqlParameter[] CardParameters =
            {
                new SqlParameter
                {
                    ParameterName ="RoomID",
                    Value = cards.RoomID
                },

                new SqlParameter
                {
                    ParameterName = "CardIsActive",
                    Value= cards.CardIsActive
                },

                new SqlParameter
                {
                    ParameterName="CardDescription",
                    Value = cards.CardDescription
                }
            };

            int MyCard = HotelHelperSQL.MyExecuteNonQuery("sp_AddCard", "sp", CardParameters);
            return MyCard;
        }

        #endregion

        #region Update
        public int UpdateCard(Cards cards)
        {
            SqlParameter[] CardParameters =
            {
                new SqlParameter
                {
                    ParameterName ="CardID",
                    Value = cards.CardID
                },
                new SqlParameter
                {
                    ParameterName ="RoomID",
                    Value = cards.RoomID
                },

                new SqlParameter
                {
                    ParameterName = "CardIsActive",
                    Value= cards.CardIsActive
                },

                new SqlParameter
                {
                    ParameterName="CardDescription",
                    Value = cards.CardDescription
                }
            };

            int MyCard = HotelHelperSQL.MyExecuteNonQuery("sp_UpdateCard", "sp", CardParameters);
            return MyCard;
        }
        #endregion

        #region Delete
        public int DeleteCard(Cards cards)
        {
            SqlParameter[] CardParameters =
            {
                new SqlParameter
                {
                    ParameterName ="CardID",
                    Value = cards.CardID
                },
            };

            int MyCard = HotelHelperSQL.MyExecuteNonQuery("sp_DeleteCard", "sp", CardParameters);
            return MyCard;
        }
        #endregion

        #region All Cards

        public CardView GetAllCards()
        {
            SqlDataReader cardReader = HotelHelperSQL.MyExecuteReader("select * from vw_Campaign where Activity = 1", "text", null);
            CardView allCard = ReadMe(cardReader);
            return allCard;
        }

        #endregion
    }
}
