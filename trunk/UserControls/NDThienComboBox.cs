using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLGV.Models;
using System.Data;

namespace QLGV.UserControls
{
    public partial class NDThienComboBox : ComboBox
    {
        private void Load()
        {
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public NDThienComboBox()
        {
            InitializeComponent();

            Load();
        }

        public NDThienComboBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            Load();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.BackColor = System.Drawing.Color.Yellow;
            this.DroppedDown = true;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            this.DroppedDown = true;
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.BackColor = System.Drawing.Color.White;
        }

        public void PopulateData(List<ListItem> list)
        {
            this.Items.Clear();
            if (list.Count > 0)
            {
                foreach (ListItem item in list)
                {
                    this.Items.Add(item);
                }
                this.SelectedIndex = 0;
            }
        }
        public void PopulateData(DataTable dt, string valueField, string displayField, object selectedValue = null)
        {
            valueField = valueField ?? "ID";
            displayField = displayField ?? "Title";
            var list = new List<ListItem>();
            foreach (DataRow row in dt.Rows)
            {
                ListItem item;
                if (valueField == "ID")
                    item = new ListItem((string)row[displayField], int.Parse("0" + row[valueField]));
                else
                    item = new ListItem((string)row[displayField], (string)row[valueField]);
                list.Add(item);
            }
            this.PopulateData(list);
            if (selectedValue != null) this.SelectedValue = selectedValue;
        }
        public new object SelectedValue
        {
            get
            {
                if (this.SelectedItem != null)
                {
                    return ((ListItem)this.SelectedItem).Value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (this.Items.Count > 0)
                {
                    int index = 0;
                    foreach (ListItem item in this.Items)
                    {
                        if (object.Equals(item.Value, value))
                        {
                            break;
                        }
                        index++;
                    }
                    if (index < this.Items.Count)
                    {
                        this.SelectedIndex = index;
                    }
                }
            }
        }
    }
}
