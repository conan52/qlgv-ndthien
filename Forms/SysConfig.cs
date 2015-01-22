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
    public partial class SysConfig : Form
    {
        public SysConfig()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            SQLiteUtils.ExcuteNonQuery("update Config set [value]=@year where [key]='Year'", "@year", numYear.Value);
            GUIController.ShowMessageBox("Cập nhật thành công!");
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            var xx = SQLiteUtils.GetTable("select [value] from Config where [key]='Year'");
            numYear.Value = decimal.Parse("0" + xx.Rows[0][0]);
        }

        public static int CurrentYear
        {
            get
            {
                var xx = SQLiteUtils.GetTable("select [value] from Config where [key]=@key", "@key", "Year");
                return int.Parse("0" + xx.Rows[0][0]);
            }
        }
    }
}
