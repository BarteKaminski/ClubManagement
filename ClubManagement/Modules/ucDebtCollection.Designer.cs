
namespace ClubManagement.Modules
{
    partial class ucDebtCollection
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
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.btn_collectDebt = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Imię = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nazwisko = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Netto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NettoPozostaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Waluta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Termin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DataPłatności = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel2
            // 
            this.tablePanel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tablePanel2.Appearance.Options.UseBackColor = true;
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 56.48F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 43.52F)});
            this.tablePanel2.Controls.Add(this.tablePanel1);
            this.tablePanel2.Controls.Add(this.gridControl1);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(0, 0);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(959, 438);
            this.tablePanel2.TabIndex = 5;
            // 
            // tablePanel1
            // 
            this.tablePanel2.SetColumn(this.tablePanel1, 0);
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 120F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 35.52F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 35.52F)});
            this.tablePanel2.SetColumnSpan(this.tablePanel1, 2);
            this.tablePanel1.Controls.Add(this.btn_collectDebt);
            this.tablePanel1.Location = new System.Drawing.Point(3, 3);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel2.SetRow(this.tablePanel1, 0);
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel1.Size = new System.Drawing.Size(953, 44);
            this.tablePanel1.TabIndex = 2;
            // 
            // btn_collectDebt
            // 
            this.btn_collectDebt.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
            this.btn_collectDebt.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.btn_collectDebt, 2);
            this.btn_collectDebt.Location = new System.Drawing.Point(779, 6);
            this.btn_collectDebt.Name = "btn_collectDebt";
            this.tablePanel1.SetRow(this.btn_collectDebt, 0);
            this.btn_collectDebt.Size = new System.Drawing.Size(171, 32);
            this.btn_collectDebt.TabIndex = 0;
            this.btn_collectDebt.Text = "Windykuj";
            this.btn_collectDebt.Click += new System.EventHandler(this.btn_collectDebt_Click);
            // 
            // gridControl1
            // 
            this.tablePanel2.SetColumn(this.gridControl1, 0);
            this.tablePanel2.SetColumnSpan(this.gridControl1, 2);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 53);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.tablePanel2.SetRow(this.gridControl1, 1);
            this.gridControl1.Size = new System.Drawing.Size(953, 382);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Imię,
            this.Nazwisko,
            this.Email,
            this.Netto,
            this.NettoPozostaje,
            this.Waluta,
            this.Termin,
            this.DataPłatności});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // Imię
            // 
            this.Imię.Caption = "Imię";
            this.Imię.FieldName = "FirstName";
            this.Imię.Name = "Imię";
            this.Imię.Visible = true;
            this.Imię.VisibleIndex = 0;
            this.Imię.Width = 85;
            // 
            // Nazwisko
            // 
            this.Nazwisko.Caption = "Nazwisko";
            this.Nazwisko.FieldName = "LastName";
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.Visible = true;
            this.Nazwisko.VisibleIndex = 1;
            this.Nazwisko.Width = 89;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "Email";
            this.Email.Name = "Email";
            this.Email.Visible = true;
            this.Email.VisibleIndex = 2;
            this.Email.Width = 86;
            // 
            // Netto
            // 
            this.Netto.Caption = "Netto";
            this.Netto.FieldName = "NetAmount";
            this.Netto.Name = "Netto";
            this.Netto.Visible = true;
            this.Netto.VisibleIndex = 3;
            // 
            // NettoPozostaje
            // 
            this.NettoPozostaje.Caption = "Netto pozostaje";
            this.NettoPozostaje.FieldName = "NetAmountRemains";
            this.NettoPozostaje.Name = "NettoPozostaje";
            this.NettoPozostaje.Visible = true;
            this.NettoPozostaje.VisibleIndex = 4;
            this.NettoPozostaje.Width = 91;
            // 
            // Waluta
            // 
            this.Waluta.Caption = "Waluta";
            this.Waluta.FieldName = "Currency";
            this.Waluta.Name = "Waluta";
            this.Waluta.Visible = true;
            this.Waluta.VisibleIndex = 5;
            this.Waluta.Width = 50;
            // 
            // Termin
            // 
            this.Termin.Caption = "Termin płatności";
            this.Termin.FieldName = "DueDate";
            this.Termin.Name = "Termin";
            this.Termin.Visible = true;
            this.Termin.VisibleIndex = 6;
            this.Termin.Width = 96;
            // 
            // DataPłatności
            // 
            this.DataPłatności.Caption = "Data płatności";
            this.DataPłatności.FieldName = "DateOfPayment";
            this.DataPłatności.Name = "DataPłatności";
            this.DataPłatności.Visible = true;
            this.DataPłatności.VisibleIndex = 7;
            this.DataPłatności.Width = 113;
            // 
            // ucDebtCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel2);
            this.Name = "ucDebtCollection";
            this.Size = new System.Drawing.Size(959, 438);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SimpleButton btn_collectDebt;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Imię;
        private DevExpress.XtraGrid.Columns.GridColumn Nazwisko;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn Netto;
        private DevExpress.XtraGrid.Columns.GridColumn NettoPozostaje;
        private DevExpress.XtraGrid.Columns.GridColumn Waluta;
        private DevExpress.XtraGrid.Columns.GridColumn Termin;
        private DevExpress.XtraGrid.Columns.GridColumn DataPłatności;
    }
}
