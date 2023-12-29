using ClubManagement.Helpers;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static ClubManagement.MainForm;
using DevExpress.XtraPrinting;

namespace ClubManagement.Modules
{
    public partial class ucStatistics : DevExpress.DXperience.Demos.TutorialControlBase, refresher
    {
        public static DataTable playersStatisticsDataTable;
        static Dictionary<string, string> statisticsNames = new Dictionary<string, string>
        {
            { "Mecze", "Matches" },
            { "Minuty", "Minutes" },
            { "Gole", "Goals" },
            { "Asysty", "Assists" },
            { "Czerwone Kartki", "RedCards" },
            { "Zółte Kartki", "YellowCards" }
        };
        Dictionary<string, string> translateStatisticToEnglish = statisticsNames.ToDictionary(x => x.Key, x => x.Value);
        public ucStatistics()
        {
            InitializeComponent();
            InitalizeControls();
            RefreshData();
            ccb_statisticsTypes.Properties.Items[0].CheckState = CheckState.Checked;
        }
        void InitalizeControls()
        {
            chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.RightOutside;
            chartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Bottom;
            ccb_statisticsTypes.Properties.Items.AddRange(statisticsNames.Keys.ToArray());

        }
        public void RefreshData()
        {
            playersStatisticsDataTable = DBHelper.SQL_dt("select * from dbo.vPlayersStatistics");
            gridControl1.DataSource = playersStatisticsDataTable;
            chartControl1.DataSource = playersStatisticsDataTable;


        }
        void UpdateChart(List<string> statisticTypes)
        {
            try
            {
                chartControl1.Series.Clear();

                foreach (string statisticType in statisticTypes)
                {
                    Series newSeries = new Series(statisticType, ViewType.Bar);

                    foreach (DataRow row in playersStatisticsDataTable.Rows)
                    {
                        double value = Convert.ToDouble(row[translateStatisticToEnglish[statisticType]]);
                        newSeries.Points.Add(new SeriesPoint(row["FirstName"] + " " + row["LastName"], value));
                        newSeries.LegendText = statisticType;
                    }


                    chartControl1.Series.Add(newSeries);
                }
            }
            catch (Exception ex)
            {
                DBHelper.WriteLog("Update chart", -1, "Error", $"Błąd podczas tworzenia wykresu - {ex.ToString()}", loggedUserId);
            }



        }

        private void ccb_statisticsTypes_EditValueChanged(object sender, EventArgs e)
        {
            CheckedListBoxItemCollection items = ccb_statisticsTypes.Properties.Items;
            List<string> selectedStatisticTypes = new List<string>();
            foreach (CheckedListBoxItem item in items)
            {
                if (item.CheckState == CheckState.Checked)
                {
                    string statisticType = item.Value.ToString();
                    selectedStatisticTypes.Add(statisticType);
                }
            }
            UpdateChart(selectedStatisticTypes);
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            string newValue = gridView1.GetRowCellValue(e.RowHandle, e.Column).ToString();
            string columnName = "PlS_" + e.Column.FieldName;
            int id = (int)gridView1.GetRowCellValue(e.RowHandle, "Id");

            if (DBHelper.InsertUpdate($"update dbo.PlayersStatistics set {columnName} = {newValue} where PlS_Id = {id}"))
            {
                DBHelper.WriteLog("Update statistic", 0, "Info", $"Zaktualizowano statystyki o ID: {id}, kolumne: {columnName} na wartość: {newValue}", loggedUserId);
            }
            else
            {
                DBHelper.WriteLog("Update statistic", -1, "Error", $"Nie udało się zaktualizować statystyki o ID: {id}, kolumny: {columnName} na wartość: {newValue}", loggedUserId);
            }
            RefreshData();
            CheckedListBoxItemCollection items = ccb_statisticsTypes.Properties.Items;
            List<string> selectedStatisticTypes = new List<string>();
            foreach (CheckedListBoxItem item in items)
            {
                if (item.CheckState == CheckState.Checked)
                {
                    string statisticType = item.Value.ToString();
                    selectedStatisticTypes.Add(statisticType);
                }
            }
            UpdateChart(selectedStatisticTypes);
        }

        private void repositoryItemSpinEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
            {
                e.Handled = true; // Ignoruj wpisanie znaku minus
            }
        }

        private void btn_exportPdf_Click(object sender, EventArgs e)
        {
            string filePath = "";
            try
            {
                gridView1.OptionsPrint.AutoWidth = true;
                gridView1.BestFitColumns();

                gridControl1.Invoke(new Action(delegate ()
                {
                    filePath = $@"C:\Users\Bartek\Desktop\Inż\Statistic\Tables\Statystyki_{DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss")}.pdf";
                    gridControl1.ExportToPdf(filePath);
                    System.Diagnostics.Process.Start(filePath);
                    DBHelper.WriteLog("Export table PDF", 0, "Info", $"Wyeksportowano tabelę statystk do {filePath}", loggedUserId);
                }));
            }
            catch (Exception ex)
            {
                DBHelper.WriteLog("Export table PDF", -1, "Error", $"Błąd podczas eksportu tabeli statystk do {filePath} - {ex.ToString()}", loggedUserId);
            }

        }

        private void btn_exportChart_Click(object sender, EventArgs e)
        {
            string filePath = "";
            try
            {
                PrintingSystem ps = new PrintingSystem();
                PrintableComponentLink link = new PrintableComponentLink(ps);
                link.Component = chartControl1;
                link.Landscape = true;


                link.Margins.Left = 10;
                link.Margins.Right = 10;
                link.Margins.Top = 10;
                link.Margins.Bottom = 10;
                link.PaperKind = System.Drawing.Printing.PaperKind.A4;

                chartControl1.Invoke(new Action(delegate ()
                {
                    filePath = $@"C:\Users\Bartek\Desktop\Inż\Statistic\Charts\Wykres_{DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss")}.pdf";
                    link.ExportToPdf(filePath);
                    System.Diagnostics.Process.Start(filePath);
                    DBHelper.WriteLog("Export chart PDF", 0, "Info", $"Wyeksportowano wykres statystk do {filePath}", loggedUserId);
                }));
            }
            catch (Exception ex)
            {
                DBHelper.WriteLog("Export chart PDF", -1, "Error", $"Błąd podczas eksportu wykresu statystk do {filePath} - {ex.ToString()}", loggedUserId);
            }

        }
    }
}

