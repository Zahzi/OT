﻿namespace TrackerClient
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.tcPlayerLists = new System.Windows.Forms.TabControl();
            this.tpPlayersAll = new System.Windows.Forms.TabPage();
            this.lbPlayersAll = new System.Windows.Forms.ListBox();
            this.cmsWatchlist = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToWatchlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFromWatchlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpPlayersTargets = new System.Windows.Forms.TabPage();
            this.lbPlayersTargets = new System.Windows.Forms.ListBox();
            this.tpWatchlist = new System.Windows.Forms.TabPage();
            this.lbWatchlist = new System.Windows.Forms.ListBox();
            this.pSearch = new System.Windows.Forms.Panel();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.pMain = new System.Windows.Forms.Panel();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpPlayerInfo = new System.Windows.Forms.TabPage();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblUpdated = new System.Windows.Forms.Label();
            this.lblHelmet = new System.Windows.Forms.Label();
            this.lblVest = new System.Windows.Forms.Label();
            this.lblGun = new System.Windows.Forms.Label();
            this.lvVehicleInfo = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chActive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTurbo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSecurity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStorage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chInsurance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lvVirtualItems = new System.Windows.Forms.ListView();
            this.chItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbAliases = new System.Windows.Forms.TextBox();
            this.lblVirtuals = new System.Windows.Forms.Label();
            this.lblMedicRevives = new System.Windows.Forms.Label();
            this.lblVigiBounty = new System.Windows.Forms.Label();
            this.lblCopArrest = new System.Windows.Forms.Label();
            this.lblMedicTime = new System.Windows.Forms.Label();
            this.lblCivTime = new System.Windows.Forms.Label();
            this.lblCopTime = new System.Windows.Forms.Label();
            this.lblMedicRank = new System.Windows.Forms.Label();
            this.lblCopRank = new System.Windows.Forms.Label();
            this.lblGang = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAliases = new System.Windows.Forms.Label();
            this.lblKDR = new System.Windows.Forms.Label();
            this.lblBounty = new System.Windows.Forms.Label();
            this.lblBank = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.tpDebug = new System.Windows.Forms.TabPage();
            this.rtbDebugEquipment = new System.Windows.Forms.RichTextBox();
            this.rtbDebugVehicle = new System.Windows.Forms.RichTextBox();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.server1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.server2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.server3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspbMain = new System.Windows.Forms.ToolStripProgressBar();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerPLRefresh = new System.Windows.Forms.Timer(this.components);
            this.bwPlayerListRefresh = new System.ComponentModel.BackgroundWorker();
            this.bwPlayerListFilter = new System.ComponentModel.BackgroundWorker();
            this.btnMap = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.tcPlayerLists.SuspendLayout();
            this.tpPlayersAll.SuspendLayout();
            this.cmsWatchlist.SuspendLayout();
            this.tpPlayersTargets.SuspendLayout();
            this.tpWatchlist.SuspendLayout();
            this.pSearch.SuspendLayout();
            this.pMain.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpPlayerInfo.SuspendLayout();
            this.tpDebug.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.tcPlayerLists);
            this.panelLeft.Controls.Add(this.pSearch);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(158, 576);
            this.panelLeft.TabIndex = 26;
            // 
            // tcPlayerLists
            // 
            this.tcPlayerLists.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcPlayerLists.Controls.Add(this.tpPlayersAll);
            this.tcPlayerLists.Controls.Add(this.tpPlayersTargets);
            this.tcPlayerLists.Controls.Add(this.tpWatchlist);
            this.tcPlayerLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPlayerLists.Location = new System.Drawing.Point(0, 34);
            this.tcPlayerLists.Name = "tcPlayerLists";
            this.tcPlayerLists.SelectedIndex = 0;
            this.tcPlayerLists.Size = new System.Drawing.Size(158, 542);
            this.tcPlayerLists.TabIndex = 36;
            // 
            // tpPlayersAll
            // 
            this.tpPlayersAll.Controls.Add(this.lbPlayersAll);
            this.tpPlayersAll.Location = new System.Drawing.Point(4, 4);
            this.tpPlayersAll.Name = "tpPlayersAll";
            this.tpPlayersAll.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlayersAll.Size = new System.Drawing.Size(150, 516);
            this.tpPlayersAll.TabIndex = 0;
            this.tpPlayersAll.Text = "All";
            this.tpPlayersAll.UseVisualStyleBackColor = true;
            // 
            // lbPlayersAll
            // 
            this.lbPlayersAll.ContextMenuStrip = this.cmsWatchlist;
            this.lbPlayersAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPlayersAll.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbPlayersAll.FormattingEnabled = true;
            this.lbPlayersAll.Location = new System.Drawing.Point(3, 3);
            this.lbPlayersAll.Name = "lbPlayersAll";
            this.lbPlayersAll.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbPlayersAll.Size = new System.Drawing.Size(144, 510);
            this.lbPlayersAll.TabIndex = 35;
            this.lbPlayersAll.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBox_DrawItem);
            this.lbPlayersAll.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            this.lbPlayersAll.MouseEnter += new System.EventHandler(this.ListBox_MouseEnter);
            // 
            // cmsWatchlist
            // 
            this.cmsWatchlist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToWatchlistToolStripMenuItem,
            this.removeFromWatchlistToolStripMenuItem});
            this.cmsWatchlist.Name = "cmsWatchlist";
            this.cmsWatchlist.Size = new System.Drawing.Size(201, 48);
            this.cmsWatchlist.Opening += new System.ComponentModel.CancelEventHandler(this.cmsWatchlist_Opening);
            // 
            // addToWatchlistToolStripMenuItem
            // 
            this.addToWatchlistToolStripMenuItem.Name = "addToWatchlistToolStripMenuItem";
            this.addToWatchlistToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.addToWatchlistToolStripMenuItem.Text = "&Add To Watchlist";
            // 
            // removeFromWatchlistToolStripMenuItem
            // 
            this.removeFromWatchlistToolStripMenuItem.Name = "removeFromWatchlistToolStripMenuItem";
            this.removeFromWatchlistToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.removeFromWatchlistToolStripMenuItem.Text = "&Remove From Watchlist";
            // 
            // tpPlayersTargets
            // 
            this.tpPlayersTargets.Controls.Add(this.lbPlayersTargets);
            this.tpPlayersTargets.Location = new System.Drawing.Point(4, 4);
            this.tpPlayersTargets.Name = "tpPlayersTargets";
            this.tpPlayersTargets.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlayersTargets.Size = new System.Drawing.Size(150, 516);
            this.tpPlayersTargets.TabIndex = 1;
            this.tpPlayersTargets.Text = "Targets";
            this.tpPlayersTargets.UseVisualStyleBackColor = true;
            // 
            // lbPlayersTargets
            // 
            this.lbPlayersTargets.ContextMenuStrip = this.cmsWatchlist;
            this.lbPlayersTargets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPlayersTargets.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbPlayersTargets.FormattingEnabled = true;
            this.lbPlayersTargets.Location = new System.Drawing.Point(3, 3);
            this.lbPlayersTargets.Name = "lbPlayersTargets";
            this.lbPlayersTargets.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbPlayersTargets.Size = new System.Drawing.Size(144, 510);
            this.lbPlayersTargets.TabIndex = 36;
            this.lbPlayersTargets.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBox_DrawItem);
            this.lbPlayersTargets.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            this.lbPlayersTargets.MouseEnter += new System.EventHandler(this.ListBox_MouseEnter);
            // 
            // tpWatchlist
            // 
            this.tpWatchlist.Controls.Add(this.lbWatchlist);
            this.tpWatchlist.Location = new System.Drawing.Point(4, 4);
            this.tpWatchlist.Name = "tpWatchlist";
            this.tpWatchlist.Size = new System.Drawing.Size(150, 516);
            this.tpWatchlist.TabIndex = 2;
            this.tpWatchlist.Text = "Watchlist";
            this.tpWatchlist.UseVisualStyleBackColor = true;
            // 
            // lbWatchlist
            // 
            this.lbWatchlist.ContextMenuStrip = this.cmsWatchlist;
            this.lbWatchlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbWatchlist.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbWatchlist.FormattingEnabled = true;
            this.lbWatchlist.Location = new System.Drawing.Point(0, 0);
            this.lbWatchlist.Name = "lbWatchlist";
            this.lbWatchlist.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbWatchlist.Size = new System.Drawing.Size(150, 516);
            this.lbWatchlist.TabIndex = 37;
            this.lbWatchlist.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBox_DrawItem);
            this.lbWatchlist.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            this.lbWatchlist.MouseEnter += new System.EventHandler(this.ListBox_MouseEnter);
            // 
            // pSearch
            // 
            this.pSearch.Controls.Add(this.tbFilter);
            this.pSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSearch.Location = new System.Drawing.Point(0, 0);
            this.pSearch.Name = "pSearch";
            this.pSearch.Size = new System.Drawing.Size(158, 34);
            this.pSearch.TabIndex = 35;
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(12, 5);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(140, 20);
            this.tbFilter.TabIndex = 0;
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.tcMain);
            this.pMain.Controls.Add(this.panelLeft);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(991, 576);
            this.pMain.TabIndex = 29;
            // 
            // tcMain
            // 
            this.tcMain.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tcMain.Controls.Add(this.tpPlayerInfo);
            this.tcMain.Controls.Add(this.tpDebug);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(158, 0);
            this.tcMain.Multiline = true;
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(833, 576);
            this.tcMain.TabIndex = 30;
            // 
            // tpPlayerInfo
            // 
            this.tpPlayerInfo.Controls.Add(this.lblLocation);
            this.tpPlayerInfo.Controls.Add(this.lblUpdated);
            this.tpPlayerInfo.Controls.Add(this.lblHelmet);
            this.tpPlayerInfo.Controls.Add(this.lblVest);
            this.tpPlayerInfo.Controls.Add(this.lblGun);
            this.tpPlayerInfo.Controls.Add(this.lvVehicleInfo);
            this.tpPlayerInfo.Controls.Add(this.label1);
            this.tpPlayerInfo.Controls.Add(this.lvVirtualItems);
            this.tpPlayerInfo.Controls.Add(this.tbAliases);
            this.tpPlayerInfo.Controls.Add(this.lblVirtuals);
            this.tpPlayerInfo.Controls.Add(this.lblMedicRevives);
            this.tpPlayerInfo.Controls.Add(this.lblVigiBounty);
            this.tpPlayerInfo.Controls.Add(this.lblCopArrest);
            this.tpPlayerInfo.Controls.Add(this.lblMedicTime);
            this.tpPlayerInfo.Controls.Add(this.lblCivTime);
            this.tpPlayerInfo.Controls.Add(this.lblCopTime);
            this.tpPlayerInfo.Controls.Add(this.lblMedicRank);
            this.tpPlayerInfo.Controls.Add(this.lblCopRank);
            this.tpPlayerInfo.Controls.Add(this.lblGang);
            this.tpPlayerInfo.Controls.Add(this.lblName);
            this.tpPlayerInfo.Controls.Add(this.lblAliases);
            this.tpPlayerInfo.Controls.Add(this.lblKDR);
            this.tpPlayerInfo.Controls.Add(this.lblBounty);
            this.tpPlayerInfo.Controls.Add(this.lblBank);
            this.tpPlayerInfo.Controls.Add(this.lblCash);
            this.tpPlayerInfo.Location = new System.Drawing.Point(4, 4);
            this.tpPlayerInfo.Name = "tpPlayerInfo";
            this.tpPlayerInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlayerInfo.Size = new System.Drawing.Size(806, 568);
            this.tpPlayerInfo.TabIndex = 1;
            this.tpPlayerInfo.Text = "Player Info";
            this.tpPlayerInfo.UseVisualStyleBackColor = true;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(7, 527);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(46, 13);
            this.lblLocation.TabIndex = 65;
            this.lblLocation.Text = "Coords: ";
            // 
            // lblUpdated
            // 
            this.lblUpdated.AutoSize = true;
            this.lblUpdated.Location = new System.Drawing.Point(7, 503);
            this.lblUpdated.Name = "lblUpdated";
            this.lblUpdated.Size = new System.Drawing.Size(51, 13);
            this.lblUpdated.TabIndex = 64;
            this.lblUpdated.Text = "Updated:";
            // 
            // lblHelmet
            // 
            this.lblHelmet.AutoSize = true;
            this.lblHelmet.Location = new System.Drawing.Point(432, 62);
            this.lblHelmet.Name = "lblHelmet";
            this.lblHelmet.Size = new System.Drawing.Size(46, 13);
            this.lblHelmet.TabIndex = 63;
            this.lblHelmet.Text = "Helmet: ";
            // 
            // lblVest
            // 
            this.lblVest.AutoSize = true;
            this.lblVest.Location = new System.Drawing.Point(432, 35);
            this.lblVest.Name = "lblVest";
            this.lblVest.Size = new System.Drawing.Size(31, 13);
            this.lblVest.TabIndex = 62;
            this.lblVest.Text = "Vest:";
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.Location = new System.Drawing.Point(432, 8);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(33, 13);
            this.lblGun.TabIndex = 61;
            this.lblGun.Text = "Gun: ";
            // 
            // lvVehicleInfo
            // 
            this.lvVehicleInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chActive,
            this.chTurbo,
            this.chSecurity,
            this.chStorage,
            this.chInsurance});
            this.lvVehicleInfo.Location = new System.Drawing.Point(372, 214);
            this.lvVehicleInfo.Name = "lvVehicleInfo";
            this.lvVehicleInfo.Size = new System.Drawing.Size(412, 276);
            this.lvVehicleInfo.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvVehicleInfo.TabIndex = 60;
            this.lvVehicleInfo.UseCompatibleStateImageBehavior = false;
            this.lvVehicleInfo.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 88;
            // 
            // chActive
            // 
            this.chActive.Text = "Active";
            // 
            // chTurbo
            // 
            this.chTurbo.Text = "Turbo";
            // 
            // chSecurity
            // 
            this.chSecurity.Text = "Security";
            // 
            // chStorage
            // 
            this.chStorage.Text = "Storage";
            // 
            // chInsurance
            // 
            this.chInsurance.Text = "Insurance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Vehicles:";
            // 
            // lvVirtualItems
            // 
            this.lvVirtualItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chItem,
            this.chAmount});
            this.lvVirtualItems.Location = new System.Drawing.Point(211, 214);
            this.lvVirtualItems.Name = "lvVirtualItems";
            this.lvVirtualItems.Size = new System.Drawing.Size(155, 276);
            this.lvVirtualItems.TabIndex = 58;
            this.lvVirtualItems.UseCompatibleStateImageBehavior = false;
            this.lvVirtualItems.View = System.Windows.Forms.View.Details;
            // 
            // chItem
            // 
            this.chItem.Text = "Item";
            this.chItem.Width = 91;
            // 
            // chAmount
            // 
            this.chAmount.Text = "Amount";
            // 
            // tbAliases
            // 
            this.tbAliases.Location = new System.Drawing.Point(10, 214);
            this.tbAliases.Multiline = true;
            this.tbAliases.Name = "tbAliases";
            this.tbAliases.ReadOnly = true;
            this.tbAliases.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAliases.Size = new System.Drawing.Size(195, 276);
            this.tbAliases.TabIndex = 41;
            // 
            // lblVirtuals
            // 
            this.lblVirtuals.AutoSize = true;
            this.lblVirtuals.Location = new System.Drawing.Point(211, 198);
            this.lblVirtuals.Name = "lblVirtuals";
            this.lblVirtuals.Size = new System.Drawing.Size(35, 13);
            this.lblVirtuals.TabIndex = 57;
            this.lblVirtuals.Text = "Items:";
            // 
            // lblMedicRevives
            // 
            this.lblMedicRevives.AutoSize = true;
            this.lblMedicRevives.Location = new System.Drawing.Point(255, 170);
            this.lblMedicRevives.Name = "lblMedicRevives";
            this.lblMedicRevives.Size = new System.Drawing.Size(74, 13);
            this.lblMedicRevives.TabIndex = 55;
            this.lblMedicRevives.Text = "R&&R Revives:";
            // 
            // lblVigiBounty
            // 
            this.lblVigiBounty.AutoSize = true;
            this.lblVigiBounty.Location = new System.Drawing.Point(239, 62);
            this.lblVigiBounty.Name = "lblVigiBounty";
            this.lblVigiBounty.Size = new System.Drawing.Size(90, 13);
            this.lblVigiBounty.TabIndex = 54;
            this.lblVigiBounty.Text = "Bounty Collected:";
            // 
            // lblCopArrest
            // 
            this.lblCopArrest.AutoSize = true;
            this.lblCopArrest.Location = new System.Drawing.Point(7, 170);
            this.lblCopArrest.Name = "lblCopArrest";
            this.lblCopArrest.Size = new System.Drawing.Size(67, 13);
            this.lblCopArrest.TabIndex = 56;
            this.lblCopArrest.Text = "APD Arrests:";
            // 
            // lblMedicTime
            // 
            this.lblMedicTime.AutoSize = true;
            this.lblMedicTime.Location = new System.Drawing.Point(271, 143);
            this.lblMedicTime.Name = "lblMedicTime";
            this.lblMedicTime.Size = new System.Drawing.Size(58, 13);
            this.lblMedicTime.TabIndex = 53;
            this.lblMedicTime.Text = "R&&R Time:";
            // 
            // lblCivTime
            // 
            this.lblCivTime.AutoSize = true;
            this.lblCivTime.Location = new System.Drawing.Point(278, 89);
            this.lblCivTime.Name = "lblCivTime";
            this.lblCivTime.Size = new System.Drawing.Size(51, 13);
            this.lblCivTime.TabIndex = 52;
            this.lblCivTime.Text = "Civ Time:";
            // 
            // lblCopTime
            // 
            this.lblCopTime.AutoSize = true;
            this.lblCopTime.Location = new System.Drawing.Point(16, 143);
            this.lblCopTime.Name = "lblCopTime";
            this.lblCopTime.Size = new System.Drawing.Size(58, 13);
            this.lblCopTime.TabIndex = 51;
            this.lblCopTime.Text = "APD Time:";
            // 
            // lblMedicRank
            // 
            this.lblMedicRank.AutoSize = true;
            this.lblMedicRank.Location = new System.Drawing.Point(268, 116);
            this.lblMedicRank.Name = "lblMedicRank";
            this.lblMedicRank.Size = new System.Drawing.Size(61, 13);
            this.lblMedicRank.TabIndex = 50;
            this.lblMedicRank.Text = "R&&R Rank:";
            // 
            // lblCopRank
            // 
            this.lblCopRank.AutoSize = true;
            this.lblCopRank.Location = new System.Drawing.Point(13, 116);
            this.lblCopRank.Name = "lblCopRank";
            this.lblCopRank.Size = new System.Drawing.Size(61, 13);
            this.lblCopRank.TabIndex = 49;
            this.lblCopRank.Text = "APD Rank:";
            // 
            // lblGang
            // 
            this.lblGang.AutoSize = true;
            this.lblGang.Location = new System.Drawing.Point(293, 8);
            this.lblGang.Name = "lblGang";
            this.lblGang.Size = new System.Drawing.Size(36, 13);
            this.lblGang.TabIndex = 48;
            this.lblGang.Text = "Gang:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(36, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 43;
            this.lblName.Text = "Name:";
            // 
            // lblAliases
            // 
            this.lblAliases.AutoSize = true;
            this.lblAliases.Location = new System.Drawing.Point(10, 198);
            this.lblAliases.Name = "lblAliases";
            this.lblAliases.Size = new System.Drawing.Size(43, 13);
            this.lblAliases.TabIndex = 47;
            this.lblAliases.Text = "Aliases:";
            // 
            // lblKDR
            // 
            this.lblKDR.AutoSize = true;
            this.lblKDR.Location = new System.Drawing.Point(28, 89);
            this.lblKDR.Name = "lblKDR";
            this.lblKDR.Size = new System.Drawing.Size(46, 13);
            this.lblKDR.TabIndex = 42;
            this.lblKDR.Text = "K/D/R: ";
            // 
            // lblBounty
            // 
            this.lblBounty.AutoSize = true;
            this.lblBounty.Location = new System.Drawing.Point(31, 62);
            this.lblBounty.Name = "lblBounty";
            this.lblBounty.Size = new System.Drawing.Size(43, 13);
            this.lblBounty.TabIndex = 46;
            this.lblBounty.Text = "Bounty:";
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Location = new System.Drawing.Point(294, 35);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(35, 13);
            this.lblBank.TabIndex = 45;
            this.lblBank.Text = "Bank:";
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Location = new System.Drawing.Point(40, 35);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(34, 13);
            this.lblCash.TabIndex = 44;
            this.lblCash.Text = "Cash:";
            // 
            // tpDebug
            // 
            this.tpDebug.Controls.Add(this.rtbDebugEquipment);
            this.tpDebug.Controls.Add(this.rtbDebugVehicle);
            this.tpDebug.Location = new System.Drawing.Point(4, 4);
            this.tpDebug.Name = "tpDebug";
            this.tpDebug.Padding = new System.Windows.Forms.Padding(3);
            this.tpDebug.Size = new System.Drawing.Size(806, 568);
            this.tpDebug.TabIndex = 2;
            this.tpDebug.Text = "Debug Info";
            this.tpDebug.UseVisualStyleBackColor = true;
            // 
            // rtbDebugEquipment
            // 
            this.rtbDebugEquipment.Location = new System.Drawing.Point(348, 6);
            this.rtbDebugEquipment.Name = "rtbDebugEquipment";
            this.rtbDebugEquipment.Size = new System.Drawing.Size(339, 556);
            this.rtbDebugEquipment.TabIndex = 1;
            this.rtbDebugEquipment.Text = "";
            // 
            // rtbDebugVehicle
            // 
            this.rtbDebugVehicle.Location = new System.Drawing.Point(3, 6);
            this.rtbDebugVehicle.Name = "rtbDebugVehicle";
            this.rtbDebugVehicle.Size = new System.Drawing.Size(339, 556);
            this.rtbDebugVehicle.TabIndex = 0;
            this.rtbDebugVehicle.Text = "";
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.tspbMain,
            this.tsslStatus});
            this.ssMain.Location = new System.Drawing.Point(0, 576);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(991, 22);
            this.ssMain.TabIndex = 2;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.server1ToolStripMenuItem,
            this.server2ToolStripMenuItem,
            this.server3ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(52, 20);
            this.toolStripDropDownButton1.Text = "Server";
            this.toolStripDropDownButton1.ToolTipText = "Select Server";
            // 
            // server1ToolStripMenuItem
            // 
            this.server1ToolStripMenuItem.Name = "server1ToolStripMenuItem";
            this.server1ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.server1ToolStripMenuItem.Text = "Server 1";
            this.server1ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // server2ToolStripMenuItem
            // 
            this.server2ToolStripMenuItem.Name = "server2ToolStripMenuItem";
            this.server2ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.server2ToolStripMenuItem.Text = "Server 2";
            this.server2ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // server3ToolStripMenuItem
            // 
            this.server3ToolStripMenuItem.Name = "server3ToolStripMenuItem";
            this.server3ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.server3ToolStripMenuItem.Text = "Server 3";
            this.server3ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // tspbMain
            // 
            this.tspbMain.Maximum = 180;
            this.tspbMain.Name = "tspbMain";
            this.tspbMain.Size = new System.Drawing.Size(100, 16);
            this.tspbMain.Step = 1;
            this.tspbMain.Click += new System.EventHandler(this.tspbMain_Click);
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(39, 17);
            this.tsslStatus.Text = "Status";
            // 
            // timerPLRefresh
            // 
            this.timerPLRefresh.Interval = 1000;
            this.timerPLRefresh.Tick += new System.EventHandler(this.timerPLRefresh_Tick);
            // 
            // bwPlayerListRefresh
            // 
            this.bwPlayerListRefresh.WorkerReportsProgress = true;
            this.bwPlayerListRefresh.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwPlayerListRefresh_DoWork);
            this.bwPlayerListRefresh.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwPlayerListRefresh_RunWorkerCompleted);
            // 
            // btnMap
            // 
            this.btnMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMap.Location = new System.Drawing.Point(917, 576);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(51, 21);
            this.btnMap.TabIndex = 31;
            this.btnMap.Text = "Map";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 598);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.ssMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelLeft.ResumeLayout(false);
            this.tcPlayerLists.ResumeLayout(false);
            this.tpPlayersAll.ResumeLayout(false);
            this.cmsWatchlist.ResumeLayout(false);
            this.tpPlayersTargets.ResumeLayout(false);
            this.tpWatchlist.ResumeLayout(false);
            this.pSearch.ResumeLayout(false);
            this.pSearch.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tpPlayerInfo.ResumeLayout(false);
            this.tpPlayerInfo.PerformLayout();
            this.tpDebug.ResumeLayout(false);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel pSearch;
        private System.Windows.Forms.ListBox lbPlayersAll;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.Timer timerPLRefresh;
        private System.ComponentModel.BackgroundWorker bwPlayerListRefresh;
        private System.Windows.Forms.TabControl tcPlayerLists;
        private System.Windows.Forms.TabPage tpPlayersAll;
        private System.Windows.Forms.TabPage tpPlayersTargets;
        private System.ComponentModel.BackgroundWorker bwPlayerListFilter;
        private System.Windows.Forms.ListBox lbPlayersTargets;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.ToolStripProgressBar tspbMain;
        private System.Windows.Forms.TabPage tpWatchlist;
        private System.Windows.Forms.ListBox lbWatchlist;
        private System.Windows.Forms.ContextMenuStrip cmsWatchlist;
        private System.Windows.Forms.ToolStripMenuItem addToWatchlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFromWatchlistToolStripMenuItem;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpPlayerInfo;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblUpdated;
        private System.Windows.Forms.Label lblHelmet;
        private System.Windows.Forms.Label lblVest;
        private System.Windows.Forms.Label lblGun;
        private System.Windows.Forms.ListView lvVehicleInfo;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chActive;
        private System.Windows.Forms.ColumnHeader chTurbo;
        private System.Windows.Forms.ColumnHeader chSecurity;
        private System.Windows.Forms.ColumnHeader chStorage;
        private System.Windows.Forms.ColumnHeader chInsurance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvVirtualItems;
        private System.Windows.Forms.ColumnHeader chItem;
        private System.Windows.Forms.ColumnHeader chAmount;
        private System.Windows.Forms.TextBox tbAliases;
        private System.Windows.Forms.Label lblVirtuals;
        private System.Windows.Forms.Label lblMedicRevives;
        private System.Windows.Forms.Label lblVigiBounty;
        private System.Windows.Forms.Label lblCopArrest;
        private System.Windows.Forms.Label lblMedicTime;
        private System.Windows.Forms.Label lblCivTime;
        private System.Windows.Forms.Label lblCopTime;
        private System.Windows.Forms.Label lblMedicRank;
        private System.Windows.Forms.Label lblCopRank;
        private System.Windows.Forms.Label lblGang;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAliases;
        private System.Windows.Forms.Label lblKDR;
        private System.Windows.Forms.Label lblBounty;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.TabPage tpDebug;
        private System.Windows.Forms.RichTextBox rtbDebugEquipment;
        private System.Windows.Forms.RichTextBox rtbDebugVehicle;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem server3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem server2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem server1ToolStripMenuItem;
    }
}

