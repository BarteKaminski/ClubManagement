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

            DBHelper.InsertUpdate($"update dbo.PlayersStatistics set {columnName} = {newValue} where PlS_Id = {id}");
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
            gridView1.OptionsPrint.AutoWidth = true;
            gridView1.BestFitColumns();

            gridControl1.Invoke(new Action(delegate ()
            {
                string filePath = $@"C:\Users\Bartek\Desktop\Inż\Statistic\Tables\Statystyki_{DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss")}.pdf";
                gridControl1.ExportToPdf(filePath);
                System.Diagnostics.Process.Start(filePath);
            }));
        }

        private void btn_exportChart_Click(object sender, EventArgs e)
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
                string filePath = $@"C:\Users\Bartek\Desktop\Inż\Statistic\Charts\Wykres_{DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss")}.pdf";
                link.ExportToPdf(filePath);
                System.Diagnostics.Process.Start(filePath);
            }));
        }
    }
}

