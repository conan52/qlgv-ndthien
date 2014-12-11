using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace QLGV.Utilities
{
    public sealed class RegistryServices
    {
        public class HKEY_CURRENT_USER
        {
            public static string DefaultSubKey = "Software\\NDThien.DanCu";
            public static object Read(string registryKey, string keyName)
            {
                try
                {
                    RegistryKey key = Registry.CurrentUser.OpenSubKey(registryKey, true);
                    if (key!=null && key.GetValue(keyName) != null)
                    {
                        return key.GetValue(keyName);
                    }
                    return null;
                }
                catch
                {
                    return null;
                }
            }

            public static void RemoveAllRegeditValue(string registryKey)
            {
                try
                {
                    RegistryKey key = Registry.CurrentUser.OpenSubKey(registryKey, true);                    
                    //string[] valueNames = key.GetValueNames();
                    //for (int i = 0; i < valueNames.Length; i++)
                    //{
                    //    key.DeleteValue(valueNames[i]);
                    //}
                    if (key != null)
                    {
                        Registry.CurrentUser.DeleteSubKey(registryKey);
                    }
                }
                catch
                {
                }
            }

            public static bool Write(string registryKey, string keyName, object value)
            {
                try
                {
                    RegistryKey key = Registry.CurrentUser.OpenSubKey(registryKey, true);
                    if (key == null)
                    {
                        key = Registry.CurrentUser.CreateSubKey(registryKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
                    }
                    key.SetValue(keyName, value);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public class HKEY_USERS
        {
            [DllImport("kernel32.dll")]
            private static extern uint GetUserDefaultLCID();
            [DllImport("kernel32.dll")]
            static extern bool SetLocaleInfo(uint Locale, uint LCType, string lpLCData);
            public const int LOCALE_SSHORTDATE = 0x1F;
            public const int LOCALE_SDATE = 0x1D;

            /// <summary>
            /// Sets the short date format for windows.
            /// </summary>
            /// <param name="strShortDate">The short date format</param>
            public static void SetShortDate(string strShortDate)
            {
                try
                {
                    uint lngLCID;
                    lngLCID = GetUserDefaultLCID();
                    SetLocaleInfo(lngLCID, LOCALE_SSHORTDATE, strShortDate);
                    SetLocaleInfo(lngLCID, LOCALE_SDATE, "/");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static string GetShortDateFormat()
            {
                try
                {
                    RegistryKey regKey = Registry.Users;
                    regKey = regKey.OpenSubKey(".DEFAULT\\Control Panel\\International");
                    string formatDate = regKey.GetValue("sShortDate").ToString();
                    return formatDate;
                }
                catch
                {
                    return string.Empty;
                }
            }
        }
    }
}