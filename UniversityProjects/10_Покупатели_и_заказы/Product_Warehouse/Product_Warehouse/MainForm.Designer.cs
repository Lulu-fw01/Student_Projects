
namespace Product_Warehouse
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewWarehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cSVReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveWarehouseAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWarehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadWarehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewWarehouseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTreeView = new System.Windows.Forms.TreeView();
            this.nodeTreeContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewCategoryTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.addSubcategoryTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.changeNameTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteSelectedNodeTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.accountTs = new System.Windows.Forms.ToolStrip();
            this.cartBtn = new System.Windows.Forms.ToolStripButton();
            this.accountDDBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.checkOrdersTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.mainFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.saveCsvFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openWarehouseFD = new System.Windows.Forms.OpenFileDialog();
            this.saveWarehouseFD = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.nodeTreeContextMenuStrip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.accountTs.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.menuStrip2);
            this.groupBox1.Controls.Add(this.mainTreeView);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 547);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categories:";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(3, 18);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(387, 28);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewWarehouseToolStripMenuItem,
            this.toolStripSeparator4,
            this.cSVReportToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveWarehouseAsToolStripMenuItem,
            this.saveWarehouseToolStripMenuItem,
            this.loadWarehouseToolStripMenuItem,
            this.createNewWarehouseToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createNewWarehouseToolStripMenuItem
            // 
            this.createNewWarehouseToolStripMenuItem.Name = "createNewWarehouseToolStripMenuItem";
            this.createNewWarehouseToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.createNewWarehouseToolStripMenuItem.Text = "Create new warehouse";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(291, 6);
            // 
            // cSVReportToolStripMenuItem
            // 
            this.cSVReportToolStripMenuItem.Name = "cSVReportToolStripMenuItem";
            this.cSVReportToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.cSVReportToolStripMenuItem.Text = "CSV report";
            this.cSVReportToolStripMenuItem.Click += new System.EventHandler(this.cSVReportToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(291, 6);
            // 
            // saveWarehouseAsToolStripMenuItem
            // 
            this.saveWarehouseAsToolStripMenuItem.Name = "saveWarehouseAsToolStripMenuItem";
            this.saveWarehouseAsToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.saveWarehouseAsToolStripMenuItem.Text = "Save warehouse as";
            this.saveWarehouseAsToolStripMenuItem.Click += new System.EventHandler(this.saveWarehouseAsToolStripMenuItem_Click);
            // 
            // saveWarehouseToolStripMenuItem
            // 
            this.saveWarehouseToolStripMenuItem.Name = "saveWarehouseToolStripMenuItem";
            this.saveWarehouseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveWarehouseToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.saveWarehouseToolStripMenuItem.Text = "Save warehouse";
            this.saveWarehouseToolStripMenuItem.Click += new System.EventHandler(this.saveWarehouseToolStripMenuItem_Click);
            // 
            // loadWarehouseToolStripMenuItem
            // 
            this.loadWarehouseToolStripMenuItem.Name = "loadWarehouseToolStripMenuItem";
            this.loadWarehouseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadWarehouseToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.loadWarehouseToolStripMenuItem.Text = "Load warehouse";
            this.loadWarehouseToolStripMenuItem.Click += new System.EventHandler(this.loadWarehouseToolStripMenuItem_Click);
            // 
            // createNewWarehouseToolStripMenuItem1
            // 
            this.createNewWarehouseToolStripMenuItem1.Name = "createNewWarehouseToolStripMenuItem1";
            this.createNewWarehouseToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createNewWarehouseToolStripMenuItem1.Size = new System.Drawing.Size(294, 26);
            this.createNewWarehouseToolStripMenuItem1.Text = "Create new warehouse";
            this.createNewWarehouseToolStripMenuItem1.Click += new System.EventHandler(this.createNewWarehouseToolStripMenuItem1_Click);
            // 
            // mainTreeView
            // 
            this.mainTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTreeView.ContextMenuStrip = this.nodeTreeContextMenuStrip;
            this.mainTreeView.Location = new System.Drawing.Point(7, 50);
            this.mainTreeView.Name = "mainTreeView";
            this.mainTreeView.Size = new System.Drawing.Size(380, 492);
            this.mainTreeView.TabIndex = 1;
            this.mainTreeView.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.mainTreeView_BeforeSelect);
            this.mainTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.mainTreeView_AfterSelect);
            this.mainTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.mainTreeView_NodeMouseClick);
            // 
            // nodeTreeContextMenuStrip
            // 
            this.nodeTreeContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.nodeTreeContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCategoryTsmi,
            this.addSubcategoryTsmi,
            this.toolStripSeparator1,
            this.changeNameTsmi,
            this.toolStripSeparator2,
            this.deleteSelectedNodeTsmi});
            this.nodeTreeContextMenuStrip.Name = "nodeTreeContextMenuStrip";
            this.nodeTreeContextMenuStrip.Size = new System.Drawing.Size(285, 112);
            this.nodeTreeContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.nodeTreeContextMenuStrip_Opening);
            // 
            // addNewCategoryTsmi
            // 
            this.addNewCategoryTsmi.Name = "addNewCategoryTsmi";
            this.addNewCategoryTsmi.Size = new System.Drawing.Size(284, 24);
            this.addNewCategoryTsmi.Text = "Add new category";
            this.addNewCategoryTsmi.Click += new System.EventHandler(this.addNewCategoryTsmi_Click);
            // 
            // addSubcategoryTsmi
            // 
            this.addSubcategoryTsmi.Name = "addSubcategoryTsmi";
            this.addSubcategoryTsmi.Size = new System.Drawing.Size(284, 24);
            this.addSubcategoryTsmi.Text = "Add  sub ctagory";
            this.addSubcategoryTsmi.Click += new System.EventHandler(this.addSubcategoryTsmi_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(281, 6);
            // 
            // changeNameTsmi
            // 
            this.changeNameTsmi.Name = "changeNameTsmi";
            this.changeNameTsmi.Size = new System.Drawing.Size(284, 24);
            this.changeNameTsmi.Text = "Change name of selected node";
            this.changeNameTsmi.Click += new System.EventHandler(this.changeNameTsmi_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(281, 6);
            // 
            // deleteSelectedNodeTsmi
            // 
            this.deleteSelectedNodeTsmi.Name = "deleteSelectedNodeTsmi";
            this.deleteSelectedNodeTsmi.Size = new System.Drawing.Size(284, 24);
            this.deleteSelectedNodeTsmi.Text = "Delete selected node";
            this.deleteSelectedNodeTsmi.Click += new System.EventHandler(this.deleteSelectedNodeTsmi_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.Color.Green;
            this.addProductButton.Location = new System.Drawing.Point(7, 18);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(95, 30);
            this.addProductButton.TabIndex = 0;
            this.addProductButton.Text = "Add product";
            this.addProductButton.UseVisualStyleBackColor = false;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.mainFlowLayoutPanel);
            this.groupBox2.Controls.Add(this.addProductButton);
            this.groupBox2.Location = new System.Drawing.Point(401, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 547);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Items:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.accountTs);
            this.groupBox3.Location = new System.Drawing.Point(270, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 46);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // accountTs
            // 
            this.accountTs.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.accountTs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cartBtn,
            this.accountDDBtn});
            this.accountTs.Location = new System.Drawing.Point(3, 18);
            this.accountTs.Name = "accountTs";
            this.accountTs.Size = new System.Drawing.Size(232, 27);
            this.accountTs.TabIndex = 0;
            this.accountTs.Text = "toolStrip1";
            // 
            // cartBtn
            // 
            this.cartBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cartBtn.Image = global::Product_Warehouse.Properties.Resources.cart_icon;
            this.cartBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.Size = new System.Drawing.Size(29, 24);
            this.cartBtn.Text = "toolStripButton1";
            this.cartBtn.Click += new System.EventHandler(this.cartBtn_Click);
            // 
            // accountDDBtn
            // 
            this.accountDDBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.accountDDBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkOrdersTsmi,
            this.exitToolStripMenuItem,
            this.loginTsmi});
            this.accountDDBtn.Image = global::Product_Warehouse.Properties.Resources.account_icon;
            this.accountDDBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.accountDDBtn.Name = "accountDDBtn";
            this.accountDDBtn.Size = new System.Drawing.Size(34, 24);
            this.accountDDBtn.Text = "toolStripDropDownButton1";
            // 
            // checkOrdersTsmi
            // 
            this.checkOrdersTsmi.Name = "checkOrdersTsmi";
            this.checkOrdersTsmi.Size = new System.Drawing.Size(224, 26);
            this.checkOrdersTsmi.Text = "Check orders";
            this.checkOrdersTsmi.Click += new System.EventHandler(this.checkOrdersTsmi_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "exit";
            // 
            // loginTsmi
            // 
            this.loginTsmi.Name = "loginTsmi";
            this.loginTsmi.Size = new System.Drawing.Size(224, 26);
            this.loginTsmi.Text = "Login";
            this.loginTsmi.Click += new System.EventHandler(this.loginTsmi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // mainFlowLayoutPanel
            // 
            this.mainFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainFlowLayoutPanel.AutoScroll = true;
            this.mainFlowLayoutPanel.Location = new System.Drawing.Point(7, 45);
            this.mainFlowLayoutPanel.Name = "mainFlowLayoutPanel";
            this.mainFlowLayoutPanel.Size = new System.Drawing.Size(501, 496);
            this.mainFlowLayoutPanel.TabIndex = 0;
            // 
            // saveCsvFileDialog
            // 
            this.saveCsvFileDialog.Filter = "CSV files | *.csv";
            // 
            // openWarehouseFD
            // 
            this.openWarehouseFD.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 552);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Product Warehouse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.nodeTreeContextMenuStrip.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.accountTs.ResumeLayout(false);
            this.accountTs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel mainFlowLayoutPanel;
        private System.Windows.Forms.TreeView mainTreeView;
        private System.Windows.Forms.ContextMenuStrip nodeTreeContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addNewCategoryTsmi;
        private System.Windows.Forms.ToolStripMenuItem addSubcategoryTsmi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedNodeTsmi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem changeNameTsmi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.SaveFileDialog saveCsvFileDialog;
        private System.Windows.Forms.OpenFileDialog openWarehouseFD;
        private System.Windows.Forms.SaveFileDialog saveWarehouseFD;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewWarehouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem cSVReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem saveWarehouseAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveWarehouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadWarehouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewWarehouseToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStrip accountTs;
        private System.Windows.Forms.ToolStripButton cartBtn;
        private System.Windows.Forms.ToolStripDropDownButton accountDDBtn;
        private System.Windows.Forms.ToolStripMenuItem checkOrdersTsmi;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginTsmi;
    }
}

