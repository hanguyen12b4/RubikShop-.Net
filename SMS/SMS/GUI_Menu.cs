using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class GUI_Menu : Form
    {
        public GUI_Menu()
        {
            InitializeComponent();
            Lock_Unlock(mySave.KT);
        }

        void Lock_Unlock(Boolean kt)
        {
            mnuLogout.Enabled = mnuManage.Enabled = mnuSearch.Enabled = mnuPrint.Enabled = !kt;
            mnuLogin.Enabled = mnuClose.Enabled = kt;
        }

        private void GUI_Menu_Activated(object sender, EventArgs e)
        {
            Lock_Unlock(mySave.KT);
        }
     
        private void mnuLogin_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.Show();
        }
        private void mnuLogout_Click(object sender, EventArgs e)
        {
            mySave.KT = !mySave.KT;
            Lock_Unlock(mySave.KT);
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void mnuNV_Click(object sender, EventArgs e)
        {
            GUI_NV f = new GUI_NV();
            f.Show();
        }

        private void mnuHoSoNV_Click(object sender, EventArgs e)
        {
            GUI_HoSoNV f = new GUI_HoSoNV();
            f.Show();
        }

        private void qLSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_QLSanPham f = new GUI_QLSanPham();
            f.Show();
        }
    }
}
