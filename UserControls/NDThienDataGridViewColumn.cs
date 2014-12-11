using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace QLGV.UserControls
{

    public enum NDThienDataGridViewColumnDataType
    {
        String,
        Bool,
        Button
    }

    public enum NDThienDataGridViewColumnStyle
    {
        None,
        Hide,
        ReadOnly
    }

    public partial class NDThienDataGridViewColumn : DataGridViewColumn
    {
        public NDThienDataGridViewColumn()
        {
            InitializeComponent();
        }

        public NDThienDataGridViewColumn(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private DataGridViewColumn _currentInstance;

        public DataGridViewColumn CurrentInstance
        {
            get { return _currentInstance; }
        }

        public NDThienDataGridViewColumn(string headerText, string columnName, string dataPropertyName,
            int width, NDThienDataGridViewColumnStyle columnStyle, NDThienDataGridViewColumnDataType columnDataType, DataGridViewAutoSizeColumnMode autoSizeMode)
        {
            switch (columnDataType)
            {
                case NDThienDataGridViewColumnDataType.String:
                    _currentInstance = new DataGridViewTextBoxColumn();
                    break;
                case NDThienDataGridViewColumnDataType.Bool:
                    _currentInstance = new DataGridViewCheckBoxColumn();
                    break;
                case NDThienDataGridViewColumnDataType.Button:
                    _currentInstance = new DataGridViewButtonColumn();
                    break;
                default:
                    _currentInstance = new DataGridViewTextBoxColumn();
                    break;
            }

            _currentInstance.HeaderText = headerText;
            _currentInstance.DataPropertyName = dataPropertyName;
            _currentInstance.Name = columnName;
            _currentInstance.Width = width;
            _currentInstance.AutoSizeMode = autoSizeMode;

            switch (columnStyle)
            {
                case NDThienDataGridViewColumnStyle.None:
                    break;
                case NDThienDataGridViewColumnStyle.Hide:
                    _currentInstance.Visible = false;
                    _currentInstance.ReadOnly = true;//đề phòng trường hợp visible=true :D
                    break;
                case NDThienDataGridViewColumnStyle.ReadOnly:
                    _currentInstance.ReadOnly = true;
                    break;
                default:
                    break;
            }
        }

        public NDThienDataGridViewColumn(string headerText, int width,
            NDThienDataGridViewColumnStyle columnStyle, NDThienDataGridViewColumnDataType columnDataType)
            : this(headerText, string.Empty, string.Empty, width, columnStyle, columnDataType, DataGridViewAutoSizeColumnMode.None)
        {
        }

        public NDThienDataGridViewColumn(string headerText, int width,
            NDThienDataGridViewColumnStyle columnStyle, NDThienDataGridViewColumnDataType columnDataType,
            DataGridViewAutoSizeColumnMode autoSizeMode)
            : this(headerText, string.Empty, string.Empty, width, columnStyle, columnDataType, autoSizeMode)
        {
        }

        public NDThienDataGridViewColumn(string headerText, string dataPropertyName, int width,
           NDThienDataGridViewColumnStyle columnStyle, NDThienDataGridViewColumnDataType columnDataType)
           : this(headerText, dataPropertyName, dataPropertyName, width, columnStyle, columnDataType, DataGridViewAutoSizeColumnMode.None)
        {
        }
    }
}

