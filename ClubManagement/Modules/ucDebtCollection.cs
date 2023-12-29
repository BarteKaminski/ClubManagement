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
    public partial class ucDebtCollection : DevExpress.DXperience.Demos.TutorialControlBase, refresher
    {
        public ucDebtCollection()
        {
            InitializeComponent();
            RefreshData();
        }
        public void RefreshData()
        {
            var playersFinancesDataTable = DBHelper.SQL_dt("select * from dbo.vPlayersFinances where isSettled = 0 and DueDate < convert(date, getdate())");
            gridControl1.DataSource = playersFinancesDataTable;
        }

        private void btn_collectDebt_Click(object sender, EventArgs e)
        {
            var debtsDataTable = DBHelper.SQL_dt("select Email, sum(NetAmountRemains) SumNetAmountRemains from dbo.vPlayersFinances where isSettled = 0 and DueDate < convert(date, getdate()) group by Email");
            string topic = "Przeterminowane płatności";
            string error = "";
            int sentMails = 0;
            var mail = new MailHelper();
            foreach(DataRow row in debtsDataTable.Rows)
            {
                string body = $"Posiadasz nieuregulowane płatności w wysokości {row["SumNetAmountRemains"]} zł. Prosimy o jak najszybsze uregulowanie zaległych płatności.{Environment.NewLine}Pozdrawiamy{Environment.NewLine}Zespół ClubManagement";
                mail.SendMail(row["Email"].ToString(), "ClubManagementMANS@outlook.com", "", body, topic, ref error);
                if(error != "")
                {
                    DBHelper.WriteLog("Send mail", -1, "Error", error, loggedUserId);
                    MainForm.ShowError(error);
                }
                else
                {
                    DBHelper.WriteLog("Send mail", 0, "Info", $"Wysłano mail do {row["Email"].ToString()}", loggedUserId);
                    sentMails++;
                }
            }
            if(sentMails > 0)
            {
                DBHelper.WriteLog("Send mail", 0, "Info", $"Wysłano {sentMails} przypomnień", loggedUserId);
                MainForm.ShowOk($"Wysłano {sentMails} przypomnień");
            }
        }
    }
}
