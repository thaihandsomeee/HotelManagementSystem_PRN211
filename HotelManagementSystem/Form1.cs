using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btBook_Click(object sender, EventArgs e)
        {
            frmBooking frmBooking = new frmBooking();
            frmBooking.Show();
        }

        private void btManage_Click(object sender, EventArgs e)
        {
            frmManageStaff frmManageStaff = new frmManageStaff();
            frmManageStaff.Show();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            frmUpdatePrice frmUpdatePrice = new frmUpdatePrice();
            frmUpdatePrice.Show();
        }
    }
}
