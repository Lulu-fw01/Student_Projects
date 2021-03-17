using System;


namespace ProjectLibrary
{
    /// <summary>
    /// Пользователь-исполнитель.
    /// </summary>
    [Serializable]
    public class Artist
    {
        /// <summary>
        /// Имя исполнителя.
        /// </summary>
        public string Name { get; }
        
        /// <summary>
        /// Пользователь исполнитель.
        /// </summary>
        /// <param name="name">
        /// Имя исполнителя.
        /// </param>
        public Artist(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
