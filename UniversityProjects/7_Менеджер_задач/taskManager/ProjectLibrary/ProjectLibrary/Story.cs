using System;


namespace ProjectLibrary
{
    /// <summary>
    /// Класс задачи Story.
    /// </summary>
    [Serializable]
    public sealed class Story: MediumTask, IAssignable
    {
        /// <summary>
        /// Задача Story.
        /// </summary>
        /// <param name="name">
        /// Название задачи.</param>
        public Story(string name) : base(name)
        {
            type = TaskType.Story;  
        }

        public override void AddArtist(Artist newArtist)
        {
            try
            {
                artists.Add(newArtist);
            }
            catch { }
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
