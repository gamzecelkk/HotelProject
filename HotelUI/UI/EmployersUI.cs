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
using Entities.Concrete;
using Entities.View;
using HotelUI.Controls;

namespace HotelUI.UI
{
    public partial class EmployersUI : Form
    {
        public EmployersUI()
        {
            InitializeComponent();
        }

        #region Instance 

        //instance --> bir sınıftan üretilen nesneler

        Employers employers = new Employers();
        EmployerDal employerDal = new EmployerDal();
        EmployerView employerView = new EmployerView();

        #endregion

        #region Move Form

        private void EmployersUI_MouseDown(object sender, MouseEventArgs e)
        {
            ControlSettings.Move(this, e);
        }

        private void EmployersUI_MouseUp(object sender, MouseEventArgs e)
        {
            ControlSettings.Move(this, e);
        }

        private void EmployersUI_MouseMove(object sender, MouseEventArgs e)
        {
            ControlSettings.Move(this, e);
        }

        #endregion

        #region Back And Exit

        private void LabelExit_MouseClick(object sender, MouseEventArgs e)
        {
            ControlSettings.Exit();
        }

        private void LabelExit_MouseEnter(object sender, EventArgs e)
        {
            ControlSettings.Colors(LabelExit, true);
        }

        private void LabelExit_MouseLeave(object sender, EventArgs e)
        {
            ControlSettings.Colors(LabelExit,false);
        }

        private void LabelBack_MouseClick(object sender, MouseEventArgs e)
        {
            ControlSettings.Back(this);
        }

        private void LabelBack_MouseEnter(object sender, EventArgs e)
        {
            ControlSettings.Colors(LabelBack, true);
        }

        private void LabelBack_MouseLeave(object sender, EventArgs e)
        {
            ControlSettings.Colors(LabelBack,false);
        }


        #endregion

        #region Search With Identity

        private void ButtonSearchWithIdentity_Click(object sender, EventArgs e)
        {
            employerView.IdentityNumber = textEmployerIdentity.Text.Trim();
            employerView = employerDal.GetEmployersWithIdentity(employerView.IdentityNumber);


            string[] entities =
            {
               employerView.ID.ToString(),
               employerView.IdentityNumber,
               employerView.FirstName,
               employerView.LastName,
               employerView.BirthDate.ToString(),
               employerView.PhoneNumber,
               employerView.Email,
               employerView.Addres,
               employerView.Country.ToString(),
               employerView.City.ToString(),
               employerView.Street.ToString(),
               employerView.Gender.ToString(),
               employerView.Manager.ToString(),
               employerView.HourlySalary.ToString(),
               employerView.Salary.ToString(),
               employerView.Languages.ToString(),
               employerView.RegistryNumber.ToString(),
               employerView.StartDate.ToString(),
               employerView.QuitDate.ToString(),
               employerView.Activity.ToString(),
               employerView.Disability.ToString(),
               employerView.Descriptions,
               employerView.ContactName,
               employerView.ContactPhone,
        };

            ListViewItem listWithIdentity = new ListViewItem(entities);
            listViewEmployer.Items.Add(listWithIdentity);
        }

        #endregion

        #region Search With First Name

        private void ButtonSearchWithFirst_Click(object sender, EventArgs e)
        {
            employerView.FirstName = textEmployerFirstName.Text.Trim();
            employerView = employerDal.GetEmployersWithFirstName(employerView.FirstName);


            string[] entities =
            {
               employerView.ID.ToString(),
               employerView.IdentityNumber,
               employerView.FirstName,
               employerView.LastName,
               employerView.BirthDate.ToString(),
               employerView.PhoneNumber,
               employerView.Email,
               employerView.Addres,
               employerView.Country.ToString(),
               employerView.City.ToString(),
               employerView.Street.ToString(),
               employerView.Gender.ToString(),
               employerView.Manager.ToString(),
               employerView.HourlySalary.ToString(),
               employerView.Salary.ToString(),
               employerView.Languages.ToString(),
               employerView.RegistryNumber.ToString(),
               employerView.StartDate.ToString(),
               employerView.QuitDate.ToString(),
               employerView.Activity.ToString(),
               employerView.Disability.ToString(),
               employerView.Descriptions,
               employerView.ContactName,
               employerView.ContactPhone,
        };

            ListViewItem listWithFirstName = new ListViewItem(entities);
            listViewEmployer.Items.Add(listWithFirstName);
        }

        #endregion

        #region Search With Last Name

