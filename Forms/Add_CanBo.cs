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
    public partial class Add_CanBo : Form
    {
        internal event EventHandler UpdateChanged;
        internal int ID = 0;
        internal int TruongID = 0;
        internal bool details = false;
        public Add_CanBo()
        {
            InitializeComponent();
        }

        private void Add_HT_CanBo_Form_Load(object sender, EventArgs e)
        {
            if (details) btSave.Hide();
            try
            {
                cbDanToc.PopulateData(SQLiteUtils.GetTable("select * from DanToc"), null, null);
                cbTonGiao.PopulateData(SQLiteUtils.GetTable("select * from TonGiao"), null, null);
                cbChuyenMon.PopulateData(SQLiteUtils.GetTable("select * from ChuyenMon"), "Code", "Title");
                cbChuyenNghanh.PopulateData(SQLiteUtils.GetTable("select * from ChuyenNghanh"), null, null);
                cbChinhTri.PopulateData(SQLiteUtils.GetTable("select * from LyLuanChinhTri"), "Code", "Title");
                cbNgoaiNgu.PopulateData(SQLiteUtils.GetTable("select * from NgoaiNgu"), "Code", "Title");
                cbTinHoc.PopulateData(SQLiteUtils.GetTable("select * from TinHoc"), "Code", "Title");
                cbChucVu.PopulateData(SQLiteUtils.GetTable("select * from ChucVu"), "Code", "Title");
                cbNgachLuong.PopulateData(SQLiteUtils.GetTable("select * from NgachLuong"), "Code", "Title");
                cbCdkh.PopulateData(SQLiteUtils.GetTable("select * from ChucDanhKH"), "Code", "Title");
                cbQlnn.PopulateData(SQLiteUtils.GetTable("select * from QLNN"), "Code", "Title");
                cbMonDay.PopulateData(SQLiteUtils.GetTable("select * from MonDay"), "Code", "Title");

                cbGioiTinh.PopulateData(new List<Models.ListItem>() { new Models.ListItem { Value = true, Text = "Nam" }, new Models.ListItem { Value = false, Text = "Nữ" } });
                if (ID != 0)
                {
                    var dt = SQLiteUtils.GetTable("select * from CanBo where ID = @id", "@id", ID);
                    var item = dt.Rows[0];
                    txtHoTen.Text = (string)dt.Rows[0]["HoTen"];
                    txtMaNgach.Text = (string)dt.Rows[0]["MaNgach"];
                    txtBacLuong.Text = (string)dt.Rows[0]["BacLuong"];
                    cbGioiTinh.SelectedValue = item["GioiTinh"];
                    rdDoanVien.Checked = int.Parse("0" + item["DoanVien"]) == 2;//dang vien =2, orther = 1
                    dtNgayVaoDoan.Visible = rdDoanVien.Checked;
                    laNgayvaodang.Visible = rdDoanVien.Checked;

                    chkTiengDanToc.Checked = (bool)item["CoTiengDanToc"];
                    nudPhuCap.Value = decimal.Parse("0" + item["PhanTramPhuCap"]);

                    dtNgaySinh.Value = (DateTime)item["NgaySinh"];
                    dtNgayVaoDoan.Value = (DateTime)item["NgayVaoDoan"];
                    dtNgayVaoNghanh.Value = (DateTime)item["NgayVaoNghanh"];
                    dtNgayChuyenDen.Value = (DateTime)item["NgayChuyenDen"];
                    dtNgayBoNhiem.Value = (DateTime)item["NgayBoNhiem"];
                    dtHuongLuongTuNgay.Value = (DateTime)item["HuongLuongTuNgay"];
                    dtHuongPhuCapTuNgay.Value = (DateTime)item["HuongPhuCapTuNgay"];

                    cbDanToc.SelectedValue = int.Parse("0" + item["DanToc"]);
                    cbTonGiao.SelectedValue = int.Parse("0" + item["TonGiao"]);
                    cbChuyenMon.SelectedValue = item["ChuyenMon"];
                    cbChuyenNghanh.SelectedValue = int.Parse("0" + item["ChuyenNghanh"]);
                    cbChinhTri.SelectedValue = item["ChinhTri"];
                    cbNgoaiNgu.SelectedValue = item["NgoaiNgu"];
                    cbTinHoc.SelectedValue = item["TinHoc"];
                    cbChucVu.SelectedValue = item["ChucVu"];
                    cbNgachLuong.SelectedValue = item["NgachLuong"];
                    cbCdkh.SelectedValue = item["ChucDanhKH"];
                    cbMonDay.SelectedValue = item["ChucVu"];
                    cbQlnn.SelectedValue = item["ChucVu"];
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
                GUIController.ShowMessageBox("Bạn phải nhập tên cán bộ");
                txtHoTen.Focus();
                return;
            }

            //Trường hợp sửa cán bộ
            if (ID != 0)
            {
                SQLiteUtils.ExcuteNonQuery(@"update CanBo set HoTen=@hoten,ngaysinh=@ngaysinh,gioitinh=@gioiTinh,dantoc=@dantoc,
                tongiao=@tongiao,doanvien=@doanvien,ngayvaodoan=@ngayvaodoan,ChuyenMon=@chuyenmon,ChuyenNghanh=@chuyennghanh,ChinhTri=@chinhtri,NgoaiNgu=@ngoaingu,TinHoc=@tinhoc,CoTiengDanToc=@cotiengdantoc,
                NgayVaoNghanh=@ngayvaonghanh,NgayChuyenDen=@ngaychuyenden,NgayBoNhiem=@ngaybonhiem,ChucVu=@chucvu,NgachLuong=@ngachluong,MaNgach=@mangach,BacLuong=@bacluong,
HuongLuongTuNgay=@huongluongtungay,PhanTramPhuCap=@phantramphucap,HuongPhuCapTuNgay=@huongphucaptungay,chucdanhkh=@chucdanhkh,qlnn=@qlnn,
monday=@monday where id=@id",
                    "@hoten", txtHoTen.Text, "@ngaysinh", Common.GetDateStringForQuery(dtNgaySinh.Value),
                    "@gioiTinh", cbGioiTinh.SelectedValue, "@dantoc", cbDanToc.SelectedValue
                    , "@tongiao", cbTonGiao.SelectedValue, "@doanvien", rdDoanVien.Checked ? 2 : 1, "@ngayvaodoan", Common.GetDateStringForQuery(dtNgayVaoDoan.Value)
                    , "@chuyenmon", cbChuyenMon.SelectedValue, "@chuyennghanh", cbChuyenNghanh.SelectedValue
                    , "@chinhtri", cbChinhTri.SelectedValue, "@ngoaingu", cbNgoaiNgu.SelectedValue
                    , "@tinhoc", cbTinHoc.SelectedValue, "@cotiengdantoc", chkTiengDanToc.Checked ? "1" : "0", "@ngayvaonghanh", Common.GetDateStringForQuery(dtNgayVaoNghanh.Value)
                    , "@ngaychuyenden", Common.GetDateStringForQuery(dtNgayChuyenDen.Value), "@ngaybonhiem", Common.GetDateStringForQuery(dtNgayBoNhiem.Value)
                    , "@chucvu", cbChucVu.SelectedValue, "@ngachluong", cbNgachLuong.SelectedValue, "@mangach", txtMaNgach.Text, "@bacluong", txtBacLuong.Text, "@huongluongtungay", Common.GetDateStringForQuery(dtHuongLuongTuNgay.Value)
                    , "@phantramphucap", nudPhuCap.Value
                    , "@huongphucaptungay", Common.GetDateStringForQuery(dtHuongPhuCapTuNgay.Value)
                    , "@chucdanhkh", cbCdkh.SelectedValue
                    , "@qlnn", cbQlnn.SelectedValue
                    , "@monday", cbMonDay.SelectedValue
                    , "@id", ID);

                GUIController.ShowMessageBox("Sửa cán bộ thành công!");
            }
            //Trường hợp thêm cán bộ
            else
            {
                SQLiteUtils.ExcuteNonQuery(@"insert into CanBo(hoten,truongid,ngaysinh,gioitinh,dantoc,tongiao,doanvien,ngayvaodoan,chuyenmon,chuyennghanh,chinhtri,ngoaingu,tinhoc,cotiengdantoc,
ngayvaonghanh,ngaychuyenden,ngaybonhiem,chucvu,ngachluong,mangach,bacluong,huongluongtungay,phantramphucap,huongphucaptungay,chucdanhkh,qlnn,monday) values(@hoten,@truongid,@ngaysinh,@gioiTinh,@dantoc,
                @tongiao,@doanvien,@ngayvaodoan,@chuyenmon,@chuyennghanh,@chinhtri,@ngoaingu,@tinhoc,@cotiengdantoc,
                @ngayvaonghanh,@ngaychuyenden,@ngaybonhiem,@chucvu,@ngachluong,@mangach,@bacluong,@huongluongtungay,@phantramphucap,@huongphucaptungay,
                @chucdanhkh,@qlnn,@monday)",
                    "@hoten", txtHoTen.Text, "@truongid", TruongID, "@ngaysinh", Common.GetDateStringForQuery(dtNgaySinh.Value),
                    "@gioiTinh", cbGioiTinh.SelectedValue, "@dantoc", cbDanToc.SelectedValue
                    , "@tongiao", cbTonGiao.SelectedValue, "@doanvien", rdDoanVien.Checked ? 2 : 1, "@ngayvaodoan", Common.GetDateStringForQuery(dtNgayVaoDoan.Value)
                    , "@chuyenmon", cbChuyenMon.SelectedValue, "@chuyennghanh", cbChuyenNghanh.SelectedValue
                    , "@chinhtri", cbChinhTri.SelectedValue, "@ngoaingu", cbNgoaiNgu.SelectedValue
                    , "@tinhoc", cbTinHoc.SelectedValue, "@cotiengdantoc", chkTiengDanToc.Checked ? "1" : "0", "@ngayvaonghanh", Common.GetDateStringForQuery(dtNgayVaoNghanh.Value)
                    , "@ngaychuyenden", Common.GetDateStringForQuery(dtNgayChuyenDen.Value), "@ngaybonhiem", Common.GetDateStringForQuery(dtNgayBoNhiem.Value)
                    , "@chucvu", cbChucVu.SelectedValue, "@ngachluong", cbNgachLuong.SelectedValue, "@mangach", txtMaNgach.Text, "@bacluong", txtBacLuong.Text, "@huongluongtungay", Common.GetDateStringForQuery(dtHuongLuongTuNgay.Value)
                    , "@phantramphucap", nudPhuCap.Value, "@chucdanhkh", cbCdkh.SelectedValue
                    , "@qlnn", cbQlnn.SelectedValue
                    , "@monday", cbMonDay.SelectedValue
                    , "@huongphucaptungay", Common.GetDateStringForQuery(dtHuongPhuCapTuNgay.Value));
                //                SQLiteUtils.ExcuteNonQuery(string.Format(@"insert into CanBo values('{0}',{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}
                //,'{18}','{19}','{20}',{21},{22},{23})",
                //                                txtHoTen.Text
                //                   ,TruongID
                //                   , Common.GetDateStringForQuery(dtNgaySinh.Value)
                //                   , cbGioiTinh.SelectedValue
                //                   , cbDanToc.SelectedValue
                //                    , cbTonGiao.SelectedValue
                //                    , rdDoanVien.Checked ? 1 : 2
                //                    , Common.GetDateStringForQuery(dtNgayVaoDoan.Value)
                //                    , cbChuyenMon.SelectedValue
                //                    , cbChuyenNghanh.SelectedValue
                //                    , cbChinhTri.SelectedValue
                //                    , cbNgoaiNgu.SelectedValue
                //                    , cbTinHoc.SelectedValue
                //                    , chkTiengDanToc.Checked ? "1" : "0"
                //                    , Common.GetDateStringForQuery(dtNgayVaoNghanh.Value)
                //                    , Common.GetDateStringForQuery(dtNgayChuyenDen.Value)
                //                    , Common.GetDateStringForQuery(dtNgayBoNhiem.Value)
                //                    , cbChucVu.SelectedValue
                //                    , txtNgachLuong.Text
                //                    , txtMaNgach.Text
                //                    , txtBacLuong.Text
                //                    , Common.GetDateStringForQuery(dtHuongLuongTuNgay.Value)
                //                    , (float)nudPhuCap.Value / (100)
                //                    , Common.GetDateStringForQuery(dtHuongPhuCapTuNgay.Value)));
                GUIController.ShowMessageBox("Thêm cán bộ thành công!");
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

        private void rdDoanVien_CheckedChanged(object sender, EventArgs e)
        {
            dtNgayVaoDoan.Visible = rdDoanVien.Checked;
            laNgayvaodang.Visible = rdDoanVien.Checked;
        }

        private void cbNgachLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaNgach.Text = (string)cbNgachLuong.SelectedValue;
        }

    }
}
