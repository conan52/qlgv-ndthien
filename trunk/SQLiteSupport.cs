using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data.SqlClient;
namespace QLGV
{
    public static class SQLiteUtils
    {
        //public static string strConnection = "Data Source=duykhanh\\express2008sp1;Initial Catalog=QLGV;User ID=sa;Password=abc123-";
       public static string strConnection = @"Data Source=D:\Recnaleerf\QL Giao Vien\DLL\QLGV.db;Version=3;UseUTF8Encoding=True";
        public static bool TestConnection()
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection(strConnection);
                conn.Open();
                conn.Close();
                conn.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static int ExcuteNonQuery(string commandText, params object[] pars)
        {
            SQLiteConnection conn = new SQLiteConnection(strConnection);
            SQLiteCommand co = CommandBuilder(conn, commandText, pars);

            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
            conn.Open();
            int n = co.ExecuteNonQuery();

            co.Dispose();
            conn.Close();
            conn.Dispose();
            return n;
        }

        public static object ExcuteScalar(string commandText, params object[] pars)
        {
            SQLiteConnection conn = new SQLiteConnection(strConnection);
            SQLiteCommand co = CommandBuilder(conn, commandText, pars);

            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
            conn.Open();
            object obj = co.ExecuteScalar();

            co.Dispose();
            conn.Close();
            conn.Dispose();
            return obj;
        }

        public static System.Data.DataTable GetTable(string commandText, params object[] pars)
        {
            SQLiteConnection conn = new SQLiteConnection(strConnection);
            SQLiteCommand co = CommandBuilder(conn, commandText, pars);

            SQLiteDataAdapter da = new SQLiteDataAdapter(co);

            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);

            co.Dispose();
            conn.Close();
            conn.Dispose();
            return dt;
        }

        private static SQLiteCommand CommandBuilder(SQLiteConnection conn, string commandText, params object[] pars)
        {
            if (pars.Length % 2 != 0) throw new Exception("Exception on parameter count");

            SQLiteCommand co = new SQLiteCommand(commandText, conn);

            for (int i = 0; i < pars.Length; i += 2)
            {
                string t = pars[i].ToString();
                if (t[0] != '@')
                    throw new Exception("Parameter name exception. Parameter name must be started by '@'");

                SQLiteParameter pa = new SQLiteParameter();
                pa.ParameterName = t;
                pa.Value = pars[i + 1];
                co.Parameters.Add(pa);
            }
            return co;
        }
    }
}