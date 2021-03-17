
namespace NotepadPlus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.createHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createWindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shortcutKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automaticSavingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tenMinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fifteenMinsoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thirtyMinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.boldButton = new System.Windows.Forms.ToolStripButton();
            this.italicButton = new System.Windows.Forms.ToolStripButton();
            this.underlineButton = new System.Windows.Forms.ToolStripButton();
            this.crossOutButton = new System.Windows.Forms.ToolStripButton();
            this.newDocButton = new System.Windows.Forms.ToolStripButton();
            this.rtbContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fontFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.savingTimer = new System.Windows.Forms.Timer(this.components);
            this.textBoxesTabControl = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.rtbContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1135, 28);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveAllToolStripMenuItem,
            this.toolStripSeparator2,
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.createHereToolStripMenuItem,
            this.createWindToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(399, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(399, 26);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(399, 26);
            this.saveAllToolStripMenuItem.Text = "Save all";
            this.saveAllToolStripMenuItem.Click += new System.EventHandler(this.saveAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(396, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(399, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(396, 6);
            // 
            // createHereToolStripMenuItem
            // 
            this.createHereToolStripMenuItem.Name = "createHereToolStripMenuItem";
            this.createHereToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createHereToolStripMenuItem.Size = new System.Drawing.Size(399, 26);
            this.createHereToolStripMenuItem.Text = "Create new doc here";
            this.createHereToolStripMenuItem.Click += new System.EventHandler(this.createHereTooltripMenuItem_Click);
            // 
            // createWindToolStripMenuItem
            // 
            this.createWindToolStripMenuItem.Name = "createWindToolStripMenuItem";
            this.createWindToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.createWindToolStripMenuItem.Size = new System.Drawing.Size(399, 26);
            this.createWindToolStripMenuItem.Text = "Create new doc in new window";
            this.createWindToolStripMenuItem.Click += new System.EventHandler(this.createWindTooltripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(396, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(399, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shortcutKeysToolStripMenuItem,
            this.themeToolStripMenuItem,
            this.automaticSavingToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // shortcutKeysToolStripMenuItem
            // 
            this.shortcutKeysToolStripMenuItem.Name = "shortcutKeysToolStripMenuItem";
            this.shortcutKeysToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.shortcutKeysToolStripMenuItem.Text = "Shortcut Keys ? ";
            this.shortcutKeysToolStripMenuItem.Click += new System.EventHandler(this.shortcutKeysToolStripMenuItem_Click);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkToolStripMenuItem,
            this.lightToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // automaticSavingToolStripMenuItem
            // 
            this.automaticSavingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tenMinsToolStripMenuItem,
            this.fifteenMinsoolStripMenuItem,
            this.thirtyMinsToolStripMenuItem,
            this.offToolStripMenuItem});
            this.automaticSavingToolStripMenuItem.Name = "automaticSavingToolStripMenuItem";
            this.automaticSavingToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.automaticSavingToolStripMenuItem.Text = "Automatic saving";
            // 
            // tenMinsToolStripMenuItem
            // 
            this.tenMinsToolStripMenuItem.Name = "tenMinsToolStripMenuItem";
            this.tenMinsToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.tenMinsToolStripMenuItem.Text = "Every 10 minutes";
            this.tenMinsToolStripMenuItem.Click += new System.EventHandler(this.tenMinsToolStripMenuItem_Click);
            // 
            // fifteenMinsoolStripMenuItem
            // 
            this.fifteenMinsoolStripMenuItem.Name = "fifteenMinsoolStripMenuItem";
            this.fifteenMinsoolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.fifteenMinsoolStripMenuItem.Text = "Every 15 minutes";
            this.fifteenMinsoolStripMenuItem.Click += new System.EventHandler(this.fiftenMinsToolStripMenuItem_Click);
            // 
            // thirtyMinsToolStripMenuItem
            // 
            this.thirtyMinsToolStripMenuItem.Name = "thirtyMinsToolStripMenuItem";
            this.thirtyMinsToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.thirtyMinsToolStripMenuItem.Text = "Every 30 minutes";
            this.thirtyMinsToolStripMenuItem.Click += new System.EventHandler(this.thirtyMinsToolStripMenuItem_Click);
            // 
            // offToolStripMenuItem
            // 
            this.offToolStripMenuItem.Name = "offToolStripMenuItem";
            this.offToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.offToolStripMenuItem.Text = "Off";
            this.offToolStripMenuItem.Click += new System.EventHandler(this.offToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldButton,
            this.italicButton,
            this.underlineButton,
            this.crossOutButton,
            this.newDocButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip.Size = new System.Drawing.Size(1135, 37);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip1";
            // 
            // boldButton
            // 
            this.boldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldButton.Image = ((System.Drawing.Image)(resources.GetObject("boldButton.Image")));
            this.boldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldButton.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.boldButton.Name = "boldButton";
            this.boldButton.Padding = new System.Windows.Forms.Padding(10, 10, 5, 0);
            this.boldButton.Size = new System.Drawing.Size(39, 34);
            this.boldButton.Text = "Bold font";
            this.boldButton.Click += new System.EventHandler(this.boldButton_Click);
            // 
            // italicButton
            // 
            this.italicButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicButton.Image = ((System.Drawing.Image)(resources.GetObject("italicButton.Image")));
            this.italicButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicButton.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.italicButton.Name = "italicButton";
            this.italicButton.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.italicButton.Size = new System.Drawing.Size(34, 34);
            this.italicButton.Text = "Italic font";
            this.italicButton.Click += new System.EventHandler(this.italicButton_Click);
            // 
            // underlineButton
            // 
            this.underlineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underlineButton.Image = ((System.Drawing.Image)(resources.GetObject("underlineButton.Image")));
            this.underlineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineButton.Name = "underlineButton";
            this.underlineButton.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.underlineButton.Size = new System.Drawing.Size(34, 34);
            this.underlineButton.Text = "Underline";
            this.underlineButton.Click += new System.EventHandler(this.underlineButton_Click);
            // 
            // crossOutButton
            // 
            this.crossOutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.crossOutButton.Image = ((System.Drawing.Image)(resources.GetObject("crossOutButton.Image")));
            this.crossOutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.crossOutButton.Name = "crossOutButton";
            this.crossOutButton.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.crossOutButton.Size = new System.Drawing.Size(34, 34);
            this.crossOutButton.Text = "Crossed out";
            this.crossOutButton.Click += new System.EventHandler(this.crossOutButton_Click);
            // 
            // newDocButton
            // 
            this.newDocButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newDocButton.Image = ((System.Drawing.Image)(resources.GetObject("newDocButton.Image")));
            this.newDocButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newDocButton.Name = "newDocButton";
            this.newDocButton.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.newDocButton.Size = new System.Drawing.Size(34, 34);
            this.newDocButton.Text = "New document";
            this.newDocButton.Click += new System.EventHandler(this.newDocButton_click);
            // 
            // rtbContextMenuStrip
            // 
            this.rtbContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rtbContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.toolStripSeparator1,
            this.fontFToolStripMenuItem});
            this.rtbContextMenuStrip.Name = "contextMenuStrip1";
            this.rtbContextMenuStrip.Size = new System.Drawing.Size(161, 140);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectAllToolStripMenuItem.Image")));
            this.selectAllToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.selectAllToolStripMenuItem.Text = "Select all";
            this.selectAllToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("insertToolStripMenuItem.Image")));
            this.insertToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.insertToolStripMenuItem.Text = "Insert";
            this.insertToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // fontFToolStripMenuItem
            // 
            this.fontFToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fontFToolStripMenuItem.Image")));
            this.fontFToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fontFToolStripMenuItem.Name = "fontFToolStripMenuItem";
            this.fontFToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.fontFToolStripMenuItem.Text = "Font format";
            this.fontFToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fontFToolStripMenuItem.Click += new System.EventHandler(this.fontFToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt files (*.txt )|*.txt | rtf files (*.rtf)|*.rtf";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "text files (*.txt; *.rtf)|*.txt; *.rtf";
            // 
            // savingTimer
            // 
            this.savingTimer.Interval = 10000;
            this.savingTimer.Tick += new System.EventHandler(this.savingTimer_Tick);
            // 
            // textBoxesTabControl
            // 
            this.textBoxesTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxesTabControl.Location = new System.Drawing.Point(0, 65);
            this.textBoxesTabControl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.textBoxesTabControl.Name = "textBoxesTabControl";
            this.textBoxesTabControl.SelectedIndex = 0;
            this.textBoxesTabControl.Size = new System.Drawing.Size(1135, 588);
            this.textBoxesTabControl.TabIndex = 6;
            this.textBoxesTabControl.SelectedIndexChanged += new System.EventHandler(this.textBoxesTabControl_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxesTabControl);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "NotepadPlus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.rtbContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton boldButton;
        private System.Windows.Forms.ToolStripButton italicButton;
        private System.Windows.Forms.ToolStripButton crossOutButton;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createHereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createWindToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
      
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripButton underlineButton;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ToolStripMenuItem shortcutKeysToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip rtbContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontFToolStripMenuItem;
        private System.Windows.Forms.Timer savingTimer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabControl textBoxesTabControl;
        private System.Windows.Forms.ToolStripButton newDocButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem automaticSavingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tenMinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fifteenMinsoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thirtyMinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem;
    }
}

