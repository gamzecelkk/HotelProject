using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Campaigns
    {
        public int CampaignID { get; set; }
        public string CampaignName { get; set; }
        public decimal CampaignDiscount { get; set; }
        public DateTime CampaignStartDate { get; set; }
        public DateTime CampaignEndDate { get; set; }
        public bool CampaignIsActive { get; set; }
        public string CampaignDescription { get; set; }
    }
}
