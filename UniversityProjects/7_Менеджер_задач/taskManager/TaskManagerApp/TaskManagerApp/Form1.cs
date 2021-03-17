using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjectLibrary;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Linq;



namespace TaskManagerApp
{
    public partial class Form1 : Form
    {

        List<Project> projectList;
        List<Artist> artistsList;

        
        NewProjectForm npf;
        addTaskToProj attp;
        NewArtistForm naf;
        EditEpicForm eef;
        EditStoryForm esf;
        AllArtistsForm aaf;
        EditTaskBugForm etbf;
        ChangeProjectNameForm cpnf;

        public Form1()
        {
            InitializeComponent();
            npf = new NewProjectForm();
            npf.NewProjectAction = AddNewProject;

            attp = new addTaskToProj();
            attp.UpdateSelectedProjectTasksList = UpdateSelectedProjectTasks;

            naf = new NewArtistForm();
            naf.AddNewArtistAction = AddNewArtist;

            eef = new EditEpicForm();
            EditEpicForm.UpdateCurrentTaskInfo = UpdateCurrentEpicInfo;

            esf = new EditStoryForm();
            esf.UpdateSelectedTask = UpdateSelectedStoryTaskOrBug;

            aaf = new AllArtistsForm();
            aaf.CheckDeletedArtists = CheckDeletedArtists;

            projectList = new List<Project>();
            artistsList = new List<Artist>();

            etbf = new EditTaskBugForm();
            etbf.UpdateSelectedTask = UpdateSelectedStoryTaskOrBug;

            cpnf = new ChangeProjectNameForm();
            cpnf.UpdateSelectedProjectName = UpdateProjectName;

            UploadData();

        }

        /// <summary>
        /// Обновление задачи Story, task, bug.
        /// </summary>
        private void UpdateSelectedStoryTaskOrBug()
        {
            try
            {
                var t = GetCurrentTask();
                if (t == null)
                    throw new Exception();
                if (t.Type == TaskType.Epic)
                {
                    UpdateCurrentEpicInfo();
                }
                else
                {
                    var curTaskNum = tasksListBox.SelectedIndex;

                    tasksListBox.Items.Clear();
                    foreach (var e in GetCurrentProject().ProjectTasks)
                        tasksListBox.Items.Add(e);

                    artistsListBox.Items.Clear();
                    foreach (var e in t)
                        artistsListBox.Items.Add(e);
                    tasksListBox.SelectedItem = tasksListBox.Items[curTaskNum];
                }
            }
            catch { }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Кнопка добавления нового проекта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewProjectButton_Click(object sender, EventArgs e)
        {
            npf.ShowDialog();     
        }

        /// <summary>
        /// Метод добавления нового проекта.
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="maxNumVal"></param>
        private void AddNewProject(string projectName, int maxNumVal)
        {
            try
            {
                var poj = new Project(projectName, maxNumVal);
                projectList.Add(poj);
                projectsListBox.Items.Add(poj.ToString());
            }
            catch { }

        }

        private void mainListView_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Событие, которое происходит при выборе другого проекта.
        /// При выборе другого проекта выводятся его задачи.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void projectsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateSelectedProjectTasks();
            }
            catch { }
        }

        /// <summary>
        /// Метод обновления листа с задачами.
        /// </summary>
        private void UpdateSelectedProjectTasks()
        {
            try
            {
                subtasksListBox.Items.Clear();
                artistsListBox.Items.Clear();
                tasksListBox.Items.Clear();
                var sp = projectList[projectsListBox.SelectedIndex];
                foreach (var x in sp)
                    tasksListBox.Items.Add(x);
            }
            catch { }
        }

