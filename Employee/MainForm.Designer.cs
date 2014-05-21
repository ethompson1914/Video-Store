using System.Linq;
using Mappings;
using NHibernate.Linq;

namespace Employee
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.operationsPage = new System.Windows.Forms.TabPage();
            this.grpCheckAvailability = new System.Windows.Forms.GroupBox();
            this.lstOperationsStoresToSearch = new System.Windows.Forms.ListBox();
            this.btnOperationsTitleExactMatch = new System.Windows.Forms.RadioButton();
            this.btnOperationsTitleContainsText = new System.Windows.Forms.RadioButton();
            this.txtOperationsMovieTitle = new System.Windows.Forms.TextBox();
            this.lblStore = new System.Windows.Forms.Label();
            this.lblAvailableMovieTitle = new System.Windows.Forms.Label();
            this.grpCheckIn = new System.Windows.Forms.GroupBox();
            this.lblSelectedVideo = new System.Windows.Forms.Label();
            this.btnOperationsCheckIn = new System.Windows.Forms.Button();
            this.cbxOperationsCheckInVideoID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpCheckOut = new System.Windows.Forms.GroupBox();
            this.btnOpCheckout = new System.Windows.Forms.Button();
            this.cbxOperationsCheckoutVideoID = new System.Windows.Forms.ComboBox();
            this.lblVideoIDOut = new System.Windows.Forms.Label();
            this.cbxOperationsCustomerID = new System.Windows.Forms.ComboBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.inventoryPage = new System.Windows.Forms.TabPage();
            this.grpRemoveMovie = new System.Windows.Forms.GroupBox();
            this.btnRemoveVideo = new System.Windows.Forms.Button();
            this.cbxInventoryRemoveVideoVideoID = new System.Windows.Forms.ComboBox();
            this.lblVideoID = new System.Windows.Forms.Label();
            this.grpAddMovie = new System.Windows.Forms.GroupBox();
            this.lblCopies = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnInventoryAddVideo = new System.Windows.Forms.Button();
            this.cbxNewArrival = new System.Windows.Forms.CheckBox();
            this.cbxInventoryAddVideoMovieID = new System.Windows.Forms.ComboBox();
            this.lblMatchingMovies = new System.Windows.Forms.Label();
            this.txtInventoryAddVideoMovieTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.customerPage = new System.Windows.Forms.TabPage();
            this.CreateNewCustomerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.grpNewCustomer = new System.Windows.Forms.GroupBox();
            this.lnklblCustomersShowAllRentalHistory = new System.Windows.Forms.LinkLabel();
            this.lnklblCustomersShowCurrentRentals = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNewCustomerConfirmedPassword = new System.Windows.Forms.TextBox();
            this.txtBoxNewCustomersPassword = new System.Windows.Forms.TextBox();
            this.lblCustomerNewCustomerPassword = new System.Windows.Forms.Label();
            this.btnCustomerNewCustomerCancel = new System.Windows.Forms.Button();
            this.cbxNewCustomerTitle = new System.Windows.Forms.ComboBox();
            this.CreateNewCustomerTitleLabel = new System.Windows.Forms.Label();
            this.btnCustomersNewCustomerSave = new System.Windows.Forms.Button();
            this.txtCustomersNewPhone = new System.Windows.Forms.TextBox();
            this.lblPrimaryPhoneNew = new System.Windows.Forms.Label();
            this.txtCustomersNewZip = new System.Windows.Forms.TextBox();
            this.lblZipNew = new System.Windows.Forms.Label();
            this.cbxCustomersNewState = new System.Windows.Forms.ComboBox();
            this.lblStateNew = new System.Windows.Forms.Label();
            this.txtCustomersNewCity = new System.Windows.Forms.TextBox();
            this.lblCityNew = new System.Windows.Forms.Label();
            this.txtCustomersNewStreetAddress = new System.Windows.Forms.TextBox();
            this.lblStreetAddressNew = new System.Windows.Forms.Label();
            this.txtCustomersNewLastName = new System.Windows.Forms.TextBox();
            this.lblLastNameNew = new System.Windows.Forms.Label();
            this.txtCustomersNewFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstNameNew = new System.Windows.Forms.Label();
            this.grpFindCustomer = new System.Windows.Forms.GroupBox();
            this.scanBarCodeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.FindCustomerInstruction2 = new System.Windows.Forms.Label();
            this.FindCustomerInstruction1 = new System.Windows.Forms.Label();
            this.txtSearchFirstName = new System.Windows.Forms.TextBox();
            this.lblSearchFirstName = new System.Windows.Forms.Label();
            this.txtSearchLastName = new System.Windows.Forms.TextBox();
            this.lblSearchLastName = new System.Windows.Forms.Label();
            this.reportsPage = new System.Windows.Forms.TabPage();
            this.grpCustomerReports = new System.Windows.Forms.GroupBox();
            this.btnReportsShowCustomersInArea = new System.Windows.Forms.Button();
            this.txtReportsZipCode = new System.Windows.Forms.TextBox();
            this.lblCustomersNearZipCode = new System.Windows.Forms.Label();
            this.btnReportsOpenStaleCustomers = new System.Windows.Forms.Button();
            this.cbxReportsCustomerUnits = new System.Windows.Forms.ComboBox();
            this.nupReportsNumberOfUnitsCustomers = new System.Windows.Forms.NumericUpDown();
            this.lblStaleCustomers = new System.Windows.Forms.Label();
            this.grpInventoryReports = new System.Windows.Forms.GroupBox();
            this.btnReportsOpenMostPopularMovies = new System.Windows.Forms.Button();
            this.lblPopularMovies = new System.Windows.Forms.Label();
            this.nudReportsNumberOfFrequentMovies = new System.Windows.Forms.NumericUpDown();
            this.btnReportsOpenStaleMovies = new System.Windows.Forms.Button();
            this.cbxVideoUnits = new System.Windows.Forms.ComboBox();
            this.lblUnrentedMovies = new System.Windows.Forms.Label();
            this.updReportsNumberOfUnitsMovies = new System.Windows.Forms.NumericUpDown();
            this.btnReportsShowInventory = new System.Windows.Forms.Button();
            this.lblShowInventory = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.infoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblOldStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnOperatinsCheckAvailability = new System.Windows.Forms.Button();
            this.btnOperationsSearchVideoIn = new System.Windows.Forms.Button();
            this.btnOperationsSearchVideoID = new System.Windows.Forms.Button();
            this.btnOperationsSearchCustomerID = new System.Windows.Forms.Button();
            this.btnLookupVideo = new System.Windows.Forms.Button();
            this.btnInventoryAddVideoSearchTitle = new System.Windows.Forms.Button();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.operationsPage.SuspendLayout();
            this.grpCheckAvailability.SuspendLayout();
            this.grpCheckIn.SuspendLayout();
            this.grpCheckOut.SuspendLayout();
            this.inventoryPage.SuspendLayout();
            this.grpRemoveMovie.SuspendLayout();
            this.grpAddMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.customerPage.SuspendLayout();
            this.grpNewCustomer.SuspendLayout();
            this.grpFindCustomer.SuspendLayout();
            this.reportsPage.SuspendLayout();
            this.grpCustomerReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupReportsNumberOfUnitsCustomers)).BeginInit();
            this.grpInventoryReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReportsNumberOfFrequentMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updReportsNumberOfUnitsMovies)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.operationsPage);
            this.tabControl1.Controls.Add(this.inventoryPage);
            this.tabControl1.Controls.Add(this.customerPage);
            this.tabControl1.Controls.Add(this.reportsPage);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(494, 467);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // operationsPage
            // 
            this.operationsPage.Controls.Add(this.grpCheckAvailability);
            this.operationsPage.Controls.Add(this.grpCheckIn);
            this.operationsPage.Controls.Add(this.grpCheckOut);
            this.operationsPage.Location = new System.Drawing.Point(4, 22);
            this.operationsPage.Name = "operationsPage";
            this.operationsPage.Size = new System.Drawing.Size(486, 441);
            this.operationsPage.TabIndex = 2;
            this.operationsPage.Text = "Operations";
            this.operationsPage.UseVisualStyleBackColor = true;
            // 
            // grpCheckAvailability
            // 
            this.grpCheckAvailability.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCheckAvailability.Controls.Add(this.lstOperationsStoresToSearch);
            this.grpCheckAvailability.Controls.Add(this.btnOperatinsCheckAvailability);
            this.grpCheckAvailability.Controls.Add(this.btnOperationsTitleExactMatch);
            this.grpCheckAvailability.Controls.Add(this.btnOperationsTitleContainsText);
            this.grpCheckAvailability.Controls.Add(this.txtOperationsMovieTitle);
            this.grpCheckAvailability.Controls.Add(this.lblStore);
            this.grpCheckAvailability.Controls.Add(this.lblAvailableMovieTitle);
            this.grpCheckAvailability.Location = new System.Drawing.Point(8, 255);
            this.grpCheckAvailability.Name = "grpCheckAvailability";
            this.grpCheckAvailability.Size = new System.Drawing.Size(469, 154);
            this.grpCheckAvailability.TabIndex = 13;
            this.grpCheckAvailability.TabStop = false;
            this.grpCheckAvailability.Text = "Check availability";
            // 
            // lstOperationsStoresToSearch
            // 
            this.lstOperationsStoresToSearch.FormattingEnabled = true;
            this.lstOperationsStoresToSearch.Items.AddRange(new object[] {
            "Holland Northside",
            "Holland Soutside",
            "Zeeland"});
            this.lstOperationsStoresToSearch.Location = new System.Drawing.Point(73, 57);
            this.lstOperationsStoresToSearch.Name = "lstOperationsStoresToSearch";
            this.lstOperationsStoresToSearch.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstOperationsStoresToSearch.Size = new System.Drawing.Size(200, 43);
            this.lstOperationsStoresToSearch.TabIndex = 16;
            this.lstOperationsStoresToSearch.SelectedIndexChanged += new System.EventHandler(this.lstStoresToSearch_SelectedIndexChanged);
            // 
            // btnOperationsTitleExactMatch
            // 
            this.btnOperationsTitleExactMatch.AutoSize = true;
            this.btnOperationsTitleExactMatch.Location = new System.Drawing.Point(363, 25);
            this.btnOperationsTitleExactMatch.Name = "btnOperationsTitleExactMatch";
            this.btnOperationsTitleExactMatch.Size = new System.Drawing.Size(85, 17);
            this.btnOperationsTitleExactMatch.TabIndex = 15;
            this.btnOperationsTitleExactMatch.Text = "Exact Match";
            this.btnOperationsTitleExactMatch.UseVisualStyleBackColor = true;
            // 
            // btnOperationsTitleContainsText
            // 
            this.btnOperationsTitleContainsText.AutoSize = true;
            this.btnOperationsTitleContainsText.Checked = true;
            this.btnOperationsTitleContainsText.Location = new System.Drawing.Point(291, 25);
            this.btnOperationsTitleContainsText.Name = "btnOperationsTitleContainsText";
            this.btnOperationsTitleContainsText.Size = new System.Drawing.Size(66, 17);
            this.btnOperationsTitleContainsText.TabIndex = 14;
            this.btnOperationsTitleContainsText.TabStop = true;
            this.btnOperationsTitleContainsText.Text = "Contains";
            this.btnOperationsTitleContainsText.UseVisualStyleBackColor = true;
            // 
            // txtOperationsMovieTitle
            // 
            this.txtOperationsMovieTitle.Location = new System.Drawing.Point(73, 23);
            this.txtOperationsMovieTitle.Name = "txtOperationsMovieTitle";
            this.txtOperationsMovieTitle.Size = new System.Drawing.Size(200, 20);
            this.txtOperationsMovieTitle.TabIndex = 13;
            this.txtOperationsMovieTitle.TextChanged += new System.EventHandler(this.txtOperationsMovieTitle_TextChanged);
            // 
            // lblStore
            // 
            this.lblStore.AutoSize = true;
            this.lblStore.Location = new System.Drawing.Point(8, 57);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(37, 13);
            this.lblStore.TabIndex = 12;
            this.lblStore.Text = "Stores";
            // 
            // lblAvailableMovieTitle
            // 
            this.lblAvailableMovieTitle.AutoSize = true;
            this.lblAvailableMovieTitle.Location = new System.Drawing.Point(7, 23);
            this.lblAvailableMovieTitle.Name = "lblAvailableMovieTitle";
            this.lblAvailableMovieTitle.Size = new System.Drawing.Size(59, 13);
            this.lblAvailableMovieTitle.TabIndex = 8;
            this.lblAvailableMovieTitle.Text = "Movie Title";
            // 
            // grpCheckIn
            // 
            this.grpCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCheckIn.Controls.Add(this.lblSelectedVideo);
            this.grpCheckIn.Controls.Add(this.btnOperationsCheckIn);
            this.grpCheckIn.Controls.Add(this.btnOperationsSearchVideoIn);
            this.grpCheckIn.Controls.Add(this.cbxOperationsCheckInVideoID);
            this.grpCheckIn.Controls.Add(this.label2);
            this.grpCheckIn.Location = new System.Drawing.Point(8, 143);
            this.grpCheckIn.Name = "grpCheckIn";
            this.grpCheckIn.Size = new System.Drawing.Size(469, 106);
            this.grpCheckIn.TabIndex = 12;
            this.grpCheckIn.TabStop = false;
            this.grpCheckIn.Text = "Check in";
            // 
            // lblSelectedVideo
            // 
            this.lblSelectedVideo.AutoSize = true;
            this.lblSelectedVideo.Location = new System.Drawing.Point(8, 57);
            this.lblSelectedVideo.Name = "lblSelectedVideo";
            this.lblSelectedVideo.Size = new System.Drawing.Size(108, 13);
            this.lblSelectedVideo.TabIndex = 12;
            this.lblSelectedVideo.Text = "Selected video: none";
            // 
            // btnOperationsCheckIn
            // 
            this.btnOperationsCheckIn.Enabled = false;
            this.btnOperationsCheckIn.Location = new System.Drawing.Point(198, 76);
            this.btnOperationsCheckIn.Name = "btnOperationsCheckIn";
            this.btnOperationsCheckIn.Size = new System.Drawing.Size(75, 23);
            this.btnOperationsCheckIn.TabIndex = 11;
            this.btnOperationsCheckIn.Text = "Check &in";
            this.toolTip.SetToolTip(this.btnOperationsCheckIn, "Click to check in the selected video");
            this.btnOperationsCheckIn.UseVisualStyleBackColor = true;
            // 
            // cbxOperationsCheckInVideoID
            // 
            this.cbxOperationsCheckInVideoID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOperationsCheckInVideoID.FormattingEnabled = true;
            this.cbxOperationsCheckInVideoID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbxOperationsCheckInVideoID.Location = new System.Drawing.Point(79, 23);
            this.cbxOperationsCheckInVideoID.Name = "cbxOperationsCheckInVideoID";
            this.cbxOperationsCheckInVideoID.Size = new System.Drawing.Size(140, 21);
            this.cbxOperationsCheckInVideoID.TabIndex = 9;
            this.toolTip.SetToolTip(this.cbxOperationsCheckInVideoID, "Select a video ID or scan using scanner");
            this.cbxOperationsCheckInVideoID.SelectedIndexChanged += new System.EventHandler(this.cbxCheckInVideoID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Video ID";
            // 
            // grpCheckOut
            // 
            this.grpCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCheckOut.Controls.Add(this.btnOpCheckout);
            this.grpCheckOut.Controls.Add(this.btnOperationsSearchVideoID);
            this.grpCheckOut.Controls.Add(this.cbxOperationsCheckoutVideoID);
            this.grpCheckOut.Controls.Add(this.lblVideoIDOut);
            this.grpCheckOut.Controls.Add(this.btnOperationsSearchCustomerID);
            this.grpCheckOut.Controls.Add(this.cbxOperationsCustomerID);
            this.grpCheckOut.Controls.Add(this.lblCustomerID);
            this.grpCheckOut.Location = new System.Drawing.Point(9, 4);
            this.grpCheckOut.Name = "grpCheckOut";
            this.grpCheckOut.Size = new System.Drawing.Size(469, 133);
            this.grpCheckOut.TabIndex = 0;
            this.grpCheckOut.TabStop = false;
            this.grpCheckOut.Text = "Check out";
            // 
            // btnOpCheckout
            // 
            this.btnOpCheckout.Enabled = false;
            this.btnOpCheckout.Location = new System.Drawing.Point(197, 99);
            this.btnOpCheckout.Name = "btnOpCheckout";
            this.btnOpCheckout.Size = new System.Drawing.Size(75, 23);
            this.btnOpCheckout.TabIndex = 11;
            this.btnOpCheckout.Text = "Check &out";
            this.toolTip.SetToolTip(this.btnOpCheckout, "Click to check out the selected video to the selected customer");
            this.btnOpCheckout.UseVisualStyleBackColor = true;
            // 
            // cbxOperationsCheckoutVideoID
            // 
            this.cbxOperationsCheckoutVideoID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOperationsCheckoutVideoID.FormattingEnabled = true;
            this.cbxOperationsCheckoutVideoID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbxOperationsCheckoutVideoID.Location = new System.Drawing.Point(79, 58);
            this.cbxOperationsCheckoutVideoID.Name = "cbxOperationsCheckoutVideoID";
            this.cbxOperationsCheckoutVideoID.Size = new System.Drawing.Size(140, 21);
            this.cbxOperationsCheckoutVideoID.TabIndex = 9;
            this.toolTip.SetToolTip(this.cbxOperationsCheckoutVideoID, "Select a video ID or scan using scanner");
            this.cbxOperationsCheckoutVideoID.SelectedIndexChanged += new System.EventHandler(this.cbxCheckoutVideoID_SelectedIndexChanged);
            // 
            // lblVideoIDOut
            // 
            this.lblVideoIDOut.AutoSize = true;
            this.lblVideoIDOut.Location = new System.Drawing.Point(7, 58);
            this.lblVideoIDOut.Name = "lblVideoIDOut";
            this.lblVideoIDOut.Size = new System.Drawing.Size(48, 13);
            this.lblVideoIDOut.TabIndex = 8;
            this.lblVideoIDOut.Text = "Video ID";
            // 
            // cbxOperationsCustomerID
            // 
            this.cbxOperationsCustomerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOperationsCustomerID.FormattingEnabled = true;
            this.cbxOperationsCustomerID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbxOperationsCustomerID.Location = new System.Drawing.Point(79, 20);
            this.cbxOperationsCustomerID.Name = "cbxOperationsCustomerID";
            this.cbxOperationsCustomerID.Size = new System.Drawing.Size(140, 21);
            this.cbxOperationsCustomerID.TabIndex = 1;
            this.toolTip.SetToolTip(this.cbxOperationsCustomerID, "Select a customer ID or scan using scanner");
            this.cbxOperationsCustomerID.SelectedIndexChanged += new System.EventHandler(this.cbxCustomerID_SelectedIndexChanged);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(7, 20);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(65, 13);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // inventoryPage
            // 
            this.inventoryPage.Controls.Add(this.grpRemoveMovie);
            this.inventoryPage.Controls.Add(this.grpAddMovie);
            this.inventoryPage.Location = new System.Drawing.Point(4, 22);
            this.inventoryPage.Name = "inventoryPage";
            this.inventoryPage.Padding = new System.Windows.Forms.Padding(3);
            this.inventoryPage.Size = new System.Drawing.Size(486, 441);
            this.inventoryPage.TabIndex = 0;
            this.inventoryPage.Text = "Inventory";
            this.inventoryPage.UseVisualStyleBackColor = true;
            // 
            // grpRemoveMovie
            // 
            this.grpRemoveMovie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRemoveMovie.Controls.Add(this.btnLookupVideo);
            this.grpRemoveMovie.Controls.Add(this.btnRemoveVideo);
            this.grpRemoveMovie.Controls.Add(this.cbxInventoryRemoveVideoVideoID);
            this.grpRemoveMovie.Controls.Add(this.lblVideoID);
            this.grpRemoveMovie.Location = new System.Drawing.Point(8, 188);
            this.grpRemoveMovie.Name = "grpRemoveMovie";
            this.grpRemoveMovie.Size = new System.Drawing.Size(469, 100);
            this.grpRemoveMovie.TabIndex = 1;
            this.grpRemoveMovie.TabStop = false;
            this.grpRemoveMovie.Text = "Remove a Video";
            // 
            // btnRemoveVideo
            // 
            this.btnRemoveVideo.Enabled = false;
            this.btnRemoveVideo.Location = new System.Drawing.Point(202, 56);
            this.btnRemoveVideo.Name = "btnRemoveVideo";
            this.btnRemoveVideo.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveVideo.TabIndex = 11;
            this.btnRemoveVideo.Text = "&Remove video";
            this.btnRemoveVideo.UseVisualStyleBackColor = true;
            // 
            // cbxInventoryRemoveVideoVideoID
            // 
            this.cbxInventoryRemoveVideoVideoID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxInventoryRemoveVideoVideoID.FormattingEnabled = true;
            this.cbxInventoryRemoveVideoVideoID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbxInventoryRemoveVideoVideoID.Location = new System.Drawing.Point(73, 16);
            this.cbxInventoryRemoveVideoVideoID.Name = "cbxInventoryRemoveVideoVideoID";
            this.cbxInventoryRemoveVideoVideoID.Size = new System.Drawing.Size(191, 21);
            this.cbxInventoryRemoveVideoVideoID.TabIndex = 1;
            this.cbxInventoryRemoveVideoVideoID.SelectedIndexChanged += new System.EventHandler(this.cbxRemoveVideoVideoID_SelectedIndexChanged);
            this.cbxInventoryRemoveVideoVideoID.MouseEnter += new System.EventHandler(this.comboBox2_MouseEnter);
            this.cbxInventoryRemoveVideoVideoID.MouseLeave += new System.EventHandler(this.comboBox2_MouseLeave);
            // 
            // lblVideoID
            // 
            this.lblVideoID.AutoSize = true;
            this.lblVideoID.Location = new System.Drawing.Point(7, 16);
            this.lblVideoID.Name = "lblVideoID";
            this.lblVideoID.Size = new System.Drawing.Size(48, 13);
            this.lblVideoID.TabIndex = 0;
            this.lblVideoID.Text = "Video ID";
            // 
            // grpAddMovie
            // 
            this.grpAddMovie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAddMovie.Controls.Add(this.lblCopies);
            this.grpAddMovie.Controls.Add(this.numericUpDown1);
            this.grpAddMovie.Controls.Add(this.btnInventoryAddVideo);
            this.grpAddMovie.Controls.Add(this.cbxNewArrival);
            this.grpAddMovie.Controls.Add(this.cbxInventoryAddVideoMovieID);
            this.grpAddMovie.Controls.Add(this.lblMatchingMovies);
            this.grpAddMovie.Controls.Add(this.btnInventoryAddVideoSearchTitle);
            this.grpAddMovie.Controls.Add(this.txtInventoryAddVideoMovieTitle);
            this.grpAddMovie.Controls.Add(this.lblTitle);
            this.grpAddMovie.Location = new System.Drawing.Point(8, 6);
            this.grpAddMovie.Name = "grpAddMovie";
            this.grpAddMovie.Size = new System.Drawing.Size(469, 157);
            this.grpAddMovie.TabIndex = 0;
            this.grpAddMovie.TabStop = false;
            this.grpAddMovie.Text = "Add a Movie";
            // 
            // lblCopies
            // 
            this.lblCopies.AutoSize = true;
            this.lblCopies.Location = new System.Drawing.Point(261, 65);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(39, 13);
            this.lblCopies.TabIndex = 10;
            this.lblCopies.Text = "Copies";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(264, 81);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnInventoryAddVideo
            // 
            this.btnInventoryAddVideo.Enabled = false;
            this.btnInventoryAddVideo.Location = new System.Drawing.Point(202, 122);
            this.btnInventoryAddVideo.Name = "btnInventoryAddVideo";
            this.btnInventoryAddVideo.Size = new System.Drawing.Size(75, 23);
            this.btnInventoryAddVideo.TabIndex = 8;
            this.btnInventoryAddVideo.Text = "&Add video";
            this.toolTip.SetToolTip(this.btnInventoryAddVideo, "Click to add new copies of the selected movie");
            this.btnInventoryAddVideo.UseVisualStyleBackColor = true;
            // 
            // cbxNewArrival
            // 
            this.cbxNewArrival.AutoSize = true;
            this.cbxNewArrival.Checked = true;
            this.cbxNewArrival.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxNewArrival.Location = new System.Drawing.Point(325, 81);
            this.cbxNewArrival.Name = "cbxNewArrival";
            this.cbxNewArrival.Size = new System.Drawing.Size(86, 17);
            this.cbxNewArrival.TabIndex = 7;
            this.cbxNewArrival.Text = "&New Arrival?";
            this.cbxNewArrival.UseVisualStyleBackColor = true;
            // 
            // cbxInventoryAddVideoMovieID
            // 
            this.cbxInventoryAddVideoMovieID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxInventoryAddVideoMovieID.FormattingEnabled = true;
            this.cbxInventoryAddVideoMovieID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxInventoryAddVideoMovieID.Location = new System.Drawing.Point(10, 79);
            this.cbxInventoryAddVideoMovieID.Name = "cbxInventoryAddVideoMovieID";
            this.cbxInventoryAddVideoMovieID.Size = new System.Drawing.Size(221, 21);
            this.cbxInventoryAddVideoMovieID.TabIndex = 6;
            this.cbxInventoryAddVideoMovieID.SelectedIndexChanged += new System.EventHandler(this.cbxInventoryAddVideoMovieID_SelectedIndexChanged);
            // 
            // lblMatchingMovies
            // 
            this.lblMatchingMovies.AutoSize = true;
            this.lblMatchingMovies.Location = new System.Drawing.Point(7, 65);
            this.lblMatchingMovies.Name = "lblMatchingMovies";
            this.lblMatchingMovies.Size = new System.Drawing.Size(88, 13);
            this.lblMatchingMovies.TabIndex = 5;
            this.lblMatchingMovies.Text = "Matching Movies";
            // 
            // txtInventoryAddVideoMovieTitle
            // 
            this.txtInventoryAddVideoMovieTitle.Location = new System.Drawing.Point(73, 20);
            this.txtInventoryAddVideoMovieTitle.Name = "txtInventoryAddVideoMovieTitle";
            this.txtInventoryAddVideoMovieTitle.Size = new System.Drawing.Size(100, 20);
            this.txtInventoryAddVideoMovieTitle.TabIndex = 1;
            this.toolTip.SetToolTip(this.txtInventoryAddVideoMovieTitle, "Enter a partial title for the movie");
            this.txtInventoryAddVideoMovieTitle.TextChanged += new System.EventHandler(this.txtAddVideoMovieTitle_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(7, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(59, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Movie Title";
            // 
            // customerPage
            // 
            this.customerPage.Controls.Add(this.CreateNewCustomerLinkLabel);
            this.customerPage.Controls.Add(this.grpNewCustomer);
            this.customerPage.Controls.Add(this.grpFindCustomer);
            this.customerPage.Location = new System.Drawing.Point(4, 22);
            this.customerPage.Name = "customerPage";
            this.customerPage.Padding = new System.Windows.Forms.Padding(3);
            this.customerPage.Size = new System.Drawing.Size(486, 441);
            this.customerPage.TabIndex = 1;
            this.customerPage.Text = "Customers";
            this.customerPage.UseVisualStyleBackColor = true;
            // 
            // CreateNewCustomerLinkLabel
            // 
            this.CreateNewCustomerLinkLabel.AutoSize = true;
            this.CreateNewCustomerLinkLabel.Location = new System.Drawing.Point(18, 170);
            this.CreateNewCustomerLinkLabel.Name = "CreateNewCustomerLinkLabel";
            this.CreateNewCustomerLinkLabel.Size = new System.Drawing.Size(116, 13);
            this.CreateNewCustomerLinkLabel.TabIndex = 2;
            this.CreateNewCustomerLinkLabel.TabStop = true;
            this.CreateNewCustomerLinkLabel.Text = "Create a new customer";
            this.CreateNewCustomerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewCustomer);
            // 
            // grpNewCustomer
            // 
            this.grpNewCustomer.Controls.Add(this.lnklblCustomersShowAllRentalHistory);
            this.grpNewCustomer.Controls.Add(this.lnklblCustomersShowCurrentRentals);
            this.grpNewCustomer.Controls.Add(this.label1);
            this.grpNewCustomer.Controls.Add(this.txtBoxNewCustomerConfirmedPassword);
            this.grpNewCustomer.Controls.Add(this.txtBoxNewCustomersPassword);
            this.grpNewCustomer.Controls.Add(this.lblCustomerNewCustomerPassword);
            this.grpNewCustomer.Controls.Add(this.btnCustomerNewCustomerCancel);
            this.grpNewCustomer.Controls.Add(this.cbxNewCustomerTitle);
            this.grpNewCustomer.Controls.Add(this.CreateNewCustomerTitleLabel);
            this.grpNewCustomer.Controls.Add(this.btnCustomersNewCustomerSave);
            this.grpNewCustomer.Controls.Add(this.txtCustomersNewPhone);
            this.grpNewCustomer.Controls.Add(this.lblPrimaryPhoneNew);
            this.grpNewCustomer.Controls.Add(this.txtCustomersNewZip);
            this.grpNewCustomer.Controls.Add(this.lblZipNew);
            this.grpNewCustomer.Controls.Add(this.cbxCustomersNewState);
            this.grpNewCustomer.Controls.Add(this.lblStateNew);
            this.grpNewCustomer.Controls.Add(this.txtCustomersNewCity);
            this.grpNewCustomer.Controls.Add(this.lblCityNew);
            this.grpNewCustomer.Controls.Add(this.txtCustomersNewStreetAddress);
            this.grpNewCustomer.Controls.Add(this.lblStreetAddressNew);
            this.grpNewCustomer.Controls.Add(this.txtCustomersNewLastName);
            this.grpNewCustomer.Controls.Add(this.lblLastNameNew);
            this.grpNewCustomer.Controls.Add(this.txtCustomersNewFirstName);
            this.grpNewCustomer.Controls.Add(this.lblFirstNameNew);
            this.grpNewCustomer.Location = new System.Drawing.Point(9, 174);
            this.grpNewCustomer.Name = "grpNewCustomer";
            this.grpNewCustomer.Size = new System.Drawing.Size(469, 249);
            this.grpNewCustomer.TabIndex = 1;
            this.grpNewCustomer.TabStop = false;
            this.grpNewCustomer.Text = "Inserting New Customer";
            this.grpNewCustomer.Visible = false;
            this.grpNewCustomer.Enter += new System.EventHandler(this.grpNewCustomer_Enter);
            // 
            // lnklblCustomersShowAllRentalHistory
            // 
            this.lnklblCustomersShowAllRentalHistory.AutoSize = true;
            this.lnklblCustomersShowAllRentalHistory.Location = new System.Drawing.Point(121, 201);
            this.lnklblCustomersShowAllRentalHistory.Name = "lnklblCustomersShowAllRentalHistory";
            this.lnklblCustomersShowAllRentalHistory.Size = new System.Drawing.Size(109, 13);
            this.lnklblCustomersShowAllRentalHistory.TabIndex = 31;
            this.lnklblCustomersShowAllRentalHistory.TabStop = true;
            this.lnklblCustomersShowAllRentalHistory.Text = "Show all rental history";
            this.lnklblCustomersShowAllRentalHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblCustomersShowAllRentalHistory_LinkClicked);
            // 
            // lnklblCustomersShowCurrentRentals
            // 
            this.lnklblCustomersShowCurrentRentals.AutoSize = true;
            this.lnklblCustomersShowCurrentRentals.Location = new System.Drawing.Point(9, 201);
            this.lnklblCustomersShowCurrentRentals.Name = "lnklblCustomersShowCurrentRentals";
            this.lnklblCustomersShowCurrentRentals.Size = new System.Drawing.Size(104, 13);
            this.lnklblCustomersShowCurrentRentals.TabIndex = 30;
            this.lnklblCustomersShowCurrentRentals.TabStop = true;
            this.lnklblCustomersShowCurrentRentals.Text = "Show current rentals";
            this.lnklblCustomersShowCurrentRentals.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblCustomersShowCurrentRentals_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Confirm Password";
            // 
            // txtBoxNewCustomerConfirmedPassword
            // 
            this.txtBoxNewCustomerConfirmedPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Password", true));
            this.txtBoxNewCustomerConfirmedPassword.Location = new System.Drawing.Point(333, 170);
            this.txtBoxNewCustomerConfirmedPassword.Name = "txtBoxNewCustomerConfirmedPassword";
            this.txtBoxNewCustomerConfirmedPassword.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNewCustomerConfirmedPassword.TabIndex = 28;
            this.txtBoxNewCustomerConfirmedPassword.TextChanged += new System.EventHandler(this.newCustomerTextField_TextChanged);
            this.txtBoxNewCustomerConfirmedPassword.Enter += new System.EventHandler(this.txtField_Enter);
            this.txtBoxNewCustomerConfirmedPassword.Leave += new System.EventHandler(this.txtField_Leave);
            // 
            // txtBoxNewCustomersPassword
            // 
            this.txtBoxNewCustomersPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Password", true));
            this.txtBoxNewCustomersPassword.Location = new System.Drawing.Point(95, 170);
            this.txtBoxNewCustomersPassword.Name = "txtBoxNewCustomersPassword";
            this.txtBoxNewCustomersPassword.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNewCustomersPassword.TabIndex = 27;
            this.txtBoxNewCustomersPassword.TextChanged += new System.EventHandler(this.newCustomerTextField_TextChanged);
            this.txtBoxNewCustomersPassword.Enter += new System.EventHandler(this.txtField_Enter);
            this.txtBoxNewCustomersPassword.Leave += new System.EventHandler(this.txtField_Leave);
            // 
            // lblCustomerNewCustomerPassword
            // 
            this.lblCustomerNewCustomerPassword.AutoSize = true;
            this.lblCustomerNewCustomerPassword.Location = new System.Drawing.Point(9, 173);
            this.lblCustomerNewCustomerPassword.Name = "lblCustomerNewCustomerPassword";
            this.lblCustomerNewCustomerPassword.Size = new System.Drawing.Size(53, 13);
            this.lblCustomerNewCustomerPassword.TabIndex = 26;
            this.lblCustomerNewCustomerPassword.Text = "Password";
            // 
            // btnCustomerNewCustomerCancel
            // 
            this.btnCustomerNewCustomerCancel.Location = new System.Drawing.Point(224, 220);
            this.btnCustomerNewCustomerCancel.Name = "btnCustomerNewCustomerCancel";
            this.btnCustomerNewCustomerCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerNewCustomerCancel.TabIndex = 25;
            this.btnCustomerNewCustomerCancel.Text = "Cancel";
            this.btnCustomerNewCustomerCancel.UseVisualStyleBackColor = true;
            this.btnCustomerNewCustomerCancel.Click += new System.EventHandler(this.btnCustomerNewCustomerCancel_Click);
            // 
            // cbxNewCustomerTitle
            // 
            this.cbxNewCustomerTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Title", true));
            this.cbxNewCustomerTitle.DisplayMember = "title";
            this.cbxNewCustomerTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNewCustomerTitle.FormattingEnabled = true;
            this.cbxNewCustomerTitle.Location = new System.Drawing.Point(97, 28);
            this.cbxNewCustomerTitle.Name = "cbxNewCustomerTitle";
            this.cbxNewCustomerTitle.Size = new System.Drawing.Size(42, 21);
            this.cbxNewCustomerTitle.TabIndex = 24;
            this.cbxNewCustomerTitle.ValueMember = "title";
            // 
            // CreateNewCustomerTitleLabel
            // 
            this.CreateNewCustomerTitleLabel.AutoSize = true;
            this.CreateNewCustomerTitleLabel.Location = new System.Drawing.Point(9, 36);
            this.CreateNewCustomerTitleLabel.Name = "CreateNewCustomerTitleLabel";
            this.CreateNewCustomerTitleLabel.Size = new System.Drawing.Size(27, 13);
            this.CreateNewCustomerTitleLabel.TabIndex = 23;
            this.CreateNewCustomerTitleLabel.Text = "Title";
            // 
            // btnCustomersNewCustomerSave
            // 
            this.btnCustomersNewCustomerSave.Enabled = false;
            this.btnCustomersNewCustomerSave.Location = new System.Drawing.Point(141, 220);
            this.btnCustomersNewCustomerSave.Name = "btnCustomersNewCustomerSave";
            this.btnCustomersNewCustomerSave.Size = new System.Drawing.Size(75, 23);
            this.btnCustomersNewCustomerSave.TabIndex = 22;
            this.btnCustomersNewCustomerSave.Text = "Save";
            this.btnCustomersNewCustomerSave.UseVisualStyleBackColor = true;
            this.btnCustomersNewCustomerSave.Click += new System.EventHandler(this.btnCustomersNewCustomerSave_Click);
            // 
            // txtCustomersNewPhone
            // 
            this.txtCustomersNewPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "PhoneNumber", true));
            this.txtCustomersNewPhone.Location = new System.Drawing.Point(95, 141);
            this.txtCustomersNewPhone.Name = "txtCustomersNewPhone";
            this.txtCustomersNewPhone.Size = new System.Drawing.Size(81, 20);
            this.txtCustomersNewPhone.TabIndex = 21;
            this.toolTip.SetToolTip(this.txtCustomersNewPhone, "Enter the customer\'s phone number in the format ###-###-####");
            this.txtCustomersNewPhone.TextChanged += new System.EventHandler(this.newCustomerTextField_TextChanged);
            this.txtCustomersNewPhone.Enter += new System.EventHandler(this.txtField_Enter);
            this.txtCustomersNewPhone.Leave += new System.EventHandler(this.txtField_Leave);
            // 
            // lblPrimaryPhoneNew
            // 
            this.lblPrimaryPhoneNew.AutoSize = true;
            this.lblPrimaryPhoneNew.Location = new System.Drawing.Point(9, 144);
            this.lblPrimaryPhoneNew.Name = "lblPrimaryPhoneNew";
            this.lblPrimaryPhoneNew.Size = new System.Drawing.Size(74, 13);
            this.lblPrimaryPhoneNew.TabIndex = 20;
            this.lblPrimaryPhoneNew.Text = "Primary phone";
            // 
            // txtCustomersNewZip
            // 
            this.txtCustomersNewZip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "ZipCode.Code", true));
            this.txtCustomersNewZip.Location = new System.Drawing.Point(95, 116);
            this.txtCustomersNewZip.Name = "txtCustomersNewZip";
            this.txtCustomersNewZip.Size = new System.Drawing.Size(71, 20);
            this.txtCustomersNewZip.TabIndex = 19;
            this.toolTip.SetToolTip(this.txtCustomersNewZip, "Enter the zip code in either 5 digit or 5+4 digit format");
            this.txtCustomersNewZip.Enter += new System.EventHandler(this.txtField_Enter);
            this.txtCustomersNewZip.Leave += new System.EventHandler(this.txtBoxCustomerZipCode_Leave);
            // 
            // lblZipNew
            // 
            this.lblZipNew.AutoSize = true;
            this.lblZipNew.Location = new System.Drawing.Point(9, 119);
            this.lblZipNew.Name = "lblZipNew";
            this.lblZipNew.Size = new System.Drawing.Size(22, 13);
            this.lblZipNew.TabIndex = 18;
            this.lblZipNew.Text = "Zip";
            // 
            // cbxCustomersNewState
            // 
            this.cbxCustomersNewState.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "ZipCode.State", true));
            this.cbxCustomersNewState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCustomersNewState.Enabled = false;
            this.cbxCustomersNewState.FormattingEnabled = true;
            this.cbxCustomersNewState.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AR",
            "AZ",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "IA",
            "ID",
            "IL",
            "IN",
            "KS",
            "KY",
            "LA",
            "MA",
            "MD",
            "ME",
            "MI",
            "MO",
            "MN",
            "MS",
            "MT",
            "NC",
            "ND",
            "NE",
            "NH",
            "NJ",
            "NM",
            "NV",
            "NY",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VA",
            "VT",
            "WA",
            "WI",
            "WV",
            "WY"});
            this.cbxCustomersNewState.Location = new System.Drawing.Point(395, 116);
            this.cbxCustomersNewState.Name = "cbxCustomersNewState";
            this.cbxCustomersNewState.Size = new System.Drawing.Size(38, 21);
            this.cbxCustomersNewState.TabIndex = 17;
            // 
            // lblStateNew
            // 
            this.lblStateNew.AutoSize = true;
            this.lblStateNew.Location = new System.Drawing.Point(357, 120);
            this.lblStateNew.Name = "lblStateNew";
            this.lblStateNew.Size = new System.Drawing.Size(32, 13);
            this.lblStateNew.TabIndex = 16;
            this.lblStateNew.Text = "State";
            // 
            // txtCustomersNewCity
            // 
            this.txtCustomersNewCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "ZipCode.City", true));
            this.txtCustomersNewCity.Location = new System.Drawing.Point(206, 116);
            this.txtCustomersNewCity.Name = "txtCustomersNewCity";
            this.txtCustomersNewCity.ReadOnly = true;
            this.txtCustomersNewCity.Size = new System.Drawing.Size(132, 20);
            this.txtCustomersNewCity.TabIndex = 15;
            this.toolTip.SetToolTip(this.txtCustomersNewCity, "Enter the customer city");
            this.txtCustomersNewCity.TextChanged += new System.EventHandler(this.newCustomerTextField_TextChanged);
            this.txtCustomersNewCity.Enter += new System.EventHandler(this.txtField_Enter);
            this.txtCustomersNewCity.Leave += new System.EventHandler(this.txtField_Leave);
            // 
            // lblCityNew
            // 
            this.lblCityNew.AutoSize = true;
            this.lblCityNew.Location = new System.Drawing.Point(176, 120);
            this.lblCityNew.Name = "lblCityNew";
            this.lblCityNew.Size = new System.Drawing.Size(24, 13);
            this.lblCityNew.TabIndex = 14;
            this.lblCityNew.Text = "City";
            // 
            // txtCustomersNewStreetAddress
            // 
            this.txtCustomersNewStreetAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "StreetAddress", true));
            this.txtCustomersNewStreetAddress.Location = new System.Drawing.Point(95, 90);
            this.txtCustomersNewStreetAddress.Name = "txtCustomersNewStreetAddress";
            this.txtCustomersNewStreetAddress.Size = new System.Drawing.Size(309, 20);
            this.txtCustomersNewStreetAddress.TabIndex = 13;
            this.toolTip.SetToolTip(this.txtCustomersNewStreetAddress, "Enter the customer\'s street address");
            this.txtCustomersNewStreetAddress.TextChanged += new System.EventHandler(this.newCustomerTextField_TextChanged);
            this.txtCustomersNewStreetAddress.Enter += new System.EventHandler(this.txtField_Enter);
            this.txtCustomersNewStreetAddress.Leave += new System.EventHandler(this.txtField_Leave);
            // 
            // lblStreetAddressNew
            // 
            this.lblStreetAddressNew.AutoSize = true;
            this.lblStreetAddressNew.Location = new System.Drawing.Point(9, 90);
            this.lblStreetAddressNew.Name = "lblStreetAddressNew";
            this.lblStreetAddressNew.Size = new System.Drawing.Size(76, 13);
            this.lblStreetAddressNew.TabIndex = 12;
            this.lblStreetAddressNew.Text = "Street Address";
            // 
            // txtCustomersNewLastName
            // 
            this.txtCustomersNewLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "LastName", true));
            this.txtCustomersNewLastName.Location = new System.Drawing.Point(285, 55);
            this.txtCustomersNewLastName.Name = "txtCustomersNewLastName";
            this.txtCustomersNewLastName.Size = new System.Drawing.Size(121, 20);
            this.txtCustomersNewLastName.TabIndex = 11;
            this.toolTip.SetToolTip(this.txtCustomersNewLastName, "Enter the customer\'s last name");
            this.txtCustomersNewLastName.TextChanged += new System.EventHandler(this.newCustomerTextField_TextChanged);
            this.txtCustomersNewLastName.Enter += new System.EventHandler(this.txtField_Enter);
            this.txtCustomersNewLastName.Leave += new System.EventHandler(this.txtField_Leave);
            // 
            // lblLastNameNew
            // 
            this.lblLastNameNew.AutoSize = true;
            this.lblLastNameNew.Location = new System.Drawing.Point(221, 58);
            this.lblLastNameNew.Name = "lblLastNameNew";
            this.lblLastNameNew.Size = new System.Drawing.Size(58, 13);
            this.lblLastNameNew.TabIndex = 10;
            this.lblLastNameNew.Text = "Last Name";
            // 
            // txtCustomersNewFirstName
            // 
            this.txtCustomersNewFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "FirstName", true));
            this.txtCustomersNewFirstName.Location = new System.Drawing.Point(95, 55);
            this.txtCustomersNewFirstName.Name = "txtCustomersNewFirstName";
            this.txtCustomersNewFirstName.Size = new System.Drawing.Size(121, 20);
            this.txtCustomersNewFirstName.TabIndex = 9;
            this.toolTip.SetToolTip(this.txtCustomersNewFirstName, "Enter the customer\'s first name");
            this.txtCustomersNewFirstName.TextChanged += new System.EventHandler(this.newCustomerTextField_TextChanged);
            this.txtCustomersNewFirstName.Enter += new System.EventHandler(this.txtField_Enter);
            this.txtCustomersNewFirstName.Leave += new System.EventHandler(this.txtField_Leave);
            // 
            // lblFirstNameNew
            // 
            this.lblFirstNameNew.AutoSize = true;
            this.lblFirstNameNew.Location = new System.Drawing.Point(9, 58);
            this.lblFirstNameNew.Name = "lblFirstNameNew";
            this.lblFirstNameNew.Size = new System.Drawing.Size(57, 13);
            this.lblFirstNameNew.TabIndex = 8;
            this.lblFirstNameNew.Text = "First Name";
            // 
            // grpFindCustomer
            // 
            this.grpFindCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFindCustomer.Controls.Add(this.scanBarCodeLinkLabel);
            this.grpFindCustomer.Controls.Add(this.FindCustomerInstruction2);
            this.grpFindCustomer.Controls.Add(this.FindCustomerInstruction1);
            this.grpFindCustomer.Controls.Add(this.btnSearchCustomer);
            this.grpFindCustomer.Controls.Add(this.txtSearchFirstName);
            this.grpFindCustomer.Controls.Add(this.lblSearchFirstName);
            this.grpFindCustomer.Controls.Add(this.txtSearchLastName);
            this.grpFindCustomer.Controls.Add(this.lblSearchLastName);
            this.grpFindCustomer.Location = new System.Drawing.Point(9, 7);
            this.grpFindCustomer.Name = "grpFindCustomer";
            this.grpFindCustomer.Size = new System.Drawing.Size(469, 160);
            this.grpFindCustomer.TabIndex = 0;
            this.grpFindCustomer.TabStop = false;
            this.grpFindCustomer.Text = "Find a Customer";
            // 
            // scanBarCodeLinkLabel
            // 
            this.scanBarCodeLinkLabel.AutoSize = true;
            this.scanBarCodeLinkLabel.Location = new System.Drawing.Point(9, 113);
            this.scanBarCodeLinkLabel.Name = "scanBarCodeLinkLabel";
            this.scanBarCodeLinkLabel.Size = new System.Drawing.Size(77, 13);
            this.scanBarCodeLinkLabel.TabIndex = 10;
            this.scanBarCodeLinkLabel.TabStop = true;
            this.scanBarCodeLinkLabel.Text = "Scan bar code";
            this.scanBarCodeLinkLabel.Click += new System.EventHandler(this.scanBarCodeLinkLabel_Click);
            // 
            // FindCustomerInstruction2
            // 
            this.FindCustomerInstruction2.AutoSize = true;
            this.FindCustomerInstruction2.Location = new System.Drawing.Point(6, 45);
            this.FindCustomerInstruction2.Name = "FindCustomerInstruction2";
            this.FindCustomerInstruction2.Size = new System.Drawing.Size(286, 13);
            this.FindCustomerInstruction2.TabIndex = 8;
            this.FindCustomerInstruction2.Text = "Or, click the link to scan a customer\'s member card directly.";
            // 
            // FindCustomerInstruction1
            // 
            this.FindCustomerInstruction1.AutoSize = true;
            this.FindCustomerInstruction1.Location = new System.Drawing.Point(6, 16);
            this.FindCustomerInstruction1.Name = "FindCustomerInstruction1";
            this.FindCustomerInstruction1.Size = new System.Drawing.Size(427, 13);
            this.FindCustomerInstruction1.TabIndex = 7;
            this.FindCustomerInstruction1.Text = "Find a customer by entering all or part of the customers name and clicking the fi" +
    "nd button.";
            // 
            // txtSearchFirstName
            // 
            this.txtSearchFirstName.Location = new System.Drawing.Point(280, 77);
            this.txtSearchFirstName.Name = "txtSearchFirstName";
            this.txtSearchFirstName.Size = new System.Drawing.Size(121, 20);
            this.txtSearchFirstName.TabIndex = 5;
            this.toolTip.SetToolTip(this.txtSearchFirstName, "Enter part or all of the desired customer\'s first name");
            this.txtSearchFirstName.TextChanged += new System.EventHandler(this.txtSearchFirstName_TextChanged);
            // 
            // lblSearchFirstName
            // 
            this.lblSearchFirstName.AutoSize = true;
            this.lblSearchFirstName.Location = new System.Drawing.Point(209, 77);
            this.lblSearchFirstName.Name = "lblSearchFirstName";
            this.lblSearchFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblSearchFirstName.TabIndex = 4;
            this.lblSearchFirstName.Text = "First Name";
            // 
            // txtSearchLastName
            // 
            this.txtSearchLastName.Location = new System.Drawing.Point(77, 77);
            this.txtSearchLastName.Name = "txtSearchLastName";
            this.txtSearchLastName.Size = new System.Drawing.Size(121, 20);
            this.txtSearchLastName.TabIndex = 3;
            this.toolTip.SetToolTip(this.txtSearchLastName, "Enter part or all of the desired customer\'s last name");
            this.txtSearchLastName.TextChanged += new System.EventHandler(this.txtSearchLastName_TextChanged);
            // 
            // lblSearchLastName
            // 
            this.lblSearchLastName.AutoSize = true;
            this.lblSearchLastName.Location = new System.Drawing.Point(6, 77);
            this.lblSearchLastName.Name = "lblSearchLastName";
            this.lblSearchLastName.Size = new System.Drawing.Size(58, 13);
            this.lblSearchLastName.TabIndex = 2;
            this.lblSearchLastName.Text = "Last Name";
            // 
            // reportsPage
            // 
            this.reportsPage.Controls.Add(this.grpCustomerReports);
            this.reportsPage.Controls.Add(this.grpInventoryReports);
            this.reportsPage.Location = new System.Drawing.Point(4, 22);
            this.reportsPage.Name = "reportsPage";
            this.reportsPage.Size = new System.Drawing.Size(486, 441);
            this.reportsPage.TabIndex = 3;
            this.reportsPage.Text = "Reports";
            this.reportsPage.UseVisualStyleBackColor = true;
            // 
            // grpCustomerReports
            // 
            this.grpCustomerReports.Controls.Add(this.btnReportsShowCustomersInArea);
            this.grpCustomerReports.Controls.Add(this.txtReportsZipCode);
            this.grpCustomerReports.Controls.Add(this.lblCustomersNearZipCode);
            this.grpCustomerReports.Controls.Add(this.btnReportsOpenStaleCustomers);
            this.grpCustomerReports.Controls.Add(this.cbxReportsCustomerUnits);
            this.grpCustomerReports.Controls.Add(this.nupReportsNumberOfUnitsCustomers);
            this.grpCustomerReports.Controls.Add(this.lblStaleCustomers);
            this.grpCustomerReports.Location = new System.Drawing.Point(9, 135);
            this.grpCustomerReports.Name = "grpCustomerReports";
            this.grpCustomerReports.Size = new System.Drawing.Size(469, 100);
            this.grpCustomerReports.TabIndex = 1;
            this.grpCustomerReports.TabStop = false;
            this.grpCustomerReports.Text = "Customers";
            // 
            // btnReportsShowCustomersInArea
            // 
            this.btnReportsShowCustomersInArea.AutoSize = true;
            this.btnReportsShowCustomersInArea.Enabled = false;
            this.btnReportsShowCustomersInArea.Location = new System.Drawing.Point(350, 51);
            this.btnReportsShowCustomersInArea.Name = "btnReportsShowCustomersInArea";
            this.btnReportsShowCustomersInArea.Size = new System.Drawing.Size(53, 23);
            this.btnReportsShowCustomersInArea.TabIndex = 12;
            this.btnReportsShowCustomersInArea.Text = "Open";
            this.toolTip.SetToolTip(this.btnReportsShowCustomersInArea, "Click to show a listing of customers living near the selected zip code");
            this.btnReportsShowCustomersInArea.UseVisualStyleBackColor = true;
            this.btnReportsShowCustomersInArea.Click += new System.EventHandler(this.btnReportShowCustomersInArea_Click);
            // 
            // txtReportsZipCode
            // 
            this.txtReportsZipCode.Location = new System.Drawing.Point(267, 56);
            this.txtReportsZipCode.Name = "txtReportsZipCode";
            this.txtReportsZipCode.Size = new System.Drawing.Size(77, 20);
            this.txtReportsZipCode.TabIndex = 11;
            this.toolTip.SetToolTip(this.txtReportsZipCode, "Enter either a 5 digit zip code or 5+4 zip code");
            this.txtReportsZipCode.TextChanged += new System.EventHandler(this.txtReportZipCode_TextChanged);
            this.txtReportsZipCode.Enter += new System.EventHandler(this.txtReportZipCode_Enter);
            this.txtReportsZipCode.Leave += new System.EventHandler(this.txtReportZipCode_Leave);
            // 
            // lblCustomersNearZipCode
            // 
            this.lblCustomersNearZipCode.AutoSize = true;
            this.lblCustomersNearZipCode.Location = new System.Drawing.Point(6, 56);
            this.lblCustomersNearZipCode.Name = "lblCustomersNearZipCode";
            this.lblCustomersNearZipCode.Size = new System.Drawing.Size(254, 13);
            this.lblCustomersNearZipCode.TabIndex = 10;
            this.lblCustomersNearZipCode.Text = "Customers who live in the area of store with zip code";
            // 
            // btnReportsOpenStaleCustomers
            // 
            this.btnReportsOpenStaleCustomers.AutoSize = true;
            this.btnReportsOpenStaleCustomers.Location = new System.Drawing.Point(364, 18);
            this.btnReportsOpenStaleCustomers.Name = "btnReportsOpenStaleCustomers";
            this.btnReportsOpenStaleCustomers.Size = new System.Drawing.Size(53, 23);
            this.btnReportsOpenStaleCustomers.TabIndex = 9;
            this.btnReportsOpenStaleCustomers.Text = "Open";
            this.btnReportsOpenStaleCustomers.UseVisualStyleBackColor = true;
            // 
            // cbxReportsCustomerUnits
            // 
            this.cbxReportsCustomerUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxReportsCustomerUnits.FormattingEnabled = true;
            this.cbxReportsCustomerUnits.Items.AddRange(new object[] {
            "days",
            "weeks",
            "months"});
            this.cbxReportsCustomerUnits.Location = new System.Drawing.Point(296, 20);
            this.cbxReportsCustomerUnits.Name = "cbxReportsCustomerUnits";
            this.cbxReportsCustomerUnits.Size = new System.Drawing.Size(62, 21);
            this.cbxReportsCustomerUnits.TabIndex = 8;
            // 
            // nupReportsNumberOfUnitsCustomers
            // 
            this.nupReportsNumberOfUnitsCustomers.Location = new System.Drawing.Point(254, 21);
            this.nupReportsNumberOfUnitsCustomers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupReportsNumberOfUnitsCustomers.Name = "nupReportsNumberOfUnitsCustomers";
            this.nupReportsNumberOfUnitsCustomers.ReadOnly = true;
            this.nupReportsNumberOfUnitsCustomers.Size = new System.Drawing.Size(36, 20);
            this.nupReportsNumberOfUnitsCustomers.TabIndex = 6;
            this.nupReportsNumberOfUnitsCustomers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblStaleCustomers
            // 
            this.lblStaleCustomers.AutoSize = true;
            this.lblStaleCustomers.Location = new System.Drawing.Point(7, 24);
            this.lblStaleCustomers.Name = "lblStaleCustomers";
            this.lblStaleCustomers.Size = new System.Drawing.Size(243, 13);
            this.lblStaleCustomers.TabIndex = 7;
            this.lblStaleCustomers.Text = "Customers who have not rented a video in the last";
            // 
            // grpInventoryReports
            // 
            this.grpInventoryReports.Controls.Add(this.btnReportsOpenMostPopularMovies);
            this.grpInventoryReports.Controls.Add(this.lblPopularMovies);
            this.grpInventoryReports.Controls.Add(this.nudReportsNumberOfFrequentMovies);
            this.grpInventoryReports.Controls.Add(this.btnReportsOpenStaleMovies);
            this.grpInventoryReports.Controls.Add(this.cbxVideoUnits);
            this.grpInventoryReports.Controls.Add(this.lblUnrentedMovies);
            this.grpInventoryReports.Controls.Add(this.updReportsNumberOfUnitsMovies);
            this.grpInventoryReports.Controls.Add(this.btnReportsShowInventory);
            this.grpInventoryReports.Controls.Add(this.lblShowInventory);
            this.grpInventoryReports.Location = new System.Drawing.Point(9, 4);
            this.grpInventoryReports.Name = "grpInventoryReports";
            this.grpInventoryReports.Size = new System.Drawing.Size(469, 124);
            this.grpInventoryReports.TabIndex = 0;
            this.grpInventoryReports.TabStop = false;
            this.grpInventoryReports.Text = "Inventory";
            // 
            // btnReportsOpenMostPopularMovies
            // 
            this.btnReportsOpenMostPopularMovies.AutoSize = true;
            this.btnReportsOpenMostPopularMovies.Location = new System.Drawing.Point(205, 80);
            this.btnReportsOpenMostPopularMovies.Name = "btnReportsOpenMostPopularMovies";
            this.btnReportsOpenMostPopularMovies.Size = new System.Drawing.Size(53, 23);
            this.btnReportsOpenMostPopularMovies.TabIndex = 8;
            this.btnReportsOpenMostPopularMovies.Text = "Open";
            this.btnReportsOpenMostPopularMovies.UseVisualStyleBackColor = true;
            // 
            // lblPopularMovies
            // 
            this.lblPopularMovies.AutoSize = true;
            this.lblPopularMovies.Location = new System.Drawing.Point(52, 85);
            this.lblPopularMovies.Name = "lblPopularMovies";
            this.lblPopularMovies.Size = new System.Drawing.Size(147, 13);
            this.lblPopularMovies.TabIndex = 7;
            this.lblPopularMovies.Text = "most frequently rented movies";
            // 
            // nudReportsNumberOfFrequentMovies
            // 
            this.nudReportsNumberOfFrequentMovies.Location = new System.Drawing.Point(10, 83);
            this.nudReportsNumberOfFrequentMovies.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudReportsNumberOfFrequentMovies.Name = "nudReportsNumberOfFrequentMovies";
            this.nudReportsNumberOfFrequentMovies.ReadOnly = true;
            this.nudReportsNumberOfFrequentMovies.Size = new System.Drawing.Size(36, 20);
            this.nudReportsNumberOfFrequentMovies.TabIndex = 6;
            this.nudReportsNumberOfFrequentMovies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnReportsOpenStaleMovies
            // 
            this.btnReportsOpenStaleMovies.AutoSize = true;
            this.btnReportsOpenStaleMovies.Location = new System.Drawing.Point(337, 50);
            this.btnReportsOpenStaleMovies.Name = "btnReportsOpenStaleMovies";
            this.btnReportsOpenStaleMovies.Size = new System.Drawing.Size(53, 23);
            this.btnReportsOpenStaleMovies.TabIndex = 5;
            this.btnReportsOpenStaleMovies.Text = "Open";
            this.btnReportsOpenStaleMovies.UseVisualStyleBackColor = true;
            // 
            // cbxVideoUnits
            // 
            this.cbxVideoUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVideoUnits.FormattingEnabled = true;
            this.cbxVideoUnits.Items.AddRange(new object[] {
            "days",
            "weeks",
            "months"});
            this.cbxVideoUnits.Location = new System.Drawing.Point(269, 51);
            this.cbxVideoUnits.Name = "cbxVideoUnits";
            this.cbxVideoUnits.Size = new System.Drawing.Size(62, 21);
            this.cbxVideoUnits.TabIndex = 4;
            // 
            // lblUnrentedMovies
            // 
            this.lblUnrentedMovies.AutoSize = true;
            this.lblUnrentedMovies.Location = new System.Drawing.Point(7, 54);
            this.lblUnrentedMovies.Name = "lblUnrentedMovies";
            this.lblUnrentedMovies.Size = new System.Drawing.Size(218, 13);
            this.lblUnrentedMovies.TabIndex = 3;
            this.lblUnrentedMovies.Text = "Movies that have not been rented in the last ";
            // 
            // updReportsNumberOfUnitsMovies
            // 
            this.updReportsNumberOfUnitsMovies.Location = new System.Drawing.Point(227, 52);
            this.updReportsNumberOfUnitsMovies.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updReportsNumberOfUnitsMovies.Name = "updReportsNumberOfUnitsMovies";
            this.updReportsNumberOfUnitsMovies.ReadOnly = true;
            this.updReportsNumberOfUnitsMovies.Size = new System.Drawing.Size(36, 20);
            this.updReportsNumberOfUnitsMovies.TabIndex = 2;
            this.updReportsNumberOfUnitsMovies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnReportsShowInventory
            // 
            this.btnReportsShowInventory.AutoSize = true;
            this.btnReportsShowInventory.Location = new System.Drawing.Point(91, 15);
            this.btnReportsShowInventory.Name = "btnReportsShowInventory";
            this.btnReportsShowInventory.Size = new System.Drawing.Size(53, 23);
            this.btnReportsShowInventory.TabIndex = 1;
            this.btnReportsShowInventory.Text = "Open";
            this.btnReportsShowInventory.UseVisualStyleBackColor = true;
            // 
            // lblShowInventory
            // 
            this.lblShowInventory.AutoSize = true;
            this.lblShowInventory.Location = new System.Drawing.Point(7, 20);
            this.lblShowInventory.Name = "lblShowInventory";
            this.lblShowInventory.Size = new System.Drawing.Size(78, 13);
            this.lblShowInventory.TabIndex = 0;
            this.lblShowInventory.Text = "Store inventory";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.infoLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 467);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(494, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 17);
            this.lblStatus.Text = "Ready";
            // 
            // infoLabel
            // 
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // lblOldStatus
            // 
            this.lblOldStatus.Name = "lblOldStatus";
            this.lblOldStatus.Size = new System.Drawing.Size(39, 17);
            this.lblOldStatus.Text = "Huh?";
            // 
            // btnOperatinsCheckAvailability
            // 
            this.btnOperatinsCheckAvailability.Enabled = false;
            this.btnOperatinsCheckAvailability.Image = ((System.Drawing.Image)(resources.GetObject("btnOperatinsCheckAvailability.Image")));
            this.btnOperatinsCheckAvailability.Location = new System.Drawing.Point(226, 105);
            this.btnOperatinsCheckAvailability.Name = "btnOperatinsCheckAvailability";
            this.btnOperatinsCheckAvailability.Size = new System.Drawing.Size(32, 32);
            this.btnOperatinsCheckAvailability.TabIndex = 13;
            this.toolTip.SetToolTip(this.btnOperatinsCheckAvailability, "Click to look up availability");
            this.btnOperatinsCheckAvailability.UseVisualStyleBackColor = true;
            // 
            // btnOperationsSearchVideoIn
            // 
            this.btnOperationsSearchVideoIn.Image = ((System.Drawing.Image)(resources.GetObject("btnOperationsSearchVideoIn.Image")));
            this.btnOperationsSearchVideoIn.Location = new System.Drawing.Point(225, 16);
            this.btnOperationsSearchVideoIn.Name = "btnOperationsSearchVideoIn";
            this.btnOperationsSearchVideoIn.Size = new System.Drawing.Size(32, 32);
            this.btnOperationsSearchVideoIn.TabIndex = 10;
            this.toolTip.SetToolTip(this.btnOperationsSearchVideoIn, "Click to look up a video whose bar code is missing");
            this.btnOperationsSearchVideoIn.UseVisualStyleBackColor = true;
            // 
            // btnOperationsSearchVideoID
            // 
            this.btnOperationsSearchVideoID.Image = ((System.Drawing.Image)(resources.GetObject("btnOperationsSearchVideoID.Image")));
            this.btnOperationsSearchVideoID.Location = new System.Drawing.Point(225, 51);
            this.btnOperationsSearchVideoID.Name = "btnOperationsSearchVideoID";
            this.btnOperationsSearchVideoID.Size = new System.Drawing.Size(32, 32);
            this.btnOperationsSearchVideoID.TabIndex = 10;
            this.toolTip.SetToolTip(this.btnOperationsSearchVideoID, "Click to look up a video whose bar code is missing");
            this.btnOperationsSearchVideoID.UseVisualStyleBackColor = true;
            // 
            // btnOperationsSearchCustomerID
            // 
            this.btnOperationsSearchCustomerID.Image = ((System.Drawing.Image)(resources.GetObject("btnOperationsSearchCustomerID.Image")));
            this.btnOperationsSearchCustomerID.Location = new System.Drawing.Point(225, 13);
            this.btnOperationsSearchCustomerID.Name = "btnOperationsSearchCustomerID";
            this.btnOperationsSearchCustomerID.Size = new System.Drawing.Size(32, 32);
            this.btnOperationsSearchCustomerID.TabIndex = 7;
            this.toolTip.SetToolTip(this.btnOperationsSearchCustomerID, "Click to look up a customer by name or phone number");
            this.btnOperationsSearchCustomerID.UseVisualStyleBackColor = true;
            // 
            // btnLookupVideo
            // 
            this.btnLookupVideo.Image = ((System.Drawing.Image)(resources.GetObject("btnLookupVideo.Image")));
            this.btnLookupVideo.Location = new System.Drawing.Point(270, 9);
            this.btnLookupVideo.Name = "btnLookupVideo";
            this.btnLookupVideo.Size = new System.Drawing.Size(32, 32);
            this.btnLookupVideo.TabIndex = 12;
            this.toolTip.SetToolTip(this.btnLookupVideo, "Click to look up a video whose bar code is missing");
            this.btnLookupVideo.UseVisualStyleBackColor = true;
            // 
            // btnInventoryAddVideoSearchTitle
            // 
            this.btnInventoryAddVideoSearchTitle.Enabled = false;
            this.btnInventoryAddVideoSearchTitle.Image = global::Employee.Properties.Resources.ni0103_24;
            this.btnInventoryAddVideoSearchTitle.Location = new System.Drawing.Point(179, 10);
            this.btnInventoryAddVideoSearchTitle.Name = "btnInventoryAddVideoSearchTitle";
            this.btnInventoryAddVideoSearchTitle.Size = new System.Drawing.Size(32, 32);
            this.btnInventoryAddVideoSearchTitle.TabIndex = 4;
            this.toolTip.SetToolTip(this.btnInventoryAddVideoSearchTitle, "Click to search for matching movies");
            this.btnInventoryAddVideoSearchTitle.UseVisualStyleBackColor = true;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Enabled = false;
            this.btnSearchCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCustomer.Image")));
            this.btnSearchCustomer.Location = new System.Drawing.Point(407, 70);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(32, 32);
            this.btnSearchCustomer.TabIndex = 6;
            this.toolTip.SetToolTip(this.btnSearchCustomer, "Click to search for matching movies");
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomerCustomers_Click);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(Model.Customer);
            // 
            // titleBindingSource
            // 
            this.titleBindingSource.DataSource = typeof(Model.Title);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 489);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainForm";
            this.Text = "CSCI 392 Video Store";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.operationsPage.ResumeLayout(false);
            this.grpCheckAvailability.ResumeLayout(false);
            this.grpCheckAvailability.PerformLayout();
            this.grpCheckIn.ResumeLayout(false);
            this.grpCheckIn.PerformLayout();
            this.grpCheckOut.ResumeLayout(false);
            this.grpCheckOut.PerformLayout();
            this.inventoryPage.ResumeLayout(false);
            this.grpRemoveMovie.ResumeLayout(false);
            this.grpRemoveMovie.PerformLayout();
            this.grpAddMovie.ResumeLayout(false);
            this.grpAddMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.customerPage.ResumeLayout(false);
            this.customerPage.PerformLayout();
            this.grpNewCustomer.ResumeLayout(false);
            this.grpNewCustomer.PerformLayout();
            this.grpFindCustomer.ResumeLayout(false);
            this.grpFindCustomer.PerformLayout();
            this.reportsPage.ResumeLayout(false);
            this.grpCustomerReports.ResumeLayout(false);
            this.grpCustomerReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupReportsNumberOfUnitsCustomers)).EndInit();
            this.grpInventoryReports.ResumeLayout(false);
            this.grpInventoryReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReportsNumberOfFrequentMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updReportsNumberOfUnitsMovies)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage inventoryPage;
        private System.Windows.Forms.TabPage customerPage;
        private System.Windows.Forms.TabPage operationsPage;
        private System.Windows.Forms.TabPage reportsPage;
        private System.Windows.Forms.GroupBox grpRemoveMovie;
        private System.Windows.Forms.GroupBox grpAddMovie;
        private System.Windows.Forms.TextBox txtInventoryAddVideoMovieTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnInventoryAddVideoSearchTitle;
        private System.Windows.Forms.ComboBox cbxInventoryAddVideoMovieID;
        private System.Windows.Forms.Label lblMatchingMovies;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnInventoryAddVideo;
        private System.Windows.Forms.CheckBox cbxNewArrival;
        private System.Windows.Forms.Label lblCopies;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblOldStatus;
        private System.Windows.Forms.ComboBox cbxInventoryRemoveVideoVideoID;
        private System.Windows.Forms.Label lblVideoID;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel infoLabel;
        private System.Windows.Forms.GroupBox grpFindCustomer;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.TextBox txtSearchFirstName;
        private System.Windows.Forms.Label lblSearchFirstName;
        private System.Windows.Forms.TextBox txtSearchLastName;
        private System.Windows.Forms.Label lblSearchLastName;
        private System.Windows.Forms.GroupBox grpNewCustomer;
        private System.Windows.Forms.GroupBox grpCheckOut;
        private System.Windows.Forms.Button btnOperationsSearchVideoID;
        private System.Windows.Forms.ComboBox cbxOperationsCheckoutVideoID;
        private System.Windows.Forms.Label lblVideoIDOut;
        private System.Windows.Forms.Button btnOperationsSearchCustomerID;
        private System.Windows.Forms.ComboBox cbxOperationsCustomerID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.GroupBox grpCheckIn;
        private System.Windows.Forms.Button btnOperationsCheckIn;
        private System.Windows.Forms.Button btnOperationsSearchVideoIn;
        private System.Windows.Forms.ComboBox cbxOperationsCheckInVideoID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpCheckout;
        private System.Windows.Forms.GroupBox grpCheckAvailability;
        private System.Windows.Forms.Label lblAvailableMovieTitle;
        private System.Windows.Forms.Label lblSelectedVideo;
        private System.Windows.Forms.RadioButton btnOperationsTitleExactMatch;
        private System.Windows.Forms.RadioButton btnOperationsTitleContainsText;
        private System.Windows.Forms.TextBox txtOperationsMovieTitle;
        private System.Windows.Forms.ListBox lstOperationsStoresToSearch;
        private System.Windows.Forms.Button btnOperatinsCheckAvailability;
        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.GroupBox grpInventoryReports;
        private System.Windows.Forms.Label lblShowInventory;
        private System.Windows.Forms.ComboBox cbxVideoUnits;
        private System.Windows.Forms.Label lblUnrentedMovies;
        private System.Windows.Forms.NumericUpDown updReportsNumberOfUnitsMovies;
        private System.Windows.Forms.Button btnReportsShowInventory;
        private System.Windows.Forms.Button btnReportsOpenStaleMovies;
        private System.Windows.Forms.Button btnReportsOpenStaleCustomers;
        private System.Windows.Forms.ComboBox cbxReportsCustomerUnits;
        private System.Windows.Forms.Label lblStaleCustomers;
        private System.Windows.Forms.NumericUpDown nupReportsNumberOfUnitsCustomers;
        private System.Windows.Forms.GroupBox grpCustomerReports;
        private System.Windows.Forms.Button btnReportsShowCustomersInArea;
        private System.Windows.Forms.TextBox txtReportsZipCode;
        private System.Windows.Forms.Label lblCustomersNearZipCode;
        private System.Windows.Forms.Label lblPopularMovies;
        private System.Windows.Forms.NumericUpDown nudReportsNumberOfFrequentMovies;
        private System.Windows.Forms.Button btnReportsOpenMostPopularMovies;
        private System.Windows.Forms.TextBox txtCustomersNewLastName;
        private System.Windows.Forms.Label lblLastNameNew;
        private System.Windows.Forms.TextBox txtCustomersNewFirstName;
        private System.Windows.Forms.Label lblFirstNameNew;
        private System.Windows.Forms.ComboBox cbxCustomersNewState;
        private System.Windows.Forms.Label lblStateNew;
        private System.Windows.Forms.TextBox txtCustomersNewCity;
        private System.Windows.Forms.Label lblCityNew;
        private System.Windows.Forms.TextBox txtCustomersNewStreetAddress;
        private System.Windows.Forms.Label lblStreetAddressNew;
        private System.Windows.Forms.TextBox txtCustomersNewZip;
        private System.Windows.Forms.Label lblZipNew;
        private System.Windows.Forms.Button btnCustomersNewCustomerSave;
        private System.Windows.Forms.TextBox txtCustomersNewPhone;
        private System.Windows.Forms.Label lblPrimaryPhoneNew;
        private System.Windows.Forms.Button btnRemoveVideo;
        private System.Windows.Forms.Button btnLookupVideo;
        private System.Windows.Forms.Label FindCustomerInstruction1;
        private System.Windows.Forms.Label FindCustomerInstruction2;
        private System.Windows.Forms.LinkLabel CreateNewCustomerLinkLabel;
        private System.Windows.Forms.LinkLabel scanBarCodeLinkLabel;
        private System.Windows.Forms.Label CreateNewCustomerTitleLabel;
        private System.Windows.Forms.ComboBox cbxNewCustomerTitle;
        private System.Windows.Forms.Button btnCustomerNewCustomerCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNewCustomerConfirmedPassword;
        private System.Windows.Forms.TextBox txtBoxNewCustomersPassword;
        private System.Windows.Forms.Label lblCustomerNewCustomerPassword;
        private System.Windows.Forms.BindingSource titleBindingSource;
        private System.Windows.Forms.LinkLabel lnklblCustomersShowAllRentalHistory;
        private System.Windows.Forms.LinkLabel lnklblCustomersShowCurrentRentals;
        private System.Windows.Forms.BindingSource customerBindingSource;
    }
}

