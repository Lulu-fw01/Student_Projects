using System;

namespace ProjectLibrary
{

    /// <summary>
    /// Задача Bug.
    /// </summary>
    [Serializable]
    public sealed class Bug: Subtask, IAssignable
    {
        /// <summary>
        /// Баг.
        /// </summary>
        /// <param name="name">
        /// Название задачи.
        /// </param>
        public Bug(string name) : base(name)
        {
            type = TaskType.Bug;
        }

        public override void AddArtist(Artist newArtist)
        {
            if (artists.Count == 1)
                throw new ArgumentException($"This bug {this.Name} is full of artists. Delete artists if you want to add another.");
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
