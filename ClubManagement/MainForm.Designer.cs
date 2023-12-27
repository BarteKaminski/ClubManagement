
namespace ClubManagement
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.TabClub = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Players = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Staff = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Sponsors = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Equipment = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.TabStatistic = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Statistic = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Table = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Schedule = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.TabFinance = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.MembershipFees = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Budget = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.DebtCollection = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.TabSettings = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Profile = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Users = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            resources.ApplyResources(this.fluentDesignFormControl1, "fluentDesignFormControl1");
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.DockingEnabled = false;
            this.fluentFormDefaultManager1.Form = this;
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fluentDesignFormContainer1.Appearance.Options.UseBackColor = true;
            this.fluentDesignFormContainer1.Controls.Add(this.accordionControl1);
            resources.ApplyResources(this.fluentDesignFormContainer1, "fluentDesignFormContainer1");
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            // 
            // accordionControl1
            // 
            this.accordionControl1.AllowItemSelection = true;
            resources.ApplyResources(this.accordionControl1, "accordionControl1");
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.TabClub,
            this.TabStatistic,
            this.TabFinance,
            this.TabSettings});
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Auto;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // TabClub
            // 
            this.TabClub.Appearance.Pressed.BackColor = System.Drawing.Color.Tomato;
            this.TabClub.Appearance.Pressed.Options.UseBackColor = true;
            this.TabClub.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.Players,
            this.Staff,
            this.Sponsors,
            this.Equipment});
            this.TabClub.Expanded = true;
            resources.ApplyResources(this.TabClub, "TabClub");
            this.TabClub.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TabClub.ImageOptions.Image")));
            this.TabClub.Name = "TabClub";
            // 
            // Players
            // 
            this.Players.Appearance.Pressed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Players.Appearance.Pressed.BackColor2 = ((System.Drawing.Color)(resources.GetObject("Players.Appearance.Pressed.BackColor2")));
            this.Players.Appearance.Pressed.Options.UseBackColor = true;
            this.Players.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Players.ImageOptions.Image")));
            this.Players.Name = "Players";
            this.Players.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.Players, "Players");
            this.Players.Click += new System.EventHandler(this.Players_Click);
            // 
            // Staff
            // 
            this.Staff.Appearance.Pressed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Staff.Appearance.Pressed.BackColor2 = ((System.Drawing.Color)(resources.GetObject("Staff.Appearance.Pressed.BackColor2")));
            this.Staff.Appearance.Pressed.Options.UseBackColor = true;
            this.Staff.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Staff.ImageOptions.Image")));
            this.Staff.Name = "Staff";
            this.Staff.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.Staff, "Staff");
            // 
            // Sponsors
            // 
            this.Sponsors.Appearance.Pressed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Sponsors.Appearance.Pressed.BackColor2 = ((System.Drawing.Color)(resources.GetObject("Sponsors.Appearance.Pressed.BackColor2")));
            this.Sponsors.Appearance.Pressed.Options.UseBackColor = true;
            this.Sponsors.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Sponsors.ImageOptions.Image")));
            this.Sponsors.Name = "Sponsors";
            this.Sponsors.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.Sponsors, "Sponsors");
            // 
            // Equipment
            // 
            this.Equipment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Equipment.ImageOptions.Image")));
            this.Equipment.Name = "Equipment";
            this.Equipment.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.Equipment, "Equipment");
            // 
            // TabStatistic
            // 
            this.TabStatistic.Appearance.Pressed.BackColor = System.Drawing.Color.Tomato;
            this.TabStatistic.Appearance.Pressed.Options.UseBackColor = true;
            this.TabStatistic.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.Statistic,
            this.Table,
            this.Schedule});
            this.TabStatistic.Expanded = true;
            resources.ApplyResources(this.TabStatistic, "TabStatistic");
            this.TabStatistic.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TabStatistic.ImageOptions.Image")));
            this.TabStatistic.Name = "TabStatistic";
            // 
            // Statistic
            // 
            this.Statistic.Appearance.Pressed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Statistic.Appearance.Pressed.BackColor2 = ((System.Drawing.Color)(resources.GetObject("Statistic.Appearance.Pressed.BackColor2")));
            this.Statistic.Appearance.Pressed.Options.UseBackColor = true;
            this.Statistic.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Statistic.ImageOptions.Image")));
            this.Statistic.Name = "Statistic";
            this.Statistic.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.Statistic, "Statistic");
            // 
            // Table
            // 
            this.Table.Appearance.Pressed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Table.Appearance.Pressed.BackColor2 = ((System.Drawing.Color)(resources.GetObject("Table.Appearance.Pressed.BackColor2")));
            this.Table.Appearance.Pressed.Options.UseBackColor = true;
            this.Table.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Table.ImageOptions.Image")));
            this.Table.Name = "Table";
            this.Table.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.Table, "Table");
            // 
            // Schedule
            // 
            this.Schedule.Appearance.Pressed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Schedule.Appearance.Pressed.BackColor2 = ((System.Drawing.Color)(resources.GetObject("Schedule.Appearance.Pressed.BackColor2")));
            this.Schedule.Appearance.Pressed.Options.UseBackColor = true;
            this.Schedule.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Schedule.ImageOptions.Image")));
            this.Schedule.Name = "Schedule";
            this.Schedule.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.Schedule, "Schedule");
            // 
            // TabFinance
            // 
            this.TabFinance.Appearance.Pressed.BackColor = System.Drawing.Color.Tomato;
            this.TabFinance.Appearance.Pressed.Options.UseBackColor = true;
            this.TabFinance.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.MembershipFees,
            this.Budget,
            this.DebtCollection});
            this.TabFinance.Expanded = true;
            resources.ApplyResources(this.TabFinance, "TabFinance");
            this.TabFinance.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TabFinance.ImageOptions.Image")));
            this.TabFinance.Name = "TabFinance";
            // 
            // MembershipFees
            // 
            this.MembershipFees.Appearance.Pressed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MembershipFees.Appearance.Pressed.BackColor2 = ((System.Drawing.Color)(resources.GetObject("MembershipFees.Appearance.Pressed.BackColor2")));
            this.MembershipFees.Appearance.Pressed.Options.UseBackColor = true;
            this.MembershipFees.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("MembershipFees.ImageOptions.Image")));
            this.MembershipFees.Name = "MembershipFees";
            this.MembershipFees.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.MembershipFees, "MembershipFees");
            this.MembershipFees.Click += new System.EventHandler(this.MembershipFees_Click);
            // 
            // Budget
            // 
            this.Budget.Appearance.Pressed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Budget.Appearance.Pressed.BackColor2 = ((System.Drawing.Color)(resources.GetObject("Budget.Appearance.Pressed.BackColor2")));
            this.Budget.Appearance.Pressed.Options.UseBackColor = true;
            this.Budget.Enabled = false;
            this.Budget.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Budget.ImageOptions.Image")));
            this.Budget.Name = "Budget";
            this.Budget.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.Budget, "Budget");
            // 
            // DebtCollection
            // 
            this.DebtCollection.Appearance.Pressed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DebtCollection.Appearance.Pressed.BackColor2 = ((System.Drawing.Color)(resources.GetObject("DebtCollection.Appearance.Pressed.BackColor2")));
            this.DebtCollection.Appearance.Pressed.Options.UseBackColor = true;
            this.DebtCollection.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DebtCollection.ImageOptions.Image")));
            this.DebtCollection.Name = "DebtCollection";
            this.DebtCollection.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.DebtCollection, "DebtCollection");
            this.DebtCollection.Click += new System.EventHandler(this.DebtCollection_Click);
            // 
            // TabSettings
            // 
            this.TabSettings.Appearance.Pressed.BackColor = System.Drawing.Color.Tomato;
            this.TabSettings.Appearance.Pressed.Options.UseBackColor = true;
            this.TabSettings.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.Profile,
            this.Users});
            this.TabSettings.Expanded = true;
            resources.ApplyResources(this.TabSettings, "TabSettings");
            this.TabSettings.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TabSettings.ImageOptions.Image")));
            this.TabSettings.Name = "TabSettings";
            // 
            // Profile
            // 
            this.Profile.Appearance.Pressed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Profile.Appearance.Pressed.BackColor2 = ((System.Drawing.Color)(resources.GetObject("Profile.Appearance.Pressed.BackColor2")));
            this.Profile.Appearance.Pressed.Options.UseBackColor = true;
            this.Profile.ImageOptions.Image = global::ClubManagement.Properties.Resources.customer_32x32;
            this.Profile.Name = "Profile";
            this.Profile.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.Profile, "Profile");
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            // 
            // Users
            // 
            this.Users.Appearance.Pressed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Users.Appearance.Pressed.BackColor2 = ((System.Drawing.Color)(resources.GetObject("Users.Appearance.Pressed.BackColor2")));
            this.Users.Appearance.Pressed.Options.UseBackColor = true;
            this.Users.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Users.ImageOptions.Image")));
            this.Users.Name = "Users";
            this.Users.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            resources.ApplyResources(this.Users, "Users");
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // MainForm
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.KeyPreview = true;
            this.LookAndFeel.SkinName = "Office 2016 Black";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement TabClub;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Players;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Staff;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Sponsors;
        private DevExpress.XtraBars.Navigation.AccordionControlElement TabStatistic;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Statistic;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Table;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Schedule;
        private DevExpress.XtraBars.Navigation.AccordionControlElement TabFinance;
        private DevExpress.XtraBars.Navigation.AccordionControlElement MembershipFees;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Budget;
        private DevExpress.XtraBars.Navigation.AccordionControlElement DebtCollection;
        private DevExpress.XtraBars.Navigation.AccordionControlElement TabSettings;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Profile;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Users;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Equipment;
    }
}