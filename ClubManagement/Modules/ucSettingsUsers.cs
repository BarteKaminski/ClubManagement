using ClubManagement.Helpers;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClubManagement.MainForm;

namespace ClubManagement.Modules
{
    public partial class ucSettingsUsers : DevExpress.DXperience.Demos.TutorialControlBase, refresher
    {
        public ucSettingsUsers()
        {
            InitializeComponent();
            RefreshData();
            cb_usersList.DisplayMember = "name";
            cb_usersList.ValueMember = "id";
        }
        public void RefreshData()
        {
            cb_usersList.DataSource = DBHelper.SQL_dt("select use_id id, use_login +' - ' + use_name name from dbo.Users where use_isActive=1");
        }
        private void btn_UserAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_login.Text) && !string.IsNullOrEmpty(txt_name.Text))
            {
                int res;
                int isAdmin = 0;
                if (chck_admin.Checked == true)
                {
                    isAdmin = 1;
                }
                res = DBHelper.SQL_int($"exec dbo.AddUser '{txt_login.Text.Replace("'", "''")}', '{txt_name.Text.Replace("'", "''")}', {isAdmin},{loggedUserId}"); 
                if (res == 0)
                {
                    txt_login.Text = "";
                    txt_name.Text = "";
                    RefreshData();
                    DBHelper.WriteLog("Register user", 0, "Info", $"Zarejestrowano nowego użytwkonika z loginem: {txt_login.Text}", loggedUserId);
                    ShowOk("Zarejestrowano pomyślnie");
                }
                else if (res == -1)
                {
                    ShowError("Użytkownik z takim loginem już istnieje");
                }
            }
            else
            {
                ShowWarning("Najpierw wprowadź dane");
            }
        }

        private void btn_ResetPass_Click(object sender, EventArgs e)
        {
            int userId;
            if (int.TryParse(((DataRowView)cb_usersList.SelectedItem).Row["id"].ToString(), out userId))
            {
                DBHelper.InsertUpdate($"update dbo.Users set Use_Password=NULL, Use_LastModifiedDate= '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', Use_LastModifiedUser={loggedUserId} where Use_Id={userId}");
                DBHelper.WriteLog("Reset password", 0, "Info", $"Zresetowano hasło dla użytnownika o ID: {userId}", loggedUserId);
                ShowOk("Hasło zostało zresetowane");
            }
        }

        private void brn_archivize_Click(object sender, EventArgs e)
        {
            int userId;
            if (int.TryParse(((DataRowView)cb_usersList.SelectedItem).Row["id"].ToString(), out userId))
            {
                DBHelper.InsertUpdate($"update dbo.Users set use_isActive=0, Use_LastModifiedDate='{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', Use_LastModifiedUser={loggedUserId} where Use_Id={userId}");
                DBHelper.WriteLog("Archive user", 0, "Info", $"Zarchiwizowano użytnownika o ID: {userId}", loggedUserId);
                ShowOk("Użytkownik został zarchiwizowany");
            }
            RefreshData();
        }
    }
}
