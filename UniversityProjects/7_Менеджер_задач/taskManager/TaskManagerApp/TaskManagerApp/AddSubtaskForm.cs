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
    /// Форма для добавления подзадачи.
    /// </summary>
    public partial class AddSubtaskForm : Form
    {
        /// <summary>
        /// Событие добавления подзадачи.
        /// </summary>
        public Action<MediumTask> AddSubtask;

        public AddSubtaskForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Создание новой подзадачи и вызов события.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (typeComboBox.SelectedIndex == -1)
                    throw new Exception("You haven't chose task type");
                MediumTask subtask;
                switch (typeComboBox.SelectedItem.ToString())
                {
                    case "Story":
                        subtask = new Story(taskNameTextBox.Text);
                        break;
                    case "Task":
                        subtask = new Task(taskNameTextBox.Text);
                        break;
                    default:
                        throw new Exception();
                }
                AddSubtask?.Invoke(subtask);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddSubtaskForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            taskNameTextBox.Text = "";
        }
    }
}
