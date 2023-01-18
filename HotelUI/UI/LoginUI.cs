using DataAccess;
using Entities.Concrete;
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
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        #region Move Form

        private void LoginUI_MouseUp(object sender, MouseEventArgs e)
        {
            ControlSettings.Mouse(false, e);
        }

        private void LoginUI_MouseMove(object sender, MouseEventArgs e)
        {
            ControlSettings.Move(this, e);
        }

        private void LoginUI_MouseDown(object sender, MouseEventArgs e)
        {
            ControlSettings.Mouse(true, e);
        }
        #endregion

        #region Exit

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
            ControlSettings.Colors(LabelExit, false);
        }
        #endregion

        #region Login Process
        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                Users users = new Users();
                users.UserEmail = Email.Text;
                users.UserPassword = Password.Text;
                UserDal userDal = new UserDal();
                int Type = userDal.UserLogin(users);

                if (Type > 0)
                {
                    ControlSettings.Back(this);
                }
                else if (Type == 0)
                {
                    Messages.Entry();
                }
                else if (Type == -1)  // there is a user who has not authority
                {
                    Messages.Authority();
                }
            }
            catch (Exception)
            {
                Messages.Error();
            }
            
            
            
        }
        #endregion

        #region Forget Password
        private void ForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ControlSettings.Open(new ForgetPasswordUI(), this);
        }
        #endregion

        
    }
}
