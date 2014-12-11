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
    public partial class SysErrorMessage : Form
    {
        public string messageString;
        public Exception errorException;

        public SysErrorMessage()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ErrorMessageForm_Load(object sender, EventArgs e)
        {
            this.Height = this.Height - 100;
            richTextBoxStackTrace.Visible = false;
            labelMessage.Text = !string.IsNullOrEmpty(messageString) ? messageString : "Có lỗi ngoại lệ: " + errorException.Message;
        }

        private bool _isDetail;
        private void buttonDetail_Click(object sender, EventArgs e)
        {
            if (!_isDetail)
            {
                _isDetail = true;
                this.Height = this.Height + 100;
                richTextBoxStackTrace.Visible = true;
                richTextBoxStackTrace.Text = errorException.Message + "\r\n" + errorException.StackTrace;
            }
        }
    }
}
