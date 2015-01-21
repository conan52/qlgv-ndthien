using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace QLGV
{
    public class Common
    {

        public static DateTime DateTimeStartDay(DateTime inputDateTime)
        {
            return new DateTime(inputDateTime.Year, inputDateTime.Month, inputDateTime.Day);
        }

        public static DateTime DateTimeEndDay(DateTime inputDateTime)
        {
            return new DateTime(inputDateTime.Year, inputDateTime.Month, inputDateTime.Day, 23, 59, 59, 998);
        }

        public static string GetDateString(DateTime? datetime)
        {
            if (datetime != null)
            {
                return datetime.Value.ToString(GlobalVariables.DateTimeFormatString);
            }
            else
            {
                return "N/A";
            }
        }
        public static DateTime GetDateStringForQuery(DateTime? datetime)
        {
            if (datetime != null)
            {
                return datetime.Value;
            }
            else
            {
                return DateTime.Now;
            }
        }
        public static string GetMoneyString(decimal? money)
        {
            if (money != null)
            {
                return money.Value.ToString(GlobalVariables.MoneyFormatString);
            }
            else
            {
                return "0";
            }
        }

        public static string GetQualityString(decimal? quality)
        {
            if (quality != null)
            {
                return quality.Value.ToString(GlobalVariables.QualityFormatString);
            }
            else
            {
                return "0";
            }
        }

        public static void StandardMoneyTextbox(TextBox txt)
        {
            decimal value = 0;
            string str = txt.Text.Trim();
            decimal.TryParse(str, out value);
            if (value == 0)
            {
                txt.Text = "";
            }
            else
            {
                txt.Text = value.ToString(GlobalVariables.MoneyFormatString);
                txt.SelectionStart = txt.Text.Length;
            }
        }

        public static void StandardQualityTextbox(TextBox txt)
        {
            decimal value = 0;
            string str = txt.Text.Trim();
            decimal.TryParse(str, out value);
            if (value == 0)
            {
                txt.Text = "";
            }
            else
            {
                txt.Text = str;
                txt.SelectionStart = txt.Text.Length;
            }
        }

        public static void StandardCodeTextbox(TextBox txt)
        {
            string str = txt.Text.Trim();
            if (string.IsNullOrEmpty(str))
            {
                txt.Text = "";
            }
            else
            {
                txt.Text = str.ToUpper();
                txt.SelectionStart = txt.Text.Length;
            }
        }

        public static string GetDayOfWeek(DayOfWeek d)
        {
            switch (d)
            {
                case DayOfWeek.Friday:
                    return "Thứ sáu";
                case DayOfWeek.Monday:
                    return "Thứ hai";
                case DayOfWeek.Saturday:
                    return "Thứ bảy";
                case DayOfWeek.Sunday:
                    return "Chủ nhật";
                case DayOfWeek.Thursday:
                    return "Thứ năm";
                case DayOfWeek.Tuesday:
                    return "Thứ ba";
                case DayOfWeek.Wednesday:
                    return "Thứ tư";
            }
            return "";
        }
    }
}
