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
    public partial class List_ChucDanhKH : Form
    {
        public List_ChucDanhKH()
        {
            InitializeComponent();
        }

        #region Private methods

        void CreateViewItemsColumn()
        {
            viewItems.AddColumns(new NDThienDataGridViewColumn[] 
            {
                new NDThienDataGridViewColumn("STT", 40, NDThienDataGridViewColumnStyle.ReadOnly, NDThienDataGridViewColumnDataType.String),
                new NDThienDataGridViewColumn("Mã chức danh khoa học", 150, NDThienDataGridViewColumnStyle.ReadOnly, NDThienDataGridViewColumnDataType.String),
                new NDThienDataGridViewColumn("Tên chức danh khoa học", 250, NDThienDataGridViewColumnStyle.ReadOnly, NDThienDataGridViewColumnDataType.String),
            });
        }

        void PopulateViewItems()
        {
            try
            {
                viewItems.Rows.Clear();
                DataTable dt = SQLiteUtils.GetTable("select * from ChucDanhKH");
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

        private void List_TrinhDoChuyenMon_Load(object sender, EventArgs e)
        {
            CreateViewItemsColumn();
            PopulateViewItems();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            var add = new Add_ChucDanhKH();
            add.Text = "Thêm chức danh khoa học";
            add.UpdateChanged += new EventHandler(addDM_UpdateChanged);
            add.ShowDialog();
        }

        void addDM_UpdateChanged(object sender, EventArgs e)
        {
            PopulateViewItems();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (viewItems.SelectedRows.Count == 0)
                {
                    GUIController.ShowMessageBox("Bạn phải chọn chức danh khoa học xem/sửa!");
                    return;
                }

                int id = int.Parse("0" + viewItems.SelectedRows[0].Tag);
                if (id == 0)
                {
                    GUIController.ShowMessageBox("Bạn phải chọn chức danh khoa học cần xem/sửa!");
                    return;
                }

                var addDM = new Add_ChucDanhKH();
                addDM.ID = id;
                addDM.Text = "Sửa chức danh khoa học";
                addDM.UpdateChanged += new EventHandler(addDM_UpdateChanged);
                addDM.ShowDialog();
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
            //        GUIController.ShowMessageBox("Bạn phải chọn chức danh khoa học cần xóa!");
            //        return;
            //    }

            //    int id = int.Parse("0" + viewItems.SelectedRows[0].Tag);
            //    if (id == 0)
            //    {
            //        GUIController.ShowMessageBox("Bạn phải chọn chức danh khoa học cần xóa!");
            //        return;
            //    }

            //    if (GUIController.ShowConfirmBox("Bạn có muốn chức danh khoa học không?"))
            //    {
            //        int isSuccess = SQLiteUtils.ExcuteNonQuery("delete from ChucDanhKH where id=@id","@id", id);

            //        if (isSuccess > 0)
            //        {
            //            GUIController.ShowMessageBox(string.Format("Xóa chức danh khoa học thành công!"));
            //            PopulateViewItems();
            //        }
            //        else
            //        {
            //            GUIController.ShowMessageBox(string.Format("Xóa chức danh khoa học thất bại!"));
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
