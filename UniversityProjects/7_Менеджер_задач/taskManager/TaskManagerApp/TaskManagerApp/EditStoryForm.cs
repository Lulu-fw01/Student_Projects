using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjectLibrary;
using System.Linq;

namespace TaskManagerApp
{
    /// <summary>
    /// Форма для редактирования Story.
    /// </summary>
    public partial class EditStoryForm : Form
    {
        protected Subtask current;
        protected List<Artist> artistsList;

        public Action UpdateSelectedTask;

        public EditStoryForm()
        {
            InitializeComponent();
            
        }

        public void ShowDialog(Story story, List<Artist> artists)
        {
            current = story;
            artistsList = artists;

            SetForm(current);

            this.ShowDialog();
        }

        /// <summary>
        /// Настройка формы.
        /// </summary>
        /// <param name="t"></param>
        protected void SetForm(Subtask t)
        {
            try
            {
                artistsListView.Items.Clear();

                curNameLabel.Text = t.Name;
                curTimeLabel.Text = t.StartTime.ToString();
                int i = 0;
                switch (t.Status)
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

                foreach (var e in artistsList)
                    artistsListView.Items.Add(e.ToString());

                for (int j = 0; j < artistsList.Count; j++)
                {
                    if (t.Artists.Contains(artistsList[j]))
                        artistsListView.Items[j].Checked = true;
                }
            }
            catch { }
        }

      

        /// <summary>
        /// Нажатие кнопки сохранить. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                current.Artists.Clear();
                for (int i = 0; i < artistsListView.Items.Count; i++)
                {
                    if (artistsListView.Items[i].Checked == true)
                        current.AddArtist(artistsList[i]);
                }

                UpdateSelectedTask?.Invoke();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Изменение состояния задачи.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
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

            current.Status = i;
        }
    }
}
