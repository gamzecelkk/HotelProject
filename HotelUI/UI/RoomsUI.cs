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
    public partial class RoomsUI : Form
    {
        public RoomsUI()
        {
            InitializeComponent();
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

        private void RoomsUI_MouseUp(object sender, MouseEventArgs e)
        {
            ControlSettings.Mouse(false, e);
        }

        private void RoomsUI_MouseMove(object sender, MouseEventArgs e)
        {
            ControlSettings.Move(this,e);
        }

        private void RoomsUI_MouseDown(object sender, MouseEventArgs e)
        {
            ControlSettings.Mouse(true, e);
        }
    }
}
