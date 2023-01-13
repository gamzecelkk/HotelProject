
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelUI.Controls
{
    public static class Messages
    {
        public static void Added(string page)
        {
            MessageBox.Show(page +" Added");
        }
        public static void Updated(string page)
        {
            MessageBox.Show(page + " Updated");
        }
        public static void Deleted(string page)
        {
            MessageBox.Show(page + " Deleted");
        }
        public static void Error()
        {
            MessageBox.Show(" Transaction Failed " );
        }

        public static void List(string page)
        {
            MessageBox.Show(page + " Listed");
        }

        public static void Renewed()
        {
            MessageBox.Show("Password Renewed");
        }

        public static void Authority()
        {
            MessageBox.Show("You have not authority ");
        }

        public static void Entry()
        {
            MessageBox.Show("Email or Password is wrong!!");
        }

    }

}
