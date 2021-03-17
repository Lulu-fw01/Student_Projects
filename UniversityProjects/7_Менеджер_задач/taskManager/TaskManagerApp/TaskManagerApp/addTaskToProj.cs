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
    /// Форма для добавления задачи в проект.
    /// </summary>
    public partial class addTaskToProj : Form
    {
        Project currentProj;
        public Action UpdateSelectedProjectTasksList;

        public addTaskToProj()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (typeComboBox.SelectedIndex == -1)
                    throw new Exception("You haven't chose task type");
                switch (typeComboBox.SelectedItem.ToString())
                {
                    case "Epic":
                        currentProj.AddTask(new Epic(taskNameTextBox.Text));
                        break;
                    case "Story":
                        currentProj.AddTask(new Story(taskNameTextBox.Text));
                        break;
                    case "Task":
                        currentProj.AddTask(new Task(taskNameTextBox.Text));
                        break;
                    case "Bug":
                        currentProj.AddTask(new Bug(taskNameTextBox.Text));
                        break;
                    default:
                        throw new Exception();
                }
                UpdateSelectedProjectTasksList?.Invoke();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void ShowDialog(Project proj)
        {
            try
            {
                currentProj = proj;
                this.ShowDialog();
            }
            catch { }
        }

        private void addTaskToProj_FormClosed(object sender, FormClosedEventArgs e)
        {
            taskNameTextBox.Text = "";
        }
    }
}
