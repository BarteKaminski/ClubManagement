using ClubManagement.Helpers;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClubManagement.MainForm;

namespace ClubManagement.Modules
{
    public partial class ucSettingsProfile : DevExpress.DXperience.Demos.TutorialControlBase, refresher
    {
        static string Login;
        public ucSettingsProfile()
        {
            InitializeComponent();
            RefreshData();
        }
        public void RefreshData()
        {
            var dt = DBHelper.SQL_dt($"select Use_Login, isnull(Use_Name,'') from dbo.users where Use_Id=1");
            Login = dt.Rows[0][0].ToString();
            lbl_userName.Text = "Login: " + Login + Environment.NewLine + Environment.NewLine + "Nazwa: " + dt.Rows[0][1];
        }

        private void btn_savePassword_Click(object sender, EventArgs e)
        {
            var error = UpdatePassword();
            if (error == "")
            {
                DBHelper.WriteLog("Update password", 0, "Info", $"Zaktualizowano hasło dla użytkownika o ID: {loggedUserId}", loggedUserId);
                ShowOk("Hasło zostało zaktualizowane");
            }
            else
            {
                DBHelper.WriteLog("Update password", -1, "Error", $"Nie udało się zaktualizowano hasło dla użytkownika o ID: {loggedUserId} - {error}", loggedUserId);
                ShowError(error);
            }
            txt_oldPass.Text = "";
            txt_newPass.Text = "";
            txt_newPass2.Text = "";
       }

        private string UpdatePassword()
        {
            string oldPasswordHash;
            string newPasswordHash;
            int error;

            if (txt_oldPass.Text == "" || txt_newPass.Text == "" || txt_newPass2.Text == "")
            {
                return "Najpierw wprowadź dane";
            }
            else if (txt_newPass.Text != txt_newPass2.Text)
            {
                return "Nowe hasła nie są identyczne";
            }
            else
            {
                oldPasswordHash = HashHelper.HashPassword(txt_oldPass.Text);
                newPasswordHash = HashHelper.HashPassword(txt_newPass.Text);
            }

            try
            {
                DataRow dr;
                dr = DBHelper.SQL_dt($"exec dbo.LoginTry '{Login}', '{oldPasswordHash.Replace("'", "''")}', '{Assembly.GetExecutingAssembly().GetName().Version.ToString()}'").Rows[0];
                error = Convert.ToInt32(dr[0]);

                if (error == -4)
                {
                    return "Nieprawidłowa wersja aplikacji";
                }
                else if (error == -2)
                {
                    return "Nieprawidłowe hasło";
                }
                else if (error == -1)
                {
                    return "Użytkownik nieaktywny";
                }
                else if (error == 0)
                {
                    DBHelper.InsertUpdate($"update dbo.users set use_password='{newPasswordHash.Replace("'", "''")}', Use_LastModifiedDate= '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', Use_LastModifiedUser={loggedUserId} where use_id={loggedUserId}");
                    return "";
                }
            }
            catch (Exception) { }

            return "Wystąpił nieokreślony błąd";
        }
    }
}