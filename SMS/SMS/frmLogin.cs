using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_SMS;
namespace SMS
{
    public partial class frmLogin : Form
    {
        BUS_Login busLogin = new BUS_Login();
        public frmLogin()
        {
            InitializeComponent();
            txtUserName.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "")
            {
                    mySave.KT = !mySave.KT;
                    Close();
            }
            else MessageBox.Show("UserName or Password is not correct!", "Attention");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
