using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace QLGV.Forms
{
    public partial class SysChangePass : Form
    {
        internal int ID = 0;
        public SysChangePass()
        {
            InitializeComponent();
        }

        private void Add_HT_TinHoc_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtpass.Text))
            {
                GUIController.ShowMessageBox("Bạn phải nhập mật khẩu");
                txtpass.Focus();
                return;
            }
            if (txtpass.Text != SysLogin.CurrentUser.Pass)
            {
                GUIController.ShowMessageBox("Bạn phải nhập đúng mật khẩu hiện tại");
                txtpass.Focus();
                return;
            }
            if (txtnewpass.Text != txtnewpasscomfirm.Text)
            {
                GUIController.ShowMessageBox("Xác nhận mật khẩu mới khống chính xác");
                txtpass.Focus();
                return;
            }
            SQLiteUtils.ExcuteNonQuery("update user set password=@password where username = @username COLLATE NOCASE", "@password", txtnewpass.Text, "@username", SysLogin.CurrentUser.Username);
            SysLogin.CurrentUser.Pass = txtnewpass.Text;
            GUIController.ShowMessageBox("Đổi mật khẩu thành công!");
            this.Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
