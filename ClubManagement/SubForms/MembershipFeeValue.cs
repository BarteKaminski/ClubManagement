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

namespace ClubManagement.SubForms
{
    public partial class MembershipFeeValue : DevExpress.XtraEditors.XtraForm
    {
        public MembershipFeeValue()
        {
            InitializeComponent();
            RefreshData();
        }
        void RefreshData()
        {
            spinEdit1.Value = DBHelper.SQL_int("select Con_value from dbo.config where con_key = 'MEMBERSHIP_FEE_VALUE'"); 
        }
        private void btn_saveMembershipFeeValue_Click(object sender, EventArgs e)
        {
            if(DBHelper.InsertUpdate($"update dbo.config set con_value = '{spinEdit1.Value}' where con_key = 'MEMBERSHIP_FEE_VALUE'"))
            {
                DBHelper.WriteLog("Update fee value", 0, "Info", $"Zaktualizowano wartość składki: {spinEdit1.Value}", MainForm.loggedUserId);
            }
            else
            {
                DBHelper.WriteLog("Update fee value", -1, "Error", $"Nie udało się zaktualizować wartość składki: {spinEdit1.Value}", MainForm.loggedUserId);
            }
            this.Close();
        }
    }
}