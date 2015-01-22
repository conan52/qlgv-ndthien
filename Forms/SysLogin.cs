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
            var x = SQLiteUtils.ExcuteScalar("select count(1) from User where username=@user  COLLATE NOCASE and password = @pass", "@user", txtUserName.Text.Trim(), "@pass", txtPassword.Text);
            bool success = int.Parse("0" + x) > 0;
            if (!success)
            {
                _currentUser = null;
                GUIController.ShowMessageBox("Đăng nhập thất bại!");
                txtUserName.Focus();
            }
            else
            {
                _currentUser = new User() { Username = txtUserName.Text.ToLower().Trim(), Pass = txtPassword.Text};
                this.Close();
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            _currentUser = null;
            //this.Close();
        }

        private void SysLogin_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (_currentUser == null) Application.Exit();
        }
    }
}