        /// <summary>
        /// Добавление новой задачи в проект.
        /// </summary>
        /// <param name="sendr"></param>
        /// <param name="e"></param>
        public void addTaskMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                attp.ShowDialog(projectList[projectsListBox.SelectedIndex]);
            }
            catch
            {

            }
        }

        /// <summary>
        /// Метод удаления проекта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void removeProjMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                projectList.RemoveAt(projectsListBox.SelectedIndex);
                projectsListBox.Items.RemoveAt(projectsListBox.SelectedIndex);

                if (projectsListBox.Items.Count > 0)
                    projectsListBox.SelectedItem = projectsListBox.Items[projectsListBox.Items.Count - 1];
            }
            catch { }
        }

        /// <summary>
        /// Метод добавления нового пользователя.
        /// </summary>
        /// <param name="newArtist"></param>
        public void AddNewArtist(Artist newArtist)
        {
            try
            {
                var i = from e in artistsList
                        where e.Name == newArtist.Name
                        select e;
                if (i.Count() > 0 )
                    throw new Exception($"Artist with name {newArtist.Name} already exist");

                artistsList.Add(newArtist);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Нажатие на данную кнопку вызывает форму добавления нового пользователя-разработчика.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void newArtistButton_Click(object sender, EventArgs e)
        {
            try
            {
                naf.ShowDialog();
            }
            catch { }
        }

        /// <summary>
        /// Обновление информации по выбанной Epic задаче.
        /// </summary>
        private void UpdateCurrentEpicInfo()
        {
            try
            {
                tasksListBox_SelectedIndexChanged(eef, null);
                var curTaskNum = tasksListBox.SelectedIndex;

                tasksListBox.Items.Clear();
                foreach (var e in GetCurrentProject().ProjectTasks)
                    tasksListBox.Items.Add(e);

                tasksListBox.SelectedItem = tasksListBox.Items[curTaskNum];
            }
            catch { }
        }

        /// <summary>
        /// Изменение выбранной задачию.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tasksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            subtasksListBox.Items.Clear();
            artistsListBox.Items.Clear();
            try
            {
                var curT = GetCurrentTask();
                if (curT == null)
                    throw new Exception();

                if (curT.Type == TaskType.Epic)
                {
                    foreach (var st in curT)
                        subtasksListBox.Items.Add(st);
                }
                else
                {
                    foreach (var st in curT)
                        artistsListBox.Items.Add(st);
                }
            }
            catch { }
            
        }

        /// <summary>
        /// Кнопка, которая открывает окно редатирования задания.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void editTaskMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var curT = GetCurrentTask();
                if (curT == null)
                    throw new Exception();
                switch (curT.Type)
                {
                    case TaskType.Epic:
                        eef.ShowDialog((Epic)curT, artistsList);
                        break;
                    case TaskType.Story:
                        esf.ShowDialog((Story)curT, artistsList);
                        break;
                    case TaskType.Task:
                        etbf.ShowDialog((Task)curT, artistsList);
                        break;
                    case TaskType.Bug:
                        etbf.ShowDialog((Bug)curT, artistsList);
                        break;
                }
            }
            catch { }
        }

        /// <summary>
        /// Удаление задачи.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void deleteTaskMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var curP = GetCurrentProject();
                int j = tasksListBox.SelectedIndex;
                curP.RemoveTaskAt(j);
                tasksListBox.Items.RemoveAt(j);
            }
            catch { }
        }

        /// <summary>
        /// Возвращает текущую подзадачу.
        /// </summary>
        /// <returns></returns>
        private AbstractTask GetCurrentTask()
        {
            try
            {
                int i = projectsListBox.SelectedIndex;
                int j = tasksListBox.SelectedIndex;
                if (i == -1 || j == -1)
                    throw new ArgumentException("Firstly, choose task.");

                var curT = projectList[i].ProjectTasks[j];

                return curT;
            }
            catch
            {
                return null;
            }
            
        }

        /// <summary>
        /// Получить выбранную подзадачу.
        /// </summary>
        /// <returns></returns>
        private MediumTask GetCurrentSubtask()
        {
            try
            {
                if (subtasksListBox.SelectedIndex == -1)
                    throw new Exception();

                var curT = (Epic)GetCurrentTask();
                return curT.SubTasks[subtasksListBox.SelectedIndex];
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Возвращает текущий проект.
        /// </summary>
        /// <returns></returns>
        private Project GetCurrentProject()
        {
            try
            {
                int i = projectsListBox.SelectedIndex;
                if (i == -1)
                    throw new Exception();
                var curP = projectList[i];
                return curP;
            }
            catch { return null; }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        /// <summary>
        /// Сериализация.
        /// </summary>
        private void SaveData()
        {
            try
            {
                var bf = new BinaryFormatter();
                var fs = new FileStream(@"appData", FileMode.Create, FileAccess.Write);

                bf.Serialize(fs, artistsList);
                bf.Serialize(fs, projectList);

                fs.Close();
            }
            catch { }
        }

        /// <summary>
        /// Десериализация.
        /// </summary>
        private void UploadData()
        {
            try
            {
                var bf = new BinaryFormatter();
                var fs = new FileStream(@"appData", FileMode.Open, FileAccess.Read);

                artistsList = (List<Artist>)bf.Deserialize(fs);
                projectList = (List<Project>)bf.Deserialize(fs);
                fs.Close();

                foreach (var e in projectList)
                {
                    e.UpdateArtistsLinks(artistsList);
                    projectsListBox.Items.Add(e);
                }
            }
            catch { }
        }

        /// <summary>
        /// Изменение выбранной подзадачи.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void subtasksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                artistsListBox.Items.Clear();
                var i = subtasksListBox.SelectedIndex;
                if (i == -1)
                    throw new Exception();
                artistsListBox.Items.Clear();
                var curSt = GetCurrentSubtask();
                if (curSt == null)
                    throw new Exception();

                foreach (var el in curSt)
                    artistsListBox.Items.Add(el);
            }
            catch { }
        }

        /// <summary>
        /// Вызов формы для просмотра всех пользователей.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void allArtistsButton_Click(object sender, EventArgs e)
        {
            try
            {
                aaf.ShowDialog(artistsList);
            }
            catch { }
        }

        /// <summary>
        /// Метод очистки задач от удаленных артистов.
        /// </summary>
        /// <param name="deletedArtisrs"></param>
        private void CheckDeletedArtists(List<Artist> deletedArtisrs)
        {
            try
            {
                foreach (var e in projectList)
                {
                    e.CheckDeletedArtists(deletedArtisrs);
                }
                UpdateSelectedStoryTaskOrBug();
            }
            catch { }
        }

        /// <summary>
        /// Кнопка контекстного меню, при нажатии на которую 
        /// появляется форма изменения названия проекта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeProjNameMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var i = projectsListBox.SelectedIndex;
                if (i == -1)
                    throw new Exception();

                cpnf.ShowDialog(projectList[i]);
            }
            catch { }
        }

        /// <summary>
        /// Обновление названия проекта.
        /// </summary>
        private void UpdateProjectName()
        {
            try
            {
                var i = projectsListBox.SelectedIndex;

                projectsListBox.Items.Clear();
                foreach (var x in projectList)
                    projectsListBox.Items.Add(x);

                projectsListBox.SelectedItem = projectsListBox.Items[i];
            }
            catch { }
        }

        /// <summary>
        /// Сортировка.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sortByStatusButton_Click(object sender, EventArgs e)
        {
            try 
            {
                var i = projectsListBox.SelectedIndex;
                if (i == -1)
                    throw new Exception("Choose project first");
                projectList[i].SortTasksByStatus();
                tasksListBox.Items.Clear();
                foreach (var k in projectList[i])
                    tasksListBox.Items.Add(k);

            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
