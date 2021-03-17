
namespace DataAnalysisSecond
{
    partial class BarGraphForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarGraphForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buildGraphBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.columnComboBox = new System.Windows.Forms.ComboBox();
            this.barGraphGroupBox = new System.Windows.Forms.GroupBox();
            this.liveBarGraph = new LiveCharts.WinForms.CartesianChart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dispersionLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deviationLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.medianLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.columnNumeric = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.barGraphGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buildGraphBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.columnComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose column";
            // 
            // buildGraphBtn
            // 
            this.buildGraphBtn.Location = new System.Drawing.Point(104, 62);
            this.buildGraphBtn.Name = "buildGraphBtn";
            this.buildGraphBtn.Size = new System.Drawing.Size(75, 34);
            this.buildGraphBtn.TabIndex = 2;
            this.buildGraphBtn.Text = "Build";
            this.buildGraphBtn.UseVisualStyleBackColor = true;
            this.buildGraphBtn.Click += new System.EventHandler(this.buildGraphBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Columns:";
            // 
            // columnComboBox
            // 
            this.columnComboBox.FormattingEnabled = true;
            this.columnComboBox.Location = new System.Drawing.Point(79, 19);
            this.columnComboBox.Name = "columnComboBox";
            this.columnComboBox.Size = new System.Drawing.Size(218, 24);
            this.columnComboBox.TabIndex = 0;
            // 
            // barGraphGroupBox
            // 
            this.barGraphGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barGraphGroupBox.Controls.Add(this.liveBarGraph);
            this.barGraphGroupBox.Location = new System.Drawing.Point(-2, 126);
            this.barGraphGroupBox.Name = "barGraphGroupBox";
            this.barGraphGroupBox.Size = new System.Drawing.Size(1272, 705);
            this.barGraphGroupBox.TabIndex = 1;
            this.barGraphGroupBox.TabStop = false;
            this.barGraphGroupBox.Text = "Bar graph:";
            // 
            // liveBarGraph
            // 
            this.liveBarGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.liveBarGraph.Location = new System.Drawing.Point(14, 21);
            this.liveBarGraph.Name = "liveBarGraph";
            this.liveBarGraph.Size = new System.Drawing.Size(1252, 671);
            this.liveBarGraph.TabIndex = 0;
            this.liveBarGraph.Text = "cartesianChart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dispersionLabel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.deviationLabel);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Controls.Add(this.medianLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.averageLabel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(338, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 108);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "...";
            // 
            // dispersionLabel
            // 
            this.dispersionLabel.AutoSize = true;
            this.dispersionLabel.Location = new System.Drawing.Point(398, 51);
            this.dispersionLabel.Name = "dispersionLabel";
            this.dispersionLabel.Size = new System.Drawing.Size(16, 17);
            this.dispersionLabel.TabIndex = 7;
            this.dispersionLabel.Text = "_";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(302, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dispersion:";
            // 
            // deviationLabel
            // 
            this.deviationLabel.AutoSize = true;
            this.deviationLabel.Location = new System.Drawing.Point(454, 22);
            this.deviationLabel.Name = "deviationLabel";
            this.deviationLabel.Size = new System.Drawing.Size(16, 17);
            this.deviationLabel.TabIndex = 5;
            this.deviationLabel.Text = "_";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(302, 22);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(146, 17);
            this.label.TabIndex = 4;
            this.label.Text = "Standart deviation:";
            // 
            // medianLabel
            // 
            this.medianLabel.AutoSize = true;
            this.medianLabel.Location = new System.Drawing.Point(87, 51);
            this.medianLabel.Name = "medianLabel";
            this.medianLabel.Size = new System.Drawing.Size(16, 17);
            this.medianLabel.TabIndex = 3;
            this.medianLabel.Text = "_";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Median:";
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Location = new System.Drawing.Point(87, 22);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(16, 17);
            this.averageLabel.TabIndex = 1;
            this.averageLabel.Text = "_";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Average:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.columnNumeric);
            this.groupBox3.Location = new System.Drawing.Point(1015, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Numeric:";
            // 
            // columnNumeric
            // 
            this.columnNumeric.Location = new System.Drawing.Point(7, 22);
            this.columnNumeric.Name = "columnNumeric";
            this.columnNumeric.Size = new System.Drawing.Size(229, 22);
            this.columnNumeric.TabIndex = 0;
            this.columnNumeric.ValueChanged += new System.EventHandler(this.columnNumeric_ValueChanged);
            // 
            // BarGraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 830);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.barGraphGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(856, 530);
            this.Name = "BarGraphForm";
            this.Text = "Bar Graph";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.barGraphGroupBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.columnNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buildGraphBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox columnComboBox;
        private System.Windows.Forms.GroupBox barGraphGroupBox;
        private LiveCharts.WinForms.CartesianChart liveBarGraph;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label medianLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label deviationLabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label dispersionLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown columnNumeric;
    }
}