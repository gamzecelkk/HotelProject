using DataAccess;
using Entities.Concrete;
using Entities.View;
using HotelUI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelUI.UI
{
    public partial class CustomersUI : Form
    {
        
        public CustomersUI()
        {
            InitializeComponent();
        }

        #region Move Form

        private void CustomersUI_MouseDown(object sender, MouseEventArgs e)
        {
            ControlSettings.Mouse(true, e);
        }

        private void CustomersUI_MouseMove(object sender, MouseEventArgs e)
        {
            ControlSettings.Move(this, e);
        }

        private void CustomersUI_MouseUp(object sender, MouseEventArgs e)
        {
            ControlSettings.Mouse(false, e);
        }

        #endregion

        #region Back And Exit
        private void LabelBack_MouseLeave(object sender, EventArgs e)
        {
            ControlSettings.Colors(LabelBack, false);
        }

        private void LabelBack_MouseEnter(object sender, EventArgs e)
        {
            ControlSettings.Colors(LabelBack, true);
        }

        private void LabelBack_MouseClick(object sender, MouseEventArgs e)
        {
            ControlSettings.Back(this);
        }

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

        #region Instance 

        //instance --> bir sınıftan üretilen nesneler

        Customers customer = new Customers();
        CustomerDal customerDal = new CustomerDal();
        CustomerView customerViews = new CustomerView();

        #endregion

        #region List Customer

        private void CButtonList_Click(object sender, EventArgs e)
        {
            try
            {
                customerViews = customerDal.GetAllCustomers();
                string[] entity =
                {
                customerViews.ID.ToString(),
                customerViews.IdentityNumber.ToString(),
                customerViews.FirstName,
                customerViews.LastName,
                customerViews.BirthDate.ToString(),
                customerViews.PhoneNumber,
                customerViews.Email,
                customerViews.Addres,
                customerViews.IsCompany.ToString(),
                customerViews.Company,
                customerViews.TaxNumber,
                customerViews.Country.ToString(),
                customerViews.City.ToString(),
                customerViews.Street.ToString(),
                customerViews.Languages.ToString(),
                customerViews.Gender.ToString(),
                customerViews.Activity.ToString(),
                customerViews.Descriptions
            };


                ListViewItem listViewItem = new ListViewItem(entity);
                listViewCustomer.Items.Add(listViewItem);
                Messages.List(this.Text);
            }
            catch (Exception)
            {
                Messages.Error();
            }
            
        }

        #endregion

        #region Update Customer

        private void CButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                customer.CustomerIdentityNumber = CTextIdentity.Text;
                customer.CustomerFirstName = CTextFirstName.Text;
                customer.CustomerLastName = CTextLastName.Text;

                customer.CustomerBirthDate = CDateBirth.Value;
                customer.CustomerPhoneNumber = CTextPhone.Text;
                customer.CustomerEmail = CTextEMail.Text;

                customer.CustomerAddress = CTextAddress.Text;
                customer.CustomerIsCompany = CCheckActive.Checked;
                customer.CustomerCompanyName = CTextCompanyName.Text;

                customer.CompanyTaxNumber = CTextTax.Text;
                customer.CountryID = (int)CComboCountry.SelectedValue;
                customer.CityID = (int)CComboCity.SelectedValue;

                customer.StreetID = (int)CComboStreet.SelectedValue;
                customer.LanguageID = (int)CComboLanguage.SelectedValue;
                customer.GenderID = (int)CComboGender.SelectedValue;

                customer.CustomerIsActive = CCheckActive.Checked;
                customer.CustomerDescription = CTextDescription.Text;

                customerDal.UpdateCustomer(customer);
                Messages.Updated(this.Text);
            }
            catch (Exception )
            {
                Messages.Error();
            }
            
        }

        #endregion

        #region Fill 

        private void CustomersUI_Load(object sender, EventArgs e)
        {
            ControlSettings.FillComboBox(CComboCountry,"select * from Countries");
            ControlSettings.FillComboBox(CComboCity, "select * from Cities");
            ControlSettings.FillComboBox(CComboStreet, "select * from Streets");
            ControlSettings.FillComboBox(CComboLanguage, "select * from Languages");
            ControlSettings.FillComboBox(CComboGender, "select * from Genders");
        }

        #endregion

        #region Search Identity Number

        private void SearchIdentityNumber_Click(object sender, EventArgs e)
        {
            customerViews.IdentityNumber = CTextIdentity.Text.Trim();
            customerViews = customerDal.GetCustomerWithIdentity(customerViews.IdentityNumber);

            CTextID.Text = customerViews.ID.ToString();
            CTextIdentity.Text = customerViews.IdentityNumber;
            CTextFirstName.Text = customerViews.FirstName;
            CTextLastName.Text = customerViews.LastName;
            CDateBirth.Value = customerViews.BirthDate;
            CTextPhone.Text = customerViews.PhoneNumber;
            CTextEMail.Text = customerViews.Email;
            CTextAddress.Text = customerViews.Addres;
            CheckCompany.Checked = customerViews.IsCompany;
            CTextCompanyName.Text = customerViews.Company;
            CTextTax.Text = customerViews.TaxNumber;
            CComboCountry.SelectedValue = customerViews.Country;
            CComboCity.SelectedValue = customerViews.City;
            CComboStreet.SelectedValue = customerViews.Street;
            CComboLanguage.SelectedValue = customerViews.Languages;
            CComboGender.SelectedValue = customerViews.Gender;
            CCheckActive.Checked = customerViews.Activity;
            CTextDescription.Text = customerViews.Descriptions;

        }

        #endregion

        #region Add Customer

        private void CButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                customer.CustomerIdentityNumber = CTextIdentity.Text;
                customer.CustomerFirstName = CTextFirstName.Text;
                customer.CustomerLastName = CTextLastName.Text;

                customer.CustomerBirthDate = CDateBirth.Value;
                customer.CustomerPhoneNumber = CTextPhone.Text;
                customer.CustomerEmail = CTextEMail.Text;

                customer.CustomerAddress = CTextAddress.Text;
                customer.CustomerIsCompany = CCheckActive.Checked;
                customer.CustomerCompanyName = CTextCompanyName.Text;

                customer.CompanyTaxNumber = CTextTax.Text;
                customer.CountryID = (int)CComboCountry.SelectedValue;
                customer.CityID = (int)CComboCity.SelectedValue;

                customer.StreetID = (int)CComboStreet.SelectedValue;
                customer.LanguageID = (int)CComboLanguage.SelectedValue;
                customer.GenderID = (int)CComboGender.SelectedValue;

                customer.CustomerIsActive = CCheckActive.Checked;
                customer.CustomerDescription = CTextDescription.Text;

                customerDal.InsertCustomer(customer);
                Messages.Added(this.Text);
            }
            catch (Exception)
            {
                Messages.Error();
            }
            

        }

        #endregion

        #region Delete Customer

        private void CButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                customer.CustomerIdentityNumber = CTextIdentity.Text;
                customerDal.DeleteCustomerWithIdentityNumber(customer);
                Messages.Deleted(this.Text);
            }
            catch (Exception)
            {
                Messages.Error();
            }
            
        }

        #endregion

        #region Search First Name

        private void SearchFirstName_Click(object sender, EventArgs e)
        {
            customerViews.FirstName = CTextFirstName.Text.Trim();
            customerViews = customerDal.GetCustomerWithFirstName(customerViews.FirstName);

            string[] entities =
            {
               customerViews.ID.ToString(),
               customerViews.IdentityNumber,
               customerViews.FirstName,
               customerViews.LastName,
               customerViews.BirthDate.ToString(),
               customerViews.PhoneNumber,
               customerViews.Email,
               customerViews.Addres,
               customerViews.IsCompany.ToString(),
               customerViews.Company,
               customerViews.TaxNumber,
               customerViews.Country.ToString(),
               customerViews.City.ToString(),
               customerViews.Street.ToString(),
               customerViews.Languages.ToString(),
               customerViews.Gender.ToString(),
               customerViews.Activity.ToString(),
               customerViews.Descriptions
            };

            ListViewItem listWithFirstName = new ListViewItem(entities);
            listViewCustomer.Items.Add(listWithFirstName);

            

        }

        #endregion

        #region Search Last Name

        private void SearchLastName_Click(object sender, EventArgs e)
        {
            customerViews.LastName = CTextLastName.Text.Trim();
            customerViews = customerDal.GetCustomerWithLastName(customerViews.LastName);


            string[] entities =
            {
               customerViews.ID.ToString(),
               customerViews.IdentityNumber,
               customerViews.FirstName,
               customerViews.LastName,
               customerViews.BirthDate.ToString(),
               customerViews.PhoneNumber,
               customerViews.Email,
               customerViews.Addres,
               customerViews.IsCompany.ToString(),
               customerViews.Company,
               customerViews.TaxNumber,
               customerViews.Country.ToString(),
               customerViews.City.ToString(),
               customerViews.Street.ToString(),
               customerViews.Languages.ToString(),
               customerViews.Gender.ToString(),
               customerViews.Activity.ToString(),
               customerViews.Descriptions
            };

            ListViewItem listWithLastName = new ListViewItem(entities);
            listViewCustomer.Items.Add(listWithLastName);
        }



        #endregion

        #region Fill Cities According To Countries

        private void CComboCountry_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string countryID = CComboCountry.SelectedValue.ToString();
            ControlSettings.FillComboBox(CComboCity, "select * from Cities where CountryID = " + countryID);
            CComboCity.Enabled = true;
        }

        #endregion

        #region Fill Streets According To Cities

        private void CComboCity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string cityID = CComboCity.SelectedValue.ToString();
            ControlSettings.FillComboBox(CComboStreet, "select * from Streets where CityID = " + cityID);
            CComboStreet.Enabled = true;
        }
        #endregion

        #region Listview To Text

        private void listViewCustomer_DoubleClick(object sender, EventArgs e)
        {
            CTextID.Text = customerViews.ID.ToString();
            CTextIdentity.Text = customerViews.IdentityNumber.ToString();
            CTextFirstName.Text = customerViews.FirstName.ToString();
            CTextLastName.Text = customerViews.LastName.ToString();
            CDateBirth.Value = customerViews.BirthDate;
            CTextPhone.Text = customerViews.PhoneNumber.ToString();
            CTextEMail.Text = customerViews.Email.ToString();
            CTextAddress.Text = customerViews.Addres.ToString();
            CheckCompany.Checked = customerViews.IsCompany;
            CTextCompanyName.Text = customerViews.Company.ToString();
            CTextTax.Text = customerViews.TaxNumber.ToString();
            CComboCountry.SelectedValue = customerViews.Country;
            CComboCity.SelectedValue = customerViews.City;
            CComboStreet.SelectedValue = customerViews.Street;
            CComboLanguage.SelectedValue = customerViews.Languages;
            CComboGender.SelectedValue = customerViews.Gender;
            CCheckActive.Checked = customerViews.Activity;
            CTextDescription.Text = customerViews.Descriptions.ToString();
        }


        #endregion

        


        //List<Customers> customers = customerDal.GetAllCustomer();
        //foreach(Customers customer in customers) 
        //{
        //    string[] satir = { customer.CustomerID.ToString(), customer.CustomerIdentityNumber.ToString() };
        //    ListViewItem lv = new ListViewItem(satir);
        //    listView1.Items.Add(lv);
        //}
    }
}
