using DataAccess;
using Entities.Concrete;
using Entities.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelUI.UI
{
    public partial class CampaignUI : Form
    {
        public CampaignUI()
        {
            InitializeComponent();
        }

        Campaigns campaigns = new Campaigns();
        CampaignDal campaignDal = new CampaignDal();

        private void LabelBack_MouseLeave(object sender, EventArgs e)
        {

        }

        private void LabelBack_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void LabelBack_MouseEnter(object sender, EventArgs e)
        {

        }

        private void buttonCampaignAdd_Click(object sender, EventArgs e)
        {
            campaigns.CampaignName = textCampaignName.Text;
            campaigns.CampaignDiscount = Convert.ToDecimal(textCampaignDiscount.Text);
            campaigns.CampaignStartDate = dateTimeStart.Value;
            campaigns.CampaignEndDate = dateTimeEnd.Value;
            campaigns.CampaignIsActive = checkCampaignActivity.Checked;
            campaigns.CampaignDescription = textCampaignDescription.Text;

            campaignDal.UpdateCampaign(campaigns);
        }

        private void buttonCampaignUpdate_Click(object sender, EventArgs e)
        {
            campaigns.CampaignID = Convert.ToInt32(textCampaignID.Text);
            campaigns.CampaignName = textCampaignName.Text;
            campaigns.CampaignDiscount = Convert.ToDecimal(textCampaignDiscount.Text);
            campaigns.CampaignStartDate = dateTimeStart.Value;
            campaigns.CampaignEndDate = dateTimeEnd.Value;
            campaigns.CampaignIsActive = checkCampaignActivity.Checked;
            campaigns.CampaignDescription = textCampaignDescription.Text;

            campaignDal.UpdateCampaign(campaigns);
        }

        private void buttonCampaignDelete_Click(object sender, EventArgs e)
        {
            campaigns.CampaignID = Convert.ToInt32(textCampaignID.Text);

            campaignDal.DeleteCampaign(campaigns);
        }

        private void buttonCampaignList_Click(object sender, EventArgs e)
        {
            campaigns = campaignDal.GetAllCampaigns();
            string[] entity =
            {
                campaigns.CampaignID.ToString(),
                campaigns.CampaignName,
                campaigns.CampaignDiscount.ToString(),
                campaigns.CampaignStartDate.ToString(),
                campaigns.CampaignEndDate.ToString(),
                campaigns.CampaignIsActive.ToString(),
                campaigns.CampaignDescription
            };

            ListViewItem listViewItem = new ListViewItem(entity);
            ListViewCampaign.Items.Add(listViewItem);
        }
    }
}
