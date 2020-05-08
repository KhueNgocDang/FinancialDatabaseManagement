namespace FinancialDatabaseManagementApplication
{
    partial class MainWindow
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
            this.TabControl = new MetroFramework.Controls.MetroTabControl();
            this.CompanyDetail = new MetroFramework.Controls.MetroTabPage();
            this.CompanyTabControl = new MetroFramework.Controls.MetroTabControl();
            this.CompanyDetailedTab = new MetroFramework.Controls.MetroTabPage();
            this.CompanyName = new MetroFramework.Controls.MetroLabel();
            this.ExchangeMembershipTextLabel = new MetroFramework.Controls.MetroLabel();
            this.SubSectorTextLabel = new MetroFramework.Controls.MetroLabel();
            this.SectorTextLabel = new MetroFramework.Controls.MetroLabel();
            this.SuperSectorTextLabel = new MetroFramework.Controls.MetroLabel();
            this.IndustryTextLabel = new MetroFramework.Controls.MetroLabel();
            this.ExchangeMembershipLabel = new System.Windows.Forms.Label();
            this.SubSectorLabel = new System.Windows.Forms.Label();
            this.SectorLabel = new System.Windows.Forms.Label();
            this.SuperSectorLabel = new System.Windows.Forms.Label();
            this.IndustryLabel = new System.Windows.Forms.Label();
            this.DetailLabel = new System.Windows.Forms.Label();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.FinancialTab = new MetroFramework.Controls.MetroTabPage();
            this.FinancialTabControl = new MetroFramework.Controls.MetroTabControl();
            this.BSTab = new MetroFramework.Controls.MetroTabPage();
            this.BSListView = new MetroFramework.Controls.MetroListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FINCTab = new MetroFramework.Controls.MetroTabPage();
            this.FINCSListView = new MetroFramework.Controls.MetroListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CFSTab = new MetroFramework.Controls.MetroTabPage();
            this.CFSListView = new MetroFramework.Controls.MetroListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StockTab = new MetroFramework.Controls.MetroTabPage();
            this.ToDateTime = new System.Windows.Forms.DateTimePicker();
            this.FromDateTime = new System.Windows.Forms.DateTimePicker();
            this.ToDateLabel = new System.Windows.Forms.Label();
            this.FromDateLabel = new System.Windows.Forms.Label();
            this.StockListView = new MetroFramework.Controls.MetroListView();
            this.CompanySearchBox = new MetroFramework.Controls.MetroTextBox();
            this.CompanySearchLabel = new System.Windows.Forms.Label();
            this.ICBSearchTab1 = new MetroFramework.Controls.MetroTabPage();
            this.ICBCompanyListView = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ICBComboBox = new MetroFramework.Controls.MetroComboBox();
            this.ICBSearchBox = new MetroFramework.Controls.MetroTextBox();
            this.ICBSearchLabel = new System.Windows.Forms.Label();
            this.InputTaskTab = new MetroFramework.Controls.MetroTabPage();
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TabControl.SuspendLayout();
            this.CompanyDetail.SuspendLayout();
            this.CompanyTabControl.SuspendLayout();
            this.CompanyDetailedTab.SuspendLayout();
            this.FinancialTab.SuspendLayout();
            this.FinancialTabControl.SuspendLayout();
            this.BSTab.SuspendLayout();
            this.FINCTab.SuspendLayout();
            this.CFSTab.SuspendLayout();
            this.StockTab.SuspendLayout();
            this.ICBSearchTab1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.CompanyDetail);
            this.TabControl.Controls.Add(this.ICBSearchTab1);
            this.TabControl.Controls.Add(this.InputTaskTab);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(30, 92);
            this.TabControl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1140, 569);
            this.TabControl.TabIndex = 1;
            this.TabControl.UseSelectable = true;
            // 
            // CompanyDetail
            // 
            this.CompanyDetail.Controls.Add(this.CompanyTabControl);
            this.CompanyDetail.Controls.Add(this.CompanySearchBox);
            this.CompanyDetail.Controls.Add(this.CompanySearchLabel);
            this.CompanyDetail.HorizontalScrollbarBarColor = true;
            this.CompanyDetail.HorizontalScrollbarHighlightOnWheel = false;
            this.CompanyDetail.HorizontalScrollbarSize = 15;
            this.CompanyDetail.Location = new System.Drawing.Point(4, 38);
            this.CompanyDetail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CompanyDetail.Name = "CompanyDetail";
            this.CompanyDetail.Size = new System.Drawing.Size(1132, 527);
            this.CompanyDetail.TabIndex = 0;
            this.CompanyDetail.Text = "Company Search";
            this.CompanyDetail.VerticalScrollbarBarColor = true;
            this.CompanyDetail.VerticalScrollbarHighlightOnWheel = false;
            this.CompanyDetail.VerticalScrollbarSize = 15;
            // 
            // CompanyTabControl
            // 
            this.CompanyTabControl.Controls.Add(this.CompanyDetailedTab);
            this.CompanyTabControl.Controls.Add(this.FinancialTab);
            this.CompanyTabControl.Location = new System.Drawing.Point(6, 51);
            this.CompanyTabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CompanyTabControl.Name = "CompanyTabControl";
            this.CompanyTabControl.SelectedIndex = 1;
            this.CompanyTabControl.Size = new System.Drawing.Size(1096, 460);
            this.CompanyTabControl.TabIndex = 16;
            this.CompanyTabControl.UseSelectable = true;
            // 
            // CompanyDetailedTab
            // 
            this.CompanyDetailedTab.Controls.Add(this.CompanyName);
            this.CompanyDetailedTab.Controls.Add(this.ExchangeMembershipTextLabel);
            this.CompanyDetailedTab.Controls.Add(this.SubSectorTextLabel);
            this.CompanyDetailedTab.Controls.Add(this.SectorTextLabel);
            this.CompanyDetailedTab.Controls.Add(this.SuperSectorTextLabel);
            this.CompanyDetailedTab.Controls.Add(this.IndustryTextLabel);
            this.CompanyDetailedTab.Controls.Add(this.ExchangeMembershipLabel);
            this.CompanyDetailedTab.Controls.Add(this.SubSectorLabel);
            this.CompanyDetailedTab.Controls.Add(this.SectorLabel);
            this.CompanyDetailedTab.Controls.Add(this.SuperSectorLabel);
            this.CompanyDetailedTab.Controls.Add(this.IndustryLabel);
            this.CompanyDetailedTab.Controls.Add(this.DetailLabel);
            this.CompanyDetailedTab.Controls.Add(this.CompanyNameLabel);
            this.CompanyDetailedTab.HorizontalScrollbarBarColor = true;
            this.CompanyDetailedTab.HorizontalScrollbarHighlightOnWheel = false;
            this.CompanyDetailedTab.HorizontalScrollbarSize = 15;
            this.CompanyDetailedTab.Location = new System.Drawing.Point(4, 38);
            this.CompanyDetailedTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CompanyDetailedTab.Name = "CompanyDetailedTab";
            this.CompanyDetailedTab.Size = new System.Drawing.Size(1088, 418);
            this.CompanyDetailedTab.TabIndex = 0;
            this.CompanyDetailedTab.Text = "Detailed";
            this.CompanyDetailedTab.VerticalScrollbarBarColor = true;
            this.CompanyDetailedTab.VerticalScrollbarHighlightOnWheel = false;
            this.CompanyDetailedTab.VerticalScrollbarSize = 15;
            // 
            // CompanyName
            // 
            this.CompanyName.AutoSize = true;
            this.CompanyName.Location = new System.Drawing.Point(279, 23);
            this.CompanyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(81, 19);
            this.CompanyName.TabIndex = 27;
            this.CompanyName.Text = "metroLabel1";
            // 
            // ExchangeMembershipTextLabel
            // 
            this.ExchangeMembershipTextLabel.AutoSize = true;
            this.ExchangeMembershipTextLabel.Location = new System.Drawing.Point(597, 200);
            this.ExchangeMembershipTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExchangeMembershipTextLabel.Name = "ExchangeMembershipTextLabel";
            this.ExchangeMembershipTextLabel.Size = new System.Drawing.Size(83, 19);
            this.ExchangeMembershipTextLabel.TabIndex = 26;
            this.ExchangeMembershipTextLabel.Text = "metroLabel5";
            // 
            // SubSectorTextLabel
            // 
            this.SubSectorTextLabel.AutoSize = true;
            this.SubSectorTextLabel.Location = new System.Drawing.Point(312, 315);
            this.SubSectorTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubSectorTextLabel.Name = "SubSectorTextLabel";
            this.SubSectorTextLabel.Size = new System.Drawing.Size(83, 19);
            this.SubSectorTextLabel.TabIndex = 25;
            this.SubSectorTextLabel.Text = "metroLabel4";
            // 
            // SectorTextLabel
            // 
            this.SectorTextLabel.AutoSize = true;
            this.SectorTextLabel.Location = new System.Drawing.Point(312, 258);
            this.SectorTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SectorTextLabel.Name = "SectorTextLabel";
            this.SectorTextLabel.Size = new System.Drawing.Size(83, 19);
            this.SectorTextLabel.TabIndex = 24;
            this.SectorTextLabel.Text = "metroLabel3";
            // 
            // SuperSectorTextLabel
            // 
            this.SuperSectorTextLabel.AutoSize = true;
            this.SuperSectorTextLabel.Location = new System.Drawing.Point(312, 200);
            this.SuperSectorTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SuperSectorTextLabel.Name = "SuperSectorTextLabel";
            this.SuperSectorTextLabel.Size = new System.Drawing.Size(83, 19);
            this.SuperSectorTextLabel.TabIndex = 23;
            this.SuperSectorTextLabel.Text = "metroLabel2";
            // 
            // IndustryTextLabel
            // 
            this.IndustryTextLabel.AutoSize = true;
            this.IndustryTextLabel.Location = new System.Drawing.Point(312, 142);
            this.IndustryTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IndustryTextLabel.Name = "IndustryTextLabel";
            this.IndustryTextLabel.Size = new System.Drawing.Size(81, 19);
            this.IndustryTextLabel.TabIndex = 22;
            this.IndustryTextLabel.Text = "metroLabel1";
            // 
            // ExchangeMembershipLabel
            // 
            this.ExchangeMembershipLabel.AutoSize = true;
            this.ExchangeMembershipLabel.BackColor = System.Drawing.Color.White;
            this.ExchangeMembershipLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExchangeMembershipLabel.Location = new System.Drawing.Point(572, 142);
            this.ExchangeMembershipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExchangeMembershipLabel.Name = "ExchangeMembershipLabel";
            this.ExchangeMembershipLabel.Size = new System.Drawing.Size(282, 29);
            this.ExchangeMembershipLabel.TabIndex = 21;
            this.ExchangeMembershipLabel.Text = "Exchange Membership:";
            // 
            // SubSectorLabel
            // 
            this.SubSectorLabel.AutoSize = true;
            this.SubSectorLabel.BackColor = System.Drawing.Color.White;
            this.SubSectorLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.SubSectorLabel.Location = new System.Drawing.Point(112, 315);
            this.SubSectorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubSectorLabel.Name = "SubSectorLabel";
            this.SubSectorLabel.Size = new System.Drawing.Size(140, 29);
            this.SubSectorLabel.TabIndex = 20;
            this.SubSectorLabel.Text = "SubSector:";
            // 
            // SectorLabel
            // 
            this.SectorLabel.AutoSize = true;
            this.SectorLabel.BackColor = System.Drawing.Color.White;
            this.SectorLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.SectorLabel.Location = new System.Drawing.Point(112, 258);
            this.SectorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SectorLabel.Name = "SectorLabel";
            this.SectorLabel.Size = new System.Drawing.Size(94, 29);
            this.SectorLabel.TabIndex = 19;
            this.SectorLabel.Text = "Sector:";
            // 
            // SuperSectorLabel
            // 
            this.SuperSectorLabel.AutoSize = true;
            this.SuperSectorLabel.BackColor = System.Drawing.Color.White;
            this.SuperSectorLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.SuperSectorLabel.Location = new System.Drawing.Point(112, 200);
            this.SuperSectorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SuperSectorLabel.Name = "SuperSectorLabel";
            this.SuperSectorLabel.Size = new System.Drawing.Size(162, 29);
            this.SuperSectorLabel.TabIndex = 18;
            this.SuperSectorLabel.Text = "SuperSector:";
            // 
            // IndustryLabel
            // 
            this.IndustryLabel.AutoSize = true;
            this.IndustryLabel.BackColor = System.Drawing.Color.White;
            this.IndustryLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndustryLabel.Location = new System.Drawing.Point(116, 142);
            this.IndustryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IndustryLabel.Name = "IndustryLabel";
            this.IndustryLabel.Size = new System.Drawing.Size(115, 29);
            this.IndustryLabel.TabIndex = 17;
            this.IndustryLabel.Text = "Industry:";
            // 
            // DetailLabel
            // 
            this.DetailLabel.AutoSize = true;
            this.DetailLabel.BackColor = System.Drawing.Color.White;
            this.DetailLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.DetailLabel.Location = new System.Drawing.Point(76, 82);
            this.DetailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DetailLabel.Name = "DetailLabel";
            this.DetailLabel.Size = new System.Drawing.Size(95, 30);
            this.DetailLabel.TabIndex = 16;
            this.DetailLabel.Text = "Detail:";
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.BackColor = System.Drawing.Color.White;
            this.CompanyNameLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyNameLabel.Location = new System.Drawing.Point(26, 18);
            this.CompanyNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(245, 34);
            this.CompanyNameLabel.TabIndex = 5;
            this.CompanyNameLabel.Text = "Company Name:";
            // 
            // FinancialTab
            // 
            this.FinancialTab.Controls.Add(this.FinancialTabControl);
            this.FinancialTab.HorizontalScrollbarBarColor = true;
            this.FinancialTab.HorizontalScrollbarHighlightOnWheel = false;
            this.FinancialTab.HorizontalScrollbarSize = 15;
            this.FinancialTab.Location = new System.Drawing.Point(4, 38);
            this.FinancialTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FinancialTab.Name = "FinancialTab";
            this.FinancialTab.Size = new System.Drawing.Size(1088, 418);
            this.FinancialTab.TabIndex = 1;
            this.FinancialTab.Text = "Financials";
            this.FinancialTab.VerticalScrollbarBarColor = true;
            this.FinancialTab.VerticalScrollbarHighlightOnWheel = false;
            this.FinancialTab.VerticalScrollbarSize = 15;
            // 
            // FinancialTabControl
            // 
            this.FinancialTabControl.Controls.Add(this.BSTab);
            this.FinancialTabControl.Controls.Add(this.FINCTab);
            this.FinancialTabControl.Controls.Add(this.CFSTab);
            this.FinancialTabControl.Controls.Add(this.StockTab);
            this.FinancialTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.FinancialTabControl.Location = new System.Drawing.Point(0, 0);
            this.FinancialTabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FinancialTabControl.Name = "FinancialTabControl";
            this.FinancialTabControl.SelectedIndex = 3;
            this.FinancialTabControl.Size = new System.Drawing.Size(1088, 391);
            this.FinancialTabControl.TabIndex = 2;
            this.FinancialTabControl.UseSelectable = true;
            // 
            // BSTab
            // 
            this.BSTab.Controls.Add(this.BSListView);
            this.BSTab.HorizontalScrollbarBarColor = true;
            this.BSTab.HorizontalScrollbarHighlightOnWheel = false;
            this.BSTab.HorizontalScrollbarSize = 15;
            this.BSTab.Location = new System.Drawing.Point(4, 38);
            this.BSTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BSTab.Name = "BSTab";
            this.BSTab.Size = new System.Drawing.Size(1080, 349);
            this.BSTab.TabIndex = 0;
            this.BSTab.Text = "Balance Sheet";
            this.BSTab.VerticalScrollbarBarColor = true;
            this.BSTab.VerticalScrollbarHighlightOnWheel = false;
            this.BSTab.VerticalScrollbarSize = 15;
            // 
            // BSListView
            // 
            this.BSListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.BSListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BSListView.FullRowSelect = true;
            this.BSListView.Location = new System.Drawing.Point(24, 5);
            this.BSListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BSListView.Name = "BSListView";
            this.BSListView.OwnerDraw = true;
            this.BSListView.Size = new System.Drawing.Size(1003, 315);
            this.BSListView.TabIndex = 2;
            this.BSListView.UseCompatibleStateImageBehavior = false;
            this.BSListView.UseSelectable = true;
            this.BSListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Item ID";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Title";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Year";
            this.columnHeader6.Width = 75;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Value";
            this.columnHeader7.Width = 250;
            // 
            // FINCTab
            // 
            this.FINCTab.Controls.Add(this.FINCSListView);
            this.FINCTab.HorizontalScrollbarBarColor = true;
            this.FINCTab.HorizontalScrollbarHighlightOnWheel = false;
            this.FINCTab.HorizontalScrollbarSize = 10;
            this.FINCTab.Location = new System.Drawing.Point(4, 38);
            this.FINCTab.Name = "FINCTab";
            this.FINCTab.Size = new System.Drawing.Size(1080, 349);
            this.FINCTab.TabIndex = 1;
            this.FINCTab.Text = "Financial Income Statement";
            this.FINCTab.VerticalScrollbarBarColor = true;
            this.FINCTab.VerticalScrollbarHighlightOnWheel = false;
            this.FINCTab.VerticalScrollbarSize = 10;
            // 
            // FINCSListView
            // 
            this.FINCSListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.FINCSListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FINCSListView.FullRowSelect = true;
            this.FINCSListView.Location = new System.Drawing.Point(24, 5);
            this.FINCSListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FINCSListView.Name = "FINCSListView";
            this.FINCSListView.OwnerDraw = true;
            this.FINCSListView.Size = new System.Drawing.Size(1000, 315);
            this.FINCSListView.TabIndex = 3;
            this.FINCSListView.UseCompatibleStateImageBehavior = false;
            this.FINCSListView.UseSelectable = true;
            this.FINCSListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Item ID";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Title";
            this.columnHeader9.Width = 200;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Year";
            this.columnHeader10.Width = 75;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Value";
            this.columnHeader11.Width = 250;
            // 
            // CFSTab
            // 
            this.CFSTab.Controls.Add(this.CFSListView);
            this.CFSTab.HorizontalScrollbarBarColor = true;
            this.CFSTab.HorizontalScrollbarHighlightOnWheel = false;
            this.CFSTab.HorizontalScrollbarSize = 10;
            this.CFSTab.Location = new System.Drawing.Point(4, 38);
            this.CFSTab.Name = "CFSTab";
            this.CFSTab.Size = new System.Drawing.Size(1080, 349);
            this.CFSTab.TabIndex = 2;
            this.CFSTab.Text = "Cash Flow Statement";
            this.CFSTab.VerticalScrollbarBarColor = true;
            this.CFSTab.VerticalScrollbarHighlightOnWheel = false;
            this.CFSTab.VerticalScrollbarSize = 10;
            // 
            // CFSListView
            // 
            this.CFSListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.CFSListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CFSListView.FullRowSelect = true;
            this.CFSListView.Location = new System.Drawing.Point(27, 5);
            this.CFSListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CFSListView.Name = "CFSListView";
            this.CFSListView.OwnerDraw = true;
            this.CFSListView.Size = new System.Drawing.Size(1003, 315);
            this.CFSListView.TabIndex = 3;
            this.CFSListView.UseCompatibleStateImageBehavior = false;
            this.CFSListView.UseSelectable = true;
            this.CFSListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Item ID";
            this.columnHeader12.Width = 100;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Title";
            this.columnHeader13.Width = 200;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Year";
            this.columnHeader14.Width = 75;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Value";
            this.columnHeader15.Width = 250;
            // 
            // StockTab
            // 
            this.StockTab.Controls.Add(this.ToDateTime);
            this.StockTab.Controls.Add(this.FromDateTime);
            this.StockTab.Controls.Add(this.ToDateLabel);
            this.StockTab.Controls.Add(this.FromDateLabel);
            this.StockTab.Controls.Add(this.StockListView);
            this.StockTab.HorizontalScrollbarBarColor = true;
            this.StockTab.HorizontalScrollbarHighlightOnWheel = false;
            this.StockTab.HorizontalScrollbarSize = 10;
            this.StockTab.Location = new System.Drawing.Point(4, 38);
            this.StockTab.Name = "StockTab";
            this.StockTab.Size = new System.Drawing.Size(1080, 349);
            this.StockTab.TabIndex = 3;
            this.StockTab.Text = "Stock";
            this.StockTab.VerticalScrollbarBarColor = true;
            this.StockTab.VerticalScrollbarHighlightOnWheel = false;
            this.StockTab.VerticalScrollbarSize = 10;
            // 
            // ToDateTime
            // 
            this.ToDateTime.CustomFormat = "yyyy-MM-dd";
            this.ToDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDateTime.Location = new System.Drawing.Point(742, 146);
            this.ToDateTime.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.ToDateTime.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.ToDateTime.Name = "ToDateTime";
            this.ToDateTime.Size = new System.Drawing.Size(164, 26);
            this.ToDateTime.TabIndex = 9;
            this.ToDateTime.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // FromDateTime
            // 
            this.FromDateTime.CustomFormat = "yyyy-MM-dd";
            this.FromDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDateTime.Location = new System.Drawing.Point(742, 44);
            this.FromDateTime.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.FromDateTime.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.FromDateTime.Name = "FromDateTime";
            this.FromDateTime.Size = new System.Drawing.Size(164, 26);
            this.FromDateTime.TabIndex = 8;
            this.FromDateTime.Value = new System.DateTime(2010, 12, 25, 0, 0, 0, 0);
            // 
            // ToDateLabel
            // 
            this.ToDateLabel.AutoSize = true;
            this.ToDateLabel.BackColor = System.Drawing.Color.White;
            this.ToDateLabel.Location = new System.Drawing.Point(690, 146);
            this.ToDateLabel.Name = "ToDateLabel";
            this.ToDateLabel.Size = new System.Drawing.Size(27, 20);
            this.ToDateLabel.TabIndex = 5;
            this.ToDateLabel.Text = "To";
            // 
            // FromDateLabel
            // 
            this.FromDateLabel.AutoSize = true;
            this.FromDateLabel.BackColor = System.Drawing.Color.White;
            this.FromDateLabel.Location = new System.Drawing.Point(690, 49);
            this.FromDateLabel.Name = "FromDateLabel";
            this.FromDateLabel.Size = new System.Drawing.Size(46, 20);
            this.FromDateLabel.TabIndex = 4;
            this.FromDateLabel.Text = "From";
            // 
            // StockListView
            // 
            this.StockListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader18,
            this.columnHeader16});
            this.StockListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.StockListView.FullRowSelect = true;
            this.StockListView.Location = new System.Drawing.Point(28, 5);
            this.StockListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StockListView.Name = "StockListView";
            this.StockListView.OwnerDraw = true;
            this.StockListView.Size = new System.Drawing.Size(627, 315);
            this.StockListView.TabIndex = 3;
            this.StockListView.UseCompatibleStateImageBehavior = false;
            this.StockListView.UseSelectable = true;
            this.StockListView.View = System.Windows.Forms.View.Details;
            // 
            // CompanySearchBox
            // 
            // 
            // 
            // 
            this.CompanySearchBox.CustomButton.Image = global::FinancialDatabaseManagementApplication.Properties.Resources.kisspng_material_font_search_icon_5b21819439b852_2823675615289225162364;
            this.CompanySearchBox.CustomButton.Location = new System.Drawing.Point(323, 1);
            this.CompanySearchBox.CustomButton.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.CompanySearchBox.CustomButton.Name = "";
            this.CompanySearchBox.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.CompanySearchBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CompanySearchBox.CustomButton.TabIndex = 1;
            this.CompanySearchBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CompanySearchBox.CustomButton.UseSelectable = true;
            this.CompanySearchBox.DisplayIcon = true;
            this.CompanySearchBox.ForeColor = System.Drawing.Color.Black;
            this.CompanySearchBox.Lines = new string[0];
            this.CompanySearchBox.Location = new System.Drawing.Point(312, 11);
            this.CompanySearchBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CompanySearchBox.MaxLength = 32767;
            this.CompanySearchBox.Name = "CompanySearchBox";
            this.CompanySearchBox.PasswordChar = '\0';
            this.CompanySearchBox.PromptText = "Enter company ticker here";
            this.CompanySearchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CompanySearchBox.SelectedText = "";
            this.CompanySearchBox.SelectionLength = 0;
            this.CompanySearchBox.SelectionStart = 0;
            this.CompanySearchBox.ShortcutsEnabled = true;
            this.CompanySearchBox.ShowButton = true;
            this.CompanySearchBox.ShowClearButton = true;
            this.CompanySearchBox.Size = new System.Drawing.Size(357, 35);
            this.CompanySearchBox.TabIndex = 3;
            this.CompanySearchBox.UseCustomForeColor = true;
            this.CompanySearchBox.UseSelectable = true;
            this.CompanySearchBox.WaterMark = "Enter company ticker here";
            this.CompanySearchBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CompanySearchBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.CompanySearchBox.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.CompanySearchBox_ButtonClick);
            // 
            // CompanySearchLabel
            // 
            this.CompanySearchLabel.AutoSize = true;
            this.CompanySearchLabel.BackColor = System.Drawing.Color.White;
            this.CompanySearchLabel.Font = new System.Drawing.Font("Arial", 14.75F, System.Drawing.FontStyle.Bold);
            this.CompanySearchLabel.Location = new System.Drawing.Point(93, 9);
            this.CompanySearchLabel.Name = "CompanySearchLabel";
            this.CompanySearchLabel.Size = new System.Drawing.Size(150, 35);
            this.CompanySearchLabel.TabIndex = 2;
            this.CompanySearchLabel.Text = "Company";
            // 
            // ICBSearchTab1
            // 
            this.ICBSearchTab1.Controls.Add(this.ICBCompanyListView);
            this.ICBSearchTab1.Controls.Add(this.ICBComboBox);
            this.ICBSearchTab1.Controls.Add(this.ICBSearchBox);
            this.ICBSearchTab1.Controls.Add(this.ICBSearchLabel);
            this.ICBSearchTab1.HorizontalScrollbarBarColor = true;
            this.ICBSearchTab1.HorizontalScrollbarHighlightOnWheel = false;
            this.ICBSearchTab1.HorizontalScrollbarSize = 15;
            this.ICBSearchTab1.Location = new System.Drawing.Point(4, 38);
            this.ICBSearchTab1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ICBSearchTab1.Name = "ICBSearchTab1";
            this.ICBSearchTab1.Size = new System.Drawing.Size(1132, 527);
            this.ICBSearchTab1.TabIndex = 1;
            this.ICBSearchTab1.Text = "ICB Company Search";
            this.ICBSearchTab1.VerticalScrollbarBarColor = true;
            this.ICBSearchTab1.VerticalScrollbarHighlightOnWheel = false;
            this.ICBSearchTab1.VerticalScrollbarSize = 15;
            // 
            // ICBCompanyListView
            // 
            this.ICBCompanyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ICBCompanyListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ICBCompanyListView.FullRowSelect = true;
            this.ICBCompanyListView.Location = new System.Drawing.Point(159, 175);
            this.ICBCompanyListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ICBCompanyListView.Name = "ICBCompanyListView";
            this.ICBCompanyListView.OwnerDraw = true;
            this.ICBCompanyListView.Size = new System.Drawing.Size(854, 241);
            this.ICBCompanyListView.TabIndex = 6;
            this.ICBCompanyListView.UseCompatibleStateImageBehavior = false;
            this.ICBCompanyListView.UseSelectable = true;
            this.ICBCompanyListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Company Ticker";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Company Name";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Exchange Ticker";
            this.columnHeader3.Width = 150;
            // 
            // ICBComboBox
            // 
            this.ICBComboBox.FormattingEnabled = true;
            this.ICBComboBox.ItemHeight = 23;
            this.ICBComboBox.Items.AddRange(new object[] {
            "Industry",
            "SuperSector",
            "Sector",
            "SubSector"});
            this.ICBComboBox.Location = new System.Drawing.Point(326, 57);
            this.ICBComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ICBComboBox.Name = "ICBComboBox";
            this.ICBComboBox.Size = new System.Drawing.Size(180, 29);
            this.ICBComboBox.TabIndex = 5;
            this.ICBComboBox.UseSelectable = true;
            this.ICBComboBox.SelectedIndexChanged += new System.EventHandler(this.ICBComboBox_SelectedIndexChanged);
            // 
            // ICBSearchBox
            // 
            // 
            // 
            // 
            this.ICBSearchBox.CustomButton.Image = global::FinancialDatabaseManagementApplication.Properties.Resources.kisspng_material_font_search_icon_5b21819439b852_2823675615289225162364;
            this.ICBSearchBox.CustomButton.Location = new System.Drawing.Point(323, 1);
            this.ICBSearchBox.CustomButton.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.ICBSearchBox.CustomButton.Name = "";
            this.ICBSearchBox.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.ICBSearchBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ICBSearchBox.CustomButton.TabIndex = 1;
            this.ICBSearchBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ICBSearchBox.CustomButton.UseSelectable = true;
            this.ICBSearchBox.DisplayIcon = true;
            this.ICBSearchBox.ForeColor = System.Drawing.Color.Silver;
            this.ICBSearchBox.Lines = new string[0];
            this.ICBSearchBox.Location = new System.Drawing.Point(556, 66);
            this.ICBSearchBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ICBSearchBox.MaxLength = 32767;
            this.ICBSearchBox.Name = "ICBSearchBox";
            this.ICBSearchBox.PasswordChar = '\0';
            this.ICBSearchBox.PromptText = "Enter ICB Code  here";
            this.ICBSearchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ICBSearchBox.SelectedText = "";
            this.ICBSearchBox.SelectionLength = 0;
            this.ICBSearchBox.SelectionStart = 0;
            this.ICBSearchBox.ShortcutsEnabled = true;
            this.ICBSearchBox.ShowButton = true;
            this.ICBSearchBox.ShowClearButton = true;
            this.ICBSearchBox.Size = new System.Drawing.Size(357, 35);
            this.ICBSearchBox.TabIndex = 4;
            this.ICBSearchBox.UseCustomForeColor = true;
            this.ICBSearchBox.UseSelectable = true;
            this.ICBSearchBox.WaterMark = "Enter ICB Code  here";
            this.ICBSearchBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ICBSearchBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ICBSearchBox.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.ICBSearchBox_ButtonClick);
            // 
            // ICBSearchLabel
            // 
            this.ICBSearchLabel.AutoSize = true;
            this.ICBSearchLabel.BackColor = System.Drawing.Color.White;
            this.ICBSearchLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICBSearchLabel.Location = new System.Drawing.Point(117, 65);
            this.ICBSearchLabel.Name = "ICBSearchLabel";
            this.ICBSearchLabel.Size = new System.Drawing.Size(186, 37);
            this.ICBSearchLabel.TabIndex = 3;
            this.ICBSearchLabel.Text = "ICB Search";
            // 
            // InputTaskTab
            // 
            this.InputTaskTab.HorizontalScrollbarBarColor = true;
            this.InputTaskTab.HorizontalScrollbarHighlightOnWheel = false;
            this.InputTaskTab.HorizontalScrollbarSize = 15;
            this.InputTaskTab.Location = new System.Drawing.Point(4, 38);
            this.InputTaskTab.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.InputTaskTab.Name = "InputTaskTab";
            this.InputTaskTab.Size = new System.Drawing.Size(1132, 527);
            this.InputTaskTab.TabIndex = 2;
            this.InputTaskTab.Text = "Input";
            this.InputTaskTab.VerticalScrollbarBarColor = true;
            this.InputTaskTab.VerticalScrollbarHighlightOnWheel = false;
            this.InputTaskTab.VerticalScrollbarSize = 15;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Day";
            this.columnHeader18.Width = 100;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Closed Adjusted Price";
            this.columnHeader16.Width = 150;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.TabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Text = "Bài tập nhóm 6";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.TabControl.ResumeLayout(false);
            this.CompanyDetail.ResumeLayout(false);
            this.CompanyDetail.PerformLayout();
            this.CompanyTabControl.ResumeLayout(false);
            this.CompanyDetailedTab.ResumeLayout(false);
            this.CompanyDetailedTab.PerformLayout();
            this.FinancialTab.ResumeLayout(false);
            this.FinancialTabControl.ResumeLayout(false);
            this.BSTab.ResumeLayout(false);
            this.FINCTab.ResumeLayout(false);
            this.CFSTab.ResumeLayout(false);
            this.StockTab.ResumeLayout(false);
            this.StockTab.PerformLayout();
            this.ICBSearchTab1.ResumeLayout(false);
            this.ICBSearchTab1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl TabControl;
        private MetroFramework.Controls.MetroTabPage CompanyDetail;
        private System.Windows.Forms.Label CompanySearchLabel;
        private MetroFramework.Controls.MetroTabPage ICBSearchTab1;
        private MetroFramework.Controls.MetroTabPage InputTaskTab;
        private MetroFramework.Controls.MetroTextBox CompanySearchBox;
        private MetroFramework.Controls.MetroComboBox ICBComboBox;
        private MetroFramework.Controls.MetroTextBox ICBSearchBox;
        private System.Windows.Forms.Label ICBSearchLabel;
        private MetroFramework.Controls.MetroListView ICBCompanyListView;
        private MetroFramework.Controls.MetroTabControl CompanyTabControl;
        private MetroFramework.Controls.MetroTabPage CompanyDetailedTab;
        private MetroFramework.Controls.MetroLabel ExchangeMembershipTextLabel;
        private MetroFramework.Controls.MetroLabel SubSectorTextLabel;
        private MetroFramework.Controls.MetroLabel SectorTextLabel;
        private MetroFramework.Controls.MetroLabel SuperSectorTextLabel;
        private MetroFramework.Controls.MetroLabel IndustryTextLabel;
        private System.Windows.Forms.Label ExchangeMembershipLabel;
        private System.Windows.Forms.Label SubSectorLabel;
        private System.Windows.Forms.Label SectorLabel;
        private System.Windows.Forms.Label SuperSectorLabel;
        private System.Windows.Forms.Label IndustryLabel;
        private System.Windows.Forms.Label DetailLabel;
        private System.Windows.Forms.Label CompanyNameLabel;
        private MetroFramework.Controls.MetroTabPage FinancialTab;
        private MetroFramework.Controls.MetroTabControl FinancialTabControl;
        private MetroFramework.Controls.MetroTabPage BSTab;
        private MetroFramework.Controls.MetroLabel CompanyName;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MetroFramework.Controls.MetroListView BSListView;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private MetroFramework.Controls.MetroTabPage FINCTab;
        private MetroFramework.Controls.MetroListView FINCSListView;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private MetroFramework.Controls.MetroTabPage CFSTab;
        private MetroFramework.Controls.MetroListView CFSListView;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private MetroFramework.Controls.MetroTabPage StockTab;
        private MetroFramework.Controls.MetroListView StockListView;
        private System.Windows.Forms.Label ToDateLabel;
        private System.Windows.Forms.Label FromDateLabel;
        private System.Windows.Forms.DateTimePicker ToDateTime;
        private System.Windows.Forms.DateTimePicker FromDateTime;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader16;
    }
}

