using ClubManagement.Helpers;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using System.Threading.Tasks;
using ClubManagement.Modules;

namespace ClubManagement
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public static string lastModuleName;
        public static int loggedUserId;
        public static int isAdmin;
        public MainForm(int userId)
        {
            InitializeComponent();
            loggedUserId = userId;
            InitAdminModules();          
        }
        async Task LoadModuleAsync(ModuleInfo module)
        {
            lastModuleName = module.Name;

            await Task.Factory.StartNew(() =>
            {
                if (!fluentDesignFormContainer1.Controls.ContainsKey(module.Name))
                {
                    TutorialControlBase control = module.TModule as TutorialControlBase;
                    if (control != null)
                    {
                        control.Dock = DockStyle.Fill;
                        control.CreateWaitDialog();
                        fluentDesignFormContainer1.Invoke(new MethodInvoker(delegate ()
                        {
                            fluentDesignFormContainer1.Controls.Add(control);
                            control.BringToFront();
                        }));
                    }
                }
                else
                {
                    var control = fluentDesignFormContainer1.Controls.Find(module.Name, true);
                    if (control.Length == 1)
                    {
                        control[0].Invoke(new Action(() => { (control[0] as refresher)?.RefreshData(); }));
                        fluentDesignFormContainer1.Invoke(new MethodInvoker(delegate () { control[0].BringToFront(); }));
                    }

                }
            });

        }

        private async void Profile_Click(object sender, EventArgs e)
        {

            if (ModulesInfo.GetItem("ucSettingsProfile") == null)
            {
                ModulesInfo.Add(new ModuleInfo("ucSettingsProfile", "ClubManagement.Modules.ucSettingsProfile"));
            }
            await LoadModuleAsync(ModulesInfo.GetItem("ucSettingsProfile"));
        }

        private async void Users_Click(object sender, EventArgs e)
        {

            if (ModulesInfo.GetItem("ucSettingsUsers") == null)
            {
                ModulesInfo.Add(new ModuleInfo("ucSettingsUsers", "ClubManagement.Modules.ucSettingsUsers"));
            }
            await LoadModuleAsync(ModulesInfo.GetItem("ucSettingsUsers"));
        }

        private void InitAdminModules()
        {
            isAdmin = DBHelper.SQL_int($"select Use_isAdmin from dbo.Users where Use_Id={loggedUserId}");
            if (isAdmin == 0)
            {
                Users.Enabled = false;
            }
        }

        #region MessageBoxes
        public static void ShowOk(string message)
        {
            var mb = new MessageBoxForm(0, "Info", message);
            mb.ShowDialog();
        }

        public static void ShowWarning(string message)
        {
            var mb = new MessageBoxForm(1, "Uwaga!", message);
            mb.ShowDialog();
        }

        public static void ShowError(string message)
        {
            var mb = new MessageBoxForm(2, "Błąd!", message);
            mb.ShowDialog();
        }
        #endregion
        public interface refresher
        {
            void RefreshData();
        }

    }
}
