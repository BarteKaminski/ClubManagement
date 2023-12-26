
namespace ClubManagement.Modules
{
    partial class ucClubPlayers
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Imię = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nazwisko = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Pseudonim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Pozycja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Data_urodzenia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Wiek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Numer_telefonu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_addPlayer = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
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
            this.tablePanel2.Controls.Add(this.gridControl1);
            this.tablePanel2.Controls.Add(this.btn_addPlayer);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(0, 0);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(1097, 548);
            this.tablePanel2.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.tablePanel2.SetColumn(this.gridControl1, 0);
            this.tablePanel2.SetColumnSpan(this.gridControl1, 2);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 41);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.tablePanel2.SetRow(this.gridControl1, 1);
            this.gridControl1.Size = new System.Drawing.Size(1091, 504);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.Imię,
            this.Nazwisko,
            this.Pseudonim,
            this.Pozycja,
            this.Data_urodzenia,
            this.Wiek,
            this.Numer_telefonu,
            this.Email});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "Id";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 43;
            // 
            // Imię
            // 
            this.Imię.Caption = "Imię";
            this.Imię.FieldName = "FirstName";
            this.Imię.Name = "Imię";
            this.Imię.Visible = true;
            this.Imię.VisibleIndex = 1;
            this.Imię.Width = 80;
            // 
            // Nazwisko
            // 
            this.Nazwisko.Caption = "Nazwisko";
            this.Nazwisko.FieldName = "LastName";
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.Visible = true;
            this.Nazwisko.VisibleIndex = 3;
            this.Nazwisko.Width = 84;
            // 
            // Pseudonim
            // 
            this.Pseudonim.Caption = "Pseudonim";
            this.Pseudonim.FieldName = "Nick";
            this.Pseudonim.Name = "Pseudonim";
            this.Pseudonim.Visible = true;
            this.Pseudonim.VisibleIndex = 2;
            this.Pseudonim.Width = 80;
            // 
            // Pozycja
            // 
            this.Pozycja.Caption = "Pozycja";
            this.Pozycja.FieldName = "Position";
            this.Pozycja.Name = "Pozycja";
            this.Pozycja.Visible = true;
            this.Pozycja.VisibleIndex = 4;
            this.Pozycja.Width = 67;
            // 
            // Data_urodzenia
            // 
            this.Data_urodzenia.Caption = "Data urodzenia";
            this.Data_urodzenia.FieldName = "DateOfBirth";
            this.Data_urodzenia.Name = "Data_urodzenia";
            this.Data_urodzenia.Visible = true;
            this.Data_urodzenia.VisibleIndex = 5;
            this.Data_urodzenia.Width = 81;
            // 
            // Wiek
            // 
            this.Wiek.Caption = "Wiek";
            this.Wiek.FieldName = "Age";
            this.Wiek.Name = "Wiek";
            this.Wiek.Visible = true;
            this.Wiek.VisibleIndex = 6;
            this.Wiek.Width = 42;
            // 
            // Numer_telefonu
            // 
            this.Numer_telefonu.Caption = "Numer telefonu";
            this.Numer_telefonu.FieldName = "Phone";
            this.Numer_telefonu.Name = "Numer_telefonu";
            this.Numer_telefonu.Visible = true;
            this.Numer_telefonu.VisibleIndex = 7;
            this.Numer_telefonu.Width = 104;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "Email";
            this.Email.Name = "Email";
            this.Email.Visible = true;
            this.Email.VisibleIndex = 8;
            this.Email.Width = 104;
            // 
            // btn_addPlayer
            // 
            this.btn_addPlayer.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
            this.btn_addPlayer.Appearance.Options.UseFont = true;
            this.btn_addPlayer.Location = new System.Drawing.Point(889, 3);
            this.btn_addPlayer.Name = "btn_addPlayer";
            this.btn_addPlayer.Size = new System.Drawing.Size(206, 32);
            this.btn_addPlayer.TabIndex = 0;
            this.btn_addPlayer.Text = "Dodaj zawodnika";
            this.btn_addPlayer.Click += new System.EventHandler(this.btn_addPlayer_Click);
            // 
            // ucClubPlayers
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucClubPlayers";
            this.Size = new System.Drawing.Size(1097, 548);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.SimpleButton btn_addPlayer;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn Imię;
        private DevExpress.XtraGrid.Columns.GridColumn Nazwisko;
        private DevExpress.XtraGrid.Columns.GridColumn Data_urodzenia;
        private DevExpress.XtraGrid.Columns.GridColumn Wiek;
        private DevExpress.XtraGrid.Columns.GridColumn Numer_telefonu;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn Pseudonim;
        private DevExpress.XtraGrid.Columns.GridColumn Pozycja;
    }
}
