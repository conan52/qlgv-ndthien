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
    public partial class ChangeCB : Form
    {
        internal event EventHandler UpdateChanged;
        internal int ID = 0;
        internal object NhomID = 0;
        internal string DVHienTai;
        public ChangeCB()
        {
            InitializeComponent();
        }

        private void Add_HT_CanBo_Form_Load(object sender, EventArgs e)
        {
            try
            {
                cbNhom.PopulateData(SQLiteUtils.GetTable("select * from NhomTruong"), null, null);

                if (ID != 0)
                {
                    var dt = SQLiteUtils.GetTable("select * from CanBo where ID = @id", "@id", ID);
                    var item = dt.Rows[0];
                    txtHoTen.Text = (string)dt.Rows[0]["HoTen"];
                    txtDV.Text = DVHienTai;
                }
            }
            catch (Exception ex)
            {
                GUIController.ShowErrorBox(ex);
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTen.Text.Trim()))
            {
                GUIController.ShowMessageBox("Bạn phải nhập tên trường");
                txtHoTen.Focus();
                return;
            }
            if (cbTruong.SelectedValue == null)
            {
                GUIController.ShowMessageBox("Bạn phải chọn trường");
                return;
            }
            if (ID != 0)
            {
                SQLiteUtils.ExcuteNonQuery(@"update CanBo set NgayBoNhiem=@NgayBoNhiem,TruongID=@TruongID where id=@id",
                    "@NgayBoNhiem", dtNgayDen.Value, "@TruongID", cbTruong.SelectedValue
                    , "@id", ID);

                GUIController.ShowMessageBox("Chuyển đơn vị thành công!");
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

        private void cbNhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbTruong.Items.Clear();
                var nhomtruongid = cbNhom.SelectedValue;
                DataTable dt;
                dt = SQLiteUtils.GetTable("select * from TruongInfo where NhomTruongID=@nhomtruongid", "@nhomtruongid", nhomtruongid);
                cbTruong.PopulateData(dt, null, null);
            }
            catch (Exception ex)
            {
                GUIController.ShowErrorBox(ex);
            }
        }
    }
}
