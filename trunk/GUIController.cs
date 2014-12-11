using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using QLGV.Forms;
using QLGV.UserControls;
using QLGV.Models;

namespace QLGV
{
    public class GUIController
    {
        public static void ShowMessageBox(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowErrorBox(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowErrorBox(string message, Exception ex)
        {
            SysErrorMessage frm = new SysErrorMessage();
            frm.messageString = message;
            frm.errorException = ex;
            frm.ShowDialog();
        }

        public static void ShowErrorBox(Exception ex)
        {
            SysErrorMessage frm = new SysErrorMessage();
            frm.errorException = ex;
            frm.ShowDialog();
        }

        public static bool ShowConfirmBox(string message)
        {
            return MessageBox.Show(message + "\r\n\r\n" + "Yes (Có), No (Không)", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public static void ResetValueInControl(Form frm)
        {
            foreach (Control item in frm.Controls)
            {
                ResetTagInControl(item);
            }

            foreach (Control item in frm.Controls)
            {
                ResetValueInControl(item);
            }
        }

        public static void ResetTagInControl(Control ctr)
        {
            ctr.Tag = null;
            foreach (Control item in ctr.Controls)
            {
                ResetTagInControl(item);
            }
        }

        public static void ResetValueInControl(Control ctr)
        {
            var txt = ctr as TextBox;
            if (txt != null)
            {
                txt.Text = string.Empty;
            }

            var dtp = ctr as DateTimePicker;
            if (dtp != null)
            {
                dtp.Value = Common.DateTimeStartDay(DateTime.Now);
            }

            var pic = ctr as NDThienPictureBox;
            if (pic != null)
            {
                pic.ImageLocation = string.Empty;
            }

            if (ctr.Tag != null)
            {
                ctr.Tag = null;
            }

            foreach (Control item in ctr.Controls)
            {
                ResetValueInControl(item);
            }
        }

        public static void DisableInputControl(Form frm)
        {
            foreach (Control item in frm.Controls)
            {
                DisableInputControl(item);
            }
        }

        public static void DisableInputControl(Control ctr)
        {
            ctr.Enabled = ctr is NDThienPictureBox || ctr is Label || ctr is GroupBox;
            foreach (Control item in ctr.Controls)
            {
                DisableInputControl(item);
            }
        }    
    }
}
