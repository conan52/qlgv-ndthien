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
    public partial class Add_Truong : Form
    {
        internal event EventHandler UpdateChanged;
        internal int ID = 0;
        internal object NhomID = 0;
        public Add_Truong()
        {
            InitializeComponent();
        }

        private void Add_HT_CanBo_Form_Load(object sender, EventArgs e)
        {
            try
            {
                cbNhom.PopulateData(SQLiteUtils.GetTable("select * from NhomTruong"), null, null);
                cbHangTruong.PopulateData(new List<Models.ListItem>() 
                { new Models.ListItem { Value = 1, Text = "I" }, 
                    new Models.ListItem { Value = 2, Text = "II" },
                new Models.ListItem { Value = 3, Text = "III" }});
                if (ID != 0)
                {
                    var dt = SQLiteUtils.GetTable("select * from TruongInfo where ID = @id", "@id", ID);
                    var item = dt.Rows[0];
                    txtTitle.Text = (string)dt.Rows[0]["Title"];
                    cbNhom.SelectedValue = item["NhomTruongID"];
                    cbHangTruong.SelectedValue = item["HangTruong"];
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
                GUIController.ShowMessageBox("Bạn phải nhập tên trường");
                txtTitle.Focus();
                return;
            }

            if (ID != 0)
            {
                SQLiteUtils.ExcuteNonQuery(@"update TruongInfo set Title=@title,NhomTruongID=@NhomTruongID,hangtruong=@hangtruong where id=@id",
                    "@title", txtTitle.Text, "@NhomTruongID", cbNhom.SelectedValue, "@hangtruong", cbHangTruong.SelectedValue
                    , "@id", ID);

                GUIController.ShowMessageBox("Sửa trường thành công!");
            }
            //Trường hợp thêm cán bộ
            else
            {
                SQLiteUtils.ExcuteNonQuery(@"insert into TruongInfo (title, Nhomtruongid, hangtruong) values(@title,@NhomTruongID,@hangtruong)", "@title", txtTitle.Text, "@NhomTruongID",
                    cbNhom.SelectedValue, "@hangtruong", cbHangTruong.SelectedValue);
                GUIController.ShowMessageBox("Thêm trường thành công!");
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