        private void ButtonSearchWithLast_Click(object sender, EventArgs e)
        {
            employerView.LastName = textEmployerLastName.Text.Trim();
            employerView = employerDal.GetEmployersWithLastName(employerView.LastName);


            string[] entities =
            {
               employerView.ID.ToString(),
               employerView.IdentityNumber,
               employerView.FirstName,
               employerView.LastName,
               employerView.BirthDate.ToString(),
               employerView.PhoneNumber,
               employerView.Email,
               employerView.Addres,
               employerView.Country.ToString(),
               employerView.City.ToString(),
               employerView.Street.ToString(),
               employerView.Gender.ToString(),
               employerView.Manager.ToString(),
               employerView.HourlySalary.ToString(),
               employerView.Salary.ToString(),
               employerView.Languages.ToString(),
               employerView.RegistryNumber.ToString(),
               employerView.StartDate.ToString(),
               employerView.QuitDate.ToString(),
               employerView.Activity.ToString(),
               employerView.Disability.ToString(),
               employerView.Descriptions,
               employerView.ContactName,
               employerView.ContactPhone,
        };

            ListViewItem listWithLastName = new ListViewItem(entities);
            listViewEmployer.Items.Add(listWithLastName);
        }

        #endregion

        #region Add Employer

        private void buttonAddEmployer_Click(object sender, EventArgs e)
        {
            try
            {
                employers.EmployerIdentityNumber = employerView.IdentityNumber;
                employers.EmployerFirstName = employerView.FirstName;
                employers.EmployerLastName = employerView.LastName;
                employers.EmployerBirthDate = employerView.BirthDate;
                employers.EmployerPhoneNumber = employerView.PhoneNumber;
                employers.EmployerEmail = employerView.Email;
                employers.EmployerAddress = employerView.Addres;
                employers.CountryID = employerView.Country;
                employers.CityID = employerView.City;
                employers.StreetID = employerView.Street;
                employers.RoleID = employerView.Languages;
                employers.GenderID = employerView.Gender;
                employers.ManagerID = employerView.Manager;
                employers.EmployerHourlySalary = employerView.HourlySalary;
                employers.EmployerSalary = employerView.Salary;
                employers.LanguageID = employerView.Languages;
                employers.EmployerRegistryNumber = employerView.RegistryNumber;
                employers.EmployerStartDate = employerView.StartDate;
                employers.EmployerQuitDate = employerView.QuitDate;
                employers.EmployerIsActive = employerView.Activity;
                employers.EmployerDisability = employerView.Disability;
                employers.EmployerDescription = employerView.Descriptions;
                employers.EmergencyContactName = employerView.ContactName;
                employers.EmergencyContactPhone = employerView.ContactPhone;

                employerDal.InsertEmployer(employers);
                Messages.Added(this.Text);
            }
            catch (Exception)
            {
                Messages.Error();
            }
            
        }

        #endregion

        #region Update Employer

        private void buttonUpdateEmployer_Click(object sender, EventArgs e)
        {
            try
            {
                employers.EmployerID = employerView.ID;
                employers.EmployerIdentityNumber = employerView.IdentityNumber;
                employers.EmployerFirstName = employerView.FirstName;
                employers.EmployerLastName = employerView.LastName;
                employers.EmployerBirthDate = employerView.BirthDate;
                employers.EmployerPhoneNumber = employerView.PhoneNumber;
                employers.EmployerEmail = employerView.Email;
                employers.EmployerAddress = employerView.Addres;
                employers.CountryID = employerView.Country;
                employers.CityID = employerView.City;
                employers.StreetID = employerView.Street;
                employers.RoleID = employerView.Languages;
                employers.GenderID = employerView.Gender;
                employers.ManagerID = employerView.Manager;
                employers.EmployerHourlySalary = employerView.HourlySalary;
                employers.EmployerSalary = employerView.Salary;
                employers.LanguageID = employerView.Languages;
                employers.EmployerRegistryNumber = employerView.RegistryNumber;
                employers.EmployerStartDate = employerView.StartDate;
                employers.EmployerQuitDate = employerView.QuitDate;
                employers.EmployerIsActive = employerView.Activity;
                employers.EmployerDisability = employerView.Disability;
                employers.EmployerDescription = employerView.Descriptions;
                employers.EmergencyContactName = employerView.ContactName;
                employers.EmergencyContactPhone = employerView.ContactPhone;

                employerDal.UpdateEmployer(employers);
                Messages.Updated(this.Text);
            }
            catch (Exception)
            {
                Messages.Error();
            }
            
        }

        #endregion

        #region Delete Employer

