
namespace DataAnalysisSecond
{
    partial class DependencyGraphsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DependencyGraphsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.secondColumnCb = new System.Windows.Forms.ComboBox();
            this.firstColumnCb = new System.Windows.Forms.ComboBox();
            this.buildBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mainGraph = new LiveCharts.WinForms.CartesianChart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.secondColumnCb);
            this.groupBox1.Controls.Add(this.firstColumnCb);
            this.groupBox1.Controls.Add(this.buildBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Columns:";
            // 
            // secondColumnCb
            // 
            this.secondColumnCb.FormattingEnabled = true;
            this.secondColumnCb.Location = new System.Drawing.Point(84, 45);
            this.secondColumnCb.Name = "secondColumnCb";
            this.secondColumnCb.Size = new System.Drawing.Size(226, 24);
            this.secondColumnCb.TabIndex = 4;
            // 
            // firstColumnCb
            // 
            this.firstColumnCb.FormattingEnabled = true;
            this.firstColumnCb.Location = new System.Drawing.Point(84, 19);
            this.firstColumnCb.Name = "firstColumnCb";
            this.firstColumnCb.Size = new System.Drawing.Size(226, 24);
            this.firstColumnCb.TabIndex = 3;
            // 
            // buildBtn
            // 
            this.buildBtn.Location = new System.Drawing.Point(106, 79);
            this.buildBtn.Name = "buildBtn";
            this.buildBtn.Size = new System.Drawing.Size(75, 29);
            this.buildBtn.TabIndex = 2;
            this.buildBtn.Text = "Build";
            this.buildBtn.UseVisualStyleBackColor = true;
            this.buildBtn.Click += new System.EventHandler(this.buildBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Column Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Column X:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.mainGraph);
            this.groupBox2.Location = new System.Drawing.Point(13, 133);
            this.groupBox2.MinimumSize = new System.Drawing.Size(1073, 523);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1073, 523);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chart:";
            // 
            // mainGraph
            // 
            this.mainGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainGraph.Location = new System.Drawing.Point(10, 22);
            this.mainGraph.Name = "mainGraph";
            this.mainGraph.Size = new System.Drawing.Size(1057, 495);
            this.mainGraph.TabIndex = 0;
            this.mainGraph.Text = "cartesianChart1";
            // 
            // DependencyGraphsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 668);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DependencyGraphsForm";
            this.Text = "Dependency Graphs";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox secondColumnCb;
        private System.Windows.Forms.ComboBox firstColumnCb;
        private System.Windows.Forms.Button buildBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private LiveCharts.WinForms.CartesianChart mainGraph;
    }
}