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
    /// Форма для редактирования задачи Epic.
    /// </summary>
    public partial class EditEpicForm : Form
    {
        public static Action UpdateCurrentTaskInfo;

        private AddSubtaskForm asf;
        private EditStoryForm esf;
        private EditTaskBugForm etbf;

        Epic currentTask;

        List<Artist> artistsList;
        public EditEpicForm()
        {
            InitializeComponent();
            asf = new AddSubtaskForm();
            asf.AddSubtask = AddSubtask;

            esf = new EditStoryForm();
            etbf = new EditTaskBugForm();
            
        }

        /// <summary>
        /// Отрисовка формы как диалогового окна.
        /// </summary>
        /// <param name="epicTask">
        /// Задача Epic.
        /// </param>
        /// <param name="artists">
        /// Список разработчиков.
        /// </param>
        public void ShowDialog(Epic epicTask, List<Artist> artists)
        {
            try
            {
                artistsList = artists;
                currentTask = epicTask;
                curNameLabel.Text = currentTask.Name;
                curTimeLabel.Text = currentTask.StartTime.ToString();
                int i = 0;
                switch (currentTask.Status)
                {
                    case TaskStatus.Opened:
                        i = 0;
                        break;
                    case TaskStatus.WorkInProgress:
                        i = 1;
                        break;
                    case TaskStatus.Done:
                        i = 2;
                        break;
                }
                statusComboBox.SelectedItem = statusComboBox.Items[i];

                subtasksListBox.Items.Clear();
                foreach (var e in currentTask)
                    subtasksListBox.Items.Add(e);
            }
            catch { }

            this.ShowDialog();

        }

        /// <summary>
        /// Изменение статуса задачи.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TaskStatus i = TaskStatus.Opened;
                switch (statusComboBox.SelectedIndex)
                {
                    case 0:
                        i = TaskStatus.Opened;
                        break;
                    case 1:
                        i = TaskStatus.WorkInProgress;
                        break;
                    case 2:
                        i = TaskStatus.Done;
                        break;
                }

                currentTask.Status = i;
            }
            catch { }
        }

        /// <summary>
        /// Нажатие на кнопку ок, выход из прилжения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            UpdateCurrentTaskInfo?.Invoke();
            this.Close();
        }

        /// <summary>
        /// Нажатие на кнопку добавления подзадачи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addSubtaskButton_Click(object sender, EventArgs e)
        {
            asf.ShowDialog();
        }

        /// <summary>
        /// Метод добавления подзадачи.
        /// </summary>
        /// <param name="newSubtask"></param>
        public void AddSubtask(MediumTask newSubtask)
        {
            currentTask.AddSubTask(newSubtask);
            subtasksListBox.Items.Add(newSubtask);
        }

        /// <summary>
        /// Настройка подзадачи.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editMenuItem_Click(object sender, EventArgs e)
        {
            try 
            {
                var i = subtasksListBox.SelectedIndex;
                if (i == -1)
                    throw new Exception();

                var t = currentTask.SubTasks[i];
                switch (t.Type)
                {
                    case TaskType.Story:
                        esf.ShowDialog((Story)t, artistsList);
                        break;
                    case TaskType.Task:
                        etbf.ShowDialog((Task)t, artistsList);
                        break;
                    default: throw new Exception();
                }
            }
            catch { }
        }

        /// <summary>
        /// Удалаение подзадачи.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var i = subtasksListBox.SelectedIndex;
                if (i == -1)
                    throw new Exception();
                currentTask.RemoveSubTaskAt(i);
                subtasksListBox.Items.RemoveAt(i);
            }
            catch { }
        }


    }
}