        private void buttonDeleteEmployer_Click(object sender, EventArgs e)
        {
            try
            {
                employers.EmployerID = employerView.ID;
                employerDal.DeleteEmployer(employers);
                Messages.Deleted(this.Text);
            }
            catch (Exception)
            {
                Messages.Error();
            }
            
        }

        #endregion

        #region List Employers

        private void buttonListEmployer_Click(object sender, EventArgs e)
        {
            try
            {
                employerView = employerDal.GetAllEmployers();

                string[] entities =
                {
                     employerView.ID.ToString(),
                     employerView.IdentityNumber,
                     employerView.FirstName,
                     employerView.LastName,
                     employerView.BirthDate.ToString(),
                     employerView.PhoneNumber,
                     employerView.Email,
                     employerView.Addres,
                     employerView.Country.ToString(),
                     employerView.City.ToString(),
                     employerView.Street.ToString(),
                     employerView.Gender.ToString(),
                     employerView.Manager.ToString(),
                     employerView.HourlySalary.ToString(),
                     employerView.Salary.ToString(),
                     employerView.Languages.ToString(),
                     employerView.RegistryNumber.ToString(),
                     employerView.StartDate.ToString(),
                     employerView.QuitDate.ToString(),
                     employerView.Activity.ToString(),
                     employerView.Disability.ToString(),
                     employerView.Descriptions,
                     employerView.ContactName,
                     employerView.ContactPhone,
                };

                ListViewItem listEmployers = new ListViewItem(entities);
                listViewEmployer.Items.Add(listEmployers);
                Messages.List(this.Text);
            }
            catch (Exception)
            {
                Messages.Error();
            }
            
        }

        #endregion

        #region City According To Country

        private void comboCountry_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string countryID = comboCountry.SelectedValue.ToString();
            ControlSettings.FillComboBox(comboCity, "select * from Cities where CountryID = " + countryID);
            comboCity.Enabled = true;
        }

        #endregion

        #region Streets According To City

        private void comboCity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string cityID = comboCity.SelectedValue.ToString();
            ControlSettings.FillComboBox(comboStreet, "select * from Streets where CityID = " + cityID);
            comboStreet.Enabled = true;
        }

        #endregion

        #region Fill ComboBox

        private void EmployersUI_Load(object sender, EventArgs e)
        {
            ControlSettings.FillComboBox(comboCountry, "select * from Countries");
            ControlSettings.FillComboBox(comboCity, "select * from Cities");
            ControlSettings.FillComboBox(comboStreet, "select * from Streets");
            ControlSettings.FillComboBox(comboRole, "select * from Roles");
            ControlSettings.FillComboBox(EComboGender, "select * from Genders");
            ControlSettings.FillComboBox(comboManager, "select * from Managers");
            ControlSettings.FillComboBox(comboEmployerLanguage, "select * from Languages");
        }

        #endregion

        #region ListView To Text

        private void listViewEmployer_DoubleClick(object sender, EventArgs e)
        {
            textEmployerID.Text                    = employerView.ID.ToString();
            textEmployerIdentity.Text              = employerView.IdentityNumber;
            textEmployerFirstName.Text             = employerView.FirstName;
            textEmployerLastName.Text              = employerView.LastName;
            employerBirthDate.Value                = employerView.BirthDate;
            textEmployerPhone.Text                 = employerView.PhoneNumber;
            textEmployerEMail.Text                 = employerView.Email;
            textEmployerAddress.Text               = employerView.Addres;
            comboCountry.SelectedValue             = employerView.Country;
            comboCity.SelectedValue                = employerView.City;
            comboStreet.SelectedValue              = employerView.Street;
            comboRole.SelectedValue                = employerView.Languages;
            EComboGender.SelectedValue             = employerView.Gender;
            comboManager.SelectedValue             = employerView.Manager;
            textEmployerHourlySalary.Text          = employerView.HourlySalary.ToString();
            textEmployerSalary.Text                = employerView.Salary.ToString();
            comboEmployerLanguage.SelectedValue    = employerView.Languages;
            textEmployerRegistry.Text              = employerView.RegistryNumber.ToString();
            EmployerDateStart.Value                = employerView.StartDate;
            EmployerDateQuit.Value                 = employerView.QuitDate;
            checkEmployerActive.Checked            = employerView.Activity;
            checkEmployerDisability.Checked        = employerView.Disability;
            textEmployerDescription.Text           = employerView.Descriptions.ToString();
            textEmployerContactName.Text           = employerView.ContactName;
            textEmployerContactPhone.Text          = employerView.ContactPhone;

        }

        #endregion

        
    }
}
