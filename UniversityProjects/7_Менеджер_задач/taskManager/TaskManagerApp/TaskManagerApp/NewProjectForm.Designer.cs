
namespace TaskManagerApp
{
    partial class NewProjectForm
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
            this.taskNumNumeric = new System.Windows.Forms.NumericUpDown();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.numLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taskNumNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // taskNumNumeric
            // 
            this.taskNumNumeric.Location = new System.Drawing.Point(391, 61);
            this.taskNumNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.taskNumNumeric.Name = "taskNumNumeric";
            this.taskNumNumeric.Size = new System.Drawing.Size(150, 27);
            this.taskNumNumeric.TabIndex = 0;
            this.taskNumNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.Location = new System.Drawing.Point(70, 61);
            this.projectNameTextBox.MaxLength = 40;
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(172, 27);
            this.projectNameTextBox.TabIndex = 1;
            this.projectNameTextBox.WordWrap = false;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(148, 156);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(94, 29);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(303, 156);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 29);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 64);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 20);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name:";
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Location = new System.Drawing.Point(287, 63);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(98, 20);
            this.numLabel.TabIndex = 5;
            this.numLabel.Text = "Num of tasks:";
            // 
            // NewProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 220);
            this.Controls.Add(this.numLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.projectNameTextBox);
            this.Controls.Add(this.taskNumNumeric);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewProjectForm";
            this.ShowIcon = false;
            this.Text = "New Project";
            
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewProjectForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.taskNumNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown taskNumNumeric;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label numLabel;
    }
}