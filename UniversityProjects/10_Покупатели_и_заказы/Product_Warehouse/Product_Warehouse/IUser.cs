using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Warehouse
{
    /// <summary>
    /// Интерфейс для описания пользователя.
    /// </summary>
    interface IUser
    {
        /// <summary>
        /// Логин (почта).
        /// </summary>
        string Login { get; }
        
        /// <summary>
        /// Пароль.
        /// </summary>
        string Password { get; }

        /// <summary>
        /// Проверка пароля.
        /// </summary>
        /// <param name="inputPassword">
        /// Пароль для проверки.
        /// </param>
        /// <returns></returns>
        bool CheckPassword(string inputPassword);

        /// <summary>
        /// Установка пароля.
        /// </summary>
        /// <param name="newInputPassword">
        /// Новый пароль.
        /// </param>
        void SetPassword(string newInputPassword);

        /// <summary>
        /// Режим приложения.
        /// </summary>
        /// <returns></returns>
        UserMode GetUserMode();

    }

    /// <summary>
    /// Перечисление режимов приложения.
    /// </summary>
    public enum UserMode { Visitor, Adminisrator, Customer }
}
