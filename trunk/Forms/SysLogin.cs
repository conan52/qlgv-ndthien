using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLGV.Models;
using QLGV.Controllers;

namespace QLGV.Forms
{
    public partial class SysLogin : Form
    {
        private static Models.User _currentUser;

        public static Models.User CurrentUser
        {
            get { return _currentUser; }
        }

        public SysLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            bool success = txtUserName.Text.ToLower() == "admin";
            if (!success)
            {
                _currentUser = null;
                GUIController.ShowMessageBox("Đăng nhập thất bại!");
                txtUserName.Focus();
            }
            else
            {
                _currentUser = new User() { Username = "admin", Pass = "1" };
                this.Close();
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            _currentUser = null;
        }
    }
}
