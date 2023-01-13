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
    public class CampaignDal
    {
        #region Read

        public Campaigns ReadMe(SqlDataReader campaignReader)
        {
            Campaigns myCampaign = new Campaigns();
            while (campaignReader.Read())
            {
                myCampaign.CampaignID = (int)campaignReader[0];
                myCampaign.CampaignName = (string)campaignReader[1];
                myCampaign.CampaignDiscount = (decimal)campaignReader[2];
                myCampaign.CampaignStartDate = (DateTime)campaignReader[3];
                myCampaign.CampaignEndDate = (DateTime)campaignReader[4];
                myCampaign.CampaignIsActive = (bool)campaignReader[5];
                myCampaign.CampaignDescription = (string)campaignReader[6];

            }
            return myCampaign;
        }

        #endregion

        #region Insert
        public int InsertCampaign(Campaigns campaigns)
        {
            SqlParameter[] CampaignsParameters =
            {
                new SqlParameter
                {
                    ParameterName ="CampaignName",
                    Value = campaigns.CampaignName
                },

                new SqlParameter
                {
                    ParameterName = "CampaignDiscount",
                    Value= campaigns.CampaignDiscount
                },

                new SqlParameter
                {
                    ParameterName="CampaignStartDate",
                    Value = campaigns.CampaignStartDate
                },
                new SqlParameter
                {
                    ParameterName ="CampaignEndDate",
                    Value = campaigns.CampaignEndDate
                },

                new SqlParameter
                {
                    ParameterName = "CampaignIsActive",
                    Value= campaigns.CampaignIsActive
                },

                new SqlParameter
                {
                    ParameterName="CampaignDescription",
                    Value = campaigns.CampaignDescription
                }
            };

            int MyCampaigns = HotelHelperSQL.MyExecuteNonQuery("sp_AddCampaign", "sp", CampaignsParameters);
            return MyCampaigns;
        }

        #endregion

        #region Update
        public int UpdateCampaign(Campaigns campaigns)
        {
            SqlParameter[] CampaignsParameters =
            {
                new SqlParameter
                {
                   ParameterName = "CampaignID",
                   Value = campaigns.CampaignID
                },
                new SqlParameter
                {
                    ParameterName ="CampaignName",
                    Value = campaigns.CampaignName
                },

                new SqlParameter
                {
                    ParameterName = "CampaignDiscount",
                    Value= campaigns.CampaignDiscount
                },

                new SqlParameter
                {
                    ParameterName="CampaignStartDate",
                    Value = campaigns.CampaignStartDate
                },
                new SqlParameter
                {
                    ParameterName ="CampaignEndDate",
                    Value = campaigns.CampaignEndDate
                },

                new SqlParameter
                {
                    ParameterName = "CampaignIsActive",
                    Value= campaigns.CampaignIsActive
                },

                new SqlParameter
                {
                    ParameterName="CampaignDescription",
                    Value = campaigns.CampaignDescription
                }
            };

            int MyCampaigns = HotelHelperSQL.MyExecuteNonQuery("sp_UpdateCampaign", "sp", CampaignsParameters);
            return MyCampaigns;
        }
        #endregion

        #region Delete
        public int DeleteCampaign(Campaigns campaigns)
        {
            SqlParameter[] CampaignsParameters =
            {
                new SqlParameter
                {
                   ParameterName = "CampaignID",
                   Value = campaigns.CampaignID
                }
            };

            int MyCampaigns = HotelHelperSQL.MyExecuteNonQuery("sp_DeleteCampaign", "sp", CampaignsParameters);
            return MyCampaigns;
        }
        #endregion

        #region All Campaigns

        public Campaigns GetAllCampaigns()
        {
            SqlDataReader campaignReader = HotelHelperSQL.MyExecuteReader("select * from Campaigns where CampaignIsActive = 1", "text", null);
            Campaigns allCampaigns = ReadMe(campaignReader);
            return allCampaigns;
        }

        #endregion
    }
}
