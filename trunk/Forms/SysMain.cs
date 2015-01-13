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
        Form lstChucVu, lstTruongCB, lstDanToc, lstChuyenNghanh, lstTonGiao, lstNgoaiNgu, lstLyLuanChinhTri, lstTinHoc, lstTrinhDoChuyenMon;
        #region Methods
        public void ShowForm(string formName)
        {
            #region List forms
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

        #region Form Events
        private void MainForm_Load(object sender, EventArgs e)
        {
            new SysLogin().ShowDialog();
        }

        #endregion

        #region Menu click event
        private void menuFunction_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripItem item = (ToolStripItem)sender;
                if (item.Tag != null)
                {
                    string formName = (string)item.Tag;
                    ShowForm(formName);
                }
            }
            catch (Exception ex)
            {
                GUIController.ShowErrorBox(ex);
            }
        }
        private void menuLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SysChangePass().ShowDialog();
        }

        private void cấuHìnhHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ShowReport().Show();
        }

        //--------------------------------------- BÁO CÁO ---------------------------------------------
        private void báoCáoBiênChếToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ShowReport().Show();
        }
        private void bcDacDiem_Click(object sender, EventArgs e)
        {
            new ShowReport().Show();
        }

        //Số lượng sheet M1
        private void thốngKêSốLượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ShowReport().Show();
        }
        //Số lượng sheet M2
        private void bcSLM2_Click(object sender, EventArgs e)
        {
            new ShowReport().Show();
        }

        #region Trình độ
        private void tổngHợpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void c0ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void c1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void c2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thừaThiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}

