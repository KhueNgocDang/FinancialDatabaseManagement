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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabControl = new MetroFramework.Controls.MetroTabControl();
            this.CompanyDetail = new MetroFramework.Controls.MetroTabPage();
            this.CompanyTabControl = new MetroFramework.Controls.MetroTabControl();
            this.CompanyDetailedTab = new MetroFramework.Controls.MetroTabPage();
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
            this.BSGrid = new MetroFramework.Controls.MetroGrid();
            this.CompanySearchBox = new MetroFramework.Controls.MetroTextBox();
            this.CompanySearchLabel = new System.Windows.Forms.Label();
            this.ICBSearchTab = new MetroFramework.Controls.MetroTabPage();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.ICBComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.ICBSearchLabel = new System.Windows.Forms.Label();
            this.DetatiledCompanySearchTab = new MetroFramework.Controls.MetroTabPage();
            this.CompanyName = new MetroFramework.Controls.MetroLabel();
            this.TabControl.SuspendLayout();
            this.CompanyDetail.SuspendLayout();
            this.CompanyTabControl.SuspendLayout();
            this.CompanyDetailedTab.SuspendLayout();
            this.FinancialTab.SuspendLayout();
            this.FinancialTabControl.SuspendLayout();
            this.BSTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSGrid)).BeginInit();
            this.ICBSearchTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.CompanyDetail);
            this.TabControl.Controls.Add(this.ICBSearchTab);
            this.TabControl.Controls.Add(this.DetatiledCompanySearchTab);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(20, 60);
            this.TabControl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(760, 370);
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
            this.CompanyDetail.HorizontalScrollbarSize = 10;
            this.CompanyDetail.Location = new System.Drawing.Point(4, 38);
            this.CompanyDetail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CompanyDetail.Name = "CompanyDetail";
            this.CompanyDetail.Size = new System.Drawing.Size(752, 328);
            this.CompanyDetail.TabIndex = 0;
            this.CompanyDetail.Text = "Company Search";
            this.CompanyDetail.VerticalScrollbarBarColor = true;
            this.CompanyDetail.VerticalScrollbarHighlightOnWheel = false;
            this.CompanyDetail.VerticalScrollbarSize = 10;
            // 
            // CompanyTabControl
            // 
            this.CompanyTabControl.Controls.Add(this.CompanyDetailedTab);
            this.CompanyTabControl.Controls.Add(this.FinancialTab);
            this.CompanyTabControl.Location = new System.Drawing.Point(4, 33);
            this.CompanyTabControl.Name = "CompanyTabControl";
            this.CompanyTabControl.SelectedIndex = 0;
            this.CompanyTabControl.Size = new System.Drawing.Size(731, 299);
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
            this.CompanyDetailedTab.HorizontalScrollbarSize = 10;
            this.CompanyDetailedTab.Location = new System.Drawing.Point(4, 38);
            this.CompanyDetailedTab.Name = "CompanyDetailedTab";
            this.CompanyDetailedTab.Size = new System.Drawing.Size(723, 257);
            this.CompanyDetailedTab.TabIndex = 0;
            this.CompanyDetailedTab.Text = "Detailed";
            this.CompanyDetailedTab.VerticalScrollbarBarColor = true;
            this.CompanyDetailedTab.VerticalScrollbarHighlightOnWheel = false;
            this.CompanyDetailedTab.VerticalScrollbarSize = 10;
            // 
            // ExchangeMembershipTextLabel
            // 
            this.ExchangeMembershipTextLabel.AutoSize = true;
            this.ExchangeMembershipTextLabel.Location = new System.Drawing.Point(586, 92);
            this.ExchangeMembershipTextLabel.Name = "ExchangeMembershipTextLabel";
            this.ExchangeMembershipTextLabel.Size = new System.Drawing.Size(83, 19);
            this.ExchangeMembershipTextLabel.TabIndex = 26;
            this.ExchangeMembershipTextLabel.Text = "metroLabel5";
            // 
            // SubSectorTextLabel
            // 
            this.SubSectorTextLabel.AutoSize = true;
            this.SubSectorTextLabel.Location = new System.Drawing.Point(208, 205);
            this.SubSectorTextLabel.Name = "SubSectorTextLabel";
            this.SubSectorTextLabel.Size = new System.Drawing.Size(83, 19);
            this.SubSectorTextLabel.TabIndex = 25;
            this.SubSectorTextLabel.Text = "metroLabel4";
            // 
            // SectorTextLabel
            // 
            this.SectorTextLabel.AutoSize = true;
            this.SectorTextLabel.Location = new System.Drawing.Point(208, 168);
            this.SectorTextLabel.Name = "SectorTextLabel";
            this.SectorTextLabel.Size = new System.Drawing.Size(83, 19);
            this.SectorTextLabel.TabIndex = 24;
            this.SectorTextLabel.Text = "metroLabel3";
            // 
            // SuperSectorTextLabel
            // 
            this.SuperSectorTextLabel.AutoSize = true;
            this.SuperSectorTextLabel.Location = new System.Drawing.Point(208, 130);
            this.SuperSectorTextLabel.Name = "SuperSectorTextLabel";
            this.SuperSectorTextLabel.Size = new System.Drawing.Size(83, 19);
            this.SuperSectorTextLabel.TabIndex = 23;
            this.SuperSectorTextLabel.Text = "metroLabel2";
            // 
            // IndustryTextLabel
            // 
            this.IndustryTextLabel.AutoSize = true;
            this.IndustryTextLabel.Location = new System.Drawing.Point(208, 92);
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
            this.ExchangeMembershipLabel.Location = new System.Drawing.Point(381, 92);
            this.ExchangeMembershipLabel.Name = "ExchangeMembershipLabel";
            this.ExchangeMembershipLabel.Size = new System.Drawing.Size(190, 19);
            this.ExchangeMembershipLabel.TabIndex = 21;
            this.ExchangeMembershipLabel.Text = "Exchange Membership:";
            // 
            // SubSectorLabel
            // 
            this.SubSectorLabel.AutoSize = true;
            this.SubSectorLabel.BackColor = System.Drawing.Color.White;
            this.SubSectorLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.SubSectorLabel.Location = new System.Drawing.Point(75, 205);
            this.SubSectorLabel.Name = "SubSectorLabel";
            this.SubSectorLabel.Size = new System.Drawing.Size(96, 19);
            this.SubSectorLabel.TabIndex = 20;
            this.SubSectorLabel.Text = "SubSector:";
            // 
            // SectorLabel
            // 
            this.SectorLabel.AutoSize = true;
            this.SectorLabel.BackColor = System.Drawing.Color.White;
            this.SectorLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.SectorLabel.Location = new System.Drawing.Point(75, 168);
            this.SectorLabel.Name = "SectorLabel";
            this.SectorLabel.Size = new System.Drawing.Size(65, 19);
            this.SectorLabel.TabIndex = 19;
            this.SectorLabel.Text = "Sector:";
            // 
            // SuperSectorLabel
            // 
            this.SuperSectorLabel.AutoSize = true;
            this.SuperSectorLabel.BackColor = System.Drawing.Color.White;
            this.SuperSectorLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.SuperSectorLabel.Location = new System.Drawing.Point(75, 130);
            this.SuperSectorLabel.Name = "SuperSectorLabel";
            this.SuperSectorLabel.Size = new System.Drawing.Size(111, 19);
            this.SuperSectorLabel.TabIndex = 18;
            this.SuperSectorLabel.Text = "SuperSector:";
            // 
            // IndustryLabel
            // 
            this.IndustryLabel.AutoSize = true;
            this.IndustryLabel.BackColor = System.Drawing.Color.White;
            this.IndustryLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndustryLabel.Location = new System.Drawing.Point(77, 92);
            this.IndustryLabel.Name = "IndustryLabel";
            this.IndustryLabel.Size = new System.Drawing.Size(78, 19);
            this.IndustryLabel.TabIndex = 17;
            this.IndustryLabel.Text = "Industry:";
            // 
            // DetailLabel
            // 
            this.DetailLabel.AutoSize = true;
            this.DetailLabel.BackColor = System.Drawing.Color.White;
            this.DetailLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.DetailLabel.Location = new System.Drawing.Point(51, 53);
            this.DetailLabel.Name = "DetailLabel";
            this.DetailLabel.Size = new System.Drawing.Size(67, 21);
            this.DetailLabel.TabIndex = 16;
            this.DetailLabel.Text = "Detail:";
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.BackColor = System.Drawing.Color.White;
            this.CompanyNameLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyNameLabel.Location = new System.Drawing.Point(17, 12);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(163, 22);
            this.CompanyNameLabel.TabIndex = 5;
            this.CompanyNameLabel.Text = "Company Name:";
            // 
            // FinancialTab
            // 
            this.FinancialTab.Controls.Add(this.FinancialTabControl);
            this.FinancialTab.HorizontalScrollbarBarColor = true;
            this.FinancialTab.HorizontalScrollbarHighlightOnWheel = false;
            this.FinancialTab.HorizontalScrollbarSize = 10;
            this.FinancialTab.Location = new System.Drawing.Point(4, 38);
            this.FinancialTab.Name = "FinancialTab";
            this.FinancialTab.Size = new System.Drawing.Size(723, 257);
            this.FinancialTab.TabIndex = 1;
            this.FinancialTab.Text = "Financials";
            this.FinancialTab.VerticalScrollbarBarColor = true;
            this.FinancialTab.VerticalScrollbarHighlightOnWheel = false;
            this.FinancialTab.VerticalScrollbarSize = 10;
            // 
            // FinancialTabControl
            // 
            this.FinancialTabControl.Controls.Add(this.BSTab);
            this.FinancialTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.FinancialTabControl.Location = new System.Drawing.Point(0, 0);
            this.FinancialTabControl.Name = "FinancialTabControl";
            this.FinancialTabControl.SelectedIndex = 0;
            this.FinancialTabControl.Size = new System.Drawing.Size(723, 222);
            this.FinancialTabControl.TabIndex = 2;
            this.FinancialTabControl.UseSelectable = true;
            // 
            // BSTab
            // 
            this.BSTab.Controls.Add(this.BSGrid);
            this.BSTab.HorizontalScrollbarBarColor = true;
            this.BSTab.HorizontalScrollbarHighlightOnWheel = false;
            this.BSTab.HorizontalScrollbarSize = 10;
            this.BSTab.Location = new System.Drawing.Point(4, 38);
            this.BSTab.Name = "BSTab";
            this.BSTab.Size = new System.Drawing.Size(715, 180);
            this.BSTab.TabIndex = 0;
            this.BSTab.Text = "Balance Sheet";
            this.BSTab.VerticalScrollbarBarColor = true;
            this.BSTab.VerticalScrollbarHighlightOnWheel = false;
            this.BSTab.VerticalScrollbarSize = 10;
            // 
            // BSGrid
            // 
            this.BSGrid.AllowUserToResizeRows = false;
            this.BSGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BSGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BSGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.BSGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BSGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BSGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BSGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.BSGrid.EnableHeadersVisualStyles = false;
            this.BSGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BSGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BSGrid.Location = new System.Drawing.Point(36, 17);
            this.BSGrid.Name = "BSGrid";
            this.BSGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BSGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.BSGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.BSGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BSGrid.Size = new System.Drawing.Size(676, 160);
            this.BSGrid.TabIndex = 2;
            // 
            // CompanySearchBox
            // 
            // 
            // 
            // 
            this.CompanySearchBox.CustomButton.Image = global::FinancialDatabaseManagementApplication.Properties.Resources.kisspng_material_font_search_icon_5b21819439b852_2823675615289225162364;
            this.CompanySearchBox.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.CompanySearchBox.CustomButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CompanySearchBox.CustomButton.Name = "";
            this.CompanySearchBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CompanySearchBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CompanySearchBox.CustomButton.TabIndex = 1;
            this.CompanySearchBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CompanySearchBox.CustomButton.UseSelectable = true;
            this.CompanySearchBox.DisplayIcon = true;
            this.CompanySearchBox.ForeColor = System.Drawing.Color.Silver;
            this.CompanySearchBox.Lines = new string[] {
        "Enter company ticker here"};
            this.CompanySearchBox.Location = new System.Drawing.Point(208, 7);
            this.CompanySearchBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CompanySearchBox.MaxLength = 32767;
            this.CompanySearchBox.Name = "CompanySearchBox";
            this.CompanySearchBox.PasswordChar = '\0';
            this.CompanySearchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CompanySearchBox.SelectedText = "";
            this.CompanySearchBox.SelectionLength = 0;
            this.CompanySearchBox.SelectionStart = 0;
            this.CompanySearchBox.ShortcutsEnabled = true;
            this.CompanySearchBox.ShowButton = true;
            this.CompanySearchBox.ShowClearButton = true;
            this.CompanySearchBox.Size = new System.Drawing.Size(238, 23);
            this.CompanySearchBox.TabIndex = 3;
            this.CompanySearchBox.Text = "Enter company ticker here";
            this.CompanySearchBox.UseCustomForeColor = true;
            this.CompanySearchBox.UseSelectable = true;
            this.CompanySearchBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CompanySearchBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.CompanySearchBox.Click += new System.EventHandler(this.CompanySearchBox_Click);
            // 
            // CompanySearchLabel
            // 
            this.CompanySearchLabel.AutoSize = true;
            this.CompanySearchLabel.BackColor = System.Drawing.Color.White;
            this.CompanySearchLabel.Font = new System.Drawing.Font("Arial", 14.75F, System.Drawing.FontStyle.Bold);
            this.CompanySearchLabel.Location = new System.Drawing.Point(62, 6);
            this.CompanySearchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CompanySearchLabel.Name = "CompanySearchLabel";
            this.CompanySearchLabel.Size = new System.Drawing.Size(99, 24);
            this.CompanySearchLabel.TabIndex = 2;
            this.CompanySearchLabel.Text = "Company";
            // 
            // ICBSearchTab
            // 
            this.ICBSearchTab.Controls.Add(this.metroListView1);
            this.ICBSearchTab.Controls.Add(this.ICBComboBox);
            this.ICBSearchTab.Controls.Add(this.metroTextBox1);
            this.ICBSearchTab.Controls.Add(this.ICBSearchLabel);
            this.ICBSearchTab.HorizontalScrollbarBarColor = true;
            this.ICBSearchTab.HorizontalScrollbarHighlightOnWheel = false;
            this.ICBSearchTab.HorizontalScrollbarSize = 10;
            this.ICBSearchTab.Location = new System.Drawing.Point(4, 38);
            this.ICBSearchTab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ICBSearchTab.Name = "ICBSearchTab";
            this.ICBSearchTab.Size = new System.Drawing.Size(752, 328);
            this.ICBSearchTab.TabIndex = 1;
            this.ICBSearchTab.Text = "ICB Search";
            this.ICBSearchTab.VerticalScrollbarBarColor = true;
            this.ICBSearchTab.VerticalScrollbarHighlightOnWheel = false;
            this.ICBSearchTab.VerticalScrollbarSize = 10;
            // 
            // metroListView1
            // 
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(106, 114);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(477, 158);
            this.metroListView1.TabIndex = 6;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            // 
            // ICBComboBox
            // 
            this.ICBComboBox.FormattingEnabled = true;
            this.ICBComboBox.ItemHeight = 23;
            this.ICBComboBox.Location = new System.Drawing.Point(217, 37);
            this.ICBComboBox.Name = "ICBComboBox";
            this.ICBComboBox.Size = new System.Drawing.Size(121, 29);
            this.ICBComboBox.TabIndex = 5;
            this.ICBComboBox.UseSelectable = true;
            this.ICBComboBox.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = global::FinancialDatabaseManagementApplication.Properties.Resources.kisspng_material_font_search_icon_5b21819439b852_2823675615289225162364;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.metroTextBox1.CustomButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.DisplayIcon = true;
            this.metroTextBox1.ForeColor = System.Drawing.Color.Silver;
            this.metroTextBox1.Lines = new string[] {
        "Enter ICB code  here"};
            this.metroTextBox1.Location = new System.Drawing.Point(371, 43);
            this.metroTextBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.ShowButton = true;
            this.metroTextBox1.ShowClearButton = true;
            this.metroTextBox1.Size = new System.Drawing.Size(238, 23);
            this.metroTextBox1.TabIndex = 4;
            this.metroTextBox1.Text = "Enter ICB code  here";
            this.metroTextBox1.UseCustomForeColor = true;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ICBSearchLabel
            // 
            this.ICBSearchLabel.AutoSize = true;
            this.ICBSearchLabel.BackColor = System.Drawing.Color.White;
            this.ICBSearchLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICBSearchLabel.Location = new System.Drawing.Point(78, 42);
            this.ICBSearchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ICBSearchLabel.Name = "ICBSearchLabel";
            this.ICBSearchLabel.Size = new System.Drawing.Size(122, 24);
            this.ICBSearchLabel.TabIndex = 3;
            this.ICBSearchLabel.Text = "ICB Search";
            // 
            // DetatiledCompanySearchTab
            // 
            this.DetatiledCompanySearchTab.HorizontalScrollbarBarColor = true;
            this.DetatiledCompanySearchTab.HorizontalScrollbarHighlightOnWheel = false;
            this.DetatiledCompanySearchTab.HorizontalScrollbarSize = 10;
            this.DetatiledCompanySearchTab.Location = new System.Drawing.Point(4, 38);
            this.DetatiledCompanySearchTab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DetatiledCompanySearchTab.Name = "DetatiledCompanySearchTab";
            this.DetatiledCompanySearchTab.Size = new System.Drawing.Size(752, 328);
            this.DetatiledCompanySearchTab.TabIndex = 2;
            this.DetatiledCompanySearchTab.Text = "metroTabPage3";
            this.DetatiledCompanySearchTab.VerticalScrollbarBarColor = true;
            this.DetatiledCompanySearchTab.VerticalScrollbarHighlightOnWheel = false;
            this.DetatiledCompanySearchTab.VerticalScrollbarSize = 10;
            // 
            // CompanyName
            // 
            this.CompanyName.AutoSize = true;
            this.CompanyName.Location = new System.Drawing.Point(186, 15);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(81, 19);
            this.CompanyName.TabIndex = 27;
            this.CompanyName.Text = "metroLabel1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainWindow";
            this.Text = "Bài tập nhóm 6";
            this.TabControl.ResumeLayout(false);
            this.CompanyDetail.ResumeLayout(false);
            this.CompanyDetail.PerformLayout();
            this.CompanyTabControl.ResumeLayout(false);
            this.CompanyDetailedTab.ResumeLayout(false);
            this.CompanyDetailedTab.PerformLayout();
            this.FinancialTab.ResumeLayout(false);
            this.FinancialTabControl.ResumeLayout(false);
            this.BSTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BSGrid)).EndInit();
            this.ICBSearchTab.ResumeLayout(false);
            this.ICBSearchTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl TabControl;
        private MetroFramework.Controls.MetroTabPage CompanyDetail;
        private System.Windows.Forms.Label CompanySearchLabel;
        private MetroFramework.Controls.MetroTabPage ICBSearchTab;
        private MetroFramework.Controls.MetroTabPage DetatiledCompanySearchTab;
        private MetroFramework.Controls.MetroTextBox CompanySearchBox;
        private MetroFramework.Controls.MetroComboBox ICBComboBox;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Label ICBSearchLabel;
        private MetroFramework.Controls.MetroListView metroListView1;
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
        private MetroFramework.Controls.MetroGrid BSGrid;
        private MetroFramework.Controls.MetroLabel CompanyName;
    }
}

