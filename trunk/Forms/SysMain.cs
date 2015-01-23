using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLGV.Controllers;
using QLGV.Models;
using System.IO;

namespace QLGV.Forms
{
    public partial class SysMain : Form
    {
        /// <summary>
        /// Danh sách chức năng được phân quyền cho user
        /// </summary>
        public SysMain()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            new SysLogin().ShowDialog();
        }

        Form lstChucDanhKH, lstMonDay, lstNgachLuong, lstQLNN, lstChucVu, lstTruongCB, lstDanToc, lstChuyenNghanh, lstTonGiao, lstNgoaiNgu, lstLyLuanChinhTri, lstTinHoc, lstTrinhDoChuyenMon;
        Form config, chagepass;
        #region Methods
        public void ShowForm(string formName)
        {
            #region List forms
            if (formName == typeof(SysChangePass).Name)
            {
                if (chagepass == null || chagepass.IsDisposed)
                {
                    chagepass = new SysChangePass();
                }
                chagepass.MdiParent = this;
                chagepass.Show();
                return;
            }
            if (formName == typeof(SysConfig).Name)
            {
                if (config == null || config.IsDisposed)
                {
                    config = new SysConfig();
                }
                config.MdiParent = this;
                config.Show();
                return;
            }
            if (formName == typeof(List_NgachLuong).Name)
            {
                if (lstNgachLuong == null || lstNgachLuong.IsDisposed)
                {
                    lstNgachLuong = new List_NgachLuong();
                }
                lstNgachLuong.MdiParent = this;
                lstNgachLuong.Show();
                return;
            }
            if (formName == typeof(List_MonDay).Name)
            {
                if (lstMonDay == null || lstMonDay.IsDisposed)
                {
                    lstMonDay = new List_MonDay();
                }
                lstMonDay.MdiParent = this;
                lstMonDay.Show();
                return;
            }
            if (formName == typeof(List_QLNN).Name)
            {
                if (lstQLNN == null || lstQLNN.IsDisposed)
                {
                    lstQLNN = new List_QLNN();
                }
                lstQLNN.MdiParent = this;
                lstQLNN.Show();
                return;
            }
            if (formName == typeof(List_ChucVu).Name)
            {
                if (lstChucVu == null || lstChucVu.IsDisposed)
                {
                    lstChucVu = new List_ChucVu();
                }
                lstChucVu.MdiParent = this;
                lstChucVu.Show();
                return;
            }
            if (formName == typeof(List_ChucDanhKH).Name)
            {
                if (lstChucDanhKH == null || lstChucDanhKH.IsDisposed)
                {
                    lstChucDanhKH = new List_ChucDanhKH();
                }
                lstChucDanhKH.MdiParent = this;
                lstChucDanhKH.Show();
                return;
            }
            if (formName == typeof(List_DanToc).Name)
            {
                if (lstDanToc == null || lstDanToc.IsDisposed)
                {
                    lstDanToc = new List_DanToc();
                }
                lstDanToc.MdiParent = this;
                lstDanToc.Show();
                return;
            }
            if (formName == typeof(List_TonGiao).Name)
            {
                if (lstTonGiao == null || lstTonGiao.IsDisposed)
                {
                    lstTonGiao = new List_TonGiao();
                }
                lstTonGiao.MdiParent = this;
                lstTonGiao.Show();
                return;
            }
            if (formName == typeof(List_LyLuanChinhTri).Name)
            {
                if (lstLyLuanChinhTri == null || lstLyLuanChinhTri.IsDisposed)
                {
                    lstLyLuanChinhTri = new List_LyLuanChinhTri();
                }
                lstLyLuanChinhTri.MdiParent = this;
                lstLyLuanChinhTri.Show();
                return;
            }
            if (formName == typeof(List_TinHoc).Name)
            {
                if (lstTinHoc == null || lstTinHoc.IsDisposed)
                {
                    lstTinHoc = new List_TinHoc();
                }
                lstTinHoc.MdiParent = this;
                lstTinHoc.Show();
                return;
            }
            if (formName == typeof(List_TrinhDoChuyenMon).Name)
            {
                if (lstTrinhDoChuyenMon == null || lstTrinhDoChuyenMon.IsDisposed)
                {
                    lstTrinhDoChuyenMon = new List_TrinhDoChuyenMon();
                }
                lstTrinhDoChuyenMon.MdiParent = this;
                lstTrinhDoChuyenMon.Show();
                return;
            }
            if (formName == typeof(List_NgoaiNgu).Name)
            {
                if (lstNgoaiNgu == null || lstNgoaiNgu.IsDisposed)
                {
                    lstNgoaiNgu = new List_NgoaiNgu();
                }
                lstNgoaiNgu.MdiParent = this;
                lstNgoaiNgu.Show();
                return;
            }
            if (formName == typeof(List_ChuyenNghanh).Name)
            {
                if (lstChuyenNghanh == null || lstChuyenNghanh.IsDisposed)
                {
                    lstChuyenNghanh = new List_ChuyenNghanh();
                }
                lstChuyenNghanh.MdiParent = this;
                lstChuyenNghanh.Show();
                return;
            }
            if (formName == typeof(List_Truong_CanBo).Name)
            {
                if (lstTruongCB == null || lstTruongCB.IsDisposed)
                {
                    lstTruongCB = new List_Truong_CanBo();
                }
                lstTruongCB.MdiParent = this;
                lstTruongCB.Show();
                return;
            }
            #endregion

            //#region Add forms
            //else if (formName == typeof(Add_PhieuYeuCau).Name)
            //{
            //    if (listPhieuYeuCau == null || listPhieuYeuCau.IsDisposed)
            //    {
            //        addPhieuYeuCau = new Add_PhieuYeuCau();
            //        addPhieuYeuCau.Text = "Thêm phiếu yêu cầu";
            //        addPhieuYeuCau.ShowDialog();
            //    }
            //    else
            //    {
            //        listPhieuYeuCau.Show(dockPanel);
            //        ((List_PhieuYeuCau)listPhieuYeuCau).AddPhieuYeuCau();
            //    }
            //}
            //#endregion
        }
        #endregion

        #region Menu click event
        private void menuFunction_Click(object sender, EventArgs e)
        {
            //try
            //{
                ToolStripItem item = (ToolStripItem)sender;
                if (item.Tag != null)
                {
                    string formName = (string)item.Tag;
                    ShowForm(formName);
                }
            //}
            //catch (Exception ex)
            //{
            //    GUIController.ShowErrorBox(ex);
            //}
        }
        private void menuLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion



        //--------------------------------------- BÁO CÁO ---------------------------------------------
        #region báo cáo biên chế
        //Tong hop
        private void tổngHợpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ShowReport("ThongKeSoLuong");

            frm.Show();
        }

        private void c0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ShowReport("C0");

            frm.Show();
        }

        private void c1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ShowReport("C1");

            frm.Show();
        }

        private void c2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ShowReport("C2");

            frm.Show();
        }

        private void thuaThieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ShowReport("ThuaThieu");

            frm.Show();
        }
        #endregion

        private void MamNonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ShowReport("TDMamNon");

            frm.Show();
        }

        private void TieuHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ShowReport("TDTieuHoc");

            frm.Show();
        }

        private void THCSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ShowReport("TDTHCS");

            frm.Show();
        }

        private void TongHoppToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new ShowReport("TDTH");

            frm.Show();
        }
    }
}

