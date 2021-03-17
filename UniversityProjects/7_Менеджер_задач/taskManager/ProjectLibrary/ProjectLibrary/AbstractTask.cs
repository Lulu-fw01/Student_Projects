using System;
using System.Collections.Generic;
using System.Collections;

namespace ProjectLibrary
{
    /// <summary>
    /// Базовый класс задач.
    /// </summary>
    [Serializable]
    public abstract class AbstractTask: IEnumerable, IEnumerator
    {
        /// <summary>
        /// Имя задачи.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Время создания задачи.
        /// </summary>
        public DateTime StartTime { get; }
        /// <summary>
        /// Статус задачи.
        /// </summary>
        public TaskStatus Status { get; set; }
        /// <summary>
        /// Задача, абстрактный класс.
        /// </summary>
        /// <param name="name">
        /// Имя задачи.
        /// </param>
        public AbstractTask(string name)
        {
            Name = name;
            StartTime = DateTime.Now;
            Status = TaskStatus.Opened;
        }
        /// <summary>
        /// Тип задачи.
        /// </summary>
        protected TaskType type;
        /// <summary>
        /// Тип таска.
        /// Epic Task Story Bug .
        /// </summary>
        public TaskType Type { get => type; }

        public override string ToString()
        {

            return $"{Name} ({type}, {Status} {StartTime.ToShortDateString()})";
        }

        protected int position = -1;
        public abstract object Current { get; }
        public abstract IEnumerator GetEnumerator();
        public abstract bool MoveNext();
        public abstract void Reset();

        /// <summary>
        /// Метод для удаления исполнителей.
        /// </summary>
        /// <param name="artists"></param>
        public abstract void CheckDeletedArtists(List<Artist> deletedArtists);

        /// <summary>
        /// Метод для обновления ссылок на Исполнителей.
        /// </summary>
        /// <param name="updatedArtits"></param>
        public abstract void UpdateArtistLinks(List<Artist> updatedArtits);
    }

    /// <summary>
    /// Перечисление статусов задачи.
    /// </summary>
    [Serializable]
    public enum TaskStatus { Opened, WorkInProgress, Done };

    /// <summary>
    /// Перечисление типов задач.
    /// </summary>
    [Serializable]
    public enum TaskType {Epic, Story, Task, Bug };

}
