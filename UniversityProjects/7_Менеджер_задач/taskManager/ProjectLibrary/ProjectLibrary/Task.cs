using System;

namespace ProjectLibrary
{
    /// <summary>
    /// Класс задачи task.
    /// </summary>
    [Serializable]
    public sealed class Task: MediumTask, IAssignable
    {
        /// <summary>
        /// Задача Task.
        /// </summary>
        /// <param name="name">
        /// Название задачи.
        /// </param>
        public Task(string name): base(name)
        {
            type = TaskType.Task;
        }

        public override void AddArtist(Artist newArtist)
        {
            if (artists.Count == 1)
                throw new ArgumentException($"This Task {this.Name} is full of artists. Delete artists if you want to add another.");
            else
                artists.Add(newArtist);
        }

        public override void RemoveArtistAt(int index)
        {
            try
            {
                artists.RemoveAt(index);
            }
            catch { }
        }

    }
}
