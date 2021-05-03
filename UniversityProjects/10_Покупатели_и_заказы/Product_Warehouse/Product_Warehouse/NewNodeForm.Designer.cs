
namespace Product_Warehouse
{
    partial class NewNodeForm
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
            this.categoryNameTb = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.categoryNameGb = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.categoryNameGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryNameTb
            // 
            this.categoryNameTb.Location = new System.Drawing.Point(6, 21);
            this.categoryNameTb.MaxLength = 50;
            this.categoryNameTb.Name = "categoryNameTb";
            this.categoryNameTb.Size = new System.Drawing.Size(183, 22);
            this.categoryNameTb.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 49);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(114, 49);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // categoryNameGb
            // 
            this.categoryNameGb.Controls.Add(this.categoryNameTb);
            this.categoryNameGb.Controls.Add(this.cancelButton);
            this.categoryNameGb.Controls.Add(this.addButton);
            this.categoryNameGb.Location = new System.Drawing.Point(12, 5);
            this.categoryNameGb.Name = "categoryNameGb";
            this.categoryNameGb.Size = new System.Drawing.Size(207, 78);
            this.categoryNameGb.TabIndex = 4;
            this.categoryNameGb.TabStop = false;
            this.categoryNameGb.Text = "Name:";
            // 
            // NewNodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(234, 95);
            this.Controls.Add(this.categoryNameGb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewNodeForm";
            this.Text = "New Node";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewNodeForm_FormClosing);
            this.Load += new System.EventHandler(this.NewNodeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.categoryNameGb.ResumeLayout(false);
            this.categoryNameGb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox categoryNameTb;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox categoryNameGb;
    }
}