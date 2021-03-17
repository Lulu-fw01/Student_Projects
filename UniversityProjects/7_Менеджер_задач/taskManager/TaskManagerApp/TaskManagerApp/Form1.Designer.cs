
namespace TaskManagerApp
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewProjectButton = new System.Windows.Forms.ToolStripButton();
            this.newArtistButton = new System.Windows.Forms.ToolStripButton();
            this.allArtistsButton = new System.Windows.Forms.ToolStripButton();
            this.sortByStatusButton = new System.Windows.Forms.ToolStripButton();
            this.projListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addTaskMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeProjNameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.removeProjMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectGroupBox = new System.Windows.Forms.GroupBox();
            this.projectsListBox = new System.Windows.Forms.ListBox();
            this.tasksContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editTaskMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sep = new System.Windows.Forms.ToolStripSeparator();
            this.deleteTaskMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subtasksGroupBox = new System.Windows.Forms.GroupBox();
            this.subtasksListBox = new System.Windows.Forms.ListBox();
            this.artistsGroupBox = new System.Windows.Forms.GroupBox();
            this.artistsListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tasksListBox = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.projListContextMenu.SuspendLayout();
            this.projectGroupBox.SuspendLayout();
            this.tasksContextMenu.SuspendLayout();
            this.subtasksGroupBox.SuspendLayout();
            this.artistsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewProjectButton,
            this.newArtistButton,
            this.allArtistsButton,
            this.sortByStatusButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NewProjectButton
            // 
            this.NewProjectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewProjectButton.Image = ((System.Drawing.Image)(resources.GetObject("NewProjectButton.Image")));
            this.NewProjectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewProjectButton.Name = "NewProjectButton";
            this.NewProjectButton.Size = new System.Drawing.Size(29, 24);
            this.NewProjectButton.Text = "New Project";
            this.NewProjectButton.Click += new System.EventHandler(this.NewProjectButton_Click);
            // 
            // newArtistButton
            // 
            this.newArtistButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newArtistButton.Image = ((System.Drawing.Image)(resources.GetObject("newArtistButton.Image")));
            this.newArtistButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newArtistButton.Name = "newArtistButton";
            this.newArtistButton.Size = new System.Drawing.Size(29, 24);
            this.newArtistButton.Text = "Add new artist";
            this.newArtistButton.Click += new System.EventHandler(this.newArtistButton_Click);
            // 
            // allArtistsButton
            // 
            this.allArtistsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.allArtistsButton.Image = ((System.Drawing.Image)(resources.GetObject("allArtistsButton.Image")));
            this.allArtistsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.allArtistsButton.Name = "allArtistsButton";
            this.allArtistsButton.Size = new System.Drawing.Size(29, 24);
            this.allArtistsButton.Text = "All artists";
            this.allArtistsButton.Click += new System.EventHandler(this.allArtistsButton_Click);
            // 
            // sortByStatusButton
            // 
            this.sortByStatusButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sortByStatusButton.Image = ((System.Drawing.Image)(resources.GetObject("sortByStatusButton.Image")));
            this.sortByStatusButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sortByStatusButton.Name = "sortByStatusButton";
            this.sortByStatusButton.Size = new System.Drawing.Size(29, 24);
            this.sortByStatusButton.Text = "Sort by status";
            this.sortByStatusButton.Click += new System.EventHandler(this.sortByStatusButton_Click);
            // 
            // projListContextMenu
            // 
            this.projListContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.projListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTaskMenuItem,
            this.changeProjNameMenuItem,
            this.toolStripSeparator1,
            this.removeProjMenuItem});
            this.projListContextMenu.Name = "mainListContextMenu";
            this.projListContextMenu.Size = new System.Drawing.Size(221, 82);
            // 
            // addTaskMenuItem
            // 
            this.addTaskMenuItem.Name = "addTaskMenuItem";
            this.addTaskMenuItem.Size = new System.Drawing.Size(220, 24);
            this.addTaskMenuItem.Text = "Add task to project";
            this.addTaskMenuItem.Click += new System.EventHandler(this.addTaskMenuItem_Click);
            // 
            // changeProjNameMenuItem
            // 
            this.changeProjNameMenuItem.Name = "changeProjNameMenuItem";
            this.changeProjNameMenuItem.Size = new System.Drawing.Size(220, 24);
            this.changeProjNameMenuItem.Text = "Change project name";
            this.changeProjNameMenuItem.Click += new System.EventHandler(this.ChangeProjNameMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(217, 6);
            // 
            // removeProjMenuItem
            // 
            this.removeProjMenuItem.Name = "removeProjMenuItem";
            this.removeProjMenuItem.Size = new System.Drawing.Size(220, 24);
            this.removeProjMenuItem.Text = "Remove project";
            this.removeProjMenuItem.Click += new System.EventHandler(this.removeProjMenuItem_Click);
            // 
            // projectGroupBox
            // 
            this.projectGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.projectGroupBox.Controls.Add(this.projectsListBox);
            this.projectGroupBox.Font = new System.Drawing.Font("Exotc350 Bd BT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.projectGroupBox.Location = new System.Drawing.Point(0, 30);
            this.projectGroupBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.projectGroupBox.Name = "projectGroupBox";
            this.projectGroupBox.Size = new System.Drawing.Size(223, 408);
            this.projectGroupBox.TabIndex = 9;
            this.projectGroupBox.TabStop = false;
            this.projectGroupBox.Text = "Projects:";
            // 
            // projectsListBox
            // 
            this.projectsListBox.ContextMenuStrip = this.projListContextMenu;
            this.projectsListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.projectsListBox.FormattingEnabled = true;
            this.projectsListBox.ItemHeight = 20;
            this.projectsListBox.Location = new System.Drawing.Point(0, 26);
            this.projectsListBox.Name = "projectsListBox";
            this.projectsListBox.Size = new System.Drawing.Size(223, 364);
            this.projectsListBox.TabIndex = 0;
            this.projectsListBox.SelectedIndexChanged += new System.EventHandler(this.projectsListBox_SelectedIndexChanged);
            // 
            // tasksContextMenu
            // 
            this.tasksContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tasksContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTaskMenuItem,
            this.sep,
            this.deleteTaskMenuItem});
            this.tasksContextMenu.Name = "tasksContextMenu";
            this.tasksContextMenu.Size = new System.Drawing.Size(153, 58);
            // 
            // editTaskMenuItem
            // 
            this.editTaskMenuItem.Name = "editTaskMenuItem";
            this.editTaskMenuItem.Size = new System.Drawing.Size(152, 24);
            this.editTaskMenuItem.Text = "Edit task";
            this.editTaskMenuItem.Click += new System.EventHandler(this.editTaskMenuItem_Click);
            // 
            // sep
            // 
            this.sep.Name = "sep";
            this.sep.Size = new System.Drawing.Size(149, 6);
            // 
            // deleteTaskMenuItem
            // 
            this.deleteTaskMenuItem.Name = "deleteTaskMenuItem";
            this.deleteTaskMenuItem.Size = new System.Drawing.Size(152, 24);
            this.deleteTaskMenuItem.Text = "Delete task";
            this.deleteTaskMenuItem.Click += new System.EventHandler(this.deleteTaskMenuItem_Click);
            // 
            // subtasksGroupBox
            // 
            this.subtasksGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.subtasksGroupBox.Controls.Add(this.subtasksListBox);
            this.subtasksGroupBox.Font = new System.Drawing.Font("Exotc350 Bd BT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subtasksGroupBox.Location = new System.Drawing.Point(485, 30);
            this.subtasksGroupBox.Name = "subtasksGroupBox";
            this.subtasksGroupBox.Size = new System.Drawing.Size(250, 408);
            this.subtasksGroupBox.TabIndex = 11;
            this.subtasksGroupBox.TabStop = false;
            this.subtasksGroupBox.Text = "subtasks:";
            // 
            // subtasksListBox
            // 
            this.subtasksListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.subtasksListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subtasksListBox.FormattingEnabled = true;
            this.subtasksListBox.ItemHeight = 20;
            this.subtasksListBox.Location = new System.Drawing.Point(0, 26);
            this.subtasksListBox.Name = "subtasksListBox";
            this.subtasksListBox.Size = new System.Drawing.Size(250, 364);
            this.subtasksListBox.TabIndex = 0;
            this.subtasksListBox.SelectedIndexChanged += new System.EventHandler(this.subtasksListBox_SelectedIndexChanged);
            // 
            // artistsGroupBox
            // 
            this.artistsGroupBox.Controls.Add(this.artistsListBox);
            this.artistsGroupBox.Font = new System.Drawing.Font("Exotc350 Bd BT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.artistsGroupBox.Location = new System.Drawing.Point(741, 30);
            this.artistsGroupBox.Name = "artistsGroupBox";
            this.artistsGroupBox.Size = new System.Drawing.Size(250, 408);
            this.artistsGroupBox.TabIndex = 12;
            this.artistsGroupBox.TabStop = false;
            this.artistsGroupBox.Text = "Artists:";
            // 
            // artistsListBox
            // 
            this.artistsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.artistsListBox.Font = new System.Drawing.Font("NewsGoth BT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.artistsListBox.FormattingEnabled = true;
            this.artistsListBox.ItemHeight = 21;
            this.artistsListBox.Location = new System.Drawing.Point(0, 26);
            this.artistsListBox.Name = "artistsListBox";
            this.artistsListBox.Size = new System.Drawing.Size(250, 361);
            this.artistsListBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tasksListBox);
            this.groupBox1.Location = new System.Drawing.Point(229, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.groupBox1.Size = new System.Drawing.Size(250, 408);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tasks:";
            // 
            // tasksListBox
            // 
            this.tasksListBox.ContextMenuStrip = this.tasksContextMenu;
            this.tasksListBox.FormattingEnabled = true;
            this.tasksListBox.ItemHeight = 20;
            this.tasksListBox.Location = new System.Drawing.Point(0, 26);
            this.tasksListBox.Name = "tasksListBox";
            this.tasksListBox.Size = new System.Drawing.Size(250, 364);
            this.tasksListBox.TabIndex = 0;
            this.tasksListBox.SelectedIndexChanged += new System.EventHandler(this.tasksListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.artistsGroupBox);
            this.Controls.Add(this.subtasksGroupBox);
            this.Controls.Add(this.projectGroupBox);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Task manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.projListContextMenu.ResumeLayout(false);
            this.projectGroupBox.ResumeLayout(false);
            this.tasksContextMenu.ResumeLayout(false);
            this.subtasksGroupBox.ResumeLayout(false);
            this.artistsGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NewProjectButton;
        private System.Windows.Forms.ContextMenuStrip projListContextMenu;
        private System.Windows.Forms.GroupBox projectGroupBox;
        private System.Windows.Forms.GroupBox subtasksGroupBox;
        private System.Windows.Forms.ToolStripMenuItem addTaskMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem removeProjMenuItem;
        private System.Windows.Forms.ToolStripButton newArtistButton;
        private System.Windows.Forms.ContextMenuStrip tasksContextMenu;
        private System.Windows.Forms.ToolStripMenuItem editTaskMenuItem;
        private System.Windows.Forms.ToolStripSeparator sep;
        private System.Windows.Forms.ToolStripMenuItem deleteTaskMenuItem;
        private System.Windows.Forms.GroupBox artistsGroupBox;
        private System.Windows.Forms.ListBox artistsListBox;
        private System.Windows.Forms.ListBox subtasksListBox;
        private System.Windows.Forms.ListBox projectsListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox tasksListBox;
        private System.Windows.Forms.ToolStripButton allArtistsButton;
        private System.Windows.Forms.ToolStripMenuItem changeProjNameMenuItem;
        private System.Windows.Forms.ToolStripButton sortByStatusButton;
    }
}

