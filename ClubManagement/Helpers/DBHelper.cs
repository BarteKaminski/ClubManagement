using ClubManagement.Models;
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
        public static bool InsertUpdate(string query)
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
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MainForm.ShowError("Błąd podczas łączenia z bazą danych");
                return false;
            }
        }
        public static void AddEditPlayer(int mode, PlayerData player, int userId)
        {
            try
            {
                using (var con = new SqlConnection(connString))
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("AddEditPlayer", con);
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@mode", mode);
                    com.Parameters.AddWithValue("@Pla_Id", player.Id);
                    com.Parameters.AddWithValue("@Pla_FirstName", player.FirstName);
                    com.Parameters.AddWithValue("@Pla_LastName", player.LastName);
                    com.Parameters.AddWithValue("@Pla_DateOfBirth", player.DateOfBirth);
                    com.Parameters.AddWithValue("@Pla_Phone", player.Phone);
                    com.Parameters.AddWithValue("@Pla_Email", player.Email);
                    com.Parameters.AddWithValue("@Pla_Country", player.Country);
                    com.Parameters.AddWithValue("@Pla_City", player.City);
                    com.Parameters.AddWithValue("@Pla_PostalCode", player.PostalCode);
                    com.Parameters.AddWithValue("@Pla_Street", player.Street);
                    com.Parameters.AddWithValue("@Pla_HouseNumber", player.HouseNumber);
                    com.Parameters.AddWithValue("@Pla_FlatNumber", player.FlatNumber);
                    com.Parameters.AddWithValue("@PlC_Nick", player.Nick);
                    com.Parameters.AddWithValue("@PlC_PositionId", player.PositionId);
                    com.Parameters.AddWithValue("@PlC_Number", player.Number);
                    com.Parameters.AddWithValue("@PlC_Leg", player.Leg);
                    com.Parameters.AddWithValue("@userId", userId);

                    com.ExecuteNonQuery();
                    if(mode == 1)
                    {
                        WriteLog("Add player", 0, "Info", $"Dodano zawodnika o ID: {player.Id}", userId);
                    }
                    else
                    {
                        WriteLog("Edit player", 0, "Info", $"Zaktualizowano zawodnika o ID: {player.Id}", userId);
                    }
               
                }
            }
            catch (Exception ex)
            {   
                if(mode == 1)
                {
                    WriteLog("Add player", -1, "Error", ex.ToString(), userId);
                }
                else
                {
                    WriteLog("Edit player", -1, "Error",$"ID: {player.Id}" + ex.ToString(), userId);
                }
                
                MainForm.ShowError("Błąd podczas łączenia z bazą danych");
            }
        }
        public static bool AddFile(FileData file, int userId)
        {
            try
            {
                using (var con = new SqlConnection(connString))
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("AddFile", con);
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@Fil_Name", file.Fil_Name);
                    com.Parameters.AddWithValue("@Fil_Size", file.Fil_Size);
                    com.Parameters.AddWithValue("@Fil_Extension", file.Fil_Extension);
                    com.Parameters.AddWithValue("@Fil_ObjectEnum", (object)file.Fil_ObjectEnum ?? DBNull.Value);
                    com.Parameters.AddWithValue("@Fil_ObjectId", (object)file.Fil_ObjectId ?? DBNull.Value);
                    com.Parameters.AddWithValue("@Fil_ObjectLp", (object)file.Fil_ObjectLp ?? DBNull.Value);
                    com.Parameters.AddWithValue("@Fil_BinaryData", file.Fil_BinaryData);
                    com.Parameters.AddWithValue("@UserId", userId);
                    com.ExecuteNonQuery();
                    WriteLog("Add file", 0, "Info", $"Dodano plik: {file.Fil_Name}", userId);
                    return true;
                }
            }
            catch (Exception ex)
            {
                WriteLog("Add file", -1, "Error", ex.ToString(), userId);
                MainForm.ShowError("Błąd podczas łączenia z bazą danych");
                return false;
            }
        }
        public static void WriteLog(string function, int result, string status, string message, int loggedUserId)
        {
            try
            {
                using (var con = new SqlConnection(connString))
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("WriteLog", con);
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@Log_Function", function);
                    com.Parameters.AddWithValue("@Log_Result", result);
                    com.Parameters.AddWithValue("@Log_Status", status);
                    com.Parameters.AddWithValue("@Log_Message", message);
                    com.Parameters.AddWithValue("@Log_UserCreated", loggedUserId);

                    com.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                MainForm.ShowError("Błąd podczas łączenia z bazą danych");
            }
        }
    }
}
