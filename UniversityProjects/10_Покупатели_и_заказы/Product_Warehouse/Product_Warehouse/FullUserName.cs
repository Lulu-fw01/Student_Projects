using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Warehouse
{
    /// <summary>
    /// Класс для описания полного имени пользователя.
    /// </summary>
    class FullUserName
    {
        /// <summary>
        /// Фамилия.
        /// </summary>
        public string Surname { get; }
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Отчество.
        /// </summary>
        public string Patronymic { get; }

        /// <summary>
        /// Полное имя пользователя.
        /// </summary>
        /// <param name="surname">
        /// Фамилия.
        /// </param>
        /// <param name="name">
        /// Имя.
        /// </param>
        /// <param name="patronymic">
        /// Отчество.
        /// </param>
        public FullUserName(string surname, string name, string patronymic)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
        }

        /// <summary>
        /// Полное имя пользователя.
        /// </summary>
        /// <param name="surname">
        /// Фамилия.
        /// </param>
        /// <param name="name">
        /// Имя.
        /// </param>
        public FullUserName(string surname, string name): this(surname, name, "")
        { }

        public override string ToString() => Surname + " " + Name + " " + Patronymic;

    }
}
