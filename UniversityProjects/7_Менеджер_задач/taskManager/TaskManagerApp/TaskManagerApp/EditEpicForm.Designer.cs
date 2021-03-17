
namespace TaskManagerApp
{
    partial class EditEpicForm
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
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.curNameLabel = new System.Windows.Forms.Label();
            this.curTimeLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.subtasksGroupBox = new System.Windows.Forms.GroupBox();
            this.addSubtaskButton = new System.Windows.Forms.Button();
            this.subtasksListBox = new System.Windows.Forms.ListBox();
            this.subtasksContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okButton = new System.Windows.Forms.Button();
            this.infoGroupBox.SuspendLayout();
            this.subtasksGroupBox.SuspendLayout();
            this.subtasksContextMenu.SuspendLayout();
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
            this.infoGroupBox.TabIndex = 0;
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
            // subtasksGroupBox
            // 
            this.subtasksGroupBox.Controls.Add(this.addSubtaskButton);
            this.subtasksGroupBox.Controls.Add(this.subtasksListBox);
            this.subtasksGroupBox.Location = new System.Drawing.Point(448, 12);
            this.subtasksGroupBox.Name = "subtasksGroupBox";
            this.subtasksGroupBox.Size = new System.Drawing.Size(340, 429);
            this.subtasksGroupBox.TabIndex = 1;
            this.subtasksGroupBox.TabStop = false;
            this.subtasksGroupBox.Text = "Subtasks:";
            // 
            // addSubtaskButton
            // 
            this.addSubtaskButton.Location = new System.Drawing.Point(7, 394);
            this.addSubtaskButton.Name = "addSubtaskButton";
            this.addSubtaskButton.Size = new System.Drawing.Size(94, 29);
            this.addSubtaskButton.TabIndex = 1;
            this.addSubtaskButton.Text = "Add new";
            this.addSubtaskButton.UseVisualStyleBackColor = true;
            this.addSubtaskButton.Click += new System.EventHandler(this.addSubtaskButton_Click);
            // 
            // subtasksListBox
            // 
            this.subtasksListBox.ContextMenuStrip = this.subtasksContextMenu;
            this.subtasksListBox.FormattingEnabled = true;
            this.subtasksListBox.ItemHeight = 20;
            this.subtasksListBox.Location = new System.Drawing.Point(7, 27);
            this.subtasksListBox.Name = "subtasksListBox";
            this.subtasksListBox.Size = new System.Drawing.Size(327, 344);
            this.subtasksListBox.TabIndex = 0;
            // 
            // subtasksContextMenu
            // 
            this.subtasksContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.subtasksContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMenuItem,
            this.toolStripSeparator1,
            this.deleteMenuItem});
            this.subtasksContextMenu.Name = "subtasksContextMenu";
            this.subtasksContextMenu.Size = new System.Drawing.Size(123, 58);
            // 
            // editMenuItem
            // 
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(122, 24);
            this.editMenuItem.Text = "Edit";
            this.editMenuItem.Click += new System.EventHandler(this.editMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteMenuItem.Text = "Delete";
            this.deleteMenuItem.Click += new System.EventHandler(this.deleteMenuItem_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(35, 406);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(94, 29);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // EditEpicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.subtasksGroupBox);
            this.Controls.Add(this.infoGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditEpicForm";
            this.Text = "Edit epic task";
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.subtasksGroupBox.ResumeLayout(false);
            this.subtasksContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.GroupBox subtasksGroupBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label curNameLabel;
        private System.Windows.Forms.Label curTimeLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Button addSubtaskButton;
        private System.Windows.Forms.ListBox subtasksListBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ContextMenuStrip subtasksContextMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
    }
}