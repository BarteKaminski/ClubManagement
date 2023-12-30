
namespace ClubManagement
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.check_rememberMe = new DevExpress.XtraEditors.CheckEdit();
            this.lbl_version = new DevExpress.XtraEditors.LabelControl();
            this.txt_password = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_info = new DevExpress.XtraEditors.LabelControl();
            this.txt_login = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_login = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_rememberMe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_login.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26.12F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 21.38F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 89.1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 23.4F)});
            this.tablePanel1.Controls.Add(this.check_rememberMe);
            this.tablePanel1.Controls.Add(this.lbl_version);
            this.tablePanel1.Controls.Add(this.txt_password);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.txt_info);
            this.tablePanel1.Controls.Add(this.txt_login);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Controls.Add(this.btn_login);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 15F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 15F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 21F)});
            this.tablePanel1.Size = new System.Drawing.Size(336, 166);
            this.tablePanel1.TabIndex = 2;
            // 
            // check_rememberMe
            // 
            this.tablePanel1.SetColumn(this.check_rememberMe, 0);
            this.tablePanel1.SetColumnSpan(this.check_rememberMe, 3);
            this.check_rememberMe.Location = new System.Drawing.Point(3, 149);
            this.check_rememberMe.Name = "check_rememberMe";
            this.check_rememberMe.Properties.Caption = "zapamiętaj dane logowania";
            this.check_rememberMe.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.tablePanel1.SetRow(this.check_rememberMe, 5);
            this.check_rememberMe.Size = new System.Drawing.Size(281, 14);
            this.check_rememberMe.TabIndex = 6;
            // 
            // lbl_version
            // 
            this.lbl_version.Appearance.Options.UseTextOptions = true;
            this.lbl_version.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tablePanel1.SetColumn(this.lbl_version, 2);
            this.tablePanel1.SetColumnSpan(this.lbl_version, 2);
            this.lbl_version.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_version.Location = new System.Drawing.Point(103, 149);
            this.lbl_version.Name = "lbl_version";
            this.tablePanel1.SetRow(this.lbl_version, 5);
            this.lbl_version.Size = new System.Drawing.Size(230, 14);
            this.lbl_version.TabIndex = 5;
            this.lbl_version.Text = "WERSJA";
            // 
            // txt_password
            // 
            this.tablePanel1.SetColumn(this.txt_password, 2);
            this.txt_password.Location = new System.Drawing.Point(103, 55);
            this.txt_password.Name = "txt_password";
            this.txt_password.Properties.PasswordChar = '*';
            this.tablePanel1.SetRow(this.txt_password, 2);
            this.txt_password.Size = new System.Drawing.Size(181, 20);
            this.txt_password.TabIndex = 1;
            this.txt_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_password_KeyPress);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel1.SetColumn(this.labelControl3, 1);
            this.labelControl3.Location = new System.Drawing.Point(58, 59);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 2);
            this.labelControl3.Size = new System.Drawing.Size(27, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Hasło";
            // 
            // txt_info
            // 
            this.txt_info.Appearance.Options.UseTextOptions = true;
            this.txt_info.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_info.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tablePanel1.SetColumn(this.txt_info, 0);
            this.tablePanel1.SetColumnSpan(this.txt_info, 4);
            this.txt_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_info.Location = new System.Drawing.Point(3, 83);
            this.txt_info.Name = "txt_info";
            this.tablePanel1.SetRow(this.txt_info, 3);
            this.txt_info.Size = new System.Drawing.Size(330, 16);
            this.txt_info.TabIndex = 3;
            this.txt_info.Text = "            ";
            // 
            // txt_login
            // 
            this.tablePanel1.SetColumn(this.txt_login, 2);
            this.txt_login.Location = new System.Drawing.Point(103, 26);
            this.txt_login.Name = "txt_login";
            this.tablePanel1.SetRow(this.txt_login, 1);
            this.txt_login.Size = new System.Drawing.Size(181, 20);
            this.txt_login.TabIndex = 0;
            this.txt_login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_login_KeyPress);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel1.SetColumn(this.labelControl1, 1);
            this.labelControl1.Location = new System.Drawing.Point(58, 30);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 1);
            this.labelControl1.Size = new System.Drawing.Size(25, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Login";
            // 
            // btn_login
            // 
            this.tablePanel1.SetColumn(this.btn_login, 1);
            this.tablePanel1.SetColumnSpan(this.btn_login, 2);
            this.btn_login.Location = new System.Drawing.Point(58, 112);
            this.btn_login.Name = "btn_login";
            this.tablePanel1.SetRow(this.btn_login, 4);
            this.btn_login.Size = new System.Drawing.Size(226, 23);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Zaloguj";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            this.btn_login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 166);
            this.Controls.Add(this.tablePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::ClubManagement.Properties.Resources.favicon;
            this.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.Shown += new System.EventHandler(this.LoginForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_rememberMe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_login.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.CheckEdit check_rememberMe;
        private DevExpress.XtraEditors.LabelControl lbl_version;
        private DevExpress.XtraEditors.TextEdit txt_password;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl txt_info;
        private DevExpress.XtraEditors.TextEdit txt_login;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_login;
    }
}

