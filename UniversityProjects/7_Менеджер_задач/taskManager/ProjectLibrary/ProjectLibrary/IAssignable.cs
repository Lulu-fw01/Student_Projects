using System;
using System.Collections.Generic;

namespace ProjectLibrary
{
    /// <summary>
    /// Интерфейс данного проекта для раюоты со списками 
    /// пользователей-исполнителей.
    /// </summary>
    public interface IAssignable
    {
        /// <summary>
        /// Список Исполнителей задачи.
        /// </summary>
        List<Artist> Artists {get;}

        /// <summary>
        /// Добавить исполнителя.
        /// </summary>
        /// <param name="newArtist">
        /// Новый исполнитель.
        /// </param>
        public void AddArtist(Artist newArtist);

        /// <summary>
        /// Удалить исполнителя.
        /// </summary>
        /// <param name="index">
        /// Индекс.
        /// </param>
        public void RemoveArtistAt(int index);

    }
    
    
}
