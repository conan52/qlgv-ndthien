using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLGV.Models;
using QLGV.UserControls;

namespace QLGV.Forms
{
    public partial class List_Truong_CanBo : Form
    {
        public List_Truong_CanBo()
        {

            InitializeComponent();
            CreateViewItemsColumnTruong();
            CreateViewItemsColumnCB();
        }

        #region Left panel
        private void cbNhomTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateViewItemsTruong();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            PopulateViewItemsTruong();
        }

        private void viewItemsTruong_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                PopulateViewItemsCB();
                PopulateViewThongTinChung();
            }
            catch { }
        }

        private void List_Truong_CanBo_Load(object sender, EventArgs e)
        {
            LoadcbNhomTruong();
            cbLoaiTruong.PopulateData(SQLiteUtils.GetTable("select * from NhomTruong"), null, null);
            cbHangTruong.PopulateData(new List<Models.ListItem>() 
                { new Models.ListItem { Value = 1, Text = "I" }, 
                    new Models.ListItem { Value = 2, Text = "II" },
                new Models.ListItem { Value = 3, Text = "III" }});
        }


        private void btNew_Click(object sender, EventArgs e)
        {
            var nhomtruongid = cbNhomTruong.SelectedValue;
            var addDM_DonViTienTe = new Add_Truong();
            addDM_DonViTienTe.NhomID = nhomtruongid;
            addDM_DonViTienTe.Text = "Thêm trường";
            addDM_DonViTienTe.UpdateChanged += new EventHandler(Truong_UpdateChanged);
            addDM_DonViTienTe.ShowDialog();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse("0" + viewItemsTruong.SelectedRows[0].Tag);
            if (id == 0) return;
            var addDM_DonViTienTe = new Add_Truong();
            addDM_DonViTienTe.ID = id;
            addDM_DonViTienTe.Text = "Sửa thông tin trường";
            addDM_DonViTienTe.UpdateChanged += new EventHandler(Truong_UpdateChanged);
            addDM_DonViTienTe.ShowDialog();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (viewItemsTruong.SelectedRows.Count == 0)
                {
                    GUIController.ShowMessageBox("Bạn phải chọn trường cần xóa!");
                    return;
                }

                int id = int.Parse("0" + viewItemsTruong.SelectedRows[0].Tag);
                if (id == 0)
                {
                    GUIController.ShowMessageBox("Bạn phải chọn trường cần xóa!");
                    return;
                }

                if (GUIController.ShowConfirmBox("Bạn có muốn trường không?"))
                {
                    int isSuccess = SQLiteUtils.ExcuteNonQuery("delete from TruongInfo where id=@id", "@id", id);

                    if (isSuccess > 0)
                    {
                        GUIController.ShowMessageBox(string.Format("Xóa trường thành công!"));
                        PopulateViewItemsTruong();
                    }
                    else
                    {
                        GUIController.ShowMessageBox(string.Format("Xóa trường thất bại!"));
                    }
                }
            }
            catch (Exception ex)
            {
                GUIController.ShowErrorBox(ex);
            }
        }
        void Truong_UpdateChanged(object sender, EventArgs e)
        {
            PopulateViewItemsTruong();
        }
        void LoadcbNhomTruong()
        {
            var dt = SQLiteUtils.GetTable("select * from NhomTruong");
            cbNhomTruong.PopulateData(dt, null, null);
        }
        void CreateViewItemsColumnTruong()
        {
            viewItemsTruong.AddColumns(new NDThienDataGridViewColumn[] 
            {
                new NDThienDataGridViewColumn("STT", 40, NDThienDataGridViewColumnStyle.ReadOnly, NDThienDataGridViewColumnDataType.String),
                new NDThienDataGridViewColumn("Tên trường", 300, NDThienDataGridViewColumnStyle.ReadOnly, NDThienDataGridViewColumnDataType.String),
            });
        }
        void PopulateViewItemsTruong()
        {
            try
            {
                viewItemsTruong.Rows.Clear();
                var nhomtruongid = cbNhomTruong.SelectedValue;
                DataTable dt;
                if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
                    dt = SQLiteUtils.GetTable("select * from TruongInfo where NhomTruongID=@nhomtruongid", "@nhomtruongid", nhomtruongid);
                else
                    dt = SQLiteUtils.GetTable("select * from TruongInfo where NhomTruongID=@nhomtruongid and Title like '%" + txtSearch.Text + "%'", "@nhomtruongid", nhomtruongid);
                int i = 1;
                foreach (DataRow item in dt.Rows)
                {
                    viewItemsTruong.Rows.Add(i, item["Title"]);
                    viewItemsTruong.Rows[i - 1].Tag = item["ID"];
                    i++;
                }

            }
            catch (Exception ex)
            {
                GUIController.ShowErrorBox(ex);
            }
        }
        #endregion

        #region Thong tin chung tab

        void PopulateViewThongTinChung()
        {
            try
            {
                int id = int.Parse("0" + viewItemsTruong.SelectedRows[0].Tag);
                if (id == 0) return;
                var dt = SQLiteUtils.GetTable("select * from TruongInfo where ID = @id", "@id", id);
                var item = dt.Rows[0];
                txtTenTruong.Text = (string)item["Title"];
                cbLoaiTruong.SelectedItem = item["NhomTruongID"];
                cbHangTruong.SelectedValue = item["HangTruong"];

                nudSoHS.Value = decimal.Parse("0" + item["SoHocSinh"]);
                nudSoLop.Value = decimal.Parse("0" + item["SoLop"]);
                nudSoLop2b.Value = decimal.Parse("0" + item["SoLop2b"]);
                nudDuocGiaoCB.Value = decimal.Parse("0" + item["DuocGiaoCB"]);
                nudDuocGiaoGV.Value = decimal.Parse("0" + item["DuocGiaoGV"]);
                nudDuocGiaoTPT.Value = decimal.Parse("0" + item["DuocGiaoTPT"]);
                nudDuocGiaoHC.Value = decimal.Parse("0" + item["DuocGiaoHC"]);
                nudDuocGiaoCNTT.Value = decimal.Parse("0" + item["DuocGiaoCNTT"]);

                nudCoMatCB.Value = decimal.Parse("0" + SQLiteUtils.GetTable("select count(1) from canbo where truongid=@truongid and chucvu=@chucvu", "@truongid", id, "@chucvu", ChucVu.CBQL).Rows[0][0]);
                nudCoMatGV.Value = decimal.Parse("0" + SQLiteUtils.GetTable(
                    string.Format("select count(1) from canbo where truongid=@truongid and (chucvu='{0}' or chucvu='{1}' or chucvu='{2}')", ChucVu.GVBC, ChucVu.GVHDCBH, ChucVu.GVHDKBH), "@truongid", id).Rows[0][0]);
                nudCoMatTPT.Value = decimal.Parse("0" + SQLiteUtils.GetTable("select count(1) from canbo where truongid=@truongid and chucvu=@chucvu", "@truongid", id, "@chucvu", ChucVu.TPTDoi).Rows[0][0]);
                nudCoMatHC.Value = decimal.Parse("0" + SQLiteUtils.GetTable("select count(1) from canbo where truongid=@truongid and chucvu=@chucvu", "@truongid", id, "@chucvu", ChucVu.HanhChinh).Rows[0][0]);
                nudCoMatCNTT.Value = decimal.Parse("0" + SQLiteUtils.GetTable("select count(1) from canbo where truongid=@truongid and chucvu=@chucvu", "@truongid", id, "@chucvu", ChucVu.CNTT).Rows[0][0]);

                nudCoMatHC.Value = decimal.Parse("0" + item["KeHoachHC"]);
                nudCoMatCNTT.Value = decimal.Parse("0" + item["KeHoachCNTT"]);
                nudKeHoachCB.Value = decimal.Parse("0" + item["KeHoachCB"]);
                nudKeHoachHC.Value = decimal.Parse("0" + item["KeHoachHC"]);
                nudKeHoachCNTT.Value = decimal.Parse("0" + item["KeHoachCNTT"]);
            }
            catch { }
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenTruong.Text.Trim()))
            {
                GUIController.ShowMessageBox("Bạn phải nhập tên trường");
                txtTenTruong.Focus();
                return;
            }
            int id = int.Parse("0" + viewItemsTruong.SelectedRows[0].Tag);
            if (id == 0) return;

            SQLiteUtils.ExcuteNonQuery(@"update TruongInfo set Title=@title,NhomTruongID=@NhomTruongID,hangtruong=@hangtruong,
SoLop=@SoLop,SoLop2b=@SoLop2b,SoHocSinh=@SoHocSinh,
DuocGiaoCB=@DuocGiaoCB,DuocGiaoGV=@DuocGiaoGV,DuocGiaoTPT=@DuocGiaoTPT,DuocGiaoHC=@DuocGiaoHC,DuocGiaoCNTT=@DuocGiaoCNTT,
CoMatCB=@CoMatCB,CoMatGV=@CoMatGV,CoMatTPT=@CoMatTPT,CoMatHC=@CoMatHC,CoMatCNTT=@CoMatCNTT,
KeHoachCB=@KeHoachCB,KeHoachGV=@KeHoachGV,KeHoachTPT=@KeHoachTPT,KeHoachHC=@KeHoachHC,KeHoachCNTT=@KeHoachCNTT 
where id=@id",
                "@title", txtTenTruong.Text, "@NhomTruongID", cbLoaiTruong.SelectedValue, "@hangtruong", cbHangTruong.SelectedValue,
                "@SoLop", nudSoLop.Value, "@SoLop2b", nudSoLop2b.Value, "@SoHocSinh", nudSoHS.Value,
                "@DuocGiaoCB", nudDuocGiaoCB.Value, "@DuocGiaoGV", nudDuocGiaoGV.Value, "@DuocGiaoTPT", nudDuocGiaoTPT.Value, "@DuocGiaoHC", nudDuocGiaoHC.Value, "@DuocGiaoCNTT", nudDuocGiaoCNTT.Value,
                "@CoMatCB", nudCoMatCB.Value, "@CoMatGV", nudCoMatGV.Value, "@CoMatTPT", nudCoMatTPT.Value, "@CoMatHC", nudCoMatHC.Value, "@CoMatCNTT", nudCoMatCNTT.Value,
                "@KeHoachCB", nudKeHoachCB.Value, "@KeHoachGV", nudKeHoachGV.Value, "@KeHoachTPT", nudKeHoachTPT.Value, "@KeHoachHC", nudKeHoachHC.Value, "@KeHoachCNTT", nudKeHoachCNTT.Value
                , "@id", id);

            GUIController.ShowMessageBox("Sửa thông tin trường thành công!");
        }
        #endregion

        #region Canbo tab

        private void viewItemsCB_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void btnDetailsCB_Click(object sender, EventArgs e)
        {
            try
            {
                if (viewItemsCB.SelectedRows.Count == 0)
                {
                    return;
                }

                int id = int.Parse("0" + viewItemsCB.SelectedRows[0].Tag);
                if (id == 0)
                {
                    return;
                }

                var addDM_DonViTienTe = new Add_CanBo();
                addDM_DonViTienTe.ID = id;
                addDM_DonViTienTe.details = true;
                addDM_DonViTienTe.Text = "Chi tiết cán bộ";
                addDM_DonViTienTe.ShowDialog();
            }
            catch (Exception ex)
            {
                GUIController.ShowErrorBox(ex);
            }
        }

        private void btnAddCB_Click(object sender, EventArgs e)
        {
            var add = new Add_CanBo();
            int id = int.Parse("0" + viewItemsTruong.SelectedRows[0].Tag);
            if (id == 0) return;
            add.TruongID = id;
            add.Text = "Thêm cán bộ";
            add.UpdateChanged += new EventHandler(CanBo_UpdateChanged);
            add.ShowDialog();
        }

        private void btnEditCB_Click(object sender, EventArgs e)
        {
            try
            {
                if (viewItemsCB.SelectedRows.Count == 0)
                {
                    GUIController.ShowMessageBox("Bạn phải chọn cán bộ cần khi sửa!");
                    return;
                }

                int id = int.Parse("0" + viewItemsCB.SelectedRows[0].Tag);
                if (id == 0)
                {
                    GUIController.ShowMessageBox("Bạn phải chọn cán bộ cần khi sửa!");
                    return;
                }

                var addDM_DonViTienTe = new Add_CanBo();
                addDM_DonViTienTe.ID = id;
                addDM_DonViTienTe.Text = "Sửa cán bộ";
                addDM_DonViTienTe.UpdateChanged += new EventHandler(CanBo_UpdateChanged);
                addDM_DonViTienTe.ShowDialog();
            }
            catch (Exception ex)
            {
                GUIController.ShowErrorBox(ex);
            }
        }

        private void btnDelCB_Click(object sender, EventArgs e)
        {
            try
            {
                if (viewItemsCB.SelectedRows.Count == 0)
                {
                    GUIController.ShowMessageBox("Bạn phải chọn cán bộ cần xóa!");
                    return;
                }

                int id = int.Parse("0" + viewItemsCB.SelectedRows[0].Tag);
                if (id == 0)
                {
                    GUIController.ShowMessageBox("Bạn phải chọn cán bộ cần xóa!");
                    return;
                }

                if (GUIController.ShowConfirmBox("Bạn có muốn cán bộ không?"))
                {
                    int isSuccess = SQLiteUtils.ExcuteNonQuery("delete from CanBo where id=@id", "@id", id);

                    if (isSuccess > 0)
                    {
                        GUIController.ShowMessageBox(string.Format("Xóa cán bộ thành công!"));
                        PopulateViewItemsCB();
                    }
                    else
                    {
                        GUIController.ShowMessageBox(string.Format("Xóa cán bộ thất bại!"));
                    }
                }
            }
            catch (Exception ex)
            {
                GUIController.ShowErrorBox(ex);
            }
        }

        private void btnChangeCB_Click(object sender, EventArgs e)
        {
            try
            {
                if (viewItemsCB.SelectedRows.Count == 0)
                {
                    GUIController.ShowMessageBox("Bạn phải chọn cán bộ cần khi chuyển!");
                    return;
                }

                int id = int.Parse("0" + viewItemsCB.SelectedRows[0].Tag);
                if (id == 0)
                {
                    GUIController.ShowMessageBox("Bạn phải chọn cán bộ cần khi chuyển!");
                    return;
                }
                int id1 = int.Parse("0" + viewItemsTruong.SelectedRows[0].Tag);
                string dv = (string)SQLiteUtils.ExcuteScalar("select Title from TruongInfo where id=@id", "@id", id1);
                var addDM_DonViTienTe = new ChangeCB();
                addDM_DonViTienTe.ID = id;
                addDM_DonViTienTe.Text = "Chuyển đơn vị công tác cán bộ";
                addDM_DonViTienTe.DVHienTai = dv;
                addDM_DonViTienTe.UpdateChanged += new EventHandler(CanBo_UpdateChanged);
                addDM_DonViTienTe.ShowDialog();
            }
            catch (Exception ex)
            {
                GUIController.ShowErrorBox(ex);
            }
        }

        void CanBo_UpdateChanged(object sender, EventArgs e)
        {
            PopulateViewItemsCB();
        }

        void CreateViewItemsColumnCB()
        {
            viewItemsCB.AddColumns(new NDThienDataGridViewColumn[] 
            {
                new NDThienDataGridViewColumn("STT", 40, NDThienDataGridViewColumnStyle.ReadOnly, NDThienDataGridViewColumnDataType.String),
                new NDThienDataGridViewColumn("Họ và tên", 140, NDThienDataGridViewColumnStyle.ReadOnly, NDThienDataGridViewColumnDataType.String),
                new NDThienDataGridViewColumn("Ngày sinh", 100, NDThienDataGridViewColumnStyle.ReadOnly, NDThienDataGridViewColumnDataType.String),
                new NDThienDataGridViewColumn("Giới tính", 80, NDThienDataGridViewColumnStyle.ReadOnly, NDThienDataGridViewColumnDataType.String),
                new NDThienDataGridViewColumn("Chức danh", 140, NDThienDataGridViewColumnStyle.ReadOnly, NDThienDataGridViewColumnDataType.String),
                new NDThienDataGridViewColumn("Chuyên môn", 140, NDThienDataGridViewColumnStyle.ReadOnly, NDThienDataGridViewColumnDataType.String),
                new NDThienDataGridViewColumn("Chính trị", 140, NDThienDataGridViewColumnStyle.ReadOnly, NDThienDataGridViewColumnDataType.String),
                new NDThienDataGridViewColumn("Ngoại ngữ", 140, NDThienDataGridViewColumnStyle.ReadOnly, NDThienDataGridViewColumnDataType.String),
            });
        }

        void PopulateViewItemsCB()
        {
            int id = int.Parse("0" + viewItemsTruong.SelectedRows[0].Tag);
            if (id == 0) return;
            try
            {
                viewItemsCB.Rows.Clear();
                DataTable dt = SQLiteUtils.GetTable(@"select cb.ID, cb.HoTen, cb.NgaySinh, cb.GioiTinh, 
ct.Title as ChinhTri, cv.Title as ChucVu, cm.Title as ChuyenMon, nn.Title as NgoaiNgu
from CanBo cb
inner join LyLuanChinhTri ct on ct.Code = cb.ChinhTri
inner join ChucVu cv on cv.Code = cb.ChucVu
inner join ChuyenMon cm on cm.Code = cb.ChuyenMon
inner join NgoaiNgu nn on nn.Code = cb.NgoaiNgu 
where TruongID=@truongid", "@truongid", id);
                int i = 1;
                foreach (DataRow item in dt.Rows)
                {
                    bool gt = (bool)item["GioiTinh"];
                    viewItemsCB.Rows.Add(i, item["HoTen"], ((DateTime)item["NgaySinh"]).ToString("dd/MM/yyyy"),
                        gt ? "Nam" : "Nữ", item["ChinhTri"], item["ChucVu"], item["ChuyenMon"], item["NgoaiNgu"]);
                    viewItemsCB.Rows[i - 1].Tag = item["ID"];
                    i++;
                }

            }
            catch (Exception ex)
            {

            }
        }
        #endregion
    }
}
