using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using QLGV.Controllers;

namespace QLGV
{
    public static class GlobalVariables
    {
        private static string _exeDirectoryPath;

        private static string ExeDirectoryPath
        {
            get
            {
                if (string.IsNullOrEmpty(_exeDirectoryPath))
                {
                    string exeFilePath = Application.ExecutablePath;
                    _exeDirectoryPath = exeFilePath.Substring(0, exeFilePath.LastIndexOf('\\') + 1);
                }
                return _exeDirectoryPath;
            }
        }

        private static string GlobalVariablesFilePath
        {
            get { return ExeDirectoryPath + "GlobalVariables.config"; }
        }

        public static string DockPanelFilePath
        {
            get { return ExeDirectoryPath + "DockPanel.config"; }
        }

        private static string GetGlobalVariables(string nodeName)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(GlobalVariablesFilePath);
                return xmlDoc.SelectSingleNode("QLGV/" + nodeName).ChildNodes[0].Value;
            }
            catch (Exception ex)
            {
                GUIController.ShowErrorBox(string.Format("Xảy ra lỗi file cấu hình tham số mặc định [{0}]", GlobalVariablesFilePath), ex);
                return string.Empty;
            }
        }

        /// <summary>
        /// Chuỗi kết nối tới CSDL
        /// </summary>
        public static readonly string ConnectionString = GetGlobalVariables("ConnectionString");

        /// <summary>
        /// Định dạng ngày/tháng/năm
        /// </summary>
        public static readonly string DateTimeFormatString = GetGlobalVariables("DateTimeFormatString");

        /// <summary>
        /// Định dạng ngày/tháng/năm giờ:phút:giây
        /// </summary>
        public static readonly string LongDateTimeFormatString = GetGlobalVariables("LongDateTimeFormatString");

        /// <summary>
        /// Định dạng số lượng
        /// </summary>
        public static readonly string QualityFormatString = GetGlobalVariables("QualityFormatString");

        /// <summary>
        /// Định dạng số tiền
        /// </summary>
        public static readonly string MoneyFormatString = GetGlobalVariables("MoneyFormatString");

    }
}
