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
    public partial class Add_TonGiao : Form
    {
        internal event EventHandler UpdateChanged;
        internal int ID = 0;
        public Add_TonGiao()
        {
            InitializeComponent();
        }

        private void Add_HT_TonGiao_Form_Load(object sender, EventArgs e)
        {
            try
            {
                if (ID != 0)
                {
                    var dt = SQLiteUtils.GetTable("select * from TonGiao where ID = @id", "@id", ID);
                    txtTitle.Text = (string)dt.Rows[0]["Title"];
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
                GUIController.ShowMessageBox("Bạn phải nhập tên tôn giáo");
                txtTitle.Focus();
                return;
            }

            //Trường hợp sửa cán bộ
            if (ID != 0)
            {
                SQLiteUtils.ExcuteNonQuery("update TonGiao set Title = @title where ID=@id", "@title", txtTitle.Text, "@id", ID);

                GUIController.ShowMessageBox("Sửa tôn giáo thành công!");
            }
            //Trường hợp thêm cán bộ
            else
            {
                SQLiteUtils.ExcuteNonQuery("insert into TonGiao(title) values(@title)", "@title", txtTitle.Text);

                GUIController.ShowMessageBox("Thêm tôn giáo thành công!");
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
