using ClubManagement.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ClubManagement
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
            lbl_version.Text = "v" + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
        private void LoginForm_Shown(object sender, EventArgs e)
        {
            this.Hide();
            try
            {
                if (File.Exists(XmlHelper.fileConfPath))
                {
                    XmlFile loginFile = new XmlFile();
                    loginFile = XmlHelper.ReadLoginData();
                    if (!string.IsNullOrEmpty(loginFile.login) && !string.IsNullOrEmpty(loginFile.pass))
                    {
                        VerifyLogin(loginFile.login, loginFile.pass, true);
                    }
                    else
                    {
                        this.Show();
                    }
                }
                else
                {
                    this.Show();
                }
                
            }
            catch (Exception) { this.Show(); }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            VerifyLogin(txt_login.Text, txt_password.Text, false);
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                VerifyLogin(txt_login.Text, txt_password.Text, false);
                e.Handled = true;
            }
        }

        private void txt_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                VerifyLogin(txt_login.Text, txt_password.Text, false);
                e.Handled = true;
            }
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                VerifyLogin(txt_login.Text, txt_password.Text, false);
                e.Handled = true;
            }
        }

       

        private void VerifyLogin(string login, string password, bool isPassHashed)
        {
            txt_info.Text = "";

            if (login == "")
            {
                txt_info.Text = "Nie podano loginu";
            }
            else
            {
                string passwordHash;
                int error = -99;


                if (password == "")
                {
                    passwordHash = "";
                }
                else
                {
                    if (isPassHashed)
                    {
                        passwordHash = password;
                    }
                    else
                    {
                        passwordHash = HashHelper.HashPassword(password);
                    }
                }

                try
                {
                    DataRow dr;
                    dr = DBHelper.SQL_dt($"exec dbo.LoginTry '{login}', '{passwordHash.Replace("'", "''")}', '{Assembly.GetExecutingAssembly().GetName().Version.ToString()}'").Rows[0];
                    error = Convert.ToInt32(dr[0]);


                    if (error == -4)
                    {
                        txt_info.Text = "Nieprawidłowa wersja aplikacji";
                    }
                    else if (error == -2)
                    {
                        txt_info.Text = "Nieprawidłowe dane logowania";
                    }
                    else if (error == -3)
                    {
                        txt_info.Text = "W celu rejestacji wpisz hasło";
                    }
                    else if (error == 1)
                    {
                        txt_info.Text = "Hasło ustawione. Możesz się teraz zalogować";
                    }
                    else if (error == -1)
                    {
                        txt_info.Text = "Użytkownik nieaktywny";
                    }
                    else if (error == 0)
                    {
                        //W przypadku pomyślnego logowania możemy zapisać dane logowania
                        if (check_rememberMe.Checked == true)
                        {
                            XmlFile saveData = new XmlFile();
                            saveData.login = login;
                            saveData.pass = passwordHash;
                            XmlHelper.SaveLoginData(saveData);
                        }

                        //Otwieramy główne okno
                        int userId = Convert.ToInt32(dr[1]);
                        this.Hide();
                        var MainWindow = new MainForm(userId);
                        MainWindow.Closed += (s, args) => this.Close();
                        MainWindow.Show();
                    }
                }
                catch (Exception)
                {
                    txt_info.Text = "Błąd połączenia z bazą danych";
                }
            }
        }
    }
}
