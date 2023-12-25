using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagement.Helpers
{
    class DBHelper
    {
        static string connString = HashHelper.DecodeConnString(Properties.Settings.Default.connString);
        public static DataTable SQL_dt(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var con = new SqlConnection(connString))
                {
                    con.Open();
                    using (var com = con.CreateCommand())
                    {
                        com.CommandType = System.Data.CommandType.Text;
                        com.CommandText = query;
                        dt.Load(com.ExecuteReader());
                    }
                }
                return dt;
            }
            catch (Exception ex)
            {
                MainForm.ShowError("Błąd podczas łączenia z bazą danych " + ex.ToString());
            }
            return null;
        }

        public static DataSet SQL_ds(string query)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var con = new SqlConnection(connString))
                {
                    con.Open();
                    using (var com = con.CreateCommand())
                    {
                        com.CommandType = System.Data.CommandType.Text;
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = com;
                        com.CommandText = query;
                        da.Fill(ds);
                    }
                }
                return ds;
            }
            catch (Exception)
            {
                MainForm.ShowError("Błąd podczas łączenia z bazą danych");
            }
            return null;
        }

        public static string SQL_string(string query)
        {
            try
            {
                DataTable dt = new DataTable();
                using (var con = new SqlConnection(connString))
                {
                    con.Open();
                    using (var com = con.CreateCommand())
                    {
                        com.CommandType = System.Data.CommandType.Text;
                        com.CommandText = query;
                        dt.Load(com.ExecuteReader());
                    }
                }
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0][0] != DBNull.Value)
                    {
                        return dt.Rows[0][0].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MainForm.ShowError("Błąd podczas łączenia z bazą danych");
            }
            return "";
        }

        public static int SQL_int(string query)
        {
            try
            {
                DataTable dt = new DataTable();
                using (var con = new SqlConnection(connString))
                {
                    con.Open();
                    using (var com = con.CreateCommand())
                    {
                        com.CommandType = System.Data.CommandType.Text;
                        com.CommandText = query;
                        dt.Load(com.ExecuteReader());
                    }
                }
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0][0] != DBNull.Value)
                    {
                        int res;
                        if (Int32.TryParse(dt.Rows[0][0].ToString(), out res))
                        {
                            return res;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MainForm.ShowError("Błąd podczas łączenia z bazą danych");
            }
            return 0;
        }
        public static void InsertUpdate(string query)
        {
            try
            {
                using (var con = new SqlConnection(connString))
                {
                    con.Open();
                    using (var com = con.CreateCommand())
                    {
                        com.CommandType = System.Data.CommandType.Text;
                        com.CommandText = query;
                        com.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                MainForm.ShowError("Błąd podczas łączenia z bazą danych");
            }
        }
    }
}
