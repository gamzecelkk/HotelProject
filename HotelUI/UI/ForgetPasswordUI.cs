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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelUI.UI
{
    public partial class ForgetPasswordUI : Form
    {
        public ForgetPasswordUI()
        {
            InitializeComponent();
        }

        #region Random Password

        private void Accept_Click(object sender, EventArgs e)
        {
            try
            {

                Random Rnd = new Random();
                StringBuilder StrBuild = new StringBuilder();
                for (int i = 0; i < 8; i++)
                {
                    int ASCII = Rnd.Next(32, 127);
                    char Karakter = Convert.ToChar(ASCII);
                    StrBuild.Append(Karakter);
                }
                Users users = new Users();
                users.UserEmail = Email.Text;
                users.UserPassword = StrBuild.ToString();
                UserDal userDal = new UserDal();
                string Pass = userDal.PasswordReset(users);
                Messages.Renewed();
            }
            catch (Exception)
            {
                Messages.Error();
            }

            
        }

        #endregion

        #region Back and Exit

        private void LabelExit_MouseClick(object sender, MouseEventArgs e)
        {
            ControlSettings.Exit();
        }

        private void LabelExit_MouseLeave(object sender, EventArgs e)
        {
            ControlSettings.Colors(LabelExit, false);
        }

        private void LabelExit_MouseEnter(object sender, EventArgs e)
        {
            ControlSettings.Colors(LabelExit, true);
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
            ControlSettings.Colors(LabelBack, false);
        }

        #endregion

        #region Move Form

        private void ForgetPasswordUI_MouseUp(object sender, MouseEventArgs e)
        {
            ControlSettings.Move(this, e);
        }

        private void ForgetPasswordUI_MouseDown(object sender, MouseEventArgs e)
        {
            ControlSettings.Move(this, e);
        }

        private void ForgetPasswordUI_MouseMove(object sender, MouseEventArgs e)
        {
            ControlSettings.Move(this, e);
        }

        #endregion
    }
}
