using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShiftsManagerSystem
{
    public partial class MenuControl : UserControl
    {
        public MenuControl()
        {
            InitializeComponent();
        }

        private void clockInOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClockInOut clockInOut = new ClockInOut();
            clockInOut.Show();
            this.FindForm().Hide();
        }

        private void viewShiftsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewShifts view = new ViewShifts();
            view.Show();
            this.FindForm().Hide();
        }

        private void manageShiftsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageShifts manage = new ManageShifts();
            manage.Show();
            this.FindForm().Hide();
        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payments pay = new Payments();
            pay.Show();
            this.FindForm().Hide();
        }
    }
}
