
namespace TaskManagerApp
{
    partial class EditStoryForm
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
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.curNameLabel = new System.Windows.Forms.Label();
            this.curTimeLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.artistsListView = new System.Windows.Forms.ListView();
            this.saveButton = new System.Windows.Forms.Button();
            this.infoGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Controls.Add(this.curNameLabel);
            this.infoGroupBox.Controls.Add(this.curTimeLabel);
            this.infoGroupBox.Controls.Add(this.statusComboBox);
            this.infoGroupBox.Controls.Add(this.statusLabel);
            this.infoGroupBox.Controls.Add(this.startTimeLabel);
            this.infoGroupBox.Controls.Add(this.nameLabel);
            this.infoGroupBox.Location = new System.Drawing.Point(12, 12);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(361, 113);
            this.infoGroupBox.TabIndex = 1;
            this.infoGroupBox.TabStop = false;
            this.infoGroupBox.Text = "Info:";
            // 
            // curNameLabel
            // 
            this.curNameLabel.AutoSize = true;
            this.curNameLabel.Location = new System.Drawing.Point(65, 27);
            this.curNameLabel.Name = "curNameLabel";
            this.curNameLabel.Size = new System.Drawing.Size(15, 20);
            this.curNameLabel.TabIndex = 5;
            this.curNameLabel.Text = "_";
            // 
            // curTimeLabel
            // 
            this.curTimeLabel.AutoSize = true;
            this.curTimeLabel.Location = new System.Drawing.Point(91, 51);
            this.curTimeLabel.Name = "curTimeLabel";
            this.curTimeLabel.Size = new System.Drawing.Size(15, 20);
            this.curTimeLabel.TabIndex = 4;
            this.curTimeLabel.Text = "_";
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Opened",
            "Work in progress",
            "Done"});
            this.statusComboBox.Location = new System.Drawing.Point(64, 77);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(151, 28);
            this.statusComboBox.TabIndex = 3;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(6, 80);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(52, 20);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Status:";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(7, 51);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(77, 20);
            this.startTimeLabel.TabIndex = 1;
            this.startTimeLabel.Text = "Start time:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(7, 27);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.artistsListView);
            this.groupBox1.Location = new System.Drawing.Point(408, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 436);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Artists:";
            // 
            // artistsListView
            // 
            this.artistsListView.CheckBoxes = true;
            this.artistsListView.HideSelection = false;
            this.artistsListView.Location = new System.Drawing.Point(6, 26);
            this.artistsListView.Name = "artistsListView";
            this.artistsListView.Size = new System.Drawing.Size(384, 404);
            this.artistsListView.TabIndex = 0;
            this.artistsListView.UseCompatibleStateImageBehavior = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(137, 335);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 29);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // EditStoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 460);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.infoGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditStoryForm";
            this.Text = "Edit Story Form";
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.Label curNameLabel;
        private System.Windows.Forms.Label curTimeLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.ListView artistsListView;
        private System.Windows.Forms.Button saveButton;
    }
}