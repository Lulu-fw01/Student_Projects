
namespace DataAnalysisSecond
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mainDataGrid = new System.Windows.Forms.DataGridView();
            this.openCSVDialog = new System.Windows.Forms.OpenFileDialog();
            this.barGraphBtn = new System.Windows.Forms.ToolStripButton();
            this.dependencyGraphsBtn = new System.Windows.Forms.ToolStripButton();
            this.mainMenuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(800, 28);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCSVToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openCSVToolStripMenuItem
            // 
            this.openCSVToolStripMenuItem.Name = "openCSVToolStripMenuItem";
            this.openCSVToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.openCSVToolStripMenuItem.Text = "Open CSV";
            this.openCSVToolStripMenuItem.Click += new System.EventHandler(this.openCSVToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barGraphBtn,
            this.dependencyGraphsBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mainDataGrid
            // 
            this.mainDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGrid.Location = new System.Drawing.Point(0, 58);
            this.mainDataGrid.Name = "mainDataGrid";
            this.mainDataGrid.RowHeadersWidth = 51;
            this.mainDataGrid.RowTemplate.Height = 24;
            this.mainDataGrid.Size = new System.Drawing.Size(800, 392);
            this.mainDataGrid.TabIndex = 2;
            // 
            // openCSVDialog
            // 
            this.openCSVDialog.FileName = "openFileDialog1";
            // 
            // barGraphBtn
            // 
            this.barGraphBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barGraphBtn.Image = global::DataAnalysisSecond.Properties.Resources.barChartIcon;
            this.barGraphBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barGraphBtn.Name = "barGraphBtn";
            this.barGraphBtn.Size = new System.Drawing.Size(29, 24);
            this.barGraphBtn.Text = "Bar graph";
            this.barGraphBtn.Click += new System.EventHandler(this.barGraphBtn_Click);
            // 
            // dependencyGraphsBtn
            // 
            this.dependencyGraphsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dependencyGraphsBtn.Image = global::DataAnalysisSecond.Properties.Resources.chartIcon;
            this.dependencyGraphsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dependencyGraphsBtn.Name = "dependencyGraphsBtn";
            this.dependencyGraphsBtn.Size = new System.Drawing.Size(29, 24);
            this.dependencyGraphsBtn.Text = "Dependency graphs";
            this.dependencyGraphsBtn.Click += new System.EventHandler(this.dependencyGraphsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainDataGrid);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "Form1";
            this.Text = "Data analysis";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton barGraphBtn;
        private System.Windows.Forms.DataGridView mainDataGrid;
        private System.Windows.Forms.OpenFileDialog openCSVDialog;
        private System.Windows.Forms.ToolStripButton dependencyGraphsBtn;
    }
}

