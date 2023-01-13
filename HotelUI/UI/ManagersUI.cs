using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using Entities.View;
using Entities.Concrete;
using HotelUI.Controls;


namespace HotelUI.UI
{
    public partial class ManagersUI : Form
    {
        public ManagersUI()
        {
            InitializeComponent();
        }

        #region Move Form

        private void ManagersUI_MouseUp(object sender, MouseEventArgs e)
        {
            ControlSettings.Mouse(false, e);
        }

        private void ManagersUI_MouseMove(object sender, MouseEventArgs e)
        {
            ControlSettings.Move(this, e);
        }

        private void ManagersUI_MouseDown(object sender, MouseEventArgs e)
        {
            ControlSettings.Mouse(true, e);
        }

        #endregion 

        #region Back and Exit

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

        private void LabelBack_MouseLeave(object sender, EventArgs e)
        {
            ControlSettings.Colors(LabelBack, false);
        }

        private void LabelBack_MouseEnter(object sender, EventArgs e)
        {
            ControlSettings.Colors(LabelBack,true);
        }

        private void LabelBack_MouseClick(object sender, MouseEventArgs e)
        {
            ControlSettings.Back(this);
        }

        #endregion

        #region Instance

        Managers managers = new Managers();
        ManagerDal managerDal = new ManagerDal();
        ManagerView managerView = new ManagerView();

        #endregion

        #region Search

        private void ButtonSearchIdentity_Click(object sender, EventArgs e)
        {
            managerView.IdentityNumber = MTextIdentity.Text.Trim();
            managerView = managerDal.GetManagersWithIdentity(managerView.IdentityNumber);

            MTextID.Text = managerView.ManagerID.ToString();
            MTextIdentity.Text = managerView.IdentityNumber;
            MTextFirstName.Text = managerView.FirstName;
            MTextLastName.Text = managerView.LastName;
            MTextPhone.Text = managerView.PhoneNumber;
            MTextEMail.Text = managerView.Email;
            MTextAddress.Text = managerView.Addres;
            MDateBirth.Value = managerView.BirthDate;
            MComboCountry.SelectedValue = managerView.Country;
            MComboCity.SelectedValue = managerView.City;
            MComboStreet.SelectedValue = managerView.Street;
            MComboRole.SelectedValue = managerView.Role;
            MComboGender.SelectedValue = managerView.Gender;
            MTextSalary.Text = managerView.Salary.ToString();
            MDateStart.Value = managerView.StartDate;
            MDateQuit.Value = managerView.QuitDate;
            MCheckActive.Checked = managerView.Activity;
            MTextDescription.Text = managerView.Descriptions;
            MComboLanguage.SelectedValue = managerView.Languages;


        }

        private void ButtonSearchFirstName_Click(object sender, EventArgs e)
        {
            managerView.FirstName = MTextFirstName.Text.Trim();
            managerDal.GetManagersWithFirstName(managerView.FirstName);

            MTextID.Text = managers.ManagerID.ToString();
            MTextIdentity.Text = managers.ManagerIdentityNumber;
            MTextFirstName.Text = managers.ManagerFirstName;
            MTextLastName.Text = managers.ManagerLastName;
            MTextPhone.Text = managers.ManagerPhoneNumber;
            MTextEMail.Text = managers.ManagerEmail;
            MTextAddress.Text = managers.ManagerAddress;
            MDateBirth.Value = managers.ManagerBirthDate;
            MComboCountry.SelectedValue = managers.CountryID;
            MComboCity.SelectedValue = managers.CityID;
            MComboStreet.SelectedValue = managers.StreetID;
            MComboRole.SelectedValue = managers.RoleID;
            MComboGender.SelectedValue = managers.GenderID;
            MTextSalary.Text = managers.ManagerSalary.ToString();
            MDateStart.Value = managers.ManagerStartDate;
            MDateQuit.Value = managers.ManagerQuitDate;
            MCheckActive.Checked = managers.ManagerIsActive;
            MTextDescription.Text = managers.ManagerDescription;
            MComboLanguage.SelectedValue = managerView.Languages;
        }

        private void ButtonSearchLastName_Click(object sender, EventArgs e)
        {
            managerView.LastName = MTextLastName.Text.Trim();
            managerDal.GetManagerWithLastName(managerView.LastName);

            MTextID.Text = managers.ManagerID.ToString();
            MTextIdentity.Text = managers.ManagerIdentityNumber;
            MTextFirstName.Text = managers.ManagerFirstName;
            MTextLastName.Text = managers.ManagerLastName;
            MTextPhone.Text = managers.ManagerPhoneNumber;
            MTextEMail.Text = managers.ManagerEmail;
            MTextAddress.Text = managers.ManagerAddress;
            MDateBirth.Value = managers.ManagerBirthDate;
            MComboCountry.SelectedValue = managers.CountryID;
            MComboCity.SelectedValue = managers.CityID;
            MComboStreet.SelectedValue = managers.StreetID;
            MComboRole.SelectedValue = managers.RoleID;
            MComboGender.SelectedValue = managers.GenderID;
            MTextSalary.Text = managers.ManagerSalary.ToString();
            MDateStart.Value = managers.ManagerStartDate;
            MDateQuit.Value = managers.ManagerQuitDate;
            MCheckActive.Checked = managers.ManagerIsActive;
            MTextDescription.Text = managers.ManagerDescription;
            MComboLanguage.SelectedValue = managerView.Languages;
        }

