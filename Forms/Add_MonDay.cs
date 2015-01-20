using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace QLGV.Forms
{
    public partial class Add_MonDay : Form
    {
        internal event EventHandler UpdateChanged;
        internal int ID = 0;
        public Add_MonDay()
        {
            InitializeComponent();
        }

        private void Add_HT_CanBo_Form_Load(object sender, EventArgs e)
        {
            try
            {
                if (ID != 0)
                {
                    var dt = SQLiteUtils.GetTable("select * from MonDay where ID = @id", "@id", ID);
                    txtTitle.Text = (string)dt.Rows[0]["Title"];
                    txtCode.Text = (string)dt.Rows[0]["Code"];
                }
            }
            catch (Exception ex)
            {
                GUIController.ShowErrorBox(ex);
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text.Trim()))
            {
                GUIController.ShowMessageBox("Bạn phải nhập tên môn dạy");
                txtTitle.Focus();
                return;
            }

            //Trường hợp sửa
            if (ID != 0)
            {
                SQLiteUtils.ExcuteNonQuery("update MonDay set Title = @title, Code=@code where ID=@id", "@title", txtTitle.Text, "@id", ID, "@code", txtCode.Text);

                GUIController.ShowMessageBox("Sửa môn dạy thành công!");
            }
            //Trường hợp thêm
            else
            {
                SQLiteUtils.ExcuteNonQuery("insert into MonDay (title, Code) values(@title, @code)", "@title", txtTitle.Text, "@code", txtCode.Text);

                GUIController.ShowMessageBox("Thêm môn dạy thành công!");
            }

            if (UpdateChanged != null)
            {
                UpdateChanged.Invoke(this, null);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
