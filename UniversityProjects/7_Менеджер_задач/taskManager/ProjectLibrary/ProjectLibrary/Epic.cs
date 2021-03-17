using System;
using System.Collections.Generic;
using System.Collections;

namespace ProjectLibrary
{
    /// <summary>
    /// Класс задачи Epic.
    /// </summary>
    [Serializable]
    public sealed class Epic: AbstractTask
    {
        /// <summary>
        /// Подзадачи.
        /// </summary>
        List<MediumTask> subTasks;

        /// <summary>
        /// Список подзадач.
        /// </summary>
        public List<MediumTask> SubTasks
        {
            get { return subTasks; }
        }


        /// <summary>
        /// Задача Epic.
        /// </summary>
        /// <param name="name">
        /// Название задачи.
        /// </param>
        public Epic(string name):base(name)
        {
            subTasks = new List<MediumTask>();
            type = TaskType.Epic;
        }

       



        /// <summary>
        /// Добавить подзадачу в Epic.
        /// </summary>
        /// <param name="newSubTask">
        /// Новая подзадача.
        /// </param>
        public void AddSubTask(MediumTask newSubTask)
        {
            subTasks.Add(newSubTask);
        }

        /// <summary>
        /// Удалить задачу по индексу.
        /// </summary>
        /// <param name="index">
        /// Индекс.
        /// </param>
        public void RemoveSubTaskAt(int index)
        {
            subTasks.RemoveAt(index);
        }



        public override object Current
        {
            get
            {
                if (position == -1 || position >= subTasks.Count)
                    throw new InvalidOperationException();
                return subTasks[position];
            }
        }

        public override IEnumerator GetEnumerator()
        {
            return subTasks.GetEnumerator();
        }

        public override bool MoveNext()
        {
            if (position < subTasks.Count - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }

        public override void Reset()
        {
            position = -1;
        }

        public override void CheckDeletedArtists(List<Artist> deletedArtists)
        {
            try
            {
                foreach (var e in subTasks)
                    e.CheckDeletedArtists(deletedArtists);
            }
            catch { }
        }

        public override void UpdateArtistLinks(List<Artist> updatedArtits)
        {
            try
            {
                foreach (var e in subTasks)
                    e.UpdateArtistLinks(updatedArtits);
            }
            catch { }
        }
    }
}
