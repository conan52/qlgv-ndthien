using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using QLGV.UserControls;

namespace QLGV.Forms
{
    public partial class List_ChucVu : Form
    {
        public List_ChucVu()
        {
            InitializeComponent();
        }

        #region Private methods

        void CreateViewItemsColumn()
        {
            viewItems.AddColumns(new NDThienDataGridViewColumn[] 
            {
                new NDThienDataGridViewColumn("STT", 40, NDThienDataGridViewColumnStyle.ReadOnly, NDThienDataGridViewColumnDataType.String),
                new NDThienDataGridViewColumn("Mã chức vụ", 150, NDThienDataGridViewColumnStyle.ReadOnly, NDThienDataGridViewColumnDataType.String),
                new NDThienDataGridViewColumn("Tên chức vụ", 250, NDThienDataGridViewColumnStyle.ReadOnly, NDThienDataGridViewColumnDataType.String),
            });
        }

        void PopulateViewItems()
        {
            try
            {
                viewItems.Rows.Clear();
                DataTable dt = SQLiteUtils.GetTable("select * from ChucVu");
                int i = 1;
                foreach (DataRow item in dt.Rows)
                {
                    viewItems.Rows.Add(i, item["Code"], item["Title"]);

                    viewItems.Rows[i - 1].Tag = item["ID"];
                    i++;
                }

                toolStripStatusLabelCount.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                GUIController.ShowErrorBox(ex);
            }
        }

        #endregion

        #region Private events

        private void List_ChucVu_Load(object sender, EventArgs e)
        {
            CreateViewItemsColumn();
            PopulateViewItems();
        }


        private void btNew_Click(object sender, EventArgs e)
        {
            var add = new Add_ChucVu();
            add.Text = "Thêm chức vụ";
            add.UpdateChanged += new EventHandler(addDM_DonViTienTe_UpdateChanged);
            add.ShowDialog();
        }

        void addDM_DonViTienTe_UpdateChanged(object sender, EventArgs e)
        {
            PopulateViewItems();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (viewItems.SelectedRows.Count == 0)
                {
                    GUIController.ShowMessageBox("Bạn phải chọn chức vụ xem/sửa!");
                    return;
                }
                
                int id = int.Parse("0" + viewItems.SelectedRows[0].Tag);
                if (id == 0)
                {
                    GUIController.ShowMessageBox("Bạn phải chọn chức vụ cần xem/sửa!");
                    return;
                }

                var addDM_DonViTienTe = new Add_ChucVu();
                addDM_DonViTienTe.ID = id;
                addDM_DonViTienTe.Text = "Sửa chức vụ";
                addDM_DonViTienTe.UpdateChanged += new EventHandler(addDM_DonViTienTe_UpdateChanged);
                addDM_DonViTienTe.ShowDialog();
            }
            catch (Exception ex)
            {
                GUIController.ShowErrorBox(ex);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            this.Close();
            //try
            //{
            //    if (viewItems.SelectedRows.Count == 0)
            //    {
            //        GUIController.ShowMessageBox("Bạn phải chọn chức vụ cần xóa!");
            //        return;
            //    }

            //    int id = int.Parse("0" + viewItems.SelectedRows[0].Tag);
            //    if (id == 0)
            //    {
            //        GUIController.ShowMessageBox("Bạn phải chọn chức vụ cần xóa!");
            //        return;
            //    }

            //    if (GUIController.ShowConfirmBox("Bạn có muốn chức vụ không?"))
            //    {
            //        int isSuccess = SQLiteUtils.ExcuteNonQuery("delete from chucvu where id=@id","@id", id);

            //        if (isSuccess > 0)
            //        {
            //            GUIController.ShowMessageBox(string.Format("Xóa chức vụ thành công!"));
            //            PopulateViewItems();
            //        }
            //        else
            //        {
            //            GUIController.ShowMessageBox(string.Format("Xóa chức vụ thất bại!"));
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    GUIController.ShowErrorBox(ex);
            //}
        }

        private void viewItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btEdit_Click(sender, null);
        }

        #endregion
    }
}
