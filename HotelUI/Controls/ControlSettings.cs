using DataAccess;
using HotelUI.UI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HotelUI.Controls
{
    public static class ControlSettings 
    {

        #region Open

        public static void Open(Form form1,Form form2)
        {
            form1.Show();
            form2.Hide();
        }

        #endregion 

        #region Back
        public static void Back(Form MyForm)
        {
            ForgetPasswordUI passwordUI = new ForgetPasswordUI();
            LoginUI loginUI = new LoginUI();
            HomeUI homeUI = new HomeUI();

            if (MyForm.GetType() == passwordUI.GetType())
            {
                MyForm.Hide();
                loginUI.Show();
            }
            else
            {
                MyForm.Hide();
                homeUI.Show();
            }


        }
        #endregion

        #region Exit
        public static void Exit()
        {
            Application.Exit();
        }

        #endregion

        #region Colors
        public static void Colors(System.Windows.Forms.Label MyLabel, bool ColorType)
        {

            if (ColorType)
            {
                MyLabel.ForeColor = Color.Red;
            }
            else
            {
                MyLabel.ForeColor = Color.Black;
            }
        }
        #endregion

        #region Fill

        public static void FillComboBox(ComboBox comboBox, string SqlCommand)
        {
            List<KeyValuePair<int, string>> list = new List<KeyValuePair<int, string>>();
            SqlDataReader sqlDataReader = HotelHelperSQL.MyExecuteReader(SqlCommand, "text", null);
            while (sqlDataReader.Read())
            {
                list.Add(new KeyValuePair<int, string>((int)sqlDataReader[0], (string)sqlDataReader[1]));
            }

            comboBox.DataSource = list;
            comboBox.ValueMember = "Key";
            comboBox.DisplayMember = "Value";

        }

        #endregion

        #region Move

        private static bool mouseDown;
        private static Point lastLocation;

        public static void Move(Form myForm,MouseEventArgs e)
        {
            if (mouseDown)
            {
                myForm.Location = new Point((myForm.Location.X - lastLocation.X)+ e.X ,(myForm.Location.Y - lastLocation.Y)+e.Y);
            }
            myForm.Update();
        }

        public static void Mouse(bool mouse, MouseEventArgs e)
        {
            if (mouse)
            {
                mouseDown = true;
                lastLocation = e.Location;
            }
            else
            {
                mouseDown = false;
            }
        }


        #endregion

    }

}
