using HotelUI.Controls;
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
    public partial class HomeUI : Form
    {
        public HomeUI()
        {
            InitializeComponent();
        }

        #region Exit
        private void LabelExit_MouseLeave(object sender, EventArgs e)
        {
            ControlSettings.Colors(LabelExit, false);
        }

        private void LabelExit_MouseEnter(object sender, EventArgs e)
        {
            ControlSettings.Colors(LabelExit, true);
        }

        private void LabelExit_MouseClick(object sender, MouseEventArgs e)
        {
            ControlSettings.Exit();
        }

        #endregion

        #region Move Form

        private void HomeUI_MouseUp(object sender, MouseEventArgs e)
        {
            ControlSettings.Mouse(false, e);
        }

        private void HomeUI_MouseMove(object sender, MouseEventArgs e)
        {
            ControlSettings.Move(this, e);
        }

        private void HomeUI_MouseDown(object sender, MouseEventArgs e)
        {
            ControlSettings.Mouse(true, e);
        }

        #endregion

        #region Open Form

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            ControlSettings.Open(new LoginUI(), this);
        }

        private void ButtonControl_Click(object sender, EventArgs e)
        {
            ControlSettings.Open(new PanelUI(), this);
        }

        private void ButtonUsers_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSetting_Click(object sender, EventArgs e)
        {

        }

        private void ButtonManagers_Click(object sender, EventArgs e)
        {
            ControlSettings.Open(new ManagersUI(), this);
        }

        private void ButtonEmployers_Click(object sender, EventArgs e)
        {
            ControlSettings.Open(new EmployersUI(), this);
        }

        private void ButtonCustomers_Click(object sender, EventArgs e)
        {
            ControlSettings.Open(new CustomersUI(), this);
        }

        private void ButtonGuests_Click(object sender, EventArgs e)
        {

        }

        private void ButtonRooms_Click(object sender, EventArgs e)
        {
            ControlSettings.Open(new RoomsUI(), this);
        }

        private void ButtonReservations_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCampaigns_Click(object sender, EventArgs e)
        {

        }

        private void ButtonShifts_Click(object sender, EventArgs e)
        {

        }

        private void ButtonExtras_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonSales_Click(object sender, EventArgs e)
        {
            ControlSettings.Open(new SaleUI(), this);
        }
        #endregion

    }
}