        #endregion

        #region Add
        private void MButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                managers.ManagerIdentityNumber = MTextIdentity.Text;
                managers.ManagerFirstName = MTextFirstName.Text;
                managers.ManagerLastName = MTextLastName.Text;
                managers.ManagerPhoneNumber = MTextPhone.Text;
                managers.ManagerEmail = MTextEMail.Text;
                managers.ManagerAddress = MTextAddress.Text;
                managers.ManagerBirthDate = MDateBirth.Value;
                managers.CountryID = (int)MComboCountry.SelectedValue;
                managers.CityID = (int)MComboCity.SelectedValue;
                managers.StreetID = (int)MComboStreet.SelectedValue;
                managers.RoleID = (int)MComboRole.SelectedValue;
                managers.GenderID = (int)MComboGender.SelectedValue;
                managers.ManagerSalary = Convert.ToDecimal(MTextSalary.Text);
                managers.ManagerStartDate = MDateStart.Value;
                managers.ManagerQuitDate = MDateQuit.Value;
                managers.ManagerIsActive = MCheckActive.Checked;
                managers.ManagerDescription = MTextDescription.Text;
                managers.LanguageID = (int)MComboLanguage.SelectedValue;

                managerDal.InsertManagers(managers);
                Messages.Added(this.Text);
            }
            catch (Exception )
            {
                Messages.Error();
            }
            

        }

        #endregion
       
        #region Update

        private void MButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                managers.ManagerIdentityNumber = MTextIdentity.Text;
                managers.ManagerFirstName = MTextFirstName.Text;
                managers.ManagerLastName = MTextLastName.Text;
                managers.ManagerPhoneNumber = MTextPhone.Text;
                managers.ManagerEmail = MTextEMail.Text;
                managers.ManagerAddress = MTextAddress.Text;
                managers.ManagerBirthDate = MDateBirth.Value;
                managers.CountryID = (int)MComboCountry.SelectedValue;
                managers.CityID = (int)MComboCity.SelectedValue;
                managers.StreetID = (int)MComboStreet.SelectedValue;
                managers.RoleID = (int)MComboRole.SelectedValue;
                managers.GenderID = (int)MComboGender.SelectedValue;
                managers.ManagerSalary = Convert.ToDecimal(MTextSalary.Text);
                managers.ManagerStartDate = MDateStart.Value;
                managers.ManagerQuitDate = MDateQuit.Value;
                managers.ManagerIsActive = MCheckActive.Checked;
                managers.ManagerDescription = MTextDescription.Text;

                managerDal.UpdateManagers(managers);
                Messages.Updated(this.Text);
            }
            catch (Exception)
            {
                Messages.Error();
            }
            
            
        }

        #endregion

        #region Delete

        private void MButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                managers.ManagerIdentityNumber = MTextIdentity.Text;
                managerDal.DeleteManager(managers);
                Messages.Deleted(this.Text);
            }
            catch (Exception)
            {
                Messages.Error();
            }
            
            
        }

        #endregion

        #region Fill ComboBox

        private void ManagersUI_Load(object sender, EventArgs e)
        {
            ControlSettings.FillComboBox(MComboCountry,"select * from Countries");
            ControlSettings.FillComboBox(MComboCity, "select * from Cities");
            ControlSettings.FillComboBox(MComboStreet, "select * from Streets");
            ControlSettings.FillComboBox(MComboRole, "select * from Roles");
            ControlSettings.FillComboBox(MComboGender, "select * from Genders");
            ControlSettings.FillComboBox(MComboLanguage, "select * from Languages");
        }

        #endregion

        #region List Manager

        private void buttonManagerList_Click(object sender, EventArgs e)
        {
            try
            {
                managerView = managerDal.GetAllManagers();
                string[] entity =
                {
                managerView.ManagerID.ToString(),
                managerView.IdentityNumber.ToString(),
                managerView.FirstName,
                managerView.LastName,
                managerView.PhoneNumber,
                managerView.Email,
                managerView.Addres,
                managerView.BirthDate.ToString(),
                managerView.Country.ToString(),
                managerView.City.ToString(),
                managerView.Street.ToString(),
                managerView.Role.ToString(),
                managerView.Gender.ToString(),
                managerView.Salary.ToString(),
                managerView.StartDate.ToString(),
                managerView.QuitDate.ToString(),
                managerView.Activity.ToString(),
                managerView.Descriptions,
                managerView.Languages.ToString(),
            };


                ListViewItem listViewItem = new ListViewItem(entity);
                listViewManager.Items.Add(listViewItem);
                Messages.List(this.Text);
            }
            catch (Exception)
            {
                Messages.Error();
            }
            
        }

        #endregion

        #region Fill Cities According To Countries

        private void MComboCountry_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string countryID = MComboCountry.SelectedValue.ToString();
            ControlSettings.FillComboBox(MComboCity, "select * from Cities where CountryID = " + countryID);
            MComboCity.Enabled = true;
        }

        #endregion

        #region Fill Streets According To Cities

        private void MComboCity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string cityID = MComboCity.SelectedValue.ToString();
            ControlSettings.FillComboBox(MComboStreet, "select * from Streets where CityID = " + cityID);
            MComboStreet.Enabled = true;
        }

        #endregion

       
    }
}
