using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjectLibrary;

namespace TaskManagerApp
{
    /// <summary>
    /// Форма для изменения названия проекта.
    /// </summary>
    public partial class ChangeProjectNameForm : Form
    {
        Project currentProject;
        public Action UpdateSelectedProjectName;
        public ChangeProjectNameForm()
        {
            InitializeComponent();
        }

        public void ShowDialog(Project proj)
        {
            currentProject = proj;
            nameTextBox.Text = proj.Name;

            this.ShowDialog();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                currentProject.Name = nameTextBox.Text;
                UpdateSelectedProjectName?.Invoke();
                this.Close();
            }
            catch { }
        }


    }
}
