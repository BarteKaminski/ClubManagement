
namespace ClubManagement.Modules
{
    partial class ucStatistics
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.btn_exportPdf = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Imię = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nazwisko = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sezon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Mecze = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.Minuty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Asysty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ŻółteKartki = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CzerwoneKartki = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.btn_exportChart = new DevExpress.XtraEditors.SimpleButton();
            this.ccb_statisticsTypes = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ccb_statisticsTypes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel2
            // 
            this.tablePanel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tablePanel2.Appearance.Options.UseBackColor = true;
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 56.66F)});
            this.tablePanel2.Controls.Add(this.xtraTabControl1);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(0, 0);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F)});
            this.tablePanel2.Size = new System.Drawing.Size(1097, 548);
            this.tablePanel2.TabIndex = 5;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Appearance.BackColor = System.Drawing.Color.Black;
            this.xtraTabControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.xtraTabControl1.Appearance.Options.UseBackColor = true;
            this.xtraTabControl1.Appearance.Options.UseFont = true;
            this.xtraTabControl1.AppearancePage.Header.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.xtraTabControl1.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabControl1.AppearancePage.Header.Options.UseTextOptions = true;
            this.xtraTabControl1.AppearancePage.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.xtraTabControl1.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
            this.xtraTabControl1.AppearancePage.HeaderActive.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.xtraTabControl1.AppearancePage.HeaderActive.Options.UseFont = true;
            this.tablePanel2.SetColumn(this.xtraTabControl1, 0);
            serializableAppearanceObject1.Font = new System.Drawing.Font("Tahoma", 10.25F);
            serializableAppearanceObject1.Options.UseFont = true;
            this.xtraTabControl1.CustomHeaderButtons.AddRange(new DevExpress.XtraTab.Buttons.CustomHeaderButton[] {
            new DevExpress.XtraTab.Buttons.CustomHeaderButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, editorButtonImageOptions1, serializableAppearanceObject1, "", null, null)});
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(3, 3);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.tablePanel2.SetRow(this.xtraTabControl1, 0);
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1091, 542);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            this.xtraTabControl1.TabPageWidth = 120;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.tablePanel3);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1089, 516);
            this.xtraTabPage1.Text = "Statystyki";
            // 
            // tablePanel3
            // 
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 46.04F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 15F)});
            this.tablePanel3.Controls.Add(this.btn_exportPdf);
            this.tablePanel3.Controls.Add(this.gridControl1);
            this.tablePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel3.Location = new System.Drawing.Point(0, 0);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
            this.tablePanel3.Size = new System.Drawing.Size(1089, 516);
            this.tablePanel3.TabIndex = 0;
            // 
            // btn_exportPdf
            // 
            this.tablePanel3.SetColumn(this.btn_exportPdf, 1);
            this.btn_exportPdf.Location = new System.Drawing.Point(824, 4);
            this.btn_exportPdf.Name = "btn_exportPdf";
            this.tablePanel3.SetRow(this.btn_exportPdf, 0);
            this.btn_exportPdf.Size = new System.Drawing.Size(262, 41);
            this.btn_exportPdf.TabIndex = 4;
            this.btn_exportPdf.Text = "Eksport PDF";
            this.btn_exportPdf.Click += new System.EventHandler(this.btn_exportPdf_Click);
            // 
            // gridControl1
            // 
            this.tablePanel3.SetColumn(this.gridControl1, 0);
            this.tablePanel3.SetColumnSpan(this.gridControl1, 2);
            this.gridControl1.Location = new System.Drawing.Point(3, 53);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1});
            this.tablePanel3.SetRow(this.gridControl1, 1);
            this.gridControl1.Size = new System.Drawing.Size(1083, 460);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Imię,
            this.Nazwisko,
            this.Sezon,
            this.Mecze,
            this.Minuty,
            this.Gole,
            this.Asysty,
            this.ŻółteKartki,
            this.CzerwoneKartki,
            this.Id});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // Imię
            // 
            this.Imię.Caption = "Imię";
            this.Imię.FieldName = "FirstName";
            this.Imię.Name = "Imię";
            this.Imię.OptionsColumn.AllowEdit = false;
            this.Imię.Visible = true;
            this.Imię.VisibleIndex = 0;
            this.Imię.Width = 98;
            // 
            // Nazwisko
            // 
            this.Nazwisko.Caption = "Nazwisko";
            this.Nazwisko.FieldName = "LastName";
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.OptionsColumn.AllowEdit = false;
            this.Nazwisko.Visible = true;
            this.Nazwisko.VisibleIndex = 1;
            this.Nazwisko.Width = 93;
            // 
            // Sezon
            // 
            this.Sezon.Caption = "Sezon";
            this.Sezon.FieldName = "Season";
            this.Sezon.Name = "Sezon";
            this.Sezon.OptionsColumn.AllowEdit = false;
            this.Sezon.Visible = true;
            this.Sezon.VisibleIndex = 2;
            this.Sezon.Width = 69;
            // 
            // Mecze
            // 
            this.Mecze.Caption = "Mecze";
            this.Mecze.ColumnEdit = this.repositoryItemSpinEdit1;
            this.Mecze.FieldName = "Matches";
            this.Mecze.Name = "Mecze";
            this.Mecze.Visible = true;
            this.Mecze.VisibleIndex = 3;
            this.Mecze.Width = 62;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.Mask.EditMask = "n0";
            this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // Minuty
            // 
            this.Minuty.Caption = "Minuty";
            this.Minuty.ColumnEdit = this.repositoryItemSpinEdit1;
            this.Minuty.FieldName = "Minutes";
            this.Minuty.Name = "Minuty";
            this.Minuty.Visible = true;
            this.Minuty.VisibleIndex = 4;
            this.Minuty.Width = 66;
            // 
            // Gole
            // 
            this.Gole.Caption = "Gole";
            this.Gole.ColumnEdit = this.repositoryItemSpinEdit1;
            this.Gole.FieldName = "Goals";
            this.Gole.Name = "Gole";
            this.Gole.Visible = true;
            this.Gole.VisibleIndex = 5;
            this.Gole.Width = 71;
            // 
            // Asysty
            // 
            this.Asysty.Caption = "Asysty";
            this.Asysty.ColumnEdit = this.repositoryItemSpinEdit1;
            this.Asysty.FieldName = "Assists";
            this.Asysty.Name = "Asysty";
            this.Asysty.Visible = true;
            this.Asysty.VisibleIndex = 6;
            this.Asysty.Width = 60;
            // 
            // ŻółteKartki
            // 
            this.ŻółteKartki.Caption = "Żółte kartki";
            this.ŻółteKartki.ColumnEdit = this.repositoryItemSpinEdit1;
            this.ŻółteKartki.FieldName = "YellowCards";
            this.ŻółteKartki.Name = "ŻółteKartki";
            this.ŻółteKartki.Visible = true;
            this.ŻółteKartki.VisibleIndex = 7;
            this.ŻółteKartki.Width = 73;
            // 
            // CzerwoneKartki
            // 
            this.CzerwoneKartki.Caption = "Czerwone kartki";
            this.CzerwoneKartki.ColumnEdit = this.repositoryItemSpinEdit1;
            this.CzerwoneKartki.FieldName = "RedCards";
            this.CzerwoneKartki.Name = "CzerwoneKartki";
            this.CzerwoneKartki.Visible = true;
            this.CzerwoneKartki.VisibleIndex = 8;
            this.CzerwoneKartki.Width = 93;
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.tablePanel1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1089, 516);
            this.xtraTabPage2.Text = "Wykresy";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 41F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F)});
            this.tablePanel1.Controls.Add(this.btn_exportChart);
            this.tablePanel1.Controls.Add(this.ccb_statisticsTypes);
            this.tablePanel1.Controls.Add(this.chartControl1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1089, 516);
            this.tablePanel1.TabIndex = 0;
            // 
            // btn_exportChart
            // 
            this.tablePanel1.SetColumn(this.btn_exportChart, 1);
            this.btn_exportChart.Location = new System.Drawing.Point(554, 6);
            this.btn_exportChart.Name = "btn_exportChart";
            this.tablePanel1.SetRow(this.btn_exportChart, 0);
            this.btn_exportChart.Size = new System.Drawing.Size(263, 37);
            this.btn_exportChart.TabIndex = 3;
            this.btn_exportChart.Text = "Eksportuj PDF";
            this.btn_exportChart.Click += new System.EventHandler(this.btn_exportChart_Click);
            // 
            // ccb_statisticsTypes
            // 
            this.tablePanel1.SetColumn(this.ccb_statisticsTypes, 2);
            this.ccb_statisticsTypes.Location = new System.Drawing.Point(823, 13);
            this.ccb_statisticsTypes.Name = "ccb_statisticsTypes";
            this.ccb_statisticsTypes.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.ccb_statisticsTypes.Properties.Appearance.Options.UseFont = true;
            this.ccb_statisticsTypes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanel1.SetRow(this.ccb_statisticsTypes, 0);
            this.ccb_statisticsTypes.Size = new System.Drawing.Size(263, 24);
            this.ccb_statisticsTypes.TabIndex = 2;
            this.ccb_statisticsTypes.EditValueChanged += new System.EventHandler(this.ccb_statisticsTypes_EditValueChanged);
            // 
            // chartControl1
            // 
            this.tablePanel1.SetColumn(this.chartControl1, 0);
            this.tablePanel1.SetColumnSpan(this.chartControl1, 3);
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(3, 53);
            this.chartControl1.Name = "chartControl1";
            this.tablePanel1.SetRow(this.chartControl1, 1);
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(1083, 460);
            this.chartControl1.TabIndex = 1;
            // 
            // ucStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel2);
            this.Name = "ucStatistics";
            this.Size = new System.Drawing.Size(1097, 548);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ccb_statisticsTypes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit ccb_statisticsTypes;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private DevExpress.XtraEditors.SimpleButton btn_exportPdf;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Imię;
        private DevExpress.XtraGrid.Columns.GridColumn Nazwisko;
        private DevExpress.XtraGrid.Columns.GridColumn Sezon;
        private DevExpress.XtraGrid.Columns.GridColumn Mecze;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn Minuty;
        private DevExpress.XtraGrid.Columns.GridColumn Gole;
        private DevExpress.XtraGrid.Columns.GridColumn Asysty;
        private DevExpress.XtraGrid.Columns.GridColumn ŻółteKartki;
        private DevExpress.XtraGrid.Columns.GridColumn CzerwoneKartki;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraEditors.SimpleButton btn_exportChart;
    }
}
