using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Product_Warehouse
{
    [Serializable]
    /// <summary>
    /// Класс для описания базовых свойств и методов пользователя.
    /// </summary>
    abstract public class BaseUser: IUser
    {
        /// <summary>
        /// Пароль.
        /// </summary>
        protected string password;
        /// <summary>
        /// Соль для пароля.
        /// </summary>
        protected byte[] salt;
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

        public bool CheckPassword(string inputPassword) => password == GetHashPassword(inputPassword, salt);
        public void SetPassword(string newInputPassword)
        {
            salt = GetSaltForPassword();
            password = GetHashPassword(newInputPassword, salt);
        }
        
        /// <summary>
        /// Метод хеширования пароля.
        /// </summary>
        /// <param name="inputPassword"></param>
        /// <returns></returns>
        protected static string GetHashPassword(string inputPassword, byte[] salt)
        {
            // пароль минимум 7 символов.
            var inputBytes = Encoding.UTF8.GetBytes(inputPassword);
            var saltInput = new byte[salt.Length + inputBytes.Length];
            salt.CopyTo(saltInput, 0);
            inputBytes.CopyTo(saltInput, salt.Length);

            var hashedBytes = hashAlgorithm.ComputeHash(saltInput);
            return BitConverter.ToString(hashedBytes);
        }

        /// <summary>
        /// Получение "Соли" для хеширования.
        /// </summary>
        /// <returns></returns>
        protected static byte[] GetSaltForPassword()
        {
            var rnd = new Random();
            var salt = "";
            for (int i = 0; i < 7; i++)
            {
                var n = rnd.Next(1, 4);
                switch(n)
                {
                    case 1:
                        salt = salt + Convert.ToChar(rnd.Next(49, 58));
                        break;
                    case 2:
                        salt = salt + Convert.ToChar(rnd.Next(65, 91));
                        break;
                    case 3:
                        salt = salt + Convert.ToChar(rnd.Next(97, 123));
                        break;
                }
            }
            return Encoding.UTF8.GetBytes(salt);
        }

        public abstract UserMode GetUserMode();
    }
}
