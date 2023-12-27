using ClubManagement.Helpers;
using ClubManagement.SubForms;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClubManagement.MainForm;

namespace ClubManagement.Modules
{
    public partial class ucMembershipFees : DevExpress.DXperience.Demos.TutorialControlBase, refresher
    {
        public ucMembershipFees()
        {
            InitializeComponent();
            RefreshData();
        }
        public void RefreshData()
        {
            var playersFinancesDataTable = DBHelper.SQL_dt("select * from dbo.vPlayersFinances where isSettled = 0");
            gridControl1.DataSource = playersFinancesDataTable;
        }

        private void btn_changeValue_Click(object sender, EventArgs e)
        {
            MembershipFeeValue membershipFeeValue = new MembershipFeeValue();
            membershipFeeValue.ShowDialog();
        }

        private void btn_settlePayments_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel (*.xls, *.xlsx)|*.xls; *.xlsx;";
                openFileDialog.Title = "Wybierz plik";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    int settledPayments = 0;
                    try
                    {
                        using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                        {
                            DataTable paymentsDataTable = ExcelHelper.ConvertExcelToDataTable(fileStream, Path.GetFileName(filePath));
                            foreach (DataRow row in paymentsDataTable.Rows)
                            {
                                string pattern = @"ID:\s*(\d+)\s*Miesiąc:\s*(\d+)";
                                Match match = Regex.Match(row["Tytuł"].ToString(), pattern);
                                if (match.Success)
                                {
                                    string id = match.Groups[1].Value;
                                    string month = match.Groups[2].Value;
                                    string dateOfPayment = row["Data wpłaty"].ToString();
                                    DateTime parsedDate = DateTime.ParseExact(dateOfPayment, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture);
                                    string formattedDate = parsedDate.ToString("yyyy-MM-dd");
                                    if (DBHelper.InsertUpdate($@"
                                                    UPDATE dbo.playersfinances 
                                                    SET PlF_PaymentMethod = '{row["Forma płatności"].ToString()}',
                                                        PlF_DateOfPayment = '{formattedDate}',
                                                        PlF_NetAmountRemains = PlF_NetAmountRemains - {Convert.ToDecimal(row["Kwota[zl]"])},
                                                        PlF_Settled = 
                                                            CASE 
                                                                WHEN PlF_NetAmountRemains - {Convert.ToDecimal(row["Kwota[zl]"])} <= 0 THEN 1 
                                                                ELSE 0 
                                                            END
                                                    WHERE PlF_PlayerId = {id} 
                                                        AND MONTH(PlF_DueDate) = {month}"))
                                    settledPayments++;
                                }
                            }
                        }
                        if(settledPayments > 0)
                        MainForm.ShowOk($"Pomyślnie rozliczono {settledPayments} płatności");
                        RefreshData();
                    }
                    catch (IOException)
                    {
                        MainForm.ShowError("Plik jest używany przez inny proces, proszę zamknąć programy w których otwarty jest plik.");
                    }
                    catch (Exception ex)
                    {
                        MainForm.ShowError(ex.Message);
                    }

                }
            }
        }
    }
}
