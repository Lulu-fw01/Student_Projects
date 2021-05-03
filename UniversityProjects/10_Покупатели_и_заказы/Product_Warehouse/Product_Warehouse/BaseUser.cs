using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Product_Warehouse
{
    /// <summary>
    /// Класс для описания базовых свойств и методов пользователя.
    /// </summary>
    abstract class BaseUser: IUser
    {
        /// <summary>
        /// Пароль.
        /// </summary>
        protected string password;
        /// <summary>
        /// Логин.
        /// </summary>
        protected readonly string login;
        /// <summary>
        /// Алгоритм для хеширования пароля.
        /// </summary>
        protected static HashAlgorithm hashAlgorithm;

        static BaseUser()
        {
            // Используем алгоритм SHA256.
            hashAlgorithm = new SHA256CryptoServiceProvider();
        }

        /// <summary>
        /// Логин.
        /// </summary>
        public string Login { get => login; }
        /// <summary>
        /// Пароль.
        /// </summary>
        public string Password { get => password; }

        /// <summary>
        /// Базовый конструктор.
        /// </summary>
        /// <param name="login">
        /// Логин.
        /// </param>
        /// <param name="password">
        /// Пароль.
        /// </param>
        public BaseUser(string login, string password)
        {
            this.login = login;
            SetPassword(password);
        }

        
        public bool CheckPassword(string inputPassword) => password == GetHashPassword(inputPassword);
        
        public void SetPassword(string newInputPassword) => password = GetHashPassword(newInputPassword);
        
        /// <summary>
        /// Метод хеширования пароля.
        /// </summary>
        /// <param name="inputPassword"></param>
        /// <returns></returns>
        protected static string GetHashPassword(string inputPassword)
        {
            var inputBytes = Encoding.UTF8.GetBytes(inputPassword);
            var hashedBytes = hashAlgorithm.ComputeHash(inputBytes);
            return BitConverter.ToString(hashedBytes);
        }

        public abstract UserMode GetUserMode();
    }
}
