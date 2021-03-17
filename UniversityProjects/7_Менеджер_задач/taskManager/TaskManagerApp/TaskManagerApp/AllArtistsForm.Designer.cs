
namespace TaskManagerApp
{
    partial class AllArtistsForm
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
            this.artistsListBox = new System.Windows.Forms.ListBox();
            this.artistsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.okButton = new System.Windows.Forms.Button();
            this.addNewButton = new System.Windows.Forms.Button();
            this.artistsContextMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // artistsListBox
            // 
            this.artistsListBox.ContextMenuStrip = this.artistsContextMenu;
            this.artistsListBox.FormattingEnabled = true;
            this.artistsListBox.ItemHeight = 20;
            this.artistsListBox.Location = new System.Drawing.Point(6, 26);
            this.artistsListBox.Name = "artistsListBox";
            this.artistsListBox.Size = new System.Drawing.Size(366, 344);
            this.artistsListBox.TabIndex = 0;
            // 
            // artistsContextMenu
            // 
            this.artistsContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.artistsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteMenuItem});
            this.artistsContextMenu.Name = "artistsContextMenu";
            this.artistsContextMenu.Size = new System.Drawing.Size(123, 28);
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteMenuItem.Text = "Delete";
            this.deleteMenuItem.Click += new System.EventHandler(this.deleteMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.artistsListBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 375);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Artists:";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(453, 302);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(94, 29);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // addNewButton
            // 
            this.addNewButton.Location = new System.Drawing.Point(453, 256);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(94, 29);
            this.addNewButton.TabIndex = 4;
            this.addNewButton.Text = "Add new artist";
            this.addNewButton.UseVisualStyleBackColor = true;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // AllArtistsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 400);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AllArtistsForm";
            this.Text = "All artists";
            this.artistsContextMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox artistsListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip artistsContextMenu;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
    }
}