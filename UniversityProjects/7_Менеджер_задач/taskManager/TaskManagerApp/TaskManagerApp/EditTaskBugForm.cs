using System;
using System.Collections.Generic;
using ProjectLibrary;

namespace TaskManagerApp
{
    public partial class EditTaskBugForm : EditStoryForm
    {
        
        public EditTaskBugForm()
        {
            InitializeComponent();
        }

        public void ShowDialog(Bug bugTask, List<Artist> artists)
        {
            artistsList = artists;
            current = bugTask;
            SetForm(current);

            this.ShowDialog();
        }

        
        public void ShowDialog(Task task, List<Artist> artists)
        {
            artistsList = artists;
            current = task;
            base.SetForm(current);

            this.ShowDialog();
        }

        protected override void saveButton_Click(object sender, EventArgs e)
        {
            base.saveButton_Click(sender, e);
        }

        
    }
}
