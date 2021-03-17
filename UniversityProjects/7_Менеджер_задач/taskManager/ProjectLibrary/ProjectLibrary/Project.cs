using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;


namespace ProjectLibrary
{
    /// <summary>
    /// Класс проекта.
    /// </summary>
    [Serializable]
    public class Project: IEnumerable, IEnumerator
    {
        
        
        /// <summary>
        /// Имя проекта.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Максимальное количество задач в проекте.
        /// </summary>
        public int MaxTaskNum { get; }

        /// <summary>
        /// Проект.
        /// </summary>
        /// <param name="name">
        /// Имя проекта.
        /// </param>
        /// <param name="maxTaskNum">
        /// Максимальное количество задач в проекте.
        /// </param>
        public Project(string name, int maxTaskNum)
        {
            Name = name;
            if(maxTaskNum == 0)
            {
                throw new ArgumentException("Num of project tasks shold be more than zero");
            }
            MaxTaskNum = maxTaskNum;
            projectTasks = new List<AbstractTask>();
        }

        List<AbstractTask> projectTasks;

        /// <summary>
        /// Список задач проекта.
        /// </summary>
        public List<AbstractTask> ProjectTasks {
            get { return projectTasks; } 
        }

        int position = -1;
        public object Current
        {
            get
            {
                if (position == -1 || position >= projectTasks.Count)
                    throw new InvalidOperationException();
                return projectTasks[position];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return projectTasks.GetEnumerator();
        }

        /// <summary>
        /// Метод для удаления задачи из проекта.
        /// </summary>
        /// <param name="index"></param>
        public void RemoveTaskAt(int index)
        {
            projectTasks.RemoveAt(index);
        }

        /// <summary>
        /// Метод для добавления задачи в проект.
        /// </summary>
        /// <param name="newTask"></param>
        public void AddTask(AbstractTask newTask)
        {
            if (projectTasks.Count == MaxTaskNum)
                throw new ArgumentException($"This project {Name} is full of tasks. Not Enought space \n remove few tasks if you want to add new.");
            else
                projectTasks.Add(newTask);
        }

        public override string ToString()
        {
            return $"{this.Name} ({projectTasks.Count}/{MaxTaskNum} tasks)" ;
        }

        public bool MoveNext()
        {
            if (position < projectTasks.Count - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            position = -1;   
        }

        /// <summary>
        /// Метод для удаления удаленных исполнителей.
        /// </summary>
        /// <param name="artists"></param>
        public void CheckDeletedArtists(List<Artist> deletedArtists)
        {
            try
            {
                foreach (var e in projectTasks)
                    e.CheckDeletedArtists(deletedArtists);
            }
            catch { }
        }

        /// <summary>
        /// Сортировка задач по статусу
        /// </summary>
        public void SortTasksByStatus()
        {
            var a = projectTasks.OrderBy(e => e.Status);
            projectTasks = a.ToList<AbstractTask>();
        }

        /// <summary>
        /// Метод для обновления ссылок после десериализации.
        /// </summary>
        /// <param name="al"></param>
        public void UpdateArtistsLinks(List<Artist> al)
        {
            try
            {
                foreach (var e in projectTasks)
                    e.UpdateArtistLinks(al);
            }
            catch { }
        }
    }
}
