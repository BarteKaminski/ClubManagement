
namespace ClubManagement.Helpers
{
    partial class MessageBoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxForm));
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.lbl_message = new DevExpress.XtraEditors.MemoEdit();
            this.svg_info = new DevExpress.XtraEditors.SvgImageBox();
            this.svg_error = new DevExpress.XtraEditors.SvgImageBox();
            this.svg_warning = new DevExpress.XtraEditors.SvgImageBox();
            this.lbl_header = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_message.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svg_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svg_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svg_warning)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 37.4F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 17.6F)});
            this.tablePanel1.Controls.Add(this.lbl_message);
            this.tablePanel1.Controls.Add(this.svg_info);
            this.tablePanel1.Controls.Add(this.svg_error);
            this.tablePanel1.Controls.Add(this.svg_warning);
            this.tablePanel1.Controls.Add(this.lbl_header);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(382, 108);
            this.tablePanel1.TabIndex = 2;
            // 
            // lbl_message
            // 
            this.tablePanel1.SetColumn(this.lbl_message, 0);
            this.lbl_message.EditValue = "messageHere";
            this.lbl_message.Location = new System.Drawing.Point(13, 45);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.lbl_message.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_message.Properties.Appearance.Options.UseBackColor = true;
            this.lbl_message.Properties.Appearance.Options.UseFont = true;
            this.lbl_message.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lbl_message.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tablePanel1.SetRow(this.lbl_message, 2);
            this.lbl_message.Size = new System.Drawing.Size(240, 46);
            this.lbl_message.TabIndex = 6;
            // 
            // svg_info
            // 
            this.tablePanel1.SetColumn(this.svg_info, 1);
            this.svg_info.Location = new System.Drawing.Point(259, 15);
            this.svg_info.Name = "svg_info";
            this.tablePanel1.SetRow(this.svg_info, 0);
            this.tablePanel1.SetRowSpan(this.svg_info, 3);
            this.svg_info.Size = new System.Drawing.Size(110, 77);
            this.svg_info.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Zoom;
            this.svg_info.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svg_info.SvgImage")));
            this.svg_info.TabIndex = 5;
            // 
            // svg_error
            // 
            this.tablePanel1.SetColumn(this.svg_error, 1);
            this.svg_error.Location = new System.Drawing.Point(259, 15);
            this.svg_error.Name = "svg_error";
            this.tablePanel1.SetRow(this.svg_error, 0);
            this.tablePanel1.SetRowSpan(this.svg_error, 3);
            this.svg_error.Size = new System.Drawing.Size(110, 77);
            this.svg_error.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Zoom;
            this.svg_error.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svg_error.SvgImage")));
            this.svg_error.TabIndex = 4;
            // 
            // svg_warning
            // 
            this.tablePanel1.SetColumn(this.svg_warning, 1);
            this.svg_warning.Location = new System.Drawing.Point(259, 13);
            this.svg_warning.Name = "svg_warning";
            this.tablePanel1.SetRow(this.svg_warning, 0);
            this.tablePanel1.SetRowSpan(this.svg_warning, 3);
            this.svg_warning.Size = new System.Drawing.Size(110, 82);
            this.svg_warning.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Zoom;
            this.svg_warning.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svg_warning.SvgImage")));
            this.svg_warning.TabIndex = 3;
            // 
            // lbl_header
            // 
            this.lbl_header.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_header.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.lbl_header, 0);
            this.lbl_header.Location = new System.Drawing.Point(13, 13);
            this.lbl_header.Name = "lbl_header";
            this.tablePanel1.SetRow(this.lbl_header, 0);
            this.lbl_header.Size = new System.Drawing.Size(88, 18);
            this.lbl_header.TabIndex = 0;
            this.lbl_header.Text = "headerHere";
            // 
            // MessageBoxForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 108);
            this.Controls.Add(this.tablePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.LookAndFeel.SkinName = "Office 2013 Dark Gray";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "MessageBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MessageBoxForm";
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_message.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svg_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svg_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svg_warning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.MemoEdit lbl_message;
        private DevExpress.XtraEditors.SvgImageBox svg_info;
        private DevExpress.XtraEditors.SvgImageBox svg_error;
        private DevExpress.XtraEditors.SvgImageBox svg_warning;
        private DevExpress.XtraEditors.LabelControl lbl_header;
    }
}