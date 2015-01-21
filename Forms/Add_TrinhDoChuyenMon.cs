﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace QLGV.Forms
{
    public partial class Add_TrinhDoChuyenMon : Form
    {
        internal event EventHandler UpdateChanged;
        internal int ID = 0;
        public Add_TrinhDoChuyenMon()
        {
            InitializeComponent();
        }

        private void Add_HT_TrinhDoChuyenMon_Form_Load(object sender, EventArgs e)
        {
            try
            {
                if (ID != 0)
                {
                    var dt = SQLiteUtils.GetTable("select * from TrinhDoChuyenMon where ID = @id", "@id", ID);
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
                GUIController.ShowMessageBox("Bạn phải nhập tên trình độ chuyên môn");
                txtTitle.Focus();
                return;
            }

            //Trường hợp sửa cán bộ
            if (ID != 0)
            {
                SQLiteUtils.ExcuteNonQuery("update TrinhDoChuyenMon set Title = @title, Code=@code where ID=@id", "@title", txtTitle.Text, "@id", ID, "@code", txtCode.Text);

                GUIController.ShowMessageBox("Sửa trình độ chuyên môn thành công!");
            }
            //Trường hợp thêm cán bộ
            else
            {
                SQLiteUtils.ExcuteNonQuery("insert into TrinhDoChuyenMon(title,code) values(@title,@code)", "@title", txtTitle.Text, "@code", txtCode.Text);

                GUIController.ShowMessageBox("Thêm trình độ chuyên môn thành công!");
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