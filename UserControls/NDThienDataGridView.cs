using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace QLGV.UserControls
{
    public partial class NDThienDataGridView : DataGridView
    {
        public NDThienDataGridView()
        {
            InitializeComponent();
            this.RowTemplate.DefaultCellStyle.Font = new Font("Tahoma", (float)9);
        }

        public NDThienDataGridView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        NDThienDataGridViewColumn[] _myDataGridViewColumns;

        public void AddColumns(NDThienDataGridViewColumn[] columns)
        {
            this.DataSource = null;
            this.Columns.Clear();

            DataGridViewColumn dgColumn;
            for (int i = 0; i < columns.Length; i++)
            {
                dgColumn = columns[i].CurrentInstance;
                //if (i == columns.Length - 1)
                //{
                //    dgColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //}
                this.Columns.Add(dgColumn);
            }
            _myDataGridViewColumns = columns;
        }

        protected override void OnDataSourceChanged(EventArgs e)
        {
            base.OnDataSourceChanged(e);

            //Sau khi gán DataSource cho DataGridView, tất cả các dataColumn của DataSource đều được hiển thị
            //cần phải ẩn đi những cột không có trong myDataGridViewColumn
            if (_myDataGridViewColumns != null && _myDataGridViewColumns.Length > 0)
            {
                for (int i = 0; i < this.Columns.Count; i++)
                {
                    for (int j = 0; j < _myDataGridViewColumns.Length; j++)
                    {
                        if (string.Equals(this.Columns[i].Name.ToUpper(), _myDataGridViewColumns[j].CurrentInstance.Name.ToUpper()))
                        {
                            break;
                        }
                        else
                        {
                            if (j == _myDataGridViewColumns.Length - 1)
                            {
                                this.Columns[i].Visible = false;
                            }
                        }
                    }
                }
            }
        }

        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    if (msg.WParam.ToInt32() == Convert.ToInt32(Keys.Enter))
        //    {
        //        SendKeys.Send("{Tab}");
        //        return true;
        //    }
        //    return base.ProcessCmdKey(ref msg, keyData);
        //}

        //protected override void OnDataError(bool displayErrorDialogIfNoHandler, DataGridViewDataErrorEventArgs e)
        //{
           
        //    DataGridViewColumn col = this.Columns[e.ColumnIndex];
        //    string str="";
        //    if (col.ValueType == typeof(Int32))
        //    {
        //        str = "số nguyên";
        //    }
        //    else if (col.ValueType == typeof(float))
        //    {
        //        str = "số";
        //    }
        //    else if (col.ValueType == typeof(decimal))
        //    {
        //        str = "số";
        //    }
        //    else if (col.ValueType == typeof(DateTime))
        //    {
        //        str = "ngày tháng";
        //    }
        //    MessageBox.Show(string.Format(@"Dữ liệu của [{0}] phải là {1}", col.HeaderText, str), "Thông báo");
        //}
    }
}