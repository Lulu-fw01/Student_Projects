using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaskManagerApp
{
    /// <summary>
    /// Форма создания нового проекта.
    /// </summary>
    public partial class NewProjectForm : Form
    {
        public Action<string, int> NewProjectAction;
        public NewProjectForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            NewProjectAction?.Invoke(projectNameTextBox.Text, (int)taskNumNumeric.Value);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void NewProjectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            projectNameTextBox.Text = "";
            taskNumNumeric.Value = 1;
        }
    }
}
